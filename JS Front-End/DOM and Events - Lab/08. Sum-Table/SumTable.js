function sumTable() {
    const priceBox = Array.from(document.querySelectorAll("td:nth-child(2)"));
    const total = priceBox.reduce((acc, curr) => {   
        return acc + Number(curr.textContent);
    }, 0);
    document.getElementById('sum').textContent = total;
}