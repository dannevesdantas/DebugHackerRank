# ﻿Debug HackerRank

## Instruções para fazer Debug de um exercício do HackerRank no Visual Studio

1. Baixar o `Input (stdin)` nos resultados dos testes no HackerRank, em formato .txt

<img width="1042" alt="image" src="https://github.com/user-attachments/assets/50472ae2-a7c7-4e41-9005-d4ebc429e9c4">

2. Copiar e colar o conteúdo do arquivo `inputXX.txt` que você fez download para dentro do arquivo `input.txt` localizado dentro do projeto, dentro da solution do Visual Studio;
3. Copiar todo o código C# no HackerRank para dentro da classe `Result.cs`, localizada dentro da solution do Visual Studio;

4. Aperte `F5` ou clique no botão verde de Play para executar o código no Visual Studio.

5. Abra o arquivo `output.txt` para visualizar o `Your Output (stdout)`

> [!IMPORTANT]
> Não esqueça de apagar o conteúdo do arquivo `output.txt` antes de executar novamente.

### Caso deseje exibir a saída no Console

Na classe `Result.cs`, dentro do método `Main`, substituir
```csharp
TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
```
por
```csharp
TextWriter textWriter = new StreamWriter(Console.OpenStandardOutput());
```

> [!TIP]
> O projeto já está configurado para fornecer o arquivo `input.txt` como argumento ao executar a aplicação em modo Debug, no arquivo launchSettings.json
> <img width="848" alt="image" src="https://github.com/user-attachments/assets/ff489e04-68dd-4ea3-97da-4c06e57f1830">
> _Fonte: https://stackoverflow.com/a/9613134/2843604_
