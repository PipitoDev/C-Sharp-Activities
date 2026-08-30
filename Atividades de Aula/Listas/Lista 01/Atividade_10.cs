using System;

class Atividade_10
{
    static void Main(String[] args)
    {
        string streetName = readUserAnswer("Digite o nome da rua: ", s => !s.Equals(""));
        string streetNumber = readUserAnswer("Digite o número da rua: ", s => !s.Equals(""));
        string districtName = readUserAnswer("Digite o nome do bairro: ", s => !s.Equals(""));
        string complement = readUserAnswer("Digite, se houver, um complemento: ", s => true);
        string cityName = readUserAnswer("Digite o nome da cidade: ", s => !s.Equals(""));
        string stateName = readUserAnswer("Digite o nome do estado: ", s => !s.Equals(""));

        if (complement.Equals(""))
        {
            complement = "Sem complemento.";
        }
        Console.WriteLine($""""
            Seu endereço é ->
            Rua: {streetName}
            Número: {streetNumber}
            Bairro: {districtName}
            Complemento: {complement}
            Cidade: {cityName}
            Estado: {stateName}
            """");

    }

    static string readUserAnswer(string message, Func<string, bool> verifier)
    {
        string userAnswer;
        Console.Write(message);
        do
        {
            userAnswer = Console.ReadLine().Trim();
            if (!verifier(userAnswer))
            {
                Console.Write("O campo não pode estar vazio.\n" + "Tente novamente:");
            }
        } while (!verifier(userAnswer));
        return userAnswer;
    }
}