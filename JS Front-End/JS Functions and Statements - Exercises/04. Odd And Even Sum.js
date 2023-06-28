function oddAndEvenSum(number){
    const numberAsString = number.toString().split('');
    let sumEven = 0;
    let sumOdd = 0;
    for(const element of numberAsString){
        if(Number(element) % 2 === 0){
            sumEven += Number(element);
        }else{
            sumOdd += Number(element);
        }
    }
    console.log(`Odd sum = ${sumOdd}, Even sum = ${sumEven}`);
}
oddAndEvenSum(1000435);