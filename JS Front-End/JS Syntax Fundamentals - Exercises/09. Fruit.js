function solve(fruit, weight, money){
    let price = (weight / 1000) * money;
    console.log(`I need $${price.toFixed(2)} to buy ${(weight/1000).toFixed(2)} kilograms ${fruit}.`)
}
solve('orange', 2500, 1.80)