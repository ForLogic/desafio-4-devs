# Escopo
Em uma conversa com a área da empresa responsável pela pesquisa, foi identificado que a aplicação precisará de ao menos dois cadastros, um cadastro de clientes e outro onde serão registradas as avaliações mensais.

## Cadastro de clientes
Para o cadastro do cliente são necessárias 3 informações básicas: **nome do cliente (razão social ou nome fantasia)**, **nome do contato (pessoa responsável)** e a **data em que se tornou cliente**.

Nesse cadastro serão necessárias as seguintes validações:
- Todos os campos são obrigatórios;
- Cada cliente deverá ter um sinalizador indicando a sua categoria de acordo com a sua última avaliação:
  - Promotor: Nota 9 ou 10
  - Neutro: Nota 7 ou 8
  - Detrator: Nota de 0 a 6
  - Nenhum: Para casos onde o cliente ainda não tenha participado de uma avaliação

## Cadastro de avaliações
Ao cadastrar uma avaliação, são necessárias duas informações:
- Mês e ano de referência *(obrigatório)*;
- Clientes que participaram da avaliação *(seleção múltipla; obrigatório)*;

As seguintes validações devem ser feitas:
-	Só é possível realizar 1 (uma) avaliação por mês;
- Cada avaliação é composta por 20% dos clientes cadastrados;
- Após participar de uma avaliação, o mesmo cliente só poderá ser selecionado novamente depois de **duas avaliações**;
  - *Ex.: Se o cliente participou da avaliação no mês **03/2018**, o mesmo só poderá participar de uma nova avaliação no mês **06/2018***

### Como uma avaliação é realizada
A pesquisa de satisfação é composta de duas perguntas, feitas individualmente para cada cliente participante:

1. Em uma escala de 0 a 10, qual a probabilidade de você recomendar nosso produto/serviço a um amigo/conhecido?
1. Qual é o motivo dessa nota?

### Como obter o resultado geral da avaliação
De acordo com a pontuação dada na questão 1, os participantes são classificados em três categorias:

`Promotores` = participantes que deram notas 9 ou 10

`Neutros` = participantes que deram notas 7 ou 8

`Detratores` = participantes que deram notas de 0 a 6

O resultado da avaliação é obtido através da seguinte equação:

`NPS = ((total de promotores - total de detratores) / total de participantes) * 100`

### Divulgação do resultados
Na aplicação deve ser possível visualizar o resultado de cada mês em que foi realizada uma avaliação.

A meta é 80%, assim os resultados deverão ser exibidos da seguinte maneira:
- Em caso de meta atingida: Cor verde
- Em caso de meta dentro da tolerância (Entre 60% e 79,99%): Cor amarela
- Em caso de meta não atingida: Cor vermelha

## Dúvidas?
Caso você tenha ficado com alguma dúvida [abra uma issue](https://github.com/ForLogic/desafio-4-devs/issues) e nós vamos te ajudar.

**Boa sorte! xD**
