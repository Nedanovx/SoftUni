function alphabeticallyAscendingOrder(names){
    return [...names]
    .sort((aName, bName) => aName.localeCompare(bName))
    .map((name, index) => `${index + 1}.${name}`)
    .join(`\n`); 
}
console.log(alphabeticallyAscendingOrder(["John", "Bob", "Christina", "Ema"]));