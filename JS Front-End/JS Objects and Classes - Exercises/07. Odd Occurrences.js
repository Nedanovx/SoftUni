function oddOccurrences(input){
    const text = input.split(' ');
    const result = text.reduce((acc, curr) => {
        const wordToLowerCase = curr.toLowerCase();
        if(acc[wordToLowerCase] = acc[wordToLowerCase]){
            acc[wordToLowerCase]++;
        }else{
            acc[wordToLowerCase] = 1;
        }
        return acc;
    }, {});
    const words = [];
    Object.entries(result).sort((a,b) => b[1]-a[1]).forEach(([key, value]) => {
        if (value % 2 !== 0) {
            words.push(key);
        }
    });
    console.log(words.join(" "));
}
oddOccurrences('Java C# Php PHP Java PhP 3 C# 3 1 5 C#')