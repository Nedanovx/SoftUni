// TODO:
function attachEvents() {
const BASE_URL = 'http://localhost:3030/jsonstore/tasks/';
const loadBtn = document.getElementById('load-board-btn');
const addTaskBtn = document.getElementById('create-task-btn');
loadBtn.addEventListener('click', loadTaskHandler);
addTaskBtn.addEventListener('click', addTaksHandler);
const inputDomSelector ={
    title: document.getElementById('title'),
    description: document.getElementById('description'),
}

const statusToTextContentMap = {
    'ToDo': 'Move to In Progress',
    'In Progress': 'Move to Code Review',
    'Code Review': 'Move to Done',
};

const statusToContainerMap = {
    'ToDo': document.querySelector('#todo-section > .task-list'),
    'In Progress': document.querySelector('#in-progress-section > .task-list'),
    'Code Review': document.querySelector('#code-review-section > .task-list'),
    'Done': document.querySelector('#done-section > .task-list'),
};

const textContentToStatusMap = {
    'Move to In Progress': 'In Progress',
    'Move to Code Review': 'Code Review',
    'Move to Done': 'Done',
};

function addTaksHandler(){
    const { title, description } = inputDomSelector;
    const hasInvalidInput = Object.values(inputDomSelector)
        .some((input) => input.value === '');
    if (hasInvalidInput) {
        return;
    }

    const httpHeader = {
        method: 'POST',
        body: JSON.stringify({
            title: title.value,
            description: description.value,
            status: 'ToDo',
        })
    };

    fetch(BASE_URL, httpHeader)
    .then(loadTaskHandler)
    .catch(console.error);

    clearAllInputs();
}

function loadTaskHandler()
{
    
    clearAllSections();
    fetch(BASE_URL)
    .then((data) => data.json())
    .then((taskRes) => {
        Object.values(taskRes).forEach((task) =>{
            const container = statusToContainerMap[task.status];
            const item = createElement('li', container, null,['task']);
            createElement('h3', item, task.title);
            createElement('p', item, task.description);
            const button = createElement('button', item, null, null, task._id);
            if(task.status !== 'Done'){
                button.textContent = statusToTextContentMap[task.status];
                button.addEventListener('click', moveTaskHandler);
            }
            else{
                button.textContent = 'Close';
                button.addEventListener('click', moveTaskHandler);
            }
            container.append(item);
        })
    })
}
function moveTaskHandler(event){
    if(event.target.textContent === 'Close'){
        let id = event.target.id;
        const httpHeader = {
            method: 'DELETE',
        }
        fetch(`${BASE_URL}${id}`, httpHeader)
        .then(loadTaskHandler)
    }
    else{
        const button = event.target; 
        const buttonId = button.getAttribute('id');
        
        const httpHeader ={
            method: 'PATCH',
            body: JSON.stringify({ status: textContentToStatusMap[button.textContent]})
        }
        fetch(`${BASE_URL}${buttonId}`, httpHeader)
        .then(loadTaskHandler)
    }
    
}

function createElement(type, parentNode, content, classes, id, attributes, useInnerHtml){
    const htmlElement = document.createElement(type);
    
    if(content && useInnerHtml){
      htmlElement.innerHTML = content;
    }else{
      if(content && type !== 'input'){
        htmlElement.textContent = content;
      }
  
      if(content && type === 'input'){
        htmlElement.value = content;
      }
    }
  
    if(classes && classes.length > 0){
      htmlElement.classList.add(...classes);
    }
  
    if(id){
      htmlElement.id = id;
    }
  
    if(attributes){
      for(const key in attributes){
        htmlElement.setAttribute(key, attributes[key]);
      }
    }
  
    if(parentNode){
      parentNode.appendChild(htmlElement);
    }
    return htmlElement;
  }


function clearAllSections() {
    Object.values(statusToContainerMap)
        .forEach((section) => {
            section.innerHTML = '';
        })
}

function clearAllInputs() {
    Object.values(inputDomSelector)
        .forEach((input) => {
            input.value = '';
        })
}
}

attachEvents();