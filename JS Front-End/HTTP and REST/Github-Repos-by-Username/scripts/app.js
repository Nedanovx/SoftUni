async function loadRepos() {
	const username = document.getElementById('username').value;
	const repositories = document.getElementById('repos');

	try{
	const response = await fetch(`https://api.github.com/users/${username}/repos`);
	if(!response.ok){
		throw new Error(`${response.status} ${response.statusText}`);
	}

	const data = await response.json();
	repositories.innerHTML = "";
	for(let repo of data){
		repositories.innerHTML += `<li><a href="${repo.html_ur}" target="_blank">${repo.full_name}></a></li>`;
	}
}catch (err){
	repositories.innerHTML = `${err.message}`;
}
}