using NUnit.Framework;
using System.Collections.Generic;

namespace VendingRetail.Tests
{
    public class Tests
    {
        

        [Test]
        public void ConstructorShouldCreateCoffeeMatCorrect()
        {
            CoffeeMat coffeeMat = new CoffeeMat(1000, 2);

            Assert.IsNotNull(coffeeMat);
            Assert.AreEqual(1000, coffeeMat.WaterCapacity);
            Assert.AreEqual(2, coffeeMat.ButtonsCount);
            Assert.AreEqual(0, coffeeMat.Income);       
        }
        [Test]
        public void FillWaterTankWhenWaterTankIsEmpty()
        {
            CoffeeMat coffeeMat = new CoffeeMat(1000, 2);
            var result = coffeeMat.FillWaterTank();
            Assert.AreEqual("Water tank is filled with 1000ml", result);
        }
        [Test]
        public void FillWaterTankWhenWaterTankIsFull()
        {
            CoffeeMat coffeeMat = new CoffeeMat(1000, 2);
            coffeeMat.FillWaterTank();
            var result = coffeeMat.FillWaterTank();
            Assert.AreEqual("Water tank is already full!", result);
        }
        [Test]
        public void AddDrinkShouldAddCorrectly()
        {
            CoffeeMat coffeeMat = new CoffeeMat(1000, 2);
            var result = coffeeMat.AddDrink("vodka", 1.5);
            Assert.IsTrue(result);
        }
        [Test]
        public void AddDrinkShoulNotAddIfDrinkExist()
        {
            CoffeeMat coffeeMat = new CoffeeMat(1000, 2);
            coffeeMat.AddDrink("vodka", 0.7);
            var result = coffeeMat.AddDrink("vodka", 0.5);
            
            Assert.IsFalse(result);
        }
        [Test]
        public void AddDrinkShouldNotAddIfDoesNotHaveEnoughButtons()
        {
            CoffeeMat coffeeMat = new CoffeeMat(1000, 2);
            coffeeMat.AddDrink("water", 0.5);
            coffeeMat.AddDrink("tea", 0.25);
            var result = coffeeMat.AddDrink("vodka", 1.5);
            Assert.IsFalse(result);
        }
        [Test]
        public void BuyDrinkShouldReturnIfDoesNotHaveEnoughWater()
        {
            CoffeeMat coffeeMat = new CoffeeMat(200, 2);
            coffeeMat.FillWaterTank();
            coffeeMat.AddDrink("water", 0.5);
            coffeeMat.BuyDrink("water");
            coffeeMat.BuyDrink("water");
            var result = coffeeMat.BuyDrink("water");
            Assert.AreEqual("CoffeeMat is out of water!", result);
        }
        [Test]
        public void BuyDrinkShouldReturnIfWantedDrinkDoesNotExist()
        {
            CoffeeMat coffeeMat = new CoffeeMat(1000, 2);
            coffeeMat.FillWaterTank();
            coffeeMat.AddDrink("tea", 0.5);
            var result = coffeeMat.BuyDrink("water");
            Assert.AreEqual("water is not available!", result);
        }
        [Test]
        public void BuyDrinkShouldMakeDrinkCorrect()
        {
            CoffeeMat coffeeMat = new CoffeeMat(1000, 2);
            coffeeMat.FillWaterTank();
            coffeeMat.AddDrink("tea", 0.5);
            var result = coffeeMat.BuyDrink("tea");
            Assert.AreEqual("Your bill is 0.50$", result);
            Assert.AreEqual(0.5, coffeeMat.Income);
        }
        [Test]
        public void CollectIncomeShouldSetIncomeToZero()
        {
            CoffeeMat coffeeMat = new CoffeeMat(1000, 2);
            coffeeMat.FillWaterTank();
            coffeeMat.AddDrink("tea", 1);
            coffeeMat.AddDrink("coffee", 5);
            coffeeMat.BuyDrink("coffee");
            double result = coffeeMat.CollectIncome();
            Assert.AreEqual(5, result);
            Assert.AreEqual(0, coffeeMat.Income);
        }
    }
}