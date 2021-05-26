# Cadastro de séries DIO

Projeto desenvolvido para o bootcamp .NET Fundamentals da DIO. Este é o repo com a aplicação original criada por Eliézer Zarpelão https://github.com/elizarp/dio-dotnet-poo-lab-2.

Trata-se de uma aplicação de console simulando um sistema de gerenciamento de uma lista de séries (tv shows).

O projeto teve as seguintes alterações como forma de aprendizado:

1.

A forma de acesso e manipulação dos dados foi mudada de uma simples lista alocada temporariamente em memória, para a utilização de um banco embutido em arquivo, utilizando SqLite.
Assim, é possível persistir e preservar os dados entre execuções, na versão original não havia forma de persistir os dados por um prazo maior do que a execução do programa. Foi utilizado a ORM Entity Framework para implementar o acesso e manipulação do banco dentro do ambiente .NET.

2.

Como as séries não são removidas (apenas marcadas como removidas, a.k.a Soft Delete), na listagem de séries, aquelas que foram removidas são imprimidas com uma cor de fundo vermelha diferenciada que as destaca das demais séries.

Requisitos:

.NET Core 3.1 +

Para rodar em linha de comando:

`dotnet run`

Para buildar o projeto:

`dotnet build`

Caso opte por rodar o projeto dentro do Visual Studio, utilize o caminho absoluto do projeto ao passar a string com o caminho do banco de dados, ao invés de apontar para o arquivo diretamente, (Data Source).
Essa mudança deve ser feita no arquivo [a link](https://github.com/vbazuke/cadastro-series-dio/blob/master/SerieContext.cs)
