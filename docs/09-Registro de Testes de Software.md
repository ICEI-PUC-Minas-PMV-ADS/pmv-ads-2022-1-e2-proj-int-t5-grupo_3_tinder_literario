# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Relatório com as evidências dos testes de software realizados no sistema pela equipe, baseado em um plano de testes pré-definido.

| Testes 	| CT-01 – Cadastrar perfil e CT-02 – Efetuar login	|
|:---:	|:---:	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/81396458/167744526-c554da2e-b6f0-4b64-8834-175ce31cc208.mp4"> |
|  	|  	|
| Teste 	| CT-03 – Criar listas	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/81396458/173191762-4f9e84ee-6096-4f5f-b55a-c7606971970c.mp4"> |
|  	|  	|
| Teste 	| CT-04 – Salvar listas	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/81396458/173191772-7247fd7d-c382-49e9-a9ba-4bdfbaec865f.mp4"> |
|  	|  	|
| Teste 	| CT-05 – Interação entre os usuários	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/81396458/173191773-b437be1b-5d00-4850-8fc3-265fa2242914.mp4"> |
|  	|  	|
| Teste 	| CT-06 – Buscar livros	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/81396458/173191777-1e3c93ed-6904-4121-9a1b-11c21561fc73.mp4"> |
|  	|  	|
| Teste 	| CT-07 – Sistema de curtidas (Match)	|
|	Vídeo 	| <video src="https://user-images.githubusercontent.com/81396458/173191781-7710756b-11ac-433c-9bfd-33b763c119ee.mp4"> |

<h2>Relatório de Testes de Software</h2>
  
O objetivo deste relatório é indicar se a aplicação M@tchbook atende aos requisitos previamente propostos e sugerir possíveis pontos de correção.

<br> 
  
| 1 	| Cadastrar perfil 	|
|:---:	|:---:	|
|	Requisito	| RF-001 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Observação | Na página inicial, a aplicação apresenta a funcionalidade de cadastro, este que pode ser realizado ao clicar em "criar conta". Após o preenchimento de informações cadastrais (e-mail, nome, CPF, por exemplo) e aceitar os termos de uso, o usuário recebe o feedback de que o cadastro foi realizado com sucesso. Além disso, é possível fazer alterações posteriores a respeito dessas informações (por exemplo, a troca de e-mail e a alteração de número de telefone). Assim, o M@tchbook atende ao requisito <b> cadastrar perfil . |
|  	|  	|
| 2| Efetuar login	|
| Requisito | RF-005	- A aplicação deve possuir opção de fazer login, sendo o login endereço de e-mail. |
| Observação | Também na página inicial, a aplicação apresenta a funcionalidade de login. Após o preenchimento dos campos de e-mail e senha o usuário é redirecionado para a tela de livros disponíveis no banco da aplicação. O M@tchbook, então, atende ao requisito <b> efetuar login. |
|  	|  	|
| 3 | Criar listas |
|Requisito | RF-006 - A página web deve possuir as opções de inserir listas de livros e de salvá-las.	|
| Observação | A aplicação permite aos usuários, primeiramente, favoritar e, em seguida, usar os livros favoritados na criação de listas. A função/ação "favoritar" pode passar despercebida pelo usuário, que, sem ela, não consegue inserir livros em uma lista. Assim, o M@tchbook atende parcialmente ao requisito <b> criar listas. |
|  	|  	|
| 4 | Salvar listas |
|Requisito | RF-006 - A página web deve possuir as opções de inserir listas de livros e de salvá-las.	|
| Observação | Após a criação da lista, o usuário consegue salvá-la sem problemas. Dessa forma, a aplicação atende ao requisito <b> salvar listas.  |
|  	|  	|
| 5 | Interação entre usuários |
|Requisito | RF-002 - A aplicação deve ter um chat para conversação para os usuários interagirem entre si.	|
| Observação | Inicialmente, a interação entre os usuários deveria ocorrer dentro da própria aplicação. No entanto, com o decorrer do desenvolvimento das demais funcionalidades do M@tchbook,  a decisão tomada foi permitir que o usuário, após ter dado _match_ em uma lista, fosse redirecionado ao WhatsApp, isto é, com um clique é possível mandar uma mensagem para a combinação por meio de outro aplicativo, caso o telefone cadastrado dessa combinação estiver correto e também cadastrado no WhatsApp. Dessa forma, o M@tchbook atende insatisfatoriamente ao requisito <b> interação entre usuários. |
|  	|  	|
| 6 | Buscar livros |
|Requisitos | RF-003 - A aplicação deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar livros.	<br> RF-008 - A aplicação deverá permitir buscar livros previamente cadastrados na base de dados.	|
| Observação | Após o login, o usuário é redirecionado para a tela de livros disponíveis. Há, nela, uma barra de pesquisa que filtra a busca diante do que foi digitado, que retorna com sucesso o livro pesquisado, mesmo que esse tenha sido digitado em caixa alta ou com fragmentos do título faltando. O M@tchbook atende ao requisito <b> buscar livros. |
|  	|  	|
| 7 | Sistema de curtidas (_Match_) |
|Requisito | RF-009 - A aplicação deve permitir a função _match_ quando um usuário se identificou com outro usuário.	 |
| Observação | A aplicação apresenta o botão de "curtir", que, quando clicado, realiza a função _match_. O M@tchbook atende ao requisito <b> sistema de curtidas. |
|  	|  	|
| 8 | Reunir _matches_ |
|Requisito | RF-011 - A aplicação deve reunir as listas com mais _matches_	 |
| Observação | A aplicação, até o momento, não reúne as listas com mais _matches_. Dessa maneira, o M@tchbook não atende ao requisito <b> reunir _matches_. |

<br>

**Possíveis pontos de correção:**
  
Como possíveis pontos de correção, sugerimos as seguintes ações:
- a equipe deve cadastrar, periodicamente, mais livros no banco para permitir uma maior e mais variada criação de listas;
- a equipe deve proporcionar que a interação entre os usuários seja realizada dentro da própria aplicação, com um chat próprio; 
- a equipe deve permitir que os livros possam ser inseridos em uma lista sem que seja necessários favoritá-los previamente.
