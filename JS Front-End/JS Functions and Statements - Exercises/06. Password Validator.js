function validator(password){
    const pattern = /^[A-Za-z0-9]+$/;
    const digits = /[0-9]{2,}/g;
    let isValid = true;

    if(password.length < 6 || password.length > 10){
        console.log(`Password must be between 6 and 10 characters`);
        isValid = false;
    }

    if(!pattern.test(password)){
        console.log(`Password must consist only of letters and digits`);
        isValid = false;
    }

    if(!digits.test(password)){
        console.log(`Password must have at least 2 digits`);
        isValid = false;
    }

    if(isValid){
        console.log(`Password is valid`);
    }
}
validator('Pasd81')