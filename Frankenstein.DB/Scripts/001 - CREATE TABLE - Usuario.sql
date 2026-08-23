-- Caso não exista, cria uma tabela chamada "Usuario", com ID, Nome, Email

IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Usuario')
BEGIN
	CREATE TABLE Usuario (
		ID INT PRIMARY KEY IDENTITY(1,1),
		Nome NVARCHAR(100) NOT NULL,
		Email NVARCHAR(100) NOT NULL UNIQUE
	);
END			