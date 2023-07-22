function solve() {
  const input = document.getElementById('input').value.split('.');
  input.pop();
  const container = document.getElementById('output');
  while(input.length > 0){
    const p = document.createElement('p');
    p.textContent = `${input.splice(0, 3).join(".")}.`;
    container.appendChild(p);
  }
}