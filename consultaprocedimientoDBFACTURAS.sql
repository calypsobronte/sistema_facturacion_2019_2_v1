/****** Object:  StoredProcedure [dbo].[actualizar_Cliente]    Script Date: 20/02/2019 20:08:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
/*use DBFACTURAS*/

Create procedure [dbo].[actualizar_Cliente]
			 @StrNombre varchar(50), 
			 @NumDocumento  bigint,
			 @StrDireccion varchar(50)   
			,@StrTelefono  varchar(30)   
			,@StrEmail  varchar(50)
			,@DtmFechaModifica  datetime  
			,@StrUsuarioModifico  varchar(20)  
as
--Actualiza empleado[dbo].[]
if NOT EXISTS (select IdCliente from TBLCLIENTES where NumDocumento=@NumDocumento)

INSERT INTO TBLCLIENTES(
           StrNombre
           ,NumDocumento
           ,StrDireccion
           ,StrTelefono
           ,StrEmail
           ,DtmFechaModifica
           ,StrUsuarioModifico)
     VALUES
           (@strNombre,
           @NumDocumento, 
           @StrDireccion, 
           @StrTelefono, 
           @StrEmail,  
           @DtmFechaModifica,  
           @StrUsuarioModifico)
 else
 

UPDATE  TBLCLIENTES
   SET  strNombre  =  @strNombre 
      , NumDocumento  = @NumDocumento 
      , StrDireccion = @StrDireccion 
      , StrTelefono  = @StrTelefono 
      , StrEmail  = @StrEmail  
      , DtmFechaModifica  = @DtmFechaModifica 
      , StrUsuarioModifico  = @StrUsuarioModifico 
 WHERE   NumDocumento  = @NumDocumento 
GO

/****** Object:  StoredProcedure [dbo].[Eliminar_Cliente]    Script Date: 20/02/2019 20:11:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Eliminar_Cliente]
@IdCliente int
as

delete from TBLCLIENTES where  IdCliente=@IdCliente
GO

/****** Object:  StoredProcedure [dbo].[actualizar_CategoriaProd]    Script Date: 20/02/2019 20:08:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[actualizar_CategoriaProd]
			 @idCategoria int,
			 @StrReferencia varchar(20), 
			 @StrDescripcion  varchar(50)
			,@DtmFechaModifica  datetime  
			,@StrUsuarioModifico  varchar(30)  
as
--Actualiza 
if NOT EXISTS (select idCategoria from TBLCATEGORIA_PROD where idCategoria=@idCategoria)

INSERT INTO TBLCATEGORIA_PROD(
           StrReferencia,
		   StrDescripcion
           ,DtmFechaModifica
           ,StrUsuarioModifico)
     VALUES(
		   @StrReferencia,
		   @StrDescripcion,
           @DtmFechaModifica,  
           @StrUsuarioModifico)
 else
 

UPDATE  TBLCATEGORIA_PROD
   SET  StrReferencia  =  @StrReferencia 
      , StrDescripcion  = @StrDescripcion 
      , DtmFechaModifica  = @DtmFechaModifica 
      , StrUsuarioModifico  = @StrUsuarioModifico 
 WHERE   idCategoria  = @idCategoria 
GO

/****** Object:  StoredProcedure [dbo].[Eliminar_CategoriaProd]    Script Date: 20/02/2019 20:11:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Eliminar_CategoriaProd]
@idCategoria int
as

delete from TBLCATEGORIA_PROD where idCategoria=@idCategoria
GO

USE [DBFACTURAS]
GO

/****** Object:  StoredProcedure [dbo].[Eliminar_Empleado]    Script Date: 20/02/2019 20:11:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Eliminar_Producto]
@IdProducto int
as

delete from TBLPRODUCTO where  IdProducto=@IdProducto
GO

/****** Object:  StoredProcedure [dbo].[actualizar_Producto]    Script Date: 20/02/2019 20:08:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[actualizar_Producto]
			 @idProducto int,
			 @StrNombre varchar(50), 
			 @StrReferencia  varchar(20),
			 @NumPrecioCompra decimal(18,0)  
			,@NumPrecioVenta  decimal(18,0)    
			,@idCategoria  int   
			,@StrDetalle varchar(250)  
			,@strFoto  varchar(30)  
			,@NumStock int  
			,@DtmFechaModifica datetime
			,@StrUsuarioModifico varchar(30)  
as
--Actualiza empleado[dbo].[]
if NOT EXISTS (select IdProducto from TBLPRODUCTO where IdProducto=@idProducto)

INSERT INTO TBLPRODUCTO(
            StrNombre
           ,StrReferencia
           ,NumPrecioCompra
           ,NumPrecioVenta
           ,idCategoria
		   ,StrDetalle
		   ,strFoto
		   ,NumStock
           ,DtmFechaModifica
           ,StrUsuarioModifico)
     VALUES
           (@strNombre,
		   @StrReferencia,
		   @NumPrecioCompra,
		   @NumPrecioVenta,
		   @idCategoria,
		   @StrDetalle,
		   @strFoto,
		   @NumStock, 
           @DtmFechaModifica,  
           @StrUsuarioModifico)
 else
 

UPDATE  TBLPRODUCTO
   SET  strNombre  =  @strNombre 
      , StrReferencia  = @StrReferencia 
      , NumPrecioCompra = @NumPrecioCompra 
      , NumPrecioVenta  = @NumPrecioVenta 
      , idCategoria  = @idCategoria 
      , StrDetalle  = @StrDetalle 
      , strFoto  = @strFoto 
      , NumStock  = @NumStock 
      , DtmFechaModifica  = @DtmFechaModifica 
      , StrUsuarioModifico  = @StrUsuarioModifico 
 WHERE   IdProducto  = @idProducto 
GO

/****** Object:  StoredProcedure [dbo].[Eliminar_Rol]    Script Date: 20/02/2019 20:11:00 ******/
use DBFACTURAS
Go

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Eliminar_Rol]
@IdRolEmpleado int 
as
delete from TBLROLES  WHERE IdRolEmpleado  = @IdRolEmpleado  

GO

/****** Object:  StoredProcedure [dbo].[Eliminar_Empleado]    Script Date: 20/02/2019 20:11:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Alter proc [dbo].[Eliminar_Producto]
@IdProducto int
as

delete from TBLPRODUCTO where  IdProducto=@IdProducto
GO

/****** Object:  StoredProcedure [dbo].[actualizar_Rol]    Script Date: 20/02/2019 20:08:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Actualizar_Rol]
			 @idRol int,
			 @StrDescripcion varchar(50), 
			 @StrDetalle  varchar(250)
as
--Actualiza empleado[dbo].[]
if NOT EXISTS (select idRolEmpleado from TBLROLES where idRolEmpleado=@idRol)

INSERT INTO TBLROLES(
           StrDescripcion,
		   StrDetalle)
     VALUES
           (@StrDescripcion,
		   @StrDetalle)
 else
 

UPDATE  TBLROLES
   SET  StrDescripcion=@StrDescripcion,
		StrDetalle = @StrDetalle 
 WHERE   IdRolEmpleado  = @idRol 
GO