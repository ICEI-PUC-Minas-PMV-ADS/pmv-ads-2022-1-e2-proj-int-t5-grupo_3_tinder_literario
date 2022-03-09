# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

A definição do problema e os pontos mais relevantes a serem tratados neste projeto foram consolidados com base nas experiências pessoais, relacionadas ao tema, compartilhada por alguns membros do grupo. A partir desses relatos, inferimos outros possíveis problemas dos usuários. Os detalhes levantados nesse processo foram organizados em personas e histórias de usuários. 

## Personas
As personas levantadas durante o processo de entendimento do problema são apresentadas nas tabelas que se seguem. 

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
**Motivações:** Passa a maior parte do tempo escutando audiolivros em casa. Gostaria de encontrar novas recomendações de livros.  |**Frustrações:** Sente dificuldade de interagir com a tecnologia. Possui baixa visão e precisa do auxílio de ferramentas leitoras de tela. 

<img src="img/personas/persona5.PNG" width="150" height="150" />| **Miguel Lima** 
--- | ---
**Idade:** 26 **Ocupação:** Afastado do emprego **Hobbies:** Literatura |**Aplicativos:** Instagram, Skoob, Apps bancários, Netflix, WhatsApp, Telegram  
**Motivações:** Gostaria de voltar a frequentar clubes de literatura. Gosta de conversar sobre livros |**Frustrações:** Devido a um acidente, desenvolveu dificuldade de mobilidade. Não sai de casa tanto quanto gostaria.


> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

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

<img src="https://user-images.githubusercontent.com/81396458/157535604-fc15e98f-4fe1-4a95-82e3-65eb1f6ee16a.png"/>
