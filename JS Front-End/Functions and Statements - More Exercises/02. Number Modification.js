function sumOfDigit(result){
    return(
        result.split("").map(Number).reduce((total, current) => total + current, 0)/ result.length);
}

function modification(number){
    let result = number.toString();

    let isAverageSumIsMoreThenFive = sumOfDigit(result);
    
    while(isAverageSumIsMoreThenFive <= 5){
        result +='9';
        isAverageSumIsMoreThenFive=(sumOfDigit(result))
    }

    console.log(result);
}
modification(101)