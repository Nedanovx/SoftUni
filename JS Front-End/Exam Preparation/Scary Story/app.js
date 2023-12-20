window.addEventListener("load", solve)

function solve() {
  const storyState = {
    firstName: null,
    lastName: null,
    age: null,
    title: null,
    genre: null,
    story: null,
  }
  const inputDomSelector = {
    firstName: document.getElementById('first-name'),
    lastName: document.getElementById('last-name'),
    age: document.getElementById('age'),
    title: document.getElementById('story-title'),
    genre: document.getElementById('genre'),
    story: document.getElementById('story'),
  }

  const otherDOMSelector = {
    publishBtn: document.getElementById('form-btn'),
    previewList: document.getElementById('preview-list'),
    mainContainer: document.getElementById('main'),
  }

  otherDOMSelector.publishBtn.addEventListener('click', publishStoryHandler);

  function publishStoryHandler(){
    const allFieldsHaveValues = Object.values(inputDomSelector)
    .every((input) => input.value !== '');

    if(!allFieldsHaveValues){
      return;
    }
    const {firstName, lastName, age, title, genre, story} = inputDomSelector;
    const li = createElement('li', otherDOMSelector.previewList, null, ['story-info']);
    const article = createElement('article', li);
    createElement('h4', article, `Name: ${firstName.value} ${lastName.value}`);
    createElement('p', article, `Age: ${age.value}`);
    createElement('p', article, `Title: ${title.value}`);
    createElement('p', article, `Genre: ${genre.value}`);
    createElement('p', article, story.value);
    const saveBtn = createElement('button', li, 'Save Story', ['save-btn']);
    const editBtn = createElement('button', li, 'Edit Story', ['edit-btn']);
    const deleteBtn = createElement('button', li, 'Delete Story', ['delete-btn']);

    editBtn.addEventListener('click', editStoryHandler);
    saveBtn.addEventListener('click', saveStoryHandler);
    deleteBtn.addEventListener('click', deleteStoryHandler);

    for(const key in inputDomSelector) {
      storyState[key] = inputDomSelector[key].value;
      }

    Object.values(inputDomSelector)
    .forEach((input) => {
      input.value = '';
    })

    otherDOMSelector.publishBtn.disabled = true;
  }

  function deleteStoryHandler(){
    const liItem = this.parentNode;
    liItem.remove();
    otherDOMSelector.publishBtn.disabled = false;
  }

    function saveStoryHandler(){
      otherDOMSelector.mainContainer.innerHTML = '';
      createElement('h1', otherDOMSelector.mainContainer, 'Your scary story is saved!');
    }

  function editStoryHandler(){
    for (const key in inputDomSelector) {
      inputDomSelector[key].value = storyState[key];
      }

      otherDOMSelector.publishBtn.disabled = false;
      otherDOMSelector.previewList.innerHTML = '';
      createElement('h3', otherDOMSelector.previewList, 'Preview');
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


