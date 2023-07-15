function addItem() {
    const value = document.getElementById('newItemText').value;
    const item = document.createElement('li');
    item.textContent = value;
    document.querySelector("ul").appendChild(item);
}