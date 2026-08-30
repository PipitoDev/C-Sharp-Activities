using System;

namespace Atividade_01;
class Program
{
    static void Main(string[] args)
    {
        string userAnswer;
        int userNumber;
        Console.Write("Digite um número inteiro: ");
        do
        {
            try
            {
                userAnswer = Console.ReadLine();
                userNumber = int.Parse(userAnswer);
            } catch (FormatException)
            {
                Console.Write("O valor inserido é inválido.\n" + "Tente novamente: ");
                continue;
            }
            break;
        } while (true);
        Console.WriteLine("Você digitou o número " + userNumber);
    }
}