using System;

class Program
{
    public static void Main(String[] args)
    {
        decimal userNumber;
        string userAnswer;
        Console.Write("Digite um número com casa decimal: ");
        do
        {
            try
            {
                userAnswer = Console.ReadLine();
                userNumber = decimal.Parse(userAnswer);
                if (userNumber % 1 == 0)
                {
                    throw new Exception();
                }
            } catch (FormatException)
            {
                Console.Write("Você digitou um valor inválido.\n" + "Tente novamente: ");
                continue;
            } catch (Exception)
            {
                Console.Write("O número que você digitou não tem casa decimal.\n" + "Tente novamente: ");
                continue;
            }
            break;
        } while (true);
        Console.WriteLine("Você digitou o número: " + userNumber);
    }
}