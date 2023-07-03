function printDNA (number){
    const pattern =[
        ["A", "T"],
        ["C", "G"],
        ["T", "T"],
        ["A", "G"],
        ["G", "G"],
    ];
    for(let index = 0; index < number; index++){
        const [x, y] = pattern[index % pattern.length];
        if(index % 4 === 0){
            console.log(`**${x}${y}**`);
            continue;
        }
        if(index % 2 === 1){
            console.log(`*${x}--${y}*`);
            continue;
        }
        if(index % 2 === 0){
            console.log(`${x}----${y}`);
            continue
        }
    }
}
printDNA(4);