function meeting(input){
    const schedule = input.reduce((acc, curr) => {
        const[day, name] = curr.split(' ');

        if(acc.hasOwnProperty(day)){
            console.log(`Conflict on ${day}!`)
        }else{
            acc[day] = name;
            console.log(`Scheduled for ${day}`);
        }
        return acc;
    }, {})
    for(const day in schedule){
        console.log(`${day} -> ${schedule[day]}`)
    }
}
meeting(['Friday Bob',
'Saturday Ted',
'Monday Bill',
'Monday John',
'Wednesday George']
)