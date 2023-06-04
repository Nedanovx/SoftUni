function solve(startNumber, endNumber){
    let sum = 0;
    let arr = new Array;
    for(let i = startNumber; i <= endNumber; i++){
        arr.push(i);
        sum += i;
    }
    console.log(arr.join(" "));
    console.log("Sum:", sum);
}
solve(5,10)