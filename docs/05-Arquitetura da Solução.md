# Arquitetura da Solução

A arquitetura de soluções constrói soluções com base nas necessidades da empresa, é responsável por desenhar e implementar recursos e ferramentas de TI para atender as necessidades do usuário, ou seja, definir de forma estruturada quais são so componentes, propriedades e documentações necessárias para que um sistema seja desenvolvido, além de seu relacionamento com outros sistemas.

A arquitetura para a solução em questão será basicamente a hospedagem da aplicação, e integração da mesma com APIs públicas, a fim de agilizar o processo de login e contatos.

Toda codificação é armazenada no Github, o versionamento é controlado via Git Flow, para que todo o processo seja acompanhado e revertido, se preciso for.

A aplicação do projeto matriz tem integração com banco de dados.

## Diagrama de Classes

O diagrama de classes abaixo representará as classes, suas estruturas e relações que servem de modelo para objetos.

O projeto comtempla o CRUD ou seja, as quatro operações básicas utilizadas em bases de dados relacionais (Create, Read, Update e Delete).


![Exemplo de Diagrama de classes](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-grupo_3_tinder_literario/blob/main/docs/img/diagrama_classe.drawio.png)

## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

![Exemplo de Modelo ER](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-grupo_3_tinder_literario/blob/main/docs/img/modelo_ur.png)

## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.
 
![Exemplo de Esquema Relacional](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-grupo_3_tinder_literario/blob/main/docs/img/diagrama_er.drawio.png)


## Tecnologias Utilizadas

As tecnologias que serão ultilizadas são HTML5, CSS3 e JavaScript para o front-end, e  C# e SQL server para back-end e banco de dados. As tecnologias foram escolhidas devido sua popularidade e sua versatilidade que permitem interações de usuário e de APIs externas.

![Diagrama de Componentes](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-1-e2-proj-int-t5-grupo_3_tinder_literario/blob/main/docs/img/Hospedagem%20-%20Heroku.png)

A solução implementada conta com os seguintes módulos:

>Navegador - Interface básica do sistema
>Páginas Web - Conjunto de arquivos HTML, CSS, JavaScript, Bootstrap e imagens que implementam as funcionalidades do sistema.
>Local Storage - local onde serão implementados os bancos de dados em SQL server, utilizando as linguagens C# e Asp.NET.
>API - plataforma que permite a conexão e sincronização da aplicação com o g-mail do usuário e Facebook.
>Hospedagem - local na Internet onde as páginas são mantidas e acessadas pelo navegador.

## Hospedagem

O site utiliza a plataforma do Github e Heroku como ambiente de hospedagem do site do projeto. O site é mantido no ambiente da URL da GitPages e Heroku, através do endereço: https://icei-puc-minas-pmv-ads.github.io/pmv-ads-2022-1-e2-proj-int-t5-grupo_3_tinder_literario/src/frontend/inicial/homepage.html


