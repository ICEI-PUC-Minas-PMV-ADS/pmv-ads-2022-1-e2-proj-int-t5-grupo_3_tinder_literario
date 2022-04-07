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
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Criar um novo perfil para a realização do teste |
|Critério de Êxito | - O cadastro foi realizado com sucesso. |
|  	|  	|
| Caso de Teste 	| CT-02 – Efetuar login	|
|Requisito Associado | RF-005	- A aplicação deve possuir opção de fazer login, sendo o login endereço de e-mail. |
| Objetivo do Teste 	| Verificar se o usuário consegue realizar login. |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Realizar login com a conta cadastrada |
|Critério de Êxito | - O login foi realizado com sucesso. |
|  	|  	|
| Caso de Teste | CT-03 – Login com a conta Google e/ou com o Facebook |
|Requisito Associado | RF-012 - A aplicação deve permitir que o login seja efetuado com a conta Google e com o Facebook.	|
|Objetivo do Teste | Verificar se o usuário consegue logar na aplicação com sua conta Google e/ou com sua conta no Facebook. |
|Passos | - Acessar o navegador <br> - Informar o endereço do site <br> - Efetuar login com a conta Google e/ou com o Facebook |
|Critério de Êxito | - Os usuários são capazes de fazer login com a conta Google e/ou com o Facebook. |
|  	|  	|
| Caso de Teste | CT-04 – Criar listas |
|Requisito Associado | RF-006 - A página web deve possuir as opções de inserir listas de livros e de salvá-las.	|
|Objetivo do Teste | Verificar se o usuário consegue criar listas de livros. |
|Passos | - Acessar o navegador <br> - Informar o endereço do site <br> - Realizar login com a conta cadastrada <br> - Criar uma lista |
|Critério de Êxito | - O usuário consegue criar suas listas.  |
|  	|  	|
| Caso de Teste | CT-05 – Salvar listas |
|Requisito Associado | RF-006 - A página web deve possuir as opções de inserir listas de livros e de salvá-las.	|
|Objetivo do Teste | Verificar se o usuário consegue salvar suas listas de livros. |
|Passos | - Acessar o navegador <br> - Informar o endereço do site <br> - Realizar login com a conta cadastrada <br> - Acessar uma lista <br> - Fazer alterações (acrescentar e/ou remover livros) |
|Critério de Êxito | - O usuário consegue salvar suas listas com sucesso. |
|  	|  	|
| Caso de Teste | CT-06 – Interação entre usuários |
|Requisito Associado | RF-002 - A aplicação deve ter um chat para conversação para os usuários interagirem entre si.	|
|Objetivo do Teste | Verificar se o chat consegue ser utilizado pelos usuários. |
|Passos | -  Acessar a aplicação <br> - Acessar a lista de usuários curtidos <br> - Selecionar um usuário para abrir o chat <br> - Enviar mensagens <br> - Receber mensagens |
|Critério de Êxito | - Os usuários são capazes de interagir no chat da aplicação. |
|  	|  	|
| Caso de Teste | CT-07 – Buscar livros |
|Requisitos Associados | RF-003 - A aplicação deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar livros.	<br> RF-008 - A aplicação deverá permitir buscar livros previamente cadastrados na base de dados.	|
|Objetivo do Teste | Verificar se o usuário consegue localizar livros. |
|Passos | - Acessar a aplicação <br> - Digitar o nome de um livro <br> - Visualizar o resultado da busca |
|Critério de Êxito | - O usuário consegue buscar livros. |
|  	|  	|
| Caso de Teste | CT-08 – Buscar listas |
|Requisito Associado | RF-007 - A aplicação deve permitir mostrar uma parte do perfil de outros usuários para facilitar o encontro de listas de livros.	|
|Objetivo do Teste | Verificar se o usuário consegue localizar listas em perfis de usuários do M@tchbook. |
|Passos | - Acessar a aplicação <br> - Visitar o perfil de outro usuário <br> - Visualizar as listas cadastradas pelo usuário |
|Critério de Êxito | - O usuário consegue visualizar listas de outros usuários do M@tchbook. |
|  	|  	|
| Caso de Teste | CT-09 – Comentar livros |
|Requisito Associado | RF-010 - A aplicação deve permitir que usuários façam comentários sobre os livros.	|
|Objetivo do Teste | Verificar se o usuário consegue comentar livros. |
|Passos | - Acessar a aplicação <br> - Digitar o nome de um livro <br> - Visualizar o resultado da busca <br> - Realizar um comentário no espaço apropriado |
|Critério de Êxito | - O usuário consegue comentar/fazer uma resenha sobre livros. |
|  	|  	|
| Caso de Teste | CT-10 – Sistema de curtidas (_Match_) |
|Requisito Associado | RF-009 - A aplicação deve permitir a função _match_ quando um usuário se identificou com outro usuário.	 |
|Objetivo do Teste | Verificar se o sistema realiza a curtida (_match_) entre os usuários. |
|Passos | - Fazer login <br> - Visualizar listas de outros usuários <br> - Curtir a lista <br> - Receber a informação de _match_ realizado |
|Critério de Êxito | - A curtida entre usuários é realizada. |
|  	|  	|
| Caso de Teste | CT-11 – Reunir _matches_ |
|Requisito Associado | RF-011 - A aplicação deve reunir as listas com mais _matches_	 |
|Objetivo do Teste | Verificar se as listas com mais _matches_ são disponibilizadas para os usuários |
|Passos | - Fazer login <br> - Acessar o menu da aplicação <br> - Observar as listas com mais curtidas |
|Critério de Êxito | - A aplicação reúne as listas com mais _matches_. |
|  	|  	|
| Caso de Teste | CT-12 – Ocultar informações cadastrais |
|Requisito Associado | RF-004 - A aplicação deve possuir a opção de não mostrar todos os dados do usuário.	 |
|Objetivo do Teste |  Verificar se informações pessoais não são disponibilizadas publicamente |
|Passos | - Fazer login <br> - Acessar o perfil de um grupo de usuários <br> - Observar se a foto e o nome desses usuários estão públicos <br> - Observar se o número de telefone e demais dados pessoais cadastrais estão ocultos |
|Critério de Êxito | -  Dados pessoais cadastrais não estão publicamente expostos para demais usuários do M@tchbook |
