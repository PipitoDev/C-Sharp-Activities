using System;
namespace MyProgram;
class Program
{
    public static void Main()
    {
        int userNumber, userNumberInfo, loopQuantity = 0;
        string userAnswer;
        Console.WriteLine("Digite um número positivo:");
        do
        {
            userAnswer = Console.ReadLine();
            try
            {
                    userNumber = int.Parse(userAnswer);
            }
            catch (FormatException)
            {
                Console.WriteLine("O dado inserido é inválido! " +
                    "Tente novamente:");
                continue;
            }
            if (userNumber > 0)
            {
                userNumberInfo = userNumber;
                break;
            } else
            {
                Console.WriteLine("Número inválido. " +
                    "Tente novamente:");
            }
        } while (true);
        while (userNumber != 1)
        {
            loopQuantity += 1;
            if (userNumber % 2 == 0)
            {
                userNumber = userNumber / 2;
            } else
            {
                userNumber = (userNumber * 3) + 1;
            }
        }
        Console.WriteLine("Foi necessário " + loopQuantity + " passos para o número " + userNumber + " virar 1!");
    }
}
