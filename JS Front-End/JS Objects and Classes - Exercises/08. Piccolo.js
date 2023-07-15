function parking(input){
    const car = [];
    input.forEach(line => {
        const [command, plateNumber] = line.split(", ");
        if(command === "IN"){
            if(!car.includes(plateNumber)){
            car.push(plateNumber);
            }
        }else if(command === "OUT"){
            if(car.includes(plateNumber)){
            const index = car.indexOf(plateNumber);
            car.splice(index, 1);
            }
        }
    });
    if(car.length > 0){
        console.log(car.sort().join("\n"));
    }else{
        console.log(`Parking Lot is Empty`);
    }
}
parking(['IN, CA2844AA',
'IN, CA1234TA',
'OUT, CA2844AA',
'IN, CA9999TT',
'IN, CA2866HI',
'OUT, CA1234TA',
'IN, CA2844AA',
'OUT, CA2866HI',
'IN, CA9876HH',
'IN, CA2822UU']


)