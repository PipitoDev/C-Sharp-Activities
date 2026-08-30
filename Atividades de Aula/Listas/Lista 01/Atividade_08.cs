using System;
class Atividade_08
{
    static void Main(String[] args)
    {
        double price, discount, truePrice;
        Console.Write("Informe o preço do produto: ");
        do
        {
            try
            {
                price = double.Parse(Console.ReadLine().Replace("R$", "").Replace(".", ","));
                if (price < 0 || price % 1 > 99)
                {
                    throw new Exception();
                }
            } catch (FormatException)
            {
                Console.Write("Formato de preço inválido.\n" + "Tente novamente: ");
                continue;
            } catch (Exception)
            {
                Console.Write("Preço inválido para o produto.\n" + "Tente novamente: ");
                continue;
            }
            Console.Write("Informe o desconto em porcentagem: ");
            try
            {
                discount = double.Parse(Console.ReadLine().Replace("%", "").Replace(".", ","));
                if (discount < 0 || discount > 100)
                {
                    throw new Exception();
                }
            } catch (FormatException)
            {
                Console.Write("Formato de desconto inválido.\n" + "Tente novamente: ");
                continue;
            } catch (Exception)
            {
                Console.Write("Valor de desconto inválido.\n" + "Tente novamente: ");
                continue;
            }
            break;
        } while (true);
        truePrice = price - ((price * discount) / 100);
        Console.WriteLine($"O produto que custa R${price:F2} recebeu {discount}% de desconto e passou a custar R${truePrice:F2}.");
    }
}