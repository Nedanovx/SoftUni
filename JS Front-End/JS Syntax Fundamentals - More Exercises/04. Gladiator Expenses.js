function equipmentPrice(lostFightsCount, helmetPrice, swordPrice, shieldPrice, armorprice){
    let sum = 0;
    let shieldBreakCount = 0;
    for (let i = 1; i <= lostFightsCount; i++) {
        if(i % 2 === 0){
            sum += helmetPrice;
        }
        if(i % 3 === 0){
            sum += swordPrice;
        }
        if(i % 2 === 0 && i % 3 === 0){
            sum +=shieldPrice;
            shieldBreakCount++;
        }
        if(shieldBreakCount === 2){
            sum += armorprice;
            shieldBreakCount = 0;
        }
    }
    console.log(`Gladiator expenses: ${sum.toFixed(2)} aureus`);
}
equipmentPrice(7,2,3,4,5);