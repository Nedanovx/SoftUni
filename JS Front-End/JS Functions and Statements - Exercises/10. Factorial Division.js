function factorial(x){
    if(x === 0 || x === 1){
        return 1;
    }
    else{
        return x * factorial(x-1);
    }
}

function factorialDivision(first, second){
    const result = factorial(first) / factorial(second);
    console.log(result.toFixed(2));
}
factorialDivision(5, 0);