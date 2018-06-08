# Metodos Disponíveis
Abaixo você vai encontrar uma descrição e exemplo de uso de cada metodo disponibilizado na API.

O código fonte da API se encontra na pasta **Source**, caso você queira fazer alguma correção ou melhoria fique a vontade.

## Headers Obrigatórios
Nome | Tipo | Descrição
---- | ---- | ---------
Authorization | string | Código do projeto no Firebase. *(esse código é obtido ao [fazer a configuração](https://github.com/ForLogic/desafio-4-devs/blob/master/API/Firebase%20Setup.md) do banco de dados no Firebase)*.

**Exemplo**
```
Key: "Authorization", Value:"nome-do-seu-projeto-10cd8"
```

> **Nota:** Para que você consiga utilizar qualquer um dos metodos presentes na API é obrigatório a presença do Header *Authorization* em cada requisição.

---

# Cadastro de Clientes
## GET `/api/customers/[id]`
Esse metodo retorna os dados dos clientes cadastrados.

O parâmetro `id` é opcional, caso ele seja enviado, a requisição vai retornar somente os dados do cliente com o respectivo `id`, do contrário, vai retornar os dados de todos os clientes cadastrados.

### Listando os dados de todos os clientes:
```
http://desafio4devs.forlogic.net/api/customers
```

**Retorno da API:**
```
{
  "-id123": {
    "name": "Cliente A",
    ...
  },
  "-id456": {
    "name": "Cliente B",
    ...
  },
  "-id789": {
    "name": "Cliente C",
    ...
  },
  "-id101": {
    "name": "Cliente D",
    ...
  }
} 
```

### Listando os dados de um cliente:
```
http://desafio4devs.forlogic.net/api/customers/-id123
```

**Retorno da API:**
```
{
  "name": "Cliente A",
  ...
}
```

> **Nota:** As propriedades retornadas serão as mesmas que você utilizou no cadastro do cliente.

## POST `/api/customers`
Esse método adiciona um cliente.

Essa requisição não possui nenhum parâmetro, os dados do cliente devem ser enviados no corpo da requisição.

### Cadastrando um novo cliente:
```
http://desafio4devs.forlogic.net/api/customers
```

**Body:**
```
{
  "name": "Cliente E",
  ...
}
```

**Retorno da API:**

A API irá retornar o `id` do cliente salvo.
```
{
  "id": "-id131"
}
```

## PUT `/api/customers/<id>`
Esse método altera os dados de um cliente.

O parâmetro `id` é obrigatório, e os dados do cliente devem ser enviados pelo corpo da requisição.

### Alterando os dados de um cliente:
```
http://desafio4devs.forlogic.net/api/customers/-id789
```

**Body:**
```
{
  "name": "Cliente C",
  ...
}
```

**Retorno da API:**

Se a alteração foi realizada com sucesso, a API retorna o status code `200 OK`.

## DELETE `/api/customers/<id>`
Esse método remove um cliente.

O parâmetro `id` é obrigatório e não é necessário enviar nenhum dado no corpo da requisição.

### Removendo um cliente:
```
http://desafio4devs.forlogic.net/api/customers/-id789
```

**Retorno da API:**

Se a alteração foi realizada com sucesso, a API retorna o status code `200 OK`.

---

# Cadastro de Avaliações
## GET `/api/evaluations/[id]`
Esse metodo retorna os dados das avaliações cadastradas.

O parâmetro `id` é opcional, caso ele seja enviado, a requisição vai retornar somente os dados da avaliação com o respectivo `id`, do contrário, vai retornar os dados de todas as avaliações cadastradas.

### Listando os dados de todas as avaliações:
```
http://desafio4devs.forlogic.net/api/evaluations
```

**Retorno da API:**
```
{
  "-idEv123": {
    "ref": "01/2018",
    ...
  },
  "-idEv456": {
    "ref": "02/2018",
    ...
  },
  "-idEv789": {
    "ref": "03/2018",
    ...
  },
  "-idEv101": {
    "ref": "04/2018",
    ...
  },
} 
```

### Listando os dados de uma avaliação:
```
http://desafio4devs.forlogic.net/api/evaluations/-idEv101
```

**Retorno da API:**
```
{
  "ref": "04/2018",
  ...
}
```

> **Nota:** As propriedades retornadas serão as mesmas que você utilizou no cadastro da avaliação.

## POST `/api/evaluations`
Esse método adiciona uma avaliação.

Essa requisição não possui nenhum parâmetro, os dados do cliente devem ser enviados no corpo da requisição.

### Cadastrando um novo cliente:
```
http://desafio4devs.forlogic.net/api/evaluations
```

**Body:**
```
{
  "ref": "05/2018",
  ...
}
```

**Retorno da API:**

A API irá retornar o `id` da avaliação cadastrada.
```
{
  "id": "-idEv131"
}
```

## PUT `/api/evaluations/<id>`
Esse método altera os dados de uma avaliação.

O parâmetro `id` é obrigatório, e os dados da avaliação devem ser enviados pelo corpo da requisição.

### Alterando os dados de uma avaliação:
```
http://desafio4devs.forlogic.net/api/evaluations/-idEv123
```

**Body:**
```
{
  "ref": "05/2018",
  ...
}
```

**Retorno da API:**

Se a alteração foi realizada com sucesso, a API retorna o status code `200 OK`.

## DELETE `/api/evaluations/<id>`
Esse método remove uma avaliação.

O parâmetro `id` é obrigatório e não é necessário enviar nenhum dado no corpo da requisição.

### Removendo uma avaliação:
```
http://desafio4devs.forlogic.net/api/evaluations/-idEv456
```

**Retorno da API:**

Se a alteração foi realizada com sucesso, a API retorna o status code `200 OK`.

## Dúvidas?
Caso você tenha ficado com alguma dúvida [abra uma issue](https://github.com/ForLogic/desafio-4-devs/issues) e nós vamos te ajudar.
