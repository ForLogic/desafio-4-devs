# Configuração do Firebase
A API se comunica com um banco configurado no Firebase via REST. Nos passos a baixo você vai saber como criar e configurar o banco para utilizar a API.

## Criando um banco de dados
O primeiro passo é acessar [esse endereço aqui](https://console.firebase.google.com/) e fazer login com a sua conta do Google.

Ao acessar o console do Firebase você já conseguirá criar um novo projeto, pra isso clique em **Adicionar Projeto**, como mostra a imagem abaixo:

![Firebase Welcome](https://i.imgur.com/kn3wun9.png)

Clicando em **Adicionar Pojeto** você pode informar os dados como mostra a imagem a seguir:

![Project Data](https://i.imgur.com/8DqP013.png)

1. O nome do projeto fica à sua escolha;
1. Copie o campo **Código do projeto**. Esse campo será necessário para comunicação da API;

Após criar o projeto você precisará criar um banco de dados realtime. Para isso siga os passos abaixo:

1. No menu lateral, clique em **Develop**;
1. No submenu lateral, clique em **Database**;
1. Então clique em **Primeiros Passos**, na seção do **Realtime Database**

![Create Realtime Database](https://i.imgur.com/gLnFsnV.png)

Na tela seguinte é muito importante que você informe **Iniciar no modo de teste**.

![Create Realtime Database](https://i.imgur.com/sjueKFg.png)

> **Nota:** Não é recomendado utilizar essa opção em aplicações reais, mas a API do desafio não realiza nenhum tipo de autenticação, portanto é necessário utilizar esse formato.

Pronto, agora você já vai [conseguir utilizar a API](https://github.com/ForLogic/desafio-4-devs/tree/master/API) com o código do seu projeto.

## Dúvidas?
Caso você tenha ficado com alguma dúvida [abra uma issue](https://github.com/ForLogic/desafio-4-devs/issues) e nós vamos te ajudar.
