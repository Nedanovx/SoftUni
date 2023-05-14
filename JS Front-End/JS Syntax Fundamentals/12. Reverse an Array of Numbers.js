function solve(n, inputArr){
    let array = new Array;
    for(let i=0; i < n; i++){
        array.unshift(inputArr[i]);
    }
    console.log(array.join(" "));
}
