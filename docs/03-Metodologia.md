
# Metodologia

A metodologia contempla as definições de ferramentas utilizadas pela equipe tanto para a manutenção dos códigos e demais artefatos quanto para a organização do time na execução das tarefas do projeto.

Para controle do projeto, das pessoas e das tarefas, utilizaremos poucos ambientes de trabalho, afim de reduzir/anular as possibilidades de redundância ou ausência de informações em determinados ambientes, focando sempre nos nossos requisitos funcionais.

Nossa ferramenta principal para gerir os tópicos citados acima, será o GitHub, que utilizaremos na sua forma típica de repositório, armazenando toda manutenção dos códigos. Paralelo a esta modalidade de repositório, faremos uso do GitHub para os gerenciamentos de backlog do produto, bem como, das sprints individualizadas, este gerenciamento será feito através da aba “Project”.

Para arquivos visuais e sonoros, bem como, formulários de pesquisas, análises de requisitos, casos de uso, utilizaremos o G.......... para a equipe envolvida no desenvolvimento da aplicação, seja através da forma técnica ou gerencial.

O Projeto de interface e wireframes foi desenvolvido através dos sites Canva e Flowmapp, criado de forma que qualquer eventual alteração ou incrementação seja feita de forma pratica e elegante.

## Controle de Versão

A gestão de código fonte ou controle de versões diz respeito ao monitoramento e gerenciamento das alterações no código, de preferência com histórico de execuções de desenvolvimento e, também, auxilia na resolução de conflitos e reverte versões anteriores de um projeto, quando necessário. Esse componente é essencial para o processo de desenvolvimento do software. 

Com isso, para gestão do código fonte utilizaremos o Git Flow, um modelo de organização de branches, o qual dita que tipos de ramificações configurar e como fazer merge. Desta forma, todas as manutenções no código são realizadas em branches separados, identificados como Main, Hotfix, Release, Develop e Feature, ou seja, um modelo de ramificação de manutenção que permite corrigir com rapidez lançamentos de produção mantendo uma linha de desenvolvimento dedicada para atualização de segurança, permitindo que a equipe trabalhe com problemas sem interromper o fluxo do trabalho ou esperar o próximo ciclo de lançamento. Segue figura 1: 

<div align="center">
 <img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-grupo_3_tinder_literario/blob/ccd161aa97c05e0679292ed27ad24e1ab9eab121/docs/img/134491247-67b5f225-afb2-4de2-a698-ff9bf310af3d.png" width="700px" />
 
 **Figura 1 - Fluxo de controle do código fonte no repositório github**  
</div> 

**Main**: branch principal, somente versão de produção; 

**Hotfix**:  branch de correção: responsável pela realização de alguma correção crítica encontrada em produção; 

**Release**: branch de lançamento: utilizada como ambiente de homologação e é removida após realizar os testes e do merge com a Main. Caso haja alguma alteração, ela também deve ser sincronizada com a Develop; 

**Develop**: branch criada a partir da branch main, contém código em nível preparatório para o próximo deploy/versão. Ou seja, quando features são terminadas, elas são juntadas com a branch develop, testadas e somente depois as atualizações da branch develop passam por mais um processo para então ser juntadas com a branch main; 

**Feature**: branch de melhorias: utiliza-se para o desenvolvimento de uma funcionalidade específica/nova, inicia-se com a palavra feature e são criadas sempre a partir da branch develop. Exemplo: feature/cadastro. 

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `stating`: versão em testes do software
- `feature`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: indica novas solicitações de recurso ou uma funcionalidade precisa ser melhorada 
- `question`: indica que um problema, pull request ou discussão precisa de mais informações 

## Gerenciamento de Projeto

A metodologia escolhida pela equipe para o gerenciamento de projeto foi o Scrum, um método ágil que proporciona eficiência e qualidade na construção do projeto ao estabelecer ciclos de entregas, ou Sprints, que asseguram a rapidez do desenvolvimento e facilita a adaptação a mudanças.

### Divisão de Papéis

A equipe está organizada da seguinte maneira:

**Scrum Master:** Pedro Daniel Jardim

**Product Owner:** Kelly Cesário de Oliveira

**Equipe de Desenvolvimento:**
 -	Cristiano Garcia Ridolfi
 - Kelly Cesário de Oliveira
- Luis Galdino de Almeida da Silva
 -	Michelle Leal Rodrigues
 -	Pedro Daniel Jardim
 - Renata Diniz Guimarães de Oliveira

**Design:**	Michelle Leal Rodrigues

### Processo

Para organização e distribuição das tarefas do projeto, a equipe utilizará o Projects (ferramenta do github), onde foi elaborado um Quadro Kanban que estrutura o desenvolvimento nas seguintes colunas:

**To Do:** Nessa coluna, estão alocadas as tarefas estabelecidas para a Sprint atual e que ainda não foram iniciadas, assim como os membros da equipe responsáveis por cada item. <br>

**In progress:** Tarefas que já foram iniciadas mas ainda não finalizadas, são acompanhadas rotineiramente seguindo os ritos da metodologia ágil.<br>

**In progress:** Tarefas que já foram iniciadas mas ainda não finalizadas, são acompanhadas rotineiramente seguindo os ritos da metodologia ágil.<br>

**Test:** Tarefas após iniciada e finalizada, é passada por validações de negócio e de lógica, assim preservando um controle de qualidade e evitando que aconteça bugs inesperados.<br>

**Test Return:** Coluna para sinalizar tarefas que de alguma maneira não passaram no teste de qualidade e sendo necessário um retrabalho para passar no teste de qualidade.<br>

**Waiting Deploy:** Quando uma tarefa tiver sido iniciada e finalizada, é movida para a coluna de waiting deploy, para que o responsável revise o código feito e aprove para as branch de teste.<br>

**Done:** Tarefas concluídas e aprovadas no teste de qualidade.

O quadro kanban do projeto no Github está disponível na [URL](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-grupo_3_tinder_literario/projects/2) e é apresentado, no estado atual, na Figura 2.

<div align="center">
 <img src="img/kanban.PNG" width="700px" />
 
 **Figura 2 - Quadro Kanban no dia 19/03/2022**  
</div>

A tarefas também são etiquetadas em função da natureza da atividade, seguindo o seguinte esquema de categorias:
-	Documentation (Documentação)
-	Bug
-	Enhacement (Nova Feature/Pedido)
 
 
### Ferramentas

As ferramentas empregadas no projeto são:

- Editor de código.
- Ferramentas de comunicação
- Ferramentas de desenho de tela (_wireframing_)

O editor de código foi escolhido porque ele possui uma integração com o
sistema de versão. As ferramentas de comunicação utilizadas possuem
integração semelhante e por isso foram selecionadas. Por fim, para criar
diagramas utilizamos essa ferramenta por melhor captar as
necessidades da nossa solução.

Liste quais ferramentas foram empregadas no desenvolvimento do projeto, justificando a escolha delas, sempre que possível.
 
> **Possíveis Ferramentas que auxiliarão no gerenciamento**: 
> - [Slack](https://slack.com/)
> - [Github](https://github.com/)
