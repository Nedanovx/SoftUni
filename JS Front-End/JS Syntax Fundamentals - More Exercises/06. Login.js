function login(array){
    let [user, ...pass] = array;
    let correctPass = [...user].reverse().join('');
    for(let i = 0; i < pass.length; i++){
        if(correctPass !== pass[i]){
            if(i <= 2){
                console.log(`Incorrect password. Try again.`);
            }
            else{
                console.log(`User ${user} blocked!`);
                return;
            }
        }
        else{
            console.log(`User ${user} logged in.`);
            return;
        }
    }
}
login(['sunny','rainy','cloudy','sunny','not', 'sunny'])