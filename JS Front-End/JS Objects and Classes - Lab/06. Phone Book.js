function phone(input){
    const phoneBook = {};
    for(const kvp of input){
        const tokens = kvp.split(' ');
        const name = tokens[0];
        const phoneNumber = tokens[1];
        phoneBook[name] = phoneNumber;
    }
    
    for(const key in phoneBook){
        console.log(`${key} -> ${phoneBook[key]}`)
    }
}

phone(['Tim 0834212554','Peter 0877547887','Bill 0896543112','Tim 0876566344']);