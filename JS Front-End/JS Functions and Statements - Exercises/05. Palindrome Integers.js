function palindrome (numbers){
    numbers.forEach(element => {
        console.log(isPalindrome(element))
        
    });

    function isPalindrome(element){
        let reversedNumber = Number([...element.toString()].reverse().join(''));
        return element === reversedNumber;
    }
}

palindrome([123,323,421,121]);