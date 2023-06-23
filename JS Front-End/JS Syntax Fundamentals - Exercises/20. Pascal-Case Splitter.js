function pascalCaseSplitter(text){
    const pattern = /[A-Z]{1}[a-z]*/gm;
    const matchesWords = text.match(pattern);
    console.log(matchesWords.join(', '));
}
pascalCaseSplitter('SplitMeIfYouCanHaHaYouCantOrYouCan');