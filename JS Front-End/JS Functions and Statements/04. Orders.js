function price(product, quantity){
    let productList = {
        coffee: 1.50,
        water: 1.00,
        coke: 1.40,
        snacks: 2.00
};
console.log((productList[product]*quantity).toFixed(2));
}
price('snacks', 5);