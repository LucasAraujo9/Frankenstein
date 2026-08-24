-- Caso não exista, cria uma tabela chamada "Reserva", com ID, Nome, Email

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Reservas')
BEGIN
	CREATE TABLE Reservas (
		ID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
		UsuarioID UNIQUEIDENTIFIER NOT NULL,
		RecursoId UNIQUEIDENTIFIER NOT NULL,
		DataReserva DATETIME NOT NULL,
		
		FOREIGN KEY (UsuarioID) REFERENCES Usuarios(ID),
		FOREIGN KEY (RecursoId) REFERENCES Recursos(ID)
	);
END			