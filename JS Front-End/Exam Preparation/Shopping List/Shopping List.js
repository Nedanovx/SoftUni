function solve(input){
    let groceriesList = input.shift().split('!');

    let commandParse ={
        'Urgent': Urgent,
        'Unnecessary': Unnecessary,
        'Correct': Correct,
        'Rearrange': Rearrange
    }

    for (const command of input) {
        if(command === 'Go Shopping!'){
            break;
        }
        let commandTokens = command.split(' ');
        let cmd = commandTokens[0];
        commandParse[cmd](...commandTokens.slice(1));
    }
        console.log(groceriesList.join(', '));

    function Urgent(item){
        if(!groceriesList.includes(item)){
            groceriesList.unshift(item)
        }
    }

    function Unnecessary(item){
        let index = groceriesList.indexOf(item);
        if(index !== -1){
            groceriesList.splice(index,1);
        }
    }

    function Correct(oldName, newName){
        let index = groceriesList.indexOf(oldName);
        if(index !== -1){
            groceriesList[index] = newName;
        }
    }

    function Rearrange(item){
        let index = groceriesList.indexOf(item);
        if(index !== -1)
        {
            groceriesList.splice(index,1);
            groceriesList.push(item);
        }
    }
}

solve((["Milk!Pepper!Salt!Water!Banana",
"Urgent Apple",
"Unnecessary Pepper",
"Correct Pepper Onion",
"Rearrange Grapes",
"Correct Tomatoes Potatoes",
"Go Shopping!"])
)