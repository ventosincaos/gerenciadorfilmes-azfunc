# Gerenciador de Filmes - Azure Functions
![HTML5](https://img.shields.io/badge/html5-%23E34F26.svg?style=for-the-badge&logo=html5&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Azure](https://img.shields.io/badge/azure-%230072C6.svg?style=for-the-badge&logo=microsoftazure&logoColor=white)

## Descrição
Este projeto implementa um gerenciador de filmes utilizando Azure Functions. As funções permitem obter a lista completa de filmes, detalhes de um filme específico e adicionar novos filmes ao armazenamento ou banco de dados.

## Funcionalidades
- **fnGetAllMovies**: Recupera a lista de todos os filmes disponíveis.
- **fnGetMovieDetail**: Fornece detalhes específicos de um filme com base em seu identificador.
- **fnPostDataStorage**: Adiciona um novo filme ao armazenamento de dados.
- **fnPostDatabase**: Insere um novo filme no banco de dados.

## Estrutura do Projeto
- **DIOFLIX.sln**: Solução principal do projeto.
- **api.html**: Documentação ou interface da API.

## Tecnologias Utilizadas
- **Azure Functions**: Para implementação das funções serverless.
- **C#**: Linguagem principal do projeto.
- **HTML**: Utilizado na documentação ou interface da API.

## Como Executar
1. **Pré-requisitos**:
   - Ter o [Azure Functions Core Tools](https://docs.microsoft.com/azure/azure-functions/functions-run-local) instalado.
   - Instalar o [.NET Core SDK](https://dotnet.microsoft.com/download).
