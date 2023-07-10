function createHero(input){
    input.map((hero) => {
        const [name, level, inventory] = hero.split(' / ');
        const levenAsInt = Number(level);
        return {name, levenAsInt, inventory}
    }).sort((a,b) => a.levenAsInt - b.levenAsInt).forEach(hero => {
        console.log(`Hero: ${hero.name}`);
        console.log(`level => ${hero.levenAsInt}`);
        console.log(`items => ${hero.inventory}`);
    });
}
createHero([
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara']);