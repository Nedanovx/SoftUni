function firstSubstring(word, text){
    const textToLowerCase = text.toLowerCase().split(' ');
    if(textToLowerCase.includes(word.toLowerCase())){
        console.log(word);
    }
    else{
        console.log(`${word} not found!`);
    }
}
firstSubstring('javascript', 'JavaScript is the best JavaScript language');