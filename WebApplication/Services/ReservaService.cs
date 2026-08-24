using Frankenstein.Application.Entities;
using Frankenstein.Application.Repositories;

namespace Frankenstein.Application.Services;

public class ReservaService : IReservaService
{
    private readonly IReservaRepository _reservaRepository;

    public ReservaService(IReservaRepository reservaRepository)
    {
        _reservaRepository = reservaRepository;
    }

    public void AddUsuario(Reserva reserva)
    {
        _reservaRepository.AddReserva(reserva);
    }

    public void AddUsuarios(IEnumerable<Reserva> reservas)
    {
        _reservaRepository.AddReservas(reservas);
    }
}
