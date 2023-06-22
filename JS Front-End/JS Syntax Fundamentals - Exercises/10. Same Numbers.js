function sameNumbers(input){
    let arr = input.toString();
    let sum = 0;
    let isSame = true;
    let firstNumber = Number(arr[0]);
    for(let i = 0; i < arr.length; i++){
        sum += Number(arr[i]);
        if(Number(arr[i]) !== firstNumber){
            isSame = false;
        }
    }
    console.log(isSame);
    console.log(sum);
}
solve(1234);