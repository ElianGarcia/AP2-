create database ArticulosDB
drop database ArticulosDB

create table Articulos (
	Id int primary key identity,
	Fecha DateTime,
	Descripcion varchar(14),
	Costo decimal,
	Ganancia decimal,
	Precio decimal
)
