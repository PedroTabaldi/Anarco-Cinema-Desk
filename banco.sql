#create database livraria \\criar a database
#use livraria \\usaro o database
#create table Livros #\\criar a tabela
#(
#IDLivro int primary key auto_increment, #o auto_increment adiciona o ID automatico
#Nome varchar(50),
#Autor varchar(50),
#Ano int not null #obriga o usuario escrever
#)
#insert into Livros (Nome,Autor,Ano) values ("Ensaio sobre a Cegueira","José de Saramargo", 1995)
#delete from Livros where IDLivro = 3;
#select * from Livros
#use filmes;
#select * from usuarios
#insert into usuarios (Email,Senha) values ("pedro@gmail.com","root") 
#insert into conta (Nome) values ("pedro")


#create table filmes (
#filme varchar(100),
#imagem LONGBLOB
# );

#INSERT INTO filmes (filme, imagem) VALUES ('Setimo selo', LOAD_FILE('C:\Users\PEDROAUGUSTOPEDROSOT\Documents\Projeto Integrador\Anarco-Cinema-Desk\Anarco-Cinema-Desk\img\poster'));

#use quiz
#create database quiz
#create table Filmes(
#ID int primary key auto_increment,
#Nome varchar(70),
#Favoritos int,
#imagem LONGBLOB
#)


#insert into filmes (Nome,Favoritos,imagem) value ("Setimo Selo","2", LOAD_FILE('C:\Users\PEDROAUGUSTOPEDROSOT\Documents\Projeto Integrador\Anarco-Cinema-Desk\Anarco-Cinema-Desk\img\poster'));

create table curtida(
Setimo int auto_increment,
Alien int auto_increment,
Jaw int auto_increment,
Vagabond int auto_increment,
Cure int auto_increment,
Meia int auto_increment,
Futuro int auto_increment,
Blade int auto_increment,
Rio int auto_increment,
Acossado int auto_increment
);
