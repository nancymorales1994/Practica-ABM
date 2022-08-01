create database ABMClientes
GO
use ABMClientes
GO
create table clientes(
id int identity primary key,
DNI  varchar(8),
CUIL varchar(11),
nombre varchar(50),
apellido varchar(50),
fechaNacimento datetime,
direccion  varchar(200),
telefono  varchar(70)
)