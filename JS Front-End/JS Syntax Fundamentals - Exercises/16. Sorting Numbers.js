function solve(numbers){
    let sortedNumbers = [...numbers].sort((a, b) => a - b);
    let count = 0;
    let result = [];
    while(sortedNumbers.length > 0){
        if(count % 2 === 0){
            result.push(sortedNumbers.shift());
        }
        else{
            result.push(sortedNumbers.pop());
        }
        count++;
    }
    return result;
}
console.log(solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));