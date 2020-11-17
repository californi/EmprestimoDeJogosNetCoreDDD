# Criando manualmente imagem e subindo para o dockerhub

docker build -t emprestimojogo:1.0 .
docker tag emprestimojogo:1.0 californibrs/emprestimojogo:1.0
docker push californibrs/emprestimojogo:1.0
