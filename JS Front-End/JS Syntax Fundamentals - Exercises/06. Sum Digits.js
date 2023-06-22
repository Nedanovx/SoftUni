function sumOfDigits(number){
    let digitAsString = number.toString();
    let sum = 0;
    for(const digit of digitAsString){
        sum += Number(digit);
    }
    console.log(sum);
}
sumOfDigits(1235);