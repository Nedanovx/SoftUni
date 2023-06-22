function solve(number, ...arr){
    for(const command of arr){
        if(command === 'chop'){
            number /= 2;
            console.log(number);
        }
        else if(command === 'dice'){
            number = Math.sqrt(number);
            console.log(number);
        }
        else if(command === 'spice'){
            number += 1;
            console.log(number);
        }
        else if(command === 'bake'){
            number *= 3;
            console.log(number);
        }
        else if(command === 'fillet'){
            number *= 0.8;
            console.log(number);
        }
    }
}
solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet')