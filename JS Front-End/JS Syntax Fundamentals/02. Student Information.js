function studentInfo (name, age, grade){
    let output = `Name: ${name}, Age: ${age}, Grade: ${grade.toFixed(2)}`;
    console.log(output);
}
studentInfo(`Ivan`, 20, 5.6235)