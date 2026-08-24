using Frankenstein.Application.Entities;

namespace Frankenstein.Application.Repositories;

public class ReservaRepository : IReservaRepository
{
    private readonly AppDbContext _context;

    public ReservaRepository(AppDbContext context)
    {
        _context = context;
    }

    public void AddReserva(Reserva reserva)
    {
        _context.Reservas.Add(reserva);
        _context.SaveChanges();
    }

    public void AddReservas(IEnumerable<Reserva> reservas)
    {
        _context.Reservas.AddRange(reservas);
        _context.SaveChanges();
    }
}
