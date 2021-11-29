USE MASTER
GO
CREATE DATABASE [TP4RECUPERATORIO]
GO
USE [TP4RECUPERATORIO]
CREATE TABLE [dbo].[ListaProgramadores](
	[idLegajo] [int] IDENTITY(1,1)PRIMARY KEY CLUSTERED  NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[genero] [int] NOT NULL,
	[edad] [int] NOT NULL,
	[puesto] [int] NOT NULL,)

INSERT INTO ListaProgramadores (nombre,apellido,genero,edad,puesto) VALUES ('John','Romero',2,54,0);
INSERT INTO ListaProgramadores (nombre,apellido,genero,edad,puesto) VALUES('Hironobu','Sakaguchi',2,59,0)
INSERT INTO ListaProgramadores (nombre,apellido,genero,edad,puesto) VALUES('Ed','Boon',2,57,0)
INSERT INTO ListaProgramadores (nombre,apellido,genero,edad,puesto) VALUES('Dafne','Spector',0,27,1)
INSERT INTO ListaProgramadores (nombre,apellido,genero,edad,puesto) VALUES('Alexia','Wright',0,23,1)
INSERT INTO ListaProgramadores (nombre,apellido,genero,edad,puesto) VALUES('Stephanie','Molyneux',1,21,2)
INSERT INTO ListaProgramadores (nombre,apellido,genero,edad,puesto) VALUES('Gary','Jaffe',1,41,2)

SELECT * FROM ListaProgramadores

SELECT * FROM ListaProgramadores WHERE genero = 2
SELECT * FROM ListaProgramadores WHERE genero = 1
SELECT * FROM ListaProgramadores WHERE genero = 0

SELECT * FROM ListaProgramadores WHERE puesto = 2
SELECT * FROM ListaProgramadores WHERE puesto = 1
SELECT * FROM ListaProgramadores WHERE puesto = 0
