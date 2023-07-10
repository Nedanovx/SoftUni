function printCityInfo(city){
    for(const key in city){
        console.log(`${key} -> ${city[key]}`);
    }
}

printCityInfo({
    name: "Plovdiv",
    area: 389,
    population: 1162358,
    country: "Bulgaria",
    postCode: "4000"
    });