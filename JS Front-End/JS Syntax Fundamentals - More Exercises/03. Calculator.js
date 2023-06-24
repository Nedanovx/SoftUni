function calculator(x, operation, y){
    switch(operation){
        case'+':
        console.log((x + y).toFixed(2));
        break;
        case'-':
        console.log((x - y).toFixed(2));
        break;
        case'/':
        console.log((x / y).toFixed(2));
        break;
        case'*':
        console.log((x * y).toFixed(2));
        break;
    }
}
calculator(25,'-',10);