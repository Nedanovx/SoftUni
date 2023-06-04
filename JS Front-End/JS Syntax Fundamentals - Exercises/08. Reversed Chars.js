function solve(param1, param2, param3){
    let result = new Array;
    result.unshift(param1);
    result.unshift(param2);
    result.unshift(param3);
    console.log(result.join(' '));
}
solve('4', 'a', 'r');