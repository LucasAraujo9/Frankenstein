-- Caso não exista, cria uma tabela chamada "Recurso", com ID, Nome, Email

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Recursos')
BEGIN
	CREATE TABLE Recursos (
		ID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
		Nome NVARCHAR(100) NOT NULL,
		Tipo NVARCHAR(100) NOT NULL
	);
END			