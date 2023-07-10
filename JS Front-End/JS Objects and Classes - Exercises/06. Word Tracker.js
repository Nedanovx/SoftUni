function wordTracker (text){
    const [searchWords, ...words] = text;
    const wordsOccurrences = searchWords.split(' ').reduce((acc, curr) => {
        acc[curr] = 0;
        return acc;
    }, {});
    words.forEach(word => {
        if(wordsOccurrences.hasOwnProperty(word)){
            wordsOccurrences[word] += 1;
        }
    });
    
    Object.entries(wordsOccurrences).sort((a,b) => b[1] - a[1]).forEach((word => {
        console.log(`${word[0]} - ${word[1]}`);
    }));
}
wordTracker([
    'this sentence',
    'In', 'this', 'sentence', 'you', 'have',
    'to', 'count', 'the', 'occurrences', 'of',
    'the', 'words', 'this', 'and', 'sentence',
    'because', 'this', 'is', 'your', 'task'])