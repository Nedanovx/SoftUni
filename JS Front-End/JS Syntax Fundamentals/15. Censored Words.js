function censoredWords(text, word){
    while(text.includes(word)){
        string = text.replace(word, '*'.repeat(word.length));
    }
    console.log(string);
}