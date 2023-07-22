async function loadCommits() {
    const username = document.getElementById('username').value;
    const repo = document.getElementById('repo').value;
    const list = document.getElementById('commits');
    try{
        const response = await fetch(`https://api.github.com/repos/${username}/${repo}/commits`);
        if(!response.ok){
            throw new Error(`Error: ${response.status} (Not Found)`);
        } 
        const data = await response.json();
        list.innerHTML = "";
        for(let {commit} of data){
            const item = document.createElement('li');
            item.textContent = `${commit.author.name}: ${commit.message}`;
            list.appendChild(item);
        }
    }catch (err){
        list.innerHTML = `${err.message}`;
    }
}