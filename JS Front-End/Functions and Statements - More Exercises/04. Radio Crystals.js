function crystal (input){
    const [target, ...chunks] = input;
    for(let chunk of chunks){
        console.log(`Processing chunk ${chunk} microns`)
        while(chunk !== target){
            if(chunk / 4 >= target){
                let count = 0;
                while(chunk / 4 >= target){
                    chunk /= 4;
                    count++;
                }
                chunk = Math.floor(chunk);
                console.log(`Cut x${count}`);
                console.log(`Transporting and washing`)
                continue;
            }
            if(chunk * 0.8 >= target){
                    let count = 0;
                    while(chunk * 0.8 >= target){
                        chunk *= 0.8;
                        count++;
                    }
                    chunk = Math.floor(chunk);
                    console.log(`Lap x${count}`);
                    console.log(`Transporting and washing`);
                    continue;
            }
            if(chunk - 20 >= target){
                let count = 0;
                while(chunk - 20 >= target){
                    chunk -= 20;
                    count++;
                }
                chunk = Math.floor(chunk);
                console.log(`Grind x${count}`);
                console.log(`Transporting and washing`);
                continue;
            }
            if(chunk - 2 >= target - 1){
                let count = 0;
                while(chunk - 2 >= target - 1){
                    chunk -= 2;
                    count++;
                }
                chunk = Math.floor(chunk);
                console.log(`Etch x${count}`);
                console.log(`Transporting and washing`);
                continue;
            }
            if(chunk +1 === target){
                chunk += 1;
                console.log(`X-ray x1`);
            }
        }
        console.log(`Finished crystal ${chunk} microns`);
    }
}
