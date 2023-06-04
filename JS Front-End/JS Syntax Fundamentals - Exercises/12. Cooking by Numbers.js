function solve(number, ...arr){
    for(const cmd of arr){
        if(cmd === 'chop'){
            number /= 2;
            console.log(number);
        }
        else if(cmd === 'dice'){
            number = Math.sqrt(number);
            console.log(number);
        }
        else if(cmd === 'spice'){
            number += 1;
            console.log(number);
        }
        else if(cmd === 'bake'){
            number *= 3;
            console.log(number);
        }
        else if(cmd === 'fillet'){
            number *= 0.8;
            console.log(number);
        }
    }
}
solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet')