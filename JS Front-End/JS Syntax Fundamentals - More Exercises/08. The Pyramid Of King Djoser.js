function pyramid(base, increment){
    let stone = 0;
    let marble = 0;
    let lapis = 0;
    let gold = 0;
    let floor = 1;

    while(base - 2 > 0){
        let total = Math.pow(base, 2);
        let innerLayer = Math.pow((base-2), 2);
        let outerLayer = total - innerLayer;
        stone += innerLayer;
        if(floor % 5 !== 0){
            marble += outerLayer;
        }
        else{
            lapis += outerLayer;
        }
        floor++;
        base -=2;
    }
    gold += Math.pow(base, 2);
    console.log(`Stone required: ${Math.ceil(stone * increment)}`);
    console.log(`Marble required: ${Math.ceil(marble * increment)}`);
    console.log(`Lapis Lazuli required: ${Math.ceil(lapis * increment)}`);
    console.log(`Gold required: ${Math.ceil(gold * increment)}`);
    console.log(`Final pyramid height: ${Math.floor(floor * increment)}`);
}
pyramid(12, 1)