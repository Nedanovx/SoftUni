window.addEventListener("load", solve);

function solve(){
    const inputState ={
        place: null,
        action: null,
        person: null,
    }

    const inputDomSelector ={
        place: document.getElementById('place'),
        action: document.getElementById('action'),
        person: document.getElementById('person'),
    }

    const otherDomSelector ={
        addButton: document.getElementById('add-btn'),
        taskList: document.getElementById('task-list'),
        doneTask: document.getElementById('done-list'),
    }
    otherDomSelector.addButton.addEventListener('click', addhandlerTask);

    function addhandlerTask(){
        const allFieldsHasValue = Object.values(inputDomSelector)
        .every((input) => input.value !== '');

        if(!allFieldsHasValue){
            return;
        }
        const {place, action, person} = inputDomSelector;
        const li = createElement('li', otherDomSelector.taskList, null, ['clean-task']);
        const articleElement = createElement('article', li);
        createElement('p',articleElement,`Place:${place.value}`);
        createElement('p', articleElement, `Action:${action.value}`);
        createElement('p', articleElement, `Person:${person.value}`);
        const divContainer = createElement('div', li, null,[`buttons`]);
        const editBtn = createElement('button', divContainer, 'Edit', ['edit']);
        const doneBtn = createElement('button', divContainer, 'Done', ['done']);

        editBtn.addEventListener('click', editTaskHandler);
        doneBtn.addEventListener('click', doneTaskHandler);
        for(const key in inputDomSelector){
            inputState[key] = inputDomSelector[key].value;
        }

        Object.values(inputDomSelector)
    .forEach((input) => {
      input.value = '';
    })
    }

    function editTaskHandler(event){
        const task = event.target.parentNode;
        const parentNode = task.parentNode;
        for(const key in inputDomSelector){
            inputDomSelector[key].value = inputState[key];
        }
        parentNode.innerHTML = '';

    }

    function doneTaskHandler(event){
        const doneTask = event.target.parentNode;
        const doneTaskParent = doneTask.parentNode;
        const {place, action, person} = inputState;
        const li = createElement('li', otherDomSelector.doneTask, null, ['done-list']);
        const articleElement = createElement('article', li);
        createElement('p',articleElement,`Place:${place.value}`);
        createElement('p', articleElement, `Action:${action.value}`);
        createElement('p', articleElement, `Person:${person.value}`);
        const deleteBtn = createElement('button', li, 'Delete', ['delete']);
        deleteBtn.addEventListener('click', deleteTaskHandler);
        doneTaskParent.innerHTML = '';
    }
    function deleteTaskHandler(event){
        const deleteTask = event.target.parentNode;
        
        deleteTask.innerHTML ='';

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
}