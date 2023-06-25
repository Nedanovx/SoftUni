function calculator(firstNumber, secondNumber, operation){
    const add = (a,b)=> a + b;
    const subtract = (a,b)=> a - b;
    const multiply = (a,b)=> a * b;
    const divide = (a,b)=> a / b;
    const operationList = {
        add,
        subtract,
        multiply,
        divide,
    };
    return operationList[operation](firstNumber, secondNumber)
}
console.log(calculator(5, 5, 'multiply'));