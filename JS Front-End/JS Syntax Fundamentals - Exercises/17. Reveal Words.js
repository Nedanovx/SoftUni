function revealWords(word, text){
    let wordArr = word.split(', ');
    let textArr = text.split(' ');
    for(const word of wordArr){
        for(const detectWord of textArr){
            if(detectWord.includes('*') && word.length === detectWord.length){
                text = text.replace(detectWord, word);
            }
        }
    }
    console.log(text);
}

revealWords('great, learning', 'softuni is ***** place for ******** new programming languages');