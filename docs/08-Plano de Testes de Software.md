# Plano de Testes de Software

Os requisitos para realização dos testes de software são: 

- Site publicado na Internet.
- Navegador da Internet - Chrome, Firefox, Edge, Opera e Safari.
- Conectividade de Internet para acesso às plataformas (APISs).

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.
 
| Caso de Teste 	| CT-01 – Cadastrar perfil 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar no M@tchbook. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios (e-mail, nome, sobrenome, celular, CPF, senha, confirmação de senha) <br> - Aceitar os termos de uso <br> - Clicar em "Registrar" |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-004	- A aplicação deve possuir opção de fazer login, sendo o login endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Entrar" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste | CT-03 – Criar listas |
|Requisito Associado | RF-005 - A página web deve possuir as opções de inserir listas de livros e de salvá-las.	|
|Objetivo do Teste | Verificar se o usuário consegue criar listas de livros. |
|Passos | - Acessar o navegador <br> - Informar o endereço do site <br> - Realizar login com a conta cadastrada <br> - Visitar os livros disponíveis <br> - Selecionar os livros que quer em uma lista <br> - Favoritar os livros que quer em uma lista <br> - Visitar a página de "Listas" <br> - Criar uma lista |
|Critério de Êxito | - O usuário consegue criar suas listas.  |
|  	|  	|
| Caso de Teste | CT-04 – Salvar listas |
|Requisito Associado | RF-005 - A página web deve possuir as opções de inserir listas de livros e de salvá-las.	|
|Objetivo do Teste | Verificar se o usuário consegue salvar suas listas de livros. |
|Passos | - Acessar o navegador <br> - Informar o endereço do site <br> - Realizar login com a conta cadastrada <br> - Acessar uma lista <br> - Fazer alterações (acrescentar e/ou remover livros) |
|Critério de Êxito | - O usuário consegue salvar suas listas com sucesso. |
|  	|  	|
| Caso de Teste | CT-05 – Interação entre usuários |
|Requisito Associado | RF-002 - A aplicação deve ter um chat para conversação para os usuários interagirem entre si.	|
|Objetivo do Teste | Verificar se o chat consegue ser utilizado pelos usuários. |
|Passos | -  Acessar a aplicação <br> - Acessar a lista de usuários curtidos <br> - Selecionar um usuário para abrir o chat <br> - Enviar mensagens <br> - Receber mensagens |
|Critério de Êxito | - Os usuários são capazes de interagir no chat da aplicação. |
|  	|  	|
| Caso de Teste | CT-06 – Buscar livros |
|Requisitos Associados | RF-003 - A aplicação deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar livros.	<br> RF-006 - A aplicação deverá permitir buscar livros previamente cadastrados na base de dados.	|
|Objetivo do Teste | Verificar se o usuário consegue localizar livros. |
|Passos | - Acessar a aplicação <br> - Digitar o nome de um livro na barra de pesquisa <br> - Clicar na lupa de busca <br> - Visualizar o resultado da busca |
|Critério de Êxito | - O usuário consegue buscar e visualizar o livro desejado. |
|  	|  	|
| Caso de Teste | CT-07 – Sistema de curtidas (_Match_) |
|Requisito Associado | RF-007 - A aplicação deve permitir a função _match_ quando um usuário se identificou com outro usuário.	 |
|Objetivo do Teste | Verificar se o sistema realiza a curtida (_match_) entre os usuários. |
|Passos | - Fazer login <br> - Visualizar listas de outros usuários <br> - Curtir a lista <br> - Receber a informação de _match_ realizado |
|Critério de Êxito | - A curtida entre usuários é realizada. |
|  	|  	|
| Caso de Teste | CT-08 –  Favoritar livros |
|Requisito Associado | RF-008 - A aplicação deve oferecer a funcionalidade de favoritar livros 	 |
|Objetivo do Teste | Verificar se o usuário consegue favoritar livros |
|Passos | - Fazer login <br> - Acessar o menu da aplicação <br> - Visitar a página de livros disponíveis <br> - Clicar no livro desejado para abrir o modal com detalhes dos livros <br> - Clicar em "Adicionar aos favoritos"  |
|Critério de Êxito | - O usuário consegue favoritar seus livros desejados. |
|  	|  	|
| Caso de Teste | CT-09 –  Recuperar senha |
|Requisito Associado | RF-009 - A aplicação deve permitir que o usuário recupere sua senha  	 |
|Objetivo do Teste | Verificar se o usuário consegue recuperar sua senha de acesso |
|Passos | -   |
|Critério de Êxito | - O usuário consegue recuperar sua senha com sucesso. |
