# Plano de Testes de Software

Os requisitos para realização dos testes de software são: 

- Site publicado na Internet.
- Navegador da Internet - Chrome, Firefox, Edge, Opera e Safari.
- Conectividade de Internet para acesso às plataformas (APISs).

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.
 
| Caso de Teste | CT-01 – Gerenciar perfil |
|------------------|----------------------------------------------------|
|Requisitos Associados | RF-001 - O site deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar seu perfil e efetuar login, sendo o login endereço de e-mail. <br> RF-004 - O site deve possuir a opção de remover informações. <br> RF-005 - O site deve possuir opção de edição de informações na conta. |
|Objetivo do Teste | Verificar se o usuário consegue se cadastrar, efetuar login, remover e editar informações em seu perfil |
|Passos | - Acessar o navegador <br> - Informar o endereço do site <br> - Criar um novo perfil para a realização do teste <br> - Efetuar login <br> - Remover alguma informação do perfil <br> - Editar alguma informação do perfil |
|Critérios de Êxito | - O cadastro foi realizado com sucesso <br> - O login foi realizado com sucesso <br> - Foi possível remover alguma informação do perfil <br> - Foi possível editar alguma informação do perfil |

| Caso de Teste | CT-02 – Gerenciar listas |
|------------------|----------------------------------------------------|
|Requisito Associado | RF-006 - O site deve possuir as opções de inserir listas de livros e de salvá-las. |
|Objetivo do Teste | Verificar se o usuário consegue cadastrar e editar listas de seus livros favoritos |
|Passos | -  |
|Critério de Êxito | - O usuário consegue cadastrar listas <br>
- O usuário consegue editar suas listas (acrescentando e alterarando livros) |

| Caso de Teste | CT-03 – Sistema de combinação (Match) |
|------------------|----------------------------------------------------|
|Requisitos Associados | RF-010 - O site deve permitir a função _match_ quando um usuário se identificou com outro usuário.<br> RF-012 - O site deve listar e reunir _os matches_ por áreas da literatura para ajudar na recuperação de informações.	 |
|Objetivo do Teste | Verificar se o sistema realiza a combinação (_match_) entre o usuário e se as combinações são organizados por gêneros literários |
|Passos | -  |
|Critérios de Êxito | - A combinação entre usuários é realizada <br>
- O usuário consegue visualizar suas listas de combinações por gêneros literários  |

| Caso de Teste | CT-04 – Navegação entre perfis |
|------------------|----------------------------------------------------|
|Requisitos Associados | RF-003 - O site deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar pessoas com os mesmos gêneros literários.<br> RF-008 - O site deve permitir mostrar uma parte do perfil de outros usuários para facilitar o encontro de mesmos gêneros literários.	|
|Objetivo do Teste | Verificar se o usuário consegue pesquisar pessoas com listas preenchidas com os mesmos gêneros literários |
|Passos | -  |
|Critério de Êxito | - O usuário consegue pesquisar e localizar pessoas com os mesmos gêneros literários |

| Caso de Teste | CT-05 – Interação entre usuários |
|------------------|----------------------------------------------------|
|Requisito Associado |RF-002 - O site deve ter um chat para conversação para os usuários interagirem entre si.	|
|Objetivo do Teste | Verificar se o chat consegue ser utilizado por usuários combinados |
|Passos | -  |
|Critério de Êxito | - Os usuários combinados são capazes de interagir no chat da aplicação |

| Caso de Teste | CT-06 – Pesquisa e avaliação de livros |
|------------------|----------------------------------------------------|
|Requisitos Associados | RF-009 - O site deve permitir um sistema simples para pesquisas de livros.	<br> RF-011 - O site deve permitir que usuários façam comentários e avaliações sobre os livros.	|
|Objetivo do Teste | Verificar se o usuário consegue pesquisar, comentar e avaliar (classificar) livros |
|Passos | -  |
|Critérios de Êxito | - O usuário consegue pesquisar livros <br>
- O usuário consegue comentar/fazer uma resenha sobre livros <br>
- O usuário consegue avaliar (classificar) livros |

| Caso de Teste | CT-07 – Atender a mais de um público |
|------------------|----------------------------------------------------|
|Requisito Associado | RF-007 - O site deve possuir um sistema adaptado para pessoas com deficiências visuais.	|
|Objetivo do Teste | Verificar se usuários com deficiências visuais conseguem utilizar todas as ferramentas do site |
|Passos | -  |
|Critério de Êxito | - Os usuários com deficiências visuais conseguem utilizar a aplicação |
