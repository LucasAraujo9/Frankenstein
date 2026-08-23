-- Caso não exista, cria uma tabela chamada "Reserva", com ID, Nome, Email

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Reserva')
BEGIN
	CREATE TABLE Reserva (
		ID INT PRIMARY KEY IDENTITY(1,1),
		UsuarioID INT NOT NULL,
		RecursoId INT NOT NULL,
		DataReserva DATETIME NOT NULL,
		
		FOREIGN KEY (UsuarioID) REFERENCES Usuario(ID),
		FOREIGN KEY (RecursoId) REFERENCES Recurso(ID)
	);
END			