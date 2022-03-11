# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição do problema e os pontos mais relevantes a serem tratados neste projeto foram consolidados com base nas experiências pessoais, relacionadas ao tema, compartilhada por alguns membros do grupo. A partir desses relatos, inferimos outros possíveis problemas dos usuários. Os detalhes levantados nesse processo foram organizados em personas e histórias de usuários. 

## Personas
As personas levantadas durante o processo de entendimento do problema são apresentadas nas tabelas que se seguem:  

<img src="img/personas/persona1.PNG" width="150" height="150" />| **Camila Silva**  
---|---
**Idade:** 19 **Ocupação:** Estudante **Hobbies:** Literatura|**Aplicativos:** Instagram, Skoob, Apps bancários, Netflix, WhatsApp, Telegram  
**Motivações:** Gosta de ler livros. Gostaria de aumentar seu círculo de amizades. Quer melhorar sua habilidade de comunicação.|**Frustrações:** Sofre com a dificuldade de estabelecer interações com pessoas. É muito tímida e se sente tensa durante diálogos por não saber o que dizer.

<img src="img/personas/persona2.PNG" width="150" height="150" />| **Carlos Santos** 
--- | ---
**Idade:** 71 **Ocupação:** Aposentado **Hobbies:** Literatura|**Aplicativos:** Facebook, Aplicativos de bancos, Whatsapp
**Motivações:** Gosta de literatura. Gosta de sair para encontrar pessoas e conversar.|**Frustrações:** Se sente solitário e triste devido ao isolamento social provocado pela pandemia de Covid-19. 

<img src="img/personas/persona3.PNG" width="150" height="150" />| **Maria Ferreira** 
--- | ---
**Idade:** 39 **Ocupação:** Escritora iniciante **Hobbies:** Literatura, Escrita criativa |**Aplicativos:** Facebook, Instagram, Whatsapp, Aplicativos de bancos 
**Motivações:** Gosta de ler romances. Quer escrever seu próprio livro.|**Frustrações:** Não consegue encontrar alguém para compartilhar os capítulos já escritos de seu romance e obter um feedback. Possui muitas tarefas para realizar diariamente. 

<img src="img/personas/persona4.PNG" width="150" height="150" />| **Ana Oliveira** 
--- | ---
**Idade:** 57 **Ocupação:** Aposentada **Hobbies:** Literatura |**Aplicativos:** Whatsapp, Youtube 
**Motivações:** Passa a maior parte do tempo escutando audiolivros em casa. |**Frustrações:** Sente dificuldade de interagir com a tecnologia. Possui baixa visão e precisa do auxílio de ferramentas leitoras de tela. 

<img src="img/personas/persona5.PNG" width="150" height="150" />| **Miguel Lima** 
--- | ---
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
Miguel Lima | Montar ou pesquisar grupos com interesses literários em comum | Para que possa se conectar com atividades que gosta de forma simples e remota |
Miguel Lima | Comentar e avaliar livros lidos por mim | Para que possa expor minha opinião, ler a de outros e descobrir novos livros |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre tarefas | ALTA | 
|RF-002| Emitir um relatório de tarefas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | MÉDIA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

<img src="https://user-images.githubusercontent.com/81396458/157950178-ccef1fec-fc98-44a4-a541-b8887d015d38.png" />
