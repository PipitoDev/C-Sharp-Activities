using System;
class Program
{
    public static void Main(String[] args)
    {
        string userAnswer;
        bool convertedAnswer;
        Console.Write("Digite ''sim'' ou ''não'': ");
        do
        {
            userAnswer = Console.ReadLine();
            userAnswer = userAnswer.ToUpper();
            if (userAnswer != "SIM" && userAnswer != "NÃO")
            {
                Console.Write("Resposta inválida.\n" + "Tente novamente: ");
            } else
            {
                if (userAnswer == "SIM")
                {
                    convertedAnswer = true;
                } else
                {
                    convertedAnswer = false;
                }
                break;
            }
        } while (true);
        Console.WriteLine("Você digitou: " + userAnswer.ToLower() + "\n" + "A variável bool é: " + convertedAnswer);
    }
}