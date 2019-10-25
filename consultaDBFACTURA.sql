/*Creacion Base de Datos de un Sistema de Facturación (DBFACTURAS)*/
create database DBFACTURAS
use  DBFACTURAS

/*Crear tabla ROLES*/
create table TBLROLES
(
 IdRolEmpleado int identity (1,1),
 StrDescripcion varchar(50) not null,
 StrDetalle varchar(50),
 Primary Key (IdRolEmpleado)
)

Insert into TBLROLES values('Administrador', 'na');

/*Crear tabla EMPLEADO*/
create table TBLEMPLEADO
(
 IdEmpleado int identity (1,1),
 strNombre varchar(50)not null,
 NumDocumento bigint not null,
 StrDireccion varchar(50) not null,
 StrTelefono varchar(30) not null,
 StrEmail varchar(50) not null,
 IdRolEmpleado int not null,
 DtmIngreso datetime not null,
 DtmRetiro datetime not null,
 strDatosAdicionales varchar(250) not null,
 DtmFechaModifica datetime not null,
 StrUsuarioModifico varchar(30) not null,
 Primary Key (IdEmpleado),
 Foreign key (IdRolEmpleado)references 
 TBLROLES (IdRolEmpleado) on delete cascade on update cascade
)

Insert into TBLEMPLEADO values('Lina','10172031','cll18','238297','calypsobronte@calypsobronte.me',1,getdate(),'','Web Dev',getdate(),'CalypsoBronte')

/*Crear tabla SEGURIDAD*/
create table TBLSEGURIDAD
(
 IdSeguridad int identity (1,1),
 IdEmpleado int not null,
 StrUsuario varchar(20) not null,
 StrClave varchar(20) not null,
 DtmFechaModifica datetime not null,
 StrUsuarioModifico varchar(30) not null,
 Primary Key (IdSeguridad),
 Foreign key (IdEmpleado)references 
 TBLEMPLEADO (IdEmpleado) on delete cascade on update cascade
)

Insert into TBLSEGURIDAD values(1,'calypsobronte','vanessa',getdate(),'CalypsoBronte')

/*Crear tabla CLIENTES*/
create table TBLCLIENTES
(
 IdCliente int identity (1,1),
 StrNombre varchar(50) not null,
 NumDocumento bigint not null,
 StrDireccion varchar(50) not null,
 StrTelefono varchar(30) not null,
 StrEmail varchar(50) not null,
 DtmFechaModifica datetime not null,
 StrUsuarioModifico varchar(30) not null,
 Primary Key (IdCliente)
)

/*Crear tabla ESTADOFACTURA*/
create table TBLESTADOFACTURA
(
 IdEstado int identity (1,1),
 StrEstado varchar(30) not null,
 check (StrEstado ='Pendiente' OR StrEstado ='Pagada' OR StrEstado ='Cancelada'),
 Primary key(IdEstado),
)

/*Crear tabla FACTURA*/
create table TBLFACTURA
(
 IdFactura int identity (1,1),
 DtmFecha datetime not null,
 IdCliente int not null,
 IdEmpleado int not null,
 NumDescuento decimal not null,
 NumImpuesto decimal not null,
 NumValorTotal decimal not null,
 IdEstado int not null,
 DtmFechaModifica datetime not null,
 StrUsuarioModifico varchar(30) not null,
 Primary Key (IdFactura),
 Foreign key (IdCliente)references 
 TBLCLIENTES (IdCliente) on delete cascade on update cascade,
 Foreign key (IdEmpleado)references 
 TBLEMPLEADO (IdEmpleado) on delete cascade on update cascade,
 Foreign key (IdEstado)references 
 TBLESTADOFACTURA (IdEstado) on delete cascade on update cascade
)

/*Crear tabla CATEGORIA_PROD*/
create table TBLCATEGORIA_PROD
(
 idCategoria int identity (1,1),
 StrReferencia varchar(20) not null,
 StrDescripcion varchar(50) not null,
 DtmFechaModifica datetime not null,
 StrUsuarioModifico varchar(30) not null,
 Primary Key (idCategoria)
)

/*Crear tabla PRODUCTO*/
create table TBLPRODUCTO
(
 IdProducto int identity (1,1),
 StrNombre varchar(50) not null,
 StrReferencia varchar(20) not null,
 NumPrecioCompra decimal not null,
 NumPrecioVenta decimal not null,
 idCategoria int not null,
 StrDetalle varchar(250) not null,
 strFoto varchar(30) not null,
 NumStock int not null,
 DtmFechaModifica datetime not null,
 StrUsuarioModifico varchar(30) not null,
 Primary Key (IdProducto),
 Foreign key (idCategoria)references 
 TBLCATEGORIA_PROD (idCategoria) on delete cascade on update cascade
)

/*Crear tabla DETALLE_FACTURA*/
create table TBLDETALLE_FACTURA
(
 idDetalle int identity (1,1),
 IdFactura int not null,
 NumCantidad int not null,
 IdProducto int not null,
 NumPrecio decimal not null,
 Primary Key (idDetalle),
 Foreign key (IdProducto)references 
 TBLPRODUCTO (IdProducto) on delete cascade on update cascade
)