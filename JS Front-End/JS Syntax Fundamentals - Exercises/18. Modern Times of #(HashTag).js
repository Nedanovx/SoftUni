function searchHashTag (text){
    const arr = text.split(' ');
    const pattern = /^[a-z]+$/i;
    for(const word of arr){
        if(word.startsWith('#') && word.length > 1 && pattern.test(word.substring(1, word.length))){
            console.log(word.substring(1, word.length));
        }
    }
}
searchHashTag('Nowadays everyone uses # to tag a #special word in #socialMedia')