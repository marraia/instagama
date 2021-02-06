CREATE DATABASE Instagama;
USE Instagama;
--Criação do Database


--Criação das tabelas
CREATE TABLE dbo.Genero (
   Id int IDENTITY(1,1) NOT NULL,
   Descricao varchar(50) NOT NULL,
   CONSTRAINT PK_Genero_Id PRIMARY KEY CLUSTERED (Id)
)

CREATE TABLE dbo.Usuario (
	Id int IDENTITY(1,1) NOT NULL,
	GeneroId int NOT NULL,
	Nome varchar(250) NOT NULL,
	Email varchar(100) NOT NULL,
	Senha varchar(200) NOT NULL,
	DataNascimento DateTime NOT NULL,
	Foto varchar(max) NOT NULL
	CONSTRAINT PK_Usuario_Id PRIMARY KEY CLUSTERED (Id)
)

ALTER TABLE dbo.Usuario
   ADD CONSTRAINT FK_Usuario_Genero FOREIGN KEY (GeneroId)
      REFERENCES dbo.Genero (Id)

SELECT * FROM Usuario
INSERT INTO GENERO VALUES ('Masculino')
INSERT INTO USUARIO VALUES (1, 'Fernando Mendes', 'fernando.abreu@gmail.com', '123Aa321', '1986-01-15', '')


SELECT u.Id,
	 u.Nome,
	 u.Email,
	 u.Senha,
	 g.Id as GeneroId,
	 g.Descricao
FROM 
	Usuario u
INNER JOIN 
	Genero g ON g.Id = u.GeneroId
WHERE 
	u.Email= 'fernando.abreu@gmail.com'


Select  * from Usuario


