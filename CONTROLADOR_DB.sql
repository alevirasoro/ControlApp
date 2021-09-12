use CONTROLADOR_DB
go

create table USUARIOS(
	ID int not null primary key identity(1,1),
	Nombre varchar(50) not null,
	Apellido varchar(50) not null,
	Email varchar(150) unique not null,
	Pass varchar(20) not null,
	)
go
create table CUENTAS(
	ID int not null primary key identity(1,1),
	IDUsuario int not null foreign key references USUARIOS(ID),
	Saldo money,
	)
go
create table MOVIMIENTOS(
	ID int not null primary key identity (1,1),
	IDCuenta int not null foreign key references CUENTAS (ID),
	Titulo varchar (15) not null,
	Concepto varchar (25) not null,
	Descpripcion varchar (80) null,
	Tipo bit not null,
	Fecha date not null,
	)
	go

	insert into USUARIOS(Nombre, Apellido, Email, Pass)
	values('Alejandro', 'Virasoro', 'virasoroalejandro@gmail.com', '123456')
	go
