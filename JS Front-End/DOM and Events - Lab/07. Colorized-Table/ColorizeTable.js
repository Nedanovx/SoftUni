function colorize() {
    const row = Array.from(document.querySelectorAll('tr:nth-child(even'));
    row.forEach((row) => {
        row.style.background = "Teal";
    });
    console.log(row);
}