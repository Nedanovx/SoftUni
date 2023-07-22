function loadRepos() {
   
   fetch("https://api.github.com/users/testnakov/repos").then((res) => {
      const body = res.text()
      .then((body) => {
         const result = document.getElementById("res");
         result.textContent = body;
      });
      
   });
}