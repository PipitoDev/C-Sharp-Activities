using System;
class Atividade_09
{
    static void Main(String[] args)
    {
        string userWord;
        Console.Write("Digite uma palavra qualquer: ");
        do
        {
            userWord = Console.ReadLine().Trim();
            if (userWord.Equals(""))
            {
                Console.Write("Você não digitou nenhuma palavra.\n" + "Tente novamente: ");
            } else if (userWord.Contains(" "))
            {
                Console.Write("Você digitou mais que uma palavra.\n" + "Tente novamente: ");
            } else
            {
                break;
            }
        } while (true);
        Console.WriteLine($"Parabéns! Você escreveu a palavra ''{userWord}''.");
    }
}