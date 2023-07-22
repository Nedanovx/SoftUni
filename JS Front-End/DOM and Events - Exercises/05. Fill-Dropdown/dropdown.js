function addItem() {
    const textInput = document.getElementById('newItemText');
    const valueInput = document.getElementById('newItemValue');

    const option = document.createElement('option');
    option.textContent = textInput.value;
    option.value = valueInput.value;

    const select = document.getElementById('menu');
    select.appendChild(option);
    textInput.value = "";
    valueInput.value = "";
}