using Frankenstein.Application;
using Frankenstein.Application.Mappings;
using Frankenstein.Application.Repositories;
using Frankenstein.Application.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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

        IConfigurationRoot configuration = new ConfigurationBuilder()
                            .SetBasePath(AppContext.BaseDirectory)
                            .AddJsonFile("appsettings.json")
                            .Build();

        string? connectionString = configuration.GetConnectionString("FrankensteinDatabase");

        ServiceCollection services = new ServiceCollection();

        services.AddLogging();

        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        services.AddScoped<IUsuarioService, UsuarioService>();
        services.AddAutoMapper(cfg => cfg.AddProfile<FrankwnstreinProfile>());

        ServiceProvider provider = services.BuildServiceProvider();
        IServiceScope scope = provider.CreateScope();

        CreateDatabase createDatabase = new CreateDatabase(
            connectionString,
            scope.ServiceProvider.GetRequiredService<IUsuarioService>());

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