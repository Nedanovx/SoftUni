class Song{
    constructor(type, name, time){
        this.type = type;
        this.name = name;
        this.time = time;
    }
}
function playList(input){ 
    const songs = []
    const numberOfSongs = input.shift();
    const typeSong = input.pop();
        input.forEach(element => {
        const [type, name, time] = element.split("_");
        const song = new Song(type, name, time);
        songs.push(song);
    });
    if(typeSong === 'all'){
        songs.forEach((song) => console.log(song.name));
    }else{
        const filterSongs = songs.filter((song) => song.type === typeSong);
        filterSongs.forEach((song) => console.log(song.name));
    }
    
}
playList([3,'favourite_DownTown_3:14', 'favourite_Kiss_4:16', 'favourite_Smooth Criminal_4:01', 'favourite'])