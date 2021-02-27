create database SistemaAfiliacion
go
use SistemaAfiliacion
go

create table Afiliado(
	Id int identity(1,1),
	Nombre varchar(30),
	Apellido varchar(30),
	Sexo char(1),
	constraint Pk_idAfiliado primary key(Id)
);
go
create table Categoria(
	Id int identity(1,1),
	Nombre varchar(50),
	constraint Pk_Categoria primary key(Id)
);	
go
create table Productos(
	Id int identity(1,1),
	IdCategoria int,
	Nombre varchar(30),
	Descripcion varchar(50),
	constraint Pk_Producto primary key(Id),

);
go											
																		
create table Link(
	IdLink int identity(1,1),
	IdAfiliado int,
	IdProducto int,
	estado varchar(10),
	texto varchar(50),
	constraint Pk_Link primary key(IdLink),
	constraint Fk_Afiliado foreign key(IdAfiliado) references Afiliado(Id),
	constraint Fk_Producto foreign key(IdProducto) references Productos(Id)
);																													