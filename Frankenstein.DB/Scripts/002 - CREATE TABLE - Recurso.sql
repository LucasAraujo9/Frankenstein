-- Caso não exista, cria uma tabela chamada "Recurso", com ID, Nome, Email

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Recurso')
BEGIN
	CREATE TABLE Recurso (
		ID INT PRIMARY KEY IDENTITY(1,1),
		Nome NVARCHAR(100) NOT NULL,
		Tipo NVARCHAR(100) NOT NULL
	);
END			