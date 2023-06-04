function solve(speed, area){
    let motorwayArea = 130;
    let interstateArea = 90;
    let cityArea = 50;
    let residentialArea = 20;
    let difference = 0;
    switch(area){
        case'motorway':
        if(speed <= motorwayArea){
            console.log(`Driving ${speed} km/h in a ${motorwayArea} zone`);
        }
        else{
            difference = speed - motorwayArea;
            if(difference <= 20){
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${motorwayArea} - speeding`);
            }
            else if(difference > 20 && difference <= 40){
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${motorwayArea} - excessive speeding`);
            }
            else{
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${motorwayArea} - reckless driving`);
            }
        }
        break;
        case'interstate':
        if(speed <= interstateArea){
            console.log(`Driving ${speed} km/h in a ${interstateArea} zone`);
        }
        else{
            difference = speed - interstateArea;
            if(difference <= 20){
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${interstateArea} - speeding`);
            }
            else if(difference > 20 && difference <= 40){
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${interstateArea} - excessive speeding`);
            }
            else{
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${interstateArea} - reckless driving`);
            }
        }
        break;
        case'city':
        if(speed <= cityArea){
            console.log(`Driving ${speed} km/h in a ${cityArea} zone`);
        }
        else{
            difference = speed - cityArea;
            if(difference <= 20){
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${cityArea} - speeding`);
            }
            else if(difference > 20 && difference <= 40){
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${cityArea} - excessive speeding`);
            }
            else{
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${cityArea} - reckless driving`);
            }
        }
        break;
        case'residential':
        if(speed <= residentialArea){
            console.log(`Driving ${speed} km/h in a ${residentialArea} zone`);
        }
        else{
            difference = speed - residentialArea;
            if(difference <= 20){
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${residentialArea} - speeding`);
            }
            else if(difference > 20 && difference <= 40){
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${residentialArea} - excessive speeding`);
            }
            else{
                console.log(`The speed is ${difference} km/h faster than the allowed speed of ${residentialArea} - reckless driving`);
            }
        }
        break;
    }
}
