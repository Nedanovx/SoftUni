function moviesInfo(input){
    let movies = [];
input.forEach(line => {
    if(line.includes('addMovie')){
        const [_, name] = line.split('addMovie ');
        movies.push({
            name,   
        });
    }else if(line.includes('directedBy')){
        const [movieName, directorname] = line.split(' directedBy ');
        const movie = movies.find(m => m.name === movieName);
        if(movie){
            movie.director = directorname;
        }
    }else if(line.includes('onDate')){
        const [movieName, date] = line.split(' onDate ');
        const movie = movies.find(m => m.name === movieName);
        if(movie){
            movie.date = date;
        }
    }
});
    movies.filter((m) => m.name && m.director && m.date)
    .forEach((m) => console.log((JSON.stringify(m))));
}
moviesInfo([
'addMovie Fast and Furious',
'addMovie Godfather',
'Inception directedBy Christopher Nolan',
'Godfather directedBy Francis Ford Coppola',
'Godfather onDate 29.07.2018',
'Fast and Furious onDate 30.07.2018','Batman onDate 01.08.2018','Fast and Furious directedBy Rob Cohen']);