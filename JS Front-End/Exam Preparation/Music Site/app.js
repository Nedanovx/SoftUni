window.addEventListener('load', solve);

function solve() {

    const inputDomSelector ={
        genre: document.getElementById('genre'),
        name: document.getElementById('name'),
        author: document.getElementById('author'),
        date: document.getElementById('date'),
    }

    const otherDomSelector = {
        addBtn: document.getElementById('add-btn'),
        allHits: document.querySelector('.all-hits-container'),
        likes: document.querySelector('.likes p'),
        saves: document.querySelector('.saved-container')
    }
    
    otherDomSelector.addBtn.addEventListener('click', function (event) {
        event.preventDefault(); 

        addTaskHandler();
    });

    function addTaskHandler(){
        const allFieldsHaveValues = Object.values(inputDomSelector)
    .every((input) => input.value !== '');

    if(!allFieldsHaveValues){
    return;
    }

        const {genre, name, author, date} = inputDomSelector;
        const divElement = createElement('div', otherDomSelector.allHits, null, ['hits-info']);
        const imgElement = document.createElement('img');
        imgElement.src = './static/img/img.png';
        divElement.appendChild(imgElement);
        createElement('h2', divElement, `Genre: ${genre.value}`);
        createElement('h2', divElement, `Name: ${name.value}`,);
        createElement('h2', divElement, `Author: ${author.value}`);
        createElement('h3', divElement, `Date: ${date.value}`);
        const saveBtn = createElement('button', divElement, 'Save song', ['save-btn']);
        const likeBtn = createElement('button', divElement, 'Like song', ['like-btn']);
        const deleteBtn = createElement('button', divElement, 'Delete', ['delete-btn']);
        
        saveBtn.addEventListener('click', saveTaskHandler);
        likeBtn.addEventListener('click', likeTaskHandler);
        deleteBtn.addEventListener('click', deleteTaskHandler);
        Object.values(inputDomSelector)
    .forEach((input) => {
      input.value = '';
    })
    }

    function deleteTaskHandler(event){
        const deleteSongs = event.target.parentElement;
        deleteSongs.remove();
    }

function saveTaskHandler(event){
        const savedSongs = event.target.parentElement;
        const likeBtnToRemove = savedSongs.querySelector('.like-btn');
        const saveBtnToremove = savedSongs.querySelector('.save-btn');
        likeBtnToRemove.remove();
        saveBtnToremove.remove();
        
        otherDomSelector.saves.appendChild(savedSongs);
}

    function likeTaskHandler(event){
        let currentLikes = (otherDomSelector.likes.textContent);
        let text = currentLikes.split(' ');
        let likesNumber = parseInt(text[2]);
        likesNumber += 1;
        otherDomSelector.likes.textContent = `Total Likes: ${likesNumber}`;
        event.target.disabled = true;
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