// TODO
function attachEvents() {
    const BASE_URL = 'http://localhost:3030/jsonstore/tasks/';
    const titleInput = document.getElementById('title');
    const loadBtn = document.getElementById('load-button');
    const addBtn = document.getElementById('add-button');
    const todoContainer = document.getElementById('todo-list');

    loadBtn.addEventListener('click', loadTaskHandler);
    addBtn.addEventListener('click', addTaskHandler);

    function addTaskHandler(event){
        event.preventDefault();
        
    const name = titleInput.value;
    const httpHeaders = {
        method: 'POST',
        body: JSON.stringify({name})
        }

        fetch(BASE_URL, httpHeaders)
        .then(() => {
            loadTaskHandler();
            titleInput.value = '';
        })
    }
    function loadTaskHandler(event){
        if(event){
            event.preventDefault();
        }
        todoContainer.innerHTML = '';
        fetch(BASE_URL)
        .then((data) => data.json())
        .then((tasksRes) => {
        const tasks = Object.values(tasksRes);
        for(const {_id, name} of tasks){
            const li = document.createElement('li');
            li.id = _id
            const span = document.createElement('span');
            const removeBtn = document.createElement('button');
            const editBtn = document.createElement('button');
            span.textContent = name;           
            removeBtn.textContent = 'Remove';
            editBtn.textContent = 'Edit';
            editBtn.addEventListener('click', editTaskHandler);
            removeBtn.addEventListener('click', removeTaskhandler);
            li.appendChild(span);
            li.appendChild(removeBtn);
            li.appendChild(editBtn);
            todoContainer.appendChild(li);
        }
    })
    }

function removeTaskhandler(event){
    const id = event.currentTarget.parentNode.id;
    const httpHeaders = {
        method:'DELETE'
    };

    fetch(`${BASE_URL}${id}`, httpHeaders)
    .then(() => loadTaskHandler())
}

    function editTaskHandler(event){
        const liParent = event.currentTarget.parentNode;
        const [span, _removeBtn, editBtn ] = Array.from(liParent.children);
        const editinput = document.createElement('input');
        editinput.value = span.textContent;
        liParent.prepend(editinput);
        const submitBtn = document.createElement('button');
        submitBtn.textContent = 'Submit';
        submitBtn.addEventListener('click', submitTaskhandler);
        liParent.appendChild(submitBtn);
        span.remove();
        editBtn.remove();
    }
    function submitTaskhandler(event){
        const liParent = event.currentTarget.parentNode;
        const id = liParent.id;
        const [input] = Array.from(liParent.children);
        const httpHeaders = {
            method: 'PATCH',
            body: JSON.stringify({name: input.value})
        }
        fetch(`${BASE_URL}${id}`, httpHeaders)
        .then(() => loadTaskHandler())
    }
}
    

attachEvents();
