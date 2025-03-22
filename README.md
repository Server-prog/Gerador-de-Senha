# 🔐 Gerador de Senhas - C#

Este é um simples gerador de senhas aleatórias feito em **C#**. Ele permite criar senhas seguras com letras maiúsculas, minúsculas, números e caracteres especiais.

## Funcionalidades
- Gera senhas seguras de qualquer tamanho
- Usa letras maiúsculas, minúsculas, números e símbolos
- Interface simples no console

## Como usar

### Instalar o .NET SDK (se ainda não tiver)
Baixe e instale o **.NET SDK** no [site oficial](https://dotnet.microsoft.com/en-us/download).

### Clonar o repositório
```sh
git clone https://github.com/SeuUsuario/GeradorSenha.git
cd GeradorSenha
```

### Rodar o projeto
```sh
dotnet run
```

### Gerar uma senha
Digite o tamanho da senha desejada e pressione **Enter**.

## 📝 Código Principal (Program.cs)
```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o tamanho da senha que desejas gerar: ");
        if (int.TryParse(Console.ReadLine(), out int tamanho) && tamanho > 0)
        {
            string senha = GerarSenha(tamanho);
            Console.WriteLine($"Sua senha gerada: {senha}");
        }
        else
        {
            Console.WriteLine("Tamanho inválido. Por favor, digite um número inteiro positivo.");
        }
    }

    static string GerarSenha(int tamanho)
    {
        const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
        Random random = new Random();
        char[] senha = new char[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            senha[i] = caracteres[random.Next(caracteres.Length)];
        }

        return new string(senha);
    }
}
```

## 🔗 Tecnologias usadas
- **C#**
- **.NET SDK**

## Contribuição
Sinta-se à vontade para contribuir! Basta fazer um **fork** do projeto e abrir um **pull request**. 😃

