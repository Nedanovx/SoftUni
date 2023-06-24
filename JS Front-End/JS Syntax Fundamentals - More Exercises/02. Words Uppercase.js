function wordsUppercase(text){
    const pattern = /[A-Z]*\w/gm;
    const words = text.toUpperCase();
    console.log(words.match(pattern).join(', '));
}
wordsUppercase('Hi, how $ are you?');