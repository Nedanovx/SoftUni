function calculator(firstNumber, secondNumber, operation){
    
    const operationList = {
        add: (a,b)=> a + b,
        subtract: (a,b)=> a - b,
         multiply: (a,b)=> a * b,
        divide: (a,b)=> a / b,
    };
    return operationList[operation](firstNumber, secondNumber)
}
console.log(calculator(5, 5, 'divide'));