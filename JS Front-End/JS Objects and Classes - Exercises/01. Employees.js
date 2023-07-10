function personalNumber(input){
input.forEach(employee => {
    console.log(`Name: ${employee} -- Personal Number: ${employee.length}`)
});
}
personalNumber(['Silas Butler','Adnaan Buckley','Juan Peterson','Brendan Villarreal']);