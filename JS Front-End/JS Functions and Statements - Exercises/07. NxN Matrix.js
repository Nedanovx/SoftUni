function matrix(number){
    new Array(number).fill(new Array(number).fill(number)).forEach(element => console.log(element.join(" ")));
}
matrix(5);