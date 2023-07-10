function personInfo (firstName, lastName, age){
    const person = {
        firstName,
        lastName,
        age,
    };
    return person;
}
console.log(personInfo("Peter","Pan","20"));