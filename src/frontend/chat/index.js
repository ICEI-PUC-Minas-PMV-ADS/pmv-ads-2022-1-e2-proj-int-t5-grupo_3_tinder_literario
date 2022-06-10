document.querySelector('.chat[data-chat=person2]').classList.add('active-chat')
document.querySelector('.person[data-chat=person2]').classList.add('active')

let friends = {
    list: document.querySelector('ul.people'),
    all: document.querySelectorAll('.left .person'),
    name: ''
  },
  chat = {
    container__chat: document.querySelector('.container__chat .right'),
    current: null,
    person: null,
    name: document.querySelector('.container__chat .right .top .name')
  }

friends.all.forEach(f => {
  f.addEventListener('mousedown', () => {
    f.classList.contains('active') || setAciveChat(f)
  })
});

function setAciveChat(f) {
  friends.list.querySelector('.active').classList.remove('active')
  f.classList.add('active')
  chat.current = chat.container__chat.querySelector('.active-chat')
  chat.person = f.getAttribute('data-chat')
  chat.current.classList.remove('active-chat')
  chat.container__chat.querySelector('[data-chat="' + chat.person + '"]').classList.add('active-chat')
  friends.name = f.querySelector('.name').innerText
  chat.name.innerHTML = friends.name
}

fetch('https://matchbookapi.herokuapp.com/api/v1/envia-mensagems', {
  method: "POST",
  body: JSON.stringify(mensagem),
  headers: {"Content-type": "application/json; charset=UTF-8"}
})
.then(response => response.json())
.then(json => console.log(json))
.catch(err => console.log(err));