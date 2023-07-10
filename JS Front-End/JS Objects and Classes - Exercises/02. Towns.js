function printTownInfo(input){
    input.map((city) => {
        const[town, lat, long] = city.split(' | ');
        const latitude = Number(lat).toFixed(2);
        const longitude = Number(long).toFixed(2);
        return {town, latitude, longitude};
    }).forEach((city => {
        console.log(city);
    }));
}
printTownInfo(['Sofia | 42.696552 | 23.32601',
'Beijing | 39.913818 | 116.363625'])