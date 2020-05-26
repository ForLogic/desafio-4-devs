# Escopo
Em uma conversa com a área da empresa responsável pela pesquisa, foi identificado que a aplicação precisará de ao menos dois cadastros, um cadastro de clientes e outro onde serão registradas as avaliações mensais.

## Cadastro dos clientes
O cadastro dos clientes terão as seguintes informações: 
- Nome do cliente (razão social ou nome fantasia)
- Nome da pessoa de contato (responsável)
- CNPJ
- Data em que se tornou cliente

Regras/validações:
- Apenas os campos `Nome do cliente` e `Nome do contato` são obrigatórios
- Não deve ser possível cadastrar o mesmo CNPJ mais de uma vez
- Deve ser possível buscar clientes pelo nome
- Cada cliente deverá ter um sinalizador indicando a sua categoria de acordo com a sua última avaliação:
  - Promotor: Nota 9 ou 10
  - Neutro: Nota 7 ou 8
  - Detrator: Nota de 0 a 6
  - Nenhum: Para casos onde o cliente ainda não tenha participado de uma avaliação

## Registro de avaliações
Ao cadastrar uma avaliação, são necessárias as informações:
- Mês/ano de referência *(obrigatório)*
- Clientes que participaram da avaliação *(seleção múltipla; obrigatório)*
- Nota/avaliação de cada cliente *(valor numérico; obrigatório)*
- Motivo da nota/avaliação *(texto descritivo; obrigatório)*

Regras/validações:
-	Só é possível realizar uma avaliação por mês
- Na seleção de clientes deve ser possível ver a data da última avaliação de cada um, pois o usuário priorizará clientes que tenham participado há mais tempo
- O usuário poderá selecionar a quantidade de clientes que desejar, mas a aplicação mostrará o percentual que os clientes selecionados representam do total

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

`NPS = ((qtd de promotores - qtd de detratores) / qtd total de participantes) * 100`

**Exemplo:**
Participantes | Qtd
------------- | ---
Promotores | 19
Neutros | 4
Detratores | 2
Total | 25

`NPS` = 68

### Divulgação do resultados
Na aplicação deve ser possível visualizar o resultado de cada mês em que foi realizada uma avaliação.

A meta é 80%, assim os resultados deverão ser exibidos da seguinte maneira:
- Em caso de meta atingida: Cor verde
- Em caso de meta dentro da tolerância (Entre 60% e 79,99%): Cor amarela
- Em caso de meta não atingida: Cor vermelha
