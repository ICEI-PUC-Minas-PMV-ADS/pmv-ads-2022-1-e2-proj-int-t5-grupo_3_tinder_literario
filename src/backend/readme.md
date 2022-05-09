
## Requisitos
Docker e Heroku CLI


## Como fazer o deploy

- entre no diretorio: pmv-ads-2022-1-e2-proj-int-t5-grupo_3_tinder_literario\src\backend\MatchBookAPI\MatchBookAPI

- Comando de buid do backend
docker build -t matchbookapi .

- Roda o build configurado
docker run -d -p 8080:80 --name matchbookapi matchbookapi

- Conecta ao Heroku 
heroku container: login

- Empurra para do compose para o heroku
heroku container:push web -a matchbookapi

- Libera o release do heroku
heroku container:release web -a matchbookapi

- O app estara disponível na URL:
https://matchbookapi.herokuapp.com