# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição do problema e os pontos mais relevantes a serem tratados neste projeto foram consolidados com base nas experiências pessoais, relacionadas ao tema, compartilhada por alguns membros do grupo. A partir desses relatos, inferimos outros possíveis problemas dos usuários. Os detalhes levantados nesse processo foram organizados em personas e histórias de usuários. 

## Personas
As personas levantadas durante o processo de entendimento do problema são apresentadas nas tabelas que se seguem:

Persona | 1
---|---
<img src="img/personas/persona1.PNG" width="150" height="150" />| **Camila Silva**  
**Idade:** 19 **Ocupação:** Estudante **Hobbies:** Literatura|**Aplicativos:** Instagram, Skoob, Apps bancários, Netflix, WhatsApp, Telegram  
**Motivações:** Gosta de ler livros. Gostaria de aumentar seu círculo de amizades. Quer melhorar sua habilidade de comunicação.|**Frustrações:** Sofre com a dificuldade de estabelecer interações com pessoas. É muito tímida e se sente tensa durante diálogos por não saber o que dizer.
**Persona** | **2** 
<img src="img/personas/persona2.PNG" width="150" height="150" />| **Carlos Santos** 
**Idade:** 71 **Ocupação:** Aposentado **Hobbies:** Literatura|**Aplicativos:** Facebook, Aplicativos de bancos, Whatsapp
**Motivações:** Gosta de literatura. Gosta de sair para encontrar pessoas e conversar.|**Frustrações:** Se sente solitário e triste devido ao isolamento social provocado pela pandemia de Covid-19. 
**Persona** | **3**
<img src="img/personas/persona3.PNG" width="150" height="150" />| **Maria Ferreira** 
**Idade:** 39 **Ocupação:** Escritora iniciante **Hobbies:** Literatura, Escrita criativa |**Aplicativos:** Facebook, Instagram, Whatsapp, Aplicativos de bancos 
**Motivações:** Gosta de ler romances. Quer escrever seu próprio livro.|**Frustrações:** Não consegue encontrar alguém para compartilhar os capítulos já escritos de seu romance e obter um feedback. Possui muitas tarefas para realizar diariamente. 
**Persona** | **4**
<img src="img/personas/persona4.PNG" width="150" height="150" />| **Ana Oliveira** 
**Idade:** 57 **Ocupação:** Aposentada **Hobbies:** Literatura |**Aplicativos:** Whatsapp, Youtube 
**Motivações:** Passa a maior parte do tempo escutando audiolivros em casa. |**Frustrações:** Sente dificuldade de interagir com a tecnologia. Possui baixa visão e precisa do auxílio de ferramentas leitoras de tela. 
**Persona** | **5**
<img src="img/personas/persona5.PNG" width="150" height="150" />| **Miguel Lima** 
**Idade:** 26 **Ocupação:** Afastado do emprego **Hobbies:** Literatura |**Aplicativos:** Instagram, Skoob, Apps bancários, Netflix, WhatsApp, Telegram  
**Motivações:** Gostaria de voltar a frequentar clubes de literatura. Quer encontrar novas recomendações de livros. |**Frustrações:** Devido a um acidente, desenvolveu dificuldade de mobilidade. Não sai de casa tanto quanto gostaria.



## Histórias de Usuários

Com base na análise das personas identificadas para o projeto, foram formuladas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Camila Silva | Criar uma conta com meus dados pessoais que devem permanecer salvos e que possam ser alterados | Para ter um perfil de acesso ao utilizar a aplicação |
|Camila Silva | Expor em meu perfil assuntos que me interessem dentro do escopo da literatura | Para facilitar durante a busca de pessoas com interesses em comum |
|Camila Silva | Visualizar pessoas com interesses em comum e estabelecer uma conexão com elas | Para que o interesse em comum facilite a interação e eventualmente melhore minhas habilidades de comunicação |
Carlos Santos | Acessar um chat para conversar na aplicação | Para interagir com as pessoas on-line ou marcar encontros pessoalmente |
Maria Ferreira | Usar a aplicação tanto no computador quanto no celular | Para acessar em diferentes contextos de sua rotina |
Ana Oliveira | Um sistema com interface simples e intuitiva | Para interagir com a aplicação, mesmo tendo dificuldade com o uso da tecnologia |
Ana Oliveira | Um sistema bem adaptado para leitores de tela | Para que a baixa visão não atrapalhe a experiência de uso |
Miguel Lima | Visualizar e comentar livros| Para que possa expor a opinião, ler a de outros, descobrir novos livros, e com isso se conctar a atividades que gosta de forma simples e remota |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O site deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar seu perfil e efetuar login, sendo o login endereço de e-mail.       | ALTA | 
|RF-002| O site deve ter um chat para conversação para os usuários interagirem entre si. | MÉDIA |
|RF-003| O site deve oferecer uma funcionalidade de filtro/pesquisa para permitir ao usuário localizar listas de livros. | ALTA |
|RF-004| O site deve possuir a opção de remover informações. | ALTA |
|RF-005| O site deve possuir opção de edição de informações na conta. | ALTA|
|RF-006| O site deve possuir as opções de inserir listas de livros e de salvá-las. | ALTA |
|RF-007| O site deve possuir um sistema adaptado para pessoas com deficiências visuais. | ALTA|
|RF-008| O site deve permitir mostrar uma parte do perfil de outros usuários para facilitar o encontro de listas de livros. | BAIXA |
|RF-009| O site deve permitir um sistema simples para pesquisas de livros. | BAIXA |
|RF-010| O site deve permitir a função _match_ quando um usuário se identificou com outro usuário. | ALTA |
|RF-011| O site deve permitir que usuários façam comentários sobre os livros.	 | MÉDIA |
|RF-012| O site deve listar e reunir os livros com mais _matches_. | BAIXA |
|RF-013| O site deve permitir que o login seja efetuado com a conta Google e com o Facebook. |ALTA|


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku). | ALTA | 
|RNF-002| O site deverá ser responsivo, permitindo a visualização em um celular de forma adequada. | ALTA | 
|RNF-003| O site deve ter bom nível de contraste entre os elementos da tela em conformidade. | MÉDIA |
|RNF-004| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge). | ALTA |
|RNF-005| O site deve possuir leitores de tela, para que pessoas com deficiência possam utilizar nossa plataforma. | MÉDIA |
|RNF-006| O site deve possuir uma tela simples e intuitiva, com base nos pressupostos do Design de Interação, para que pessoas com dificuldades em tecnologias possam utilizá-lo.  | ALTA |
|RNF-007| O site deve permitir salvar as informações dos usuários respeitando a LGPD.  | MÉDIA |

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 26/06/2022.   |
|RE-02| O aplicativo deve utilizar conhecimentos de SQL e Modelagem de Dados, Engenharia de Requisitos de Software, Programação Modular, Algoritmos e Estruturas de Dados, Desenvolvimento Web Back-End e Front-End e Fundamentos de Redes de Computadores.          |
|RE-03| A equipe não pode subcontratar o desenvolvimento do trabalho.        |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

<img src="https://user-images.githubusercontent.com/81396458/157950178-ccef1fec-fc98-44a4-a541-b8887d015d38.png" width="70%"/>
