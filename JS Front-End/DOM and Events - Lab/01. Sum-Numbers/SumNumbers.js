function calc() {
    const firstNumber = document.getElementById('num1');
    const secondNumber = document.getElementById('num2');
    const result = Number(firstNumber.value) + Number(secondNumber.value);
    document.getElementById('sum').value = result;
}
