function catalogue(input){
    const products = input.reduce((acc, curr) =>{
        const [key, value] = curr.split(' : ');
        acc[key] = value;
        return acc;
    }, {});
    const sortedProducts = Object.keys(products).sort((a,b) =>a.localeCompare(b));
    let letter = sortedProducts[0][0];
    console.log(letter);
    sortedProducts.forEach((item) => {
        if(item[0] !== letter){
            letter = item[0];
            console.log(letter);
        }
        console.log(`  ${item}: ${products[item]}`);
        
    })
}
catalogue([
    'Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10'
    ]
    )