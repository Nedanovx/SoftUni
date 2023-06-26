function singCheck(number1, number2, number3){
    let countPositiveNumber = 0;
    function mathSing (num){
        if(Math.sign(num) >= 0){
            countPositiveNumber++;
        }
    }
    mathSing(number1);
    mathSing(number2);
    mathSing(number3);
    if(countPositiveNumber % 2 !== 0){
        console.log('Positive');
    }
    else{
        console.log('Negative');
    }
}
singCheck(5, -12, -15);