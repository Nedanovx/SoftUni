function convertToObject(input){
    const obj = JSON.parse(input);
    for(const key in obj){
        console.log(`${key}: ${obj[key]}`);
    }
}
convertToObject('{"name": "Peter", "age": 35, "town": "Plovdiv"}')