function countWord(text, searchedWord){
    let string = text.split(' ');
    let count = 0;
    for(let word of string){
        if(word === searchedWord){
            count++;
        }
    }
    console.log(count);
}