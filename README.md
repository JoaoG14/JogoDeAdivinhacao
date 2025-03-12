# Jogo da Adivinhação 2025

![](https://i.imgur.com/NZ52NTH.gif)

## Introdução

Um jogo de console divertido onde você precisa adivinhar um número secreto através de dicas fornecidas pelo computador.

## Funcionalidades

- **Níveis de Dificuldade**: Escolha entre:
  - Fácil (10 tentativas)
  - Médio (5 tentativas)
  - Difícil (3 tentativas)
- **Dicas**: Receba feedback se o número é maior ou menor que sua tentativa
- **Número Aleatório**: O jogo gera um número aleatório entre 1 e 20
- **Opção de Continuar**: Ao final de cada partida, você pode escolher se deseja jogar novamente
- **Histórico de Partidas**: Visualize o histórico das suas últimas partidas jogadas.

## Como utilizar

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto.

```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:

```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real

```
dotnet run --project JogoAdivinhacao.ConsoleApp
```

6. Para executar o arquivo compilado, navegue até a pasta `./JogoAdivinhacao.ConsoleApp/bin/Release/net8.0/` e execute o arquivo:

```
JogoAdivinhacao.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
