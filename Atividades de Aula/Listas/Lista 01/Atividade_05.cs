using System;

class Program
{
    public static void Main(String[] args)
    {
        char userChar;
        string userAnswer;
        Console.Write("Digite apenas 1 caractere qualquer: ");
        do
        {
            userAnswer = Console.ReadLine().Trim();
            if (userAnswer.Length != 1)
            {
                Console.Write("Você não inseriu apenas 1 caractere!\n" + "Tente novamente: ");
            } else
            {
                userChar = char.Parse(userAnswer);
                break;
            }
        } while (true);
        if (userChar != 'P' && userChar != 'p')
        {
            Console.WriteLine("Você digitou o caractere: " + userChar);
        } else
        {
            Console.WriteLine("Pipito Amarelo.");
        }
    }
}