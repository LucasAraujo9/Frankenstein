using Microsoft.Extensions.Configuration;

namespace Frankenstein.DB;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("1...Criar tabelas e registros.....>");
        Console.WriteLine("2...Inserir mais registros........>");
        Console.WriteLine("3...Resetar tudo..................>");
        Console.WriteLine("0...Sair..........................>");
        Console.WriteLine("-----------------------------------");

        Console.Write("Escolha uma opção:. ");
        byte opcao = 9;

        try
        {
            opcao = byte.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
            opcao = byte.Parse(Console.ReadLine());
        }

        while (opcao > 3 || opcao < 0)
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.Write("Escolha uma opção:. ");
            opcao = byte.Parse(Console.ReadLine());
        }

        IConfigurationRoot? configuration = new ConfigurationBuilder()
                            .SetBasePath(AppContext.BaseDirectory)
                            .AddJsonFile("appsettings.json")
                            .Build();

        CreateDatabase createDatabase = new CreateDatabase(configuration.GetConnectionString("FrankensteinDatabase"));

        switch (opcao)
        {
            case 1:
                createDatabase.CreateTables();
                createDatabase.InsertRecords(10);
                Console.WriteLine("Tabelas criadas e registros inseridos com sucesso!");
                break;
            case 2:
                Console.Write("Quantos registros deseja inserir em cada tabela? ");
                int quantidade = int.Parse(Console.ReadLine());
                createDatabase.InsertRecords(quantidade);
                break;
            case 3:
                createDatabase.ResetDatabase();
                break;
            case 0:
                Console.WriteLine("Saindo...");
                break;
        }
    }
}