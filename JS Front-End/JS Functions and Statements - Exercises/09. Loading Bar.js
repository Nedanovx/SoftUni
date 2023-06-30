function loading(number){
    let bar = '';
    for(let i = 1; i <= 100; i+=10){
        if(i < number){
            bar +='%';
        }
        else{
            bar += '.';
        }
    }
    if(number < 100){
        console.log(`${number}% [${bar}]`);
        console.log(`Still loading...`);
    }
    else{
        console.log(`${number}% Complete!`);
        console.log(bar);
    }
}
loading(20);