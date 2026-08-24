using Frankenstein.Application.Entities;

namespace Frankenstein.Application.Repositories;

public interface IReservaRepository
{
    void AddReserva(Reserva reserva);
    void AddReservas(IEnumerable<Reserva> reservas);
}
