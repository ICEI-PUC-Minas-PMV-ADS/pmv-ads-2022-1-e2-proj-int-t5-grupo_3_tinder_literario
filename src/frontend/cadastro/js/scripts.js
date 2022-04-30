
function RealizeRegistry(event){
    event.stopPropagation();

    let user = {
        nome: "",
        documento: "",
        email: "",
        senha: "",
        celular: ""
    }

    try{
        user.nome = document.querySelector('#name').value + " " + document.querySelector('#lastname').value
        user.documento = document.querySelector('#cpf').value
        user.email = document.querySelector('#email').value
        user.celular = document.querySelector('#phoneNumber').value
        user.senha = document.querySelector('#password').value
    }catch(e){
        console.error(e)
    }
    


    fetch("http://localhost:32738/api/v1/criar-usuario", {
        method: "POST", 
        headers: {
            'Content-Type': 'application/json',
            'Access-Control-Allow-Origin': '*',
            'Access-Control-Request-Headers': 'access-control-allow-origin,content-type',
            'Access-Control-Request-Method': 'access-control-allow-origin,content-type'
        },
        body: JSON.stringify(user)
      }).then(res => {
        user = {
            nome: "",
            documento: "",
            email: "",
            senha: "",
            celular: ""
        }
        window.location.href("http://127.0.0.1:5500/login/index.html")
        console.log("Promise resolved", res.text());
      }).catch(err => {
        console.log(err)
        user = {
            nome: "",
            documento: "",
            email: "",
            senha: "",
            celular: ""
        }
    
    });

    user = {
        nome: "",
        documento: "",
        email: "",
        senha: "",
        celular: ""
    }


  return false
}
