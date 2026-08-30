using System;
using System.Data;

namespace Atividade_02;

class Program
{
    public static void Main(String[] args)
    {
        double userNumber;
        string userAnswer;
        Console.Write("Digite um número com casa decimal: ");
        do
        {
            try
            {
                userAnswer = Console.ReadLine();
                userAnswer = userAnswer.Replace(".", ",");
                userNumber = double.Parse(userAnswer);
                if (userNumber % 1 == 0)
                {
                    throw new ArgumentException();
                }
            } catch (FormatException)
            {
                Console.Write("O valor inserido é inválido.\n" + "Tente novamente: ");
                continue;
            } catch (ArgumentException)
            {
                Console.Write("O valor inserido não tem casa decimal.\n" + "Tente novamente: ");
                continue;
            }
            break;
        } while (true);
        Console.WriteLine("\nVocê digitou o número: " + userNumber);
    }
}