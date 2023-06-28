function charInRange(firstChar, secondChar){
    const convertFirstCharToNumber = firstChar.charCodeAt();
    const convertSecondCharToNumber = secondChar.charCodeAt();
    const result =[];
    if(convertFirstCharToNumber > convertSecondCharToNumber + 1){
        for(let i = convertSecondCharToNumber +1; i < convertFirstCharToNumber; i++){
            result.push(String.fromCharCode(i));
        }
    }
    else if(convertFirstCharToNumber + 1 < convertSecondCharToNumber){
        for(let i = convertFirstCharToNumber + 1; i < convertSecondCharToNumber; i++){
            result.push(String.fromCharCode(i));
        }
    }
    console.log(result.join(' '));
}
charInRange('#', ':');