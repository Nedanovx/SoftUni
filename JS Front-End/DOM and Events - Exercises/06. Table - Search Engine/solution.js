function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      const input = document.getElementById('searchField').value;
      const cells = Array.from(document.querySelectorAll('tbody td'));

      cells.forEach((cell) => {
            cell.parentElement.classList.remove('select');
         
      });

      cells.forEach((cell) => {
         if(cell.textContent.includes(input)){
            cell.parentElement.classList.add('select');
         }
      });
   }
}