using System;

class Program {
    static void Main() {

        Console.WriteLine("Digite o tamanho da senha que desejas gerar:");
        if (int.TryParse(Console.ReadLine(), out int tamanho)&& tamanho > 0) {
            string senha = GerarSenha(tamanho);
            Console.WriteLine($"Sua senha gerada: {senha}");
        } else {
            Console.WriteLine("Tamanho inválido. Por favor, digite um número inteiro positivo.");
        }

    }

    static string GerarSenha(int tamanho )
    {
        const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&";
        Random random = new Random();
        char [] senha = new char [tamanho];

        for (int i = 0; i < senha.Length; i++)
        {
            senha[i] = caracteres[random.Next(0, caracteres.Length)];
        }

        return new string(senha);
    }
}