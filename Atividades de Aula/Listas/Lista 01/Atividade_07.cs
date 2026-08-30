using System;
using System.Text.RegularExpressions;

class Atividade_07
{
    public static void Main(String[] args)
    {
        string userName;
        int userAge;
        Console.Write("Digite seu nome: ");
        do
        {
            userName = Console.ReadLine().Trim();
            if (userName.Equals(""))
            {
                Console.Write("Seu nome não pode estar vazio.\n" + "Tente novamente: ");
            } else if (userName.Length < 3)
            {
                Console.Write("Nome muito curto.\n" + "Tente novamente: ");
            } else
            {
                break;
            }       
        } while (true);
        Console.Write("Agora, digite sua idade: ");
        do
        {
            try
            {
                userAge = int.Parse(Console.ReadLine());
                if (userAge < 0 || userAge > 150)
                {
                    throw new Exception();
                }
            } catch (FormatException)
            {
                Console.Write("Informação errada, digite apenas números.\n" + "Tente novamente: ");
                continue;
            } catch (Exception)
            {
                Console.Write("Idade inválida.\n" + "Tente novamente: ");
                continue;
            }
            break;
        } while (true);
        Console.WriteLine($"Seu nome é {userName} e sua idade é {userAge}.");
    }
}