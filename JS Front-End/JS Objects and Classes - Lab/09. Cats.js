class Cat {
    constructor(name, age){
        this.name = name;
        this.age = age;
    }

    meow() {
        console.log(`${this.name}, age ${this.age} says Meow`)
    }
}

function createCats(input){
    
    input.forEach(element => {
        const [name, age] = element.split(' ');
        const cat = new Cat(name, age);
        cat.meow();
    });
}
createCats(['Mellow 2', 'Tom 5']);
