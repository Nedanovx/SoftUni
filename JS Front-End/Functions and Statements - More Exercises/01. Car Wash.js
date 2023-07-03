function carWash(command){
    let sum = 0;
    const clean = {
        soap: (sum) => sum + 10,
        water: (sum) => sum * 1.2,
        'vacuum cleaner': (sum) => sum * 1.25,
        mud: (sum) => sum * 0.9,
    };
    for(const cmd of command){
        sum = clean[cmd](sum);
    }
    console.log(`The car is ${sum.toFixed(2)}% clean.`);
}
carWash(['soap', 'soap', 'vacuum cleaner', 'mud', 'soap','water']);