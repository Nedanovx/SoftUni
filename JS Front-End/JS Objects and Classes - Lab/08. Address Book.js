function addresBook(input){
    const personInfo = input.reduce((acc, curr) =>{
        const [name, addres] = curr.split(':');
        acc[name] = addres;
        return acc;
    }, {})
    const sortedInfo = Object.entries(personInfo);
    sortedInfo.sort((a, b) => a[0].localeCompare(b[0])); 
    sortedInfo.forEach(element => {
        console.log(element.join(' -> '));
    });
}

addresBook(['Tim:Doe Crossing',
'Bill:Nelson Place',
'Peter:Carlyle Ave',
'Bill:Ornery Rd']
)