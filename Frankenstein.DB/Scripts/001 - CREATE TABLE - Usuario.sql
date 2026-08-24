-- Caso não exista, cria uma tabela chamada "Usuario", com ID, Nome, Email

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Usuarios')
BEGIN
	CREATE TABLE Usuarios (
		ID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
		Nome NVARCHAR(100) NOT NULL,
		Email NVARCHAR(100) NOT NULL UNIQUE
	);
END			