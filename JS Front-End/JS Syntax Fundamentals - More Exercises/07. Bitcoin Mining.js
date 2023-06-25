function changeGoldToBitcoin(gold){
    const bitcoinPrice = 11949.16;
    const gramGoldPrice = 67.51;
    let money = 0;
    let firstDay = 0;
    let bitcoin = 0;
    for(let i = 0; i < gold.length; i++){
        if((i + 1) % 3 !== 0){
            money += gold[i] * gramGoldPrice;
        }
        else{
            money += gold[i] * 0.7 * gramGoldPrice;
        }
        while(money >= bitcoinPrice){
            bitcoin++;
            money -= bitcoinPrice;
            if(firstDay === 0){
                firstDay = i + 1;
            }
        }
    }
    console.log(`Bought bitcoins: ${bitcoin}`);
    if(firstDay > 0){
        console.log(`Day of the first purchased bitcoin: ${firstDay}`)
    }
    console.log(`Left money: ${money.toFixed(2)} lv.`)
}
changeGoldToBitcoin([100, 200, 300])