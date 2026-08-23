namespace Frankenstein.Application.Models;

public class Reserva
{
    public Guid Id { get; set; }
    public Guid UsuarioId { get; set; }
    public Guid RecursoId { get; set; }
    public DateTime DataReserva { get; set; }    

    // Propriedades de navegação
    public Usuario Usuario { get; set; }
    public Recurso Recurso { get; set; }
}
