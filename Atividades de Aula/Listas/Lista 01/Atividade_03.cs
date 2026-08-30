using System;
using System.Linq.Expressions;

class Program
{
    public static void Main(String[] args)
    {
        float userNumber;
        string userAnswer;
        Console.Write("Digite um número com ponto flutuante: ");
        do
        {
            try
            {
                userAnswer = Console.ReadLine();
                userAnswer = userAnswer.Replace(".", ",");
                userNumber = float.Parse(userAnswer);
                if (userNumber % 1 == 0)
                {
                    throw new Exception();
                }
            } catch (FormatException)
            {
                Console.Write("O valor digitado é inválido.\n" + "Tente novamente: ");
                continue;
            } catch (Exception)
            {
                Console.Write("O valor digitado não contém casa decimal.\n" + "Tente novamente: ");
                continue;
            }
            break;
        } while (true);
        Console.WriteLine("Você digitou o número: " + userNumber);
    }
}