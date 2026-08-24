using Frankenstein.Application.Services;
using Microsoft.Data.SqlClient;

namespace Frankenstein.DB;

public class CreateDatabase
{
    private string _connectionString;
    private readonly IUsuarioService _usuarioService;

    public CreateDatabase(string connectionString, IUsuarioService usuarioService)
    {
        this._connectionString = connectionString;
        this._usuarioService = usuarioService;
    }

    public void CreateTables()
    {
        SqlConnection connection = new SqlConnection(_connectionString);
        connection.Open();

        Console.WriteLine("Criando tabela de Usuario");
        CreateTableUsuario(connection);

        Console.WriteLine("Criando tabela de Recurso");
        CreateTableRecurso(connection);

        Console.WriteLine("Criando tabela de Reserva");
        CreateTableReserva(connection);
    }

    public void InsertRecords(int quantidade)
    {        
        Console.WriteLine($"Inserindo {quantidade} registros na tabela de Usuario");
        _usuarioService.AddManyUsuarios(quantidade);

        Console.WriteLine($"Inserindo {quantidade} registros na tabela de Recurso");
        // Tabela de Recurso
        Console.WriteLine($"Inserindo {quantidade} registros na tabela de Reserva");
        // Tabela de Reserva
    }

    public void ResetDatabase()
    {
        Console.WriteLine("Resetando o banco de dados...");
        // Code to reset the database
        Console.WriteLine("Banco de dados resetado com sucesso!");
    }

    #region Create Table
    private void CreateTableUsuario(SqlConnection connection)
    {
        string sqlUsuario = File.ReadAllText("Scripts/001 - CREATE TABLE - Usuario.sql");
        using var commandUsuario = new SqlCommand(sqlUsuario, connection);
        commandUsuario.ExecuteNonQuery();
    }

    private void CreateTableRecurso(SqlConnection connection)
    {
        string sqlRecurso = File.ReadAllText("Scripts/002 - CREATE TABLE - Recurso.sql");
        using var commandRecurso = new SqlCommand(sqlRecurso, connection);
        commandRecurso.ExecuteNonQuery();
    }

    private void CreateTableReserva(SqlConnection connection)
    {
        string sqlReserva = File.ReadAllText("Scripts/003 - CREATE TABLE - Reserva.sql");
        using var commandReserva = new SqlCommand(sqlReserva, connection);
        commandReserva.ExecuteNonQuery();
    }
    #endregion

    #region Insert in Table

    public void InsertUsuario(int quantidade)
    {

    }

    public void InsertRecurso(int quantidade)
    {

    }

    public void InsertReserva(int quantidade)
    {

    }

    #endregion
}
