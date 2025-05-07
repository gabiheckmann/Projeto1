-- CRIANDO BANCO DE DADOS 
create database bdExemplo;
use bdExemplo;
-- CRIANDO TABELAS DO BANCO
create table Usuarios(
id int primary key auto_increment,
nome varchar(50) not null,
email varchar(50) not null,
senha varchar(50) not null
);
-- CONSULTANDO OS DADOS DO BANCO 
select * FROM Usuarios;