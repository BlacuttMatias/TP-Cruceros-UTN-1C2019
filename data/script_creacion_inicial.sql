USE [GD1C2019]
GO


/************************************************************************************************************/
/*********************************** ELIMINO LAS STORED PROCEDURES SI YA EXISTEN ***************************************/


if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[AgregarFuncionalidadARol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[AgregarFuncionalidadARol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[agregarRol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [agregarRol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[actualizarNombreRol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [actualizarNombreRol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[habilitarRol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [habilitarRol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[deshabilitarRol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [deshabilitarRol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[eliminarFuncionalidadARol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [eliminarFuncionalidadARol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarFuncionalidadesNoAgregadasARol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarFuncionalidadesNoAgregadasARol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarRoles]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarRoles]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarFuncionalidadesAgregadasARol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarFuncionalidadesAgregadasARol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarRolesHabilitados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarRolesHabilitados]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[sumaDeIntentosFallidos]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [sumaDeIntentosFallidos]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[adminLogin]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [adminLogin]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[agregarPuerto]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [agregarPuerto]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[modificarPuerto]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [modificarPuerto]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[habilitarPuerto]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [habilitarPuerto]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[deshabilitarPuerto]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [deshabilitarPuerto]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarPuertos]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarPuertos]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarPuertosHabilitados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarPuertosHabilitados]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarPuertosDeshabilitados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarPuertosDeshabilitados]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[agregarRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [agregarRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[agregarTramoAUnRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [agregarTramoAUnRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[modificarRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [modificarRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[eliminarTramoDeUnRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [eliminarTramoDeUnRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[habilitarRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [habilitarRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[deshabilitarRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [deshabilitarRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarRecorridos]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarRecorridos]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarRecorridosHabilitados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarRecorridosHabilitados]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarRecorridosDeshabilitados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarRecorridosDeshabilitados]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarTramosDeUnRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarTramosDeUnRecorrido]
GO

/************************************************************************************************************/
/*********************************** ELIMINO LAS TABLAS SI YA EXISTEN ***************************************/


if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[Funcionalidad_por_rol]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Funcionalidad_por_rol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[Funcionalidad]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Funcionalidad]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[Rol_por_usuario]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Rol_por_usuario]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[Rol]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Rol]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Tramos_por_recorrido]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Tramos_por_recorrido]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Tramo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Tramo]
GO


if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Cancelacion_reserva]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Cancelacion_reserva]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Reserva]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Reserva]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Registro_baja]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Registro_baja]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Pasaje]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Pasaje]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Viaje]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Viaje]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Recorrido]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Recorrido]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Puerto]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Puerto]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Ciudad]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Ciudad]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Cabina]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Cabina]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Tipo_cabina]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Tipo_cabina]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Crucero]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Crucero]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Marca]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Marca]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Modelo]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Modelo]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Compra]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Compra]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Cliente]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Cliente]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Usuario]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Usuario]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Medio_de_pago]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Medio_de_pago]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Tarjeta]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Tarjeta]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Empresa_tarjeta]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Empresa_tarjeta]
GO


/************************************************************************************************************/
/******************************** ELIMINO SI EXISTE Y CREO EL SCHEMA ****************************************/
/************************************************************************************************************/

IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'FIDEOS_CON_TUCO')
DROP SCHEMA [FIDEOS_CON_TUCO]
GO

CREATE SCHEMA [FIDEOS_CON_TUCO] AUTHORIZATION gdCruceros2019
GO


/************************************************************************************************************/
/*********************** CREO LAS TABLAS Y MIGRO LOS DATOS DE LA TABLA MAESTRA ******************************/
/************************************************************************************************************/


/********* <<USUARIO>> ***********/


CREATE TABLE [FIDEOS_CON_TUCO].[Usuario](
	[usua_codigo] int IDENTITY(1,1) NOT NULL,
	[usua_username] [varchar](255),
	[usua_contrasenia] [varbinary](MAX),
	[usua_intentos_fallidos] int,
	[usua_esta_habilitado] [bit])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Usuario] ADD CONSTRAINT PK_USUARIO
	PRIMARY KEY(usua_codigo)
GO


/***************<<ROL>>*************************/


CREATE TABLE FIDEOS_CON_TUCO.Rol(
	rol_codigo [int] IDENTITY(1,1) PRIMARY KEY,
	rol_descripcion	 VARCHAR(255) NOT NULL UNIQUE,
	rol_esta_habilitado BIT NOT NULL)
GO


/****** <<ROL_POR_USUARIO>> ******/


CREATE TABLE FIDEOS_CON_TUCO.Rol_por_usuario ( 
	rol_por_usua_rol [int] NOT NULL, 
	rol_por_usua_usuario int NOT NULL) 
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Rol_por_usuario] ADD CONSTRAINT PK_USUA_ROL
	PRIMARY KEY(rol_por_usua_rol, rol_por_usua_usuario)
GO

ALTER TABLE FIDEOS_CON_TUCO.Rol_por_usuario ADD CONSTRAINT FK_Usuario FOREIGN KEY (rol_por_usua_usuario) REFERENCES FIDEOS_CON_TUCO.Usuario(usua_codigo)
GO

ALTER TABLE FIDEOS_CON_TUCO.Rol_por_Usuario ADD CONSTRAINT FK_Rol FOREIGN KEY (rol_por_usua_rol) REFERENCES FIDEOS_CON_TUCO.Rol(rol_codigo)
GO


/***************<<Funcionalidad>>*********************/


CREATE TABLE FIDEOS_CON_TUCO.Funcionalidad(
	func_codigo [int] IDENTITY(1,1) PRIMARY KEY,
	func_descripcion VARCHAR(255) NOT NULL UNIQUE)
GO


/***************<<Funcionalidad_Por_Rol>>*************/


CREATE TABLE FIDEOS_CON_TUCO.Funcionalidad_por_rol ( 
	func_por_rol_funcionalidad [int] NOT NULL, 
	func_por_rol_rol [int] NOT NULL) 
GO

ALTER TABLE FIDEOS_CON_TUCO.Funcionalidad_por_rol ADD CONSTRAINT FK_Funcionalidad FOREIGN KEY (func_por_rol_funcionalidad) REFERENCES FIDEOS_CON_TUCO.Funcionalidad(func_codigo)
GO

ALTER TABLE FIDEOS_CON_TUCO.Funcionalidad_por_rol ADD CONSTRAINT FK_Func_Rol FOREIGN KEY (func_por_rol_rol) REFERENCES FIDEOS_CON_TUCO.Rol(rol_codigo)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Funcionalidad_por_rol] ADD CONSTRAINT PK_FUNC_ROL
	PRIMARY KEY(func_por_rol_funcionalidad, func_por_rol_rol)
GO


/*********** <<CIUDAD>> ***************/


CREATE TABLE [FIDEOS_CON_TUCO].[Ciudad](
	[ciud_codigo] int IDENTITY(1,1) NOT NULL,
	[ciud_descripcion] [varchar](255) NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Ciudad] ADD CONSTRAINT PK_CIUDAD
	PRIMARY KEY(ciud_codigo)
GO


/********** <<PUERTO>> **************/


CREATE TABLE [FIDEOS_CON_TUCO].[Puerto](
	[puer_codigo] int IDENTITY(1,1) NOT NULL,
	[puer_descripcion] [varchar](255),
	[puer_esta_habilitado] [bit] NOT NULL,
	[puer_ciudad] [varchar](255) NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Puerto] ADD CONSTRAINT PK_PUERTO
	PRIMARY KEY(puer_codigo)
GO


/************* <<RECORRIDO>> ***************/


CREATE TABLE [FIDEOS_CON_TUCO].[Recorrido](
	[reco_id] int IDENTITY(1,1) NOT NULL,
	[reco_codigo] int,								/*CAMBIO EN EL DER*/
	[reco_precio] numeric(10,2) NOT NULL,
	[reco_puerto_origen] int NOT NULL,
	[reco_puerto_destino] int NOT NULL,
	[reco_esta_habilitado] bit NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Recorrido] ADD CONSTRAINT PK_RECORRIDO
	PRIMARY KEY(reco_id)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Recorrido] ADD CONSTRAINT FK_Reco_Puerto_origen FOREIGN KEY ([reco_puerto_origen])
	REFERENCES [FIDEOS_CON_TUCO].[Puerto]([puer_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Recorrido] ADD CONSTRAINT FK_Reco_Puerto_destino FOREIGN KEY ([reco_puerto_destino])
	REFERENCES [FIDEOS_CON_TUCO].[Puerto]([puer_codigo])
GO


/*********** <<TRAMO>> ***********/


CREATE TABLE [FIDEOS_CON_TUCO].[Tramo](
	[tram_codigo] int IDENTITY(1,1) NOT NULL,
	[tram_puerto_origen] int NOT NULL,
	[tram_puerto_destino] int NOT NULL,
	[tram_precio] numeric(10,2) NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Tramo] ADD CONSTRAINT PK_TRAMO
	PRIMARY KEY(tram_codigo)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Tramo] ADD CONSTRAINT FK_Tram_Puerto_origen FOREIGN KEY ([tram_puerto_origen])
	REFERENCES [FIDEOS_CON_TUCO].[Puerto]([puer_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Tramo] ADD CONSTRAINT FK_Tram_Puerto_destino FOREIGN KEY ([tram_puerto_destino])
	REFERENCES [FIDEOS_CON_TUCO].[Puerto]([puer_codigo])
GO


/************* <<TRAMO_POR_RECORRIDO>> ***************/


CREATE TABLE [FIDEOS_CON_TUCO].[Tramos_por_recorrido](
	[tram_por_reco_tramo] int NOT NULL,
	[tram_por_reco_recorrido] int NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Tramos_por_recorrido] ADD CONSTRAINT FK_Tramo FOREIGN KEY ([tram_por_reco_tramo])
	REFERENCES [FIDEOS_CON_TUCO].[Tramo]([tram_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Tramos_por_recorrido] ADD CONSTRAINT FK_Recorrido FOREIGN KEY ([tram_por_reco_recorrido])
	REFERENCES [FIDEOS_CON_TUCO].[Recorrido]([reco_id])
GO 


/************ <<MARCA>> *************/


CREATE TABLE [FIDEOS_CON_TUCO].[Marca](
	[marc_codigo] int IDENTITY(1,1) NOT NULL,
	[marc_descripcion] [varchar](255) NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Marca] ADD CONSTRAINT PK_MARCA 
	PRIMARY KEY ([marc_codigo])
GO


/********** <<MODELO>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Modelo](
	[mode_codigo] int IDENTITY(1,1) NOT NULL,
	[mode_descripcion] [varchar](255) NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Modelo] ADD CONSTRAINT PK_MODELO
	PRIMARY KEY ([mode_codigo])
GO


/********** <<CRUCERO>> ***************/


CREATE TABLE [FIDEOS_CON_TUCO].[Crucero](
	[cruc_codigo] [varchar](255) NOT NULL,		/*CAMBIO EN EL DER*/
	[cruc_marca] int NOT NULL,
	[cruc_modelo] int NOT NULL,
	[cruc_fecha_de_alta] [datetime],		/*???CREO QUE ESTE CAMPO AL FINAL NO VA*/
	[cruc_cantidad_cabinas] int NOT NULL,
	[cruc_esta_habilitado] [bit] NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Crucero] ADD CONSTRAINT PK_CRUCERO 
	PRIMARY KEY ([cruc_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Crucero] ADD CONSTRAINT FK_Marca FOREIGN KEY ([cruc_marca])
	REFERENCES [FIDEOS_CON_TUCO].[Marca]([marc_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Crucero] ADD CONSTRAINT FK_Modelo FOREIGN KEY ([cruc_modelo])
	REFERENCES [FIDEOS_CON_TUCO].[Modelo]([mode_codigo])
GO


/********** <<TIPO_CABINA>> ************/		

/*****************************************************************************************/
/***CAMBIO EN EL DER: CREO QUE LA ENTIDAD SERVICIO NO ES NECESARIA, POR ESO NO LA PUSE****/
/*****************************************************************************************/


CREATE TABLE [FIDEOS_CON_TUCO].[Tipo_cabina](
	[tipo_codigo] int IDENTITY(1,1) NOT NULL,
	[tipo_descripcion] [varchar](255) NOT NULL,
	[tipo_porcentaje_recargo] numeric(4,2) NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Tipo_Cabina] ADD CONSTRAINT PK_TIPO_CABINA
	PRIMARY KEY ([tipo_codigo])
GO


/********** <<CABINA>> ************/				


CREATE TABLE [FIDEOS_CON_TUCO].[Cabina](
	[cabi_codigo] int IDENTITY(1,1) NOT NULL,
	[cabi_numero] int NOT NULL,
	[cabi_piso] int NOT NULL,
	[cabi_tipo] int NOT NULL,
	[cabi_crucero] [varchar](255) NOT NULL,				/*CAMBIO EN EL DER*/
	[cabi_esta_disponible] [bit] NOT NULL)				
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Cabina] ADD CONSTRAINT PK_CABINA 
	PRIMARY KEY ([cabi_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Cabina] ADD CONSTRAINT FK_Tipo FOREIGN KEY ([cabi_tipo])
	REFERENCES [FIDEOS_CON_TUCO].[Tipo_Cabina]([tipo_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Cabina] ADD CONSTRAINT FK_Cabi_Crucero FOREIGN KEY ([cabi_crucero])
	REFERENCES [FIDEOS_CON_TUCO].[Crucero]([cruc_codigo])
GO


/************* <<VIAJE>> ****************/


CREATE TABLE [FIDEOS_CON_TUCO].[Viaje] (
	[viaj_codigo] int IDENTITY(1,1) NOT NULL,
	[viaj_crucero] [varchar](255) NOT NULL,			/*CAMBIO EN EL DER*/
	[viaj_recorrido] int NOT NULL,
	[viaj_fecha_inicio] [datetime] NOT NULL,
	[viaj_fecha_finalizacion] [datetime] NOT NULL,
	[viaj_fecha_finalizacion_estimada] [datetime] NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Viaje] ADD CONSTRAINT PK_VIAJE 
	PRIMARY KEY ([viaj_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Viaje] ADD CONSTRAINT FK_Viaj_Crucero FOREIGN KEY ([viaj_crucero])
	REFERENCES [FIDEOS_CON_TUCO].[Crucero]([cruc_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Viaje] ADD CONSTRAINT FK_Viaj_Recorrido FOREIGN KEY ([viaj_recorrido])
	REFERENCES [FIDEOS_CON_TUCO].[Recorrido]([reco_id])
GO


/********** <<REGISTRO_BAJA>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Registro_baja](
	[regi_codigo] int IDENTITY(1,1) NOT NULL,
	[regi_tipo] [varchar](25) NOT NULL CHECK([regi_tipo] IN('PERMANENTE','TEMPORAL')),	/*?? PODRIA CAMBIARSE POR A UNA ENTIDAD SEPARADA*/
	[regi_crucero] [varchar](255) NOT NULL,			/*CAMBIO EN EL DER*/
	[regi_fecha_de_baja] [datetime] NOT NULL,
	[regi_fecha_de_alta] [datetime])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Registro_baja] ADD CONSTRAINT PK_REGISTRO_BAJA
	PRIMARY KEY ([regi_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Registro_baja] ADD CONSTRAINT FK_Crucero FOREIGN KEY ([regi_crucero])
	REFERENCES [FIDEOS_CON_TUCO].[Crucero]([cruc_codigo])
GO


/********** <<CLIENTE>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Cliente](
	[clie_codigo] int IDENTITY(1,1) NOT NULL,
	[clie_nombre] [varchar](255) NOT NULL,
	[clie_apellido] [varchar](255) NOT NULL,
	[clie_telefono] numeric(18,0) NOT NULL,
	[clie_mail] [varchar](255) NOT NULL,
	[clie_fecha_nacimiento] [datetime] NOT NULL,
	[clie_direccion] [varchar](255) NOT NULL,
	[clie_dni] numeric(18,0) NOT NULL,
	[clie_usuario] int)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Cliente] ADD CONSTRAINT PK_CLIENTE
	PRIMARY KEY ([clie_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Cliente] ADD CONSTRAINT FK_Clie_usuario FOREIGN KEY ([clie_usuario])
	REFERENCES [FIDEOS_CON_TUCO].[Usuario]([usua_codigo])
GO


/********** <<EMPRESA_TARJETA>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Empresa_tarjeta](
	[empr_codigo] int IDENTITY(1,1) NOT NULL,
	[empr_descripcion] [varchar](255) NOT NULL,
	[empr_cantidad_de_cuotas] int NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Empresa_tarjeta] ADD CONSTRAINT PK_EMPRESA_TARJETA
	PRIMARY KEY ([empr_codigo])
GO


/********** <<TARJETA>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Tarjeta](
	[tarj_numero] numeric(20,0) NOT NULL,
	[tarj_empresa] int NOT NULL,
	[tarj_codigo_verificador] int NOT NULL,
	[tarj_tipo] [varchar] NOT NULL CHECK([tarj_tipo] IN('DEBITO', 'CREDITO')))
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Tarjeta] ADD CONSTRAINT PK_TARJETA
	PRIMARY KEY ([tarj_numero])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Tarjeta] ADD CONSTRAINT FK_Empresa FOREIGN KEY ([tarj_empresa])
	REFERENCES [FIDEOS_CON_TUCO].[Empresa_tarjeta]([empr_codigo])
GO


/********** <<MEDIO_DE_PAGO>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Medio_de_pago](
	[medi_codigo] int IDENTITY(1,1) NOT NULL,
	[medi_tipo] [varchar](50) NOT NULL CHECK([medi_tipo] IN('EFECTIVO', 'TARJETA')),
	[medi_tarjeta] numeric(20,0))
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Medio_de_pago] ADD CONSTRAINT PK_MEDIO_DE_PAGO
	PRIMARY KEY ([medi_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Medio_de_pago] ADD CONSTRAINT FK_Tarjeta FOREIGN KEY ([medi_tarjeta])
	REFERENCES [FIDEOS_CON_TUCO].[Tarjeta]([tarj_numero])
GO


/********** <<COMPRA>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Compra](
	[comp_codigo] int IDENTITY(1,1) NOT NULL,
	[comp_cliente] int NOT NULL,
	[comp_medio_de_pago] int,
	[comp_fecha] [datetime] NOT NULL,
	[comp_monto_total] numeric(10,2) NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Compra] ADD CONSTRAINT PK_COMPRA
	PRIMARY KEY ([comp_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Compra] ADD CONSTRAINT FK_Comp_Cliente FOREIGN KEY ([comp_cliente])
	REFERENCES [FIDEOS_CON_TUCO].[Cliente]([clie_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Compra] ADD CONSTRAINT FK_Medio_de_pago FOREIGN KEY ([comp_medio_de_pago])
	REFERENCES [FIDEOS_CON_TUCO].[Medio_de_pago]([medi_codigo])
GO


/********** <<PASAJE>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Pasaje](
	[pasa_codigo] int IDENTITY(1,1) NOT NULL,
	[pasa_precio] numeric (10,0),
	[pasa_cliente] int NOT NULL,
	[pasa_viaje] int NOT NULL,
	[pasa_cabina] int NOT NULL,
	[pasa_compra] int)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Pasaje] ADD CONSTRAINT PK_PASAJE
	PRIMARY KEY ([pasa_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Pasaje] ADD CONSTRAINT FK_Pasa_Cliente FOREIGN KEY ([pasa_cliente])
	REFERENCES [FIDEOS_CON_TUCO].[Cliente]([clie_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Pasaje] ADD CONSTRAINT FK_Viaje FOREIGN KEY ([pasa_viaje])
	REFERENCES [FIDEOS_CON_TUCO].[Viaje]([viaj_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Pasaje] ADD CONSTRAINT FK_Viaj_Cabina FOREIGN KEY ([pasa_cabina])
	REFERENCES [FIDEOS_CON_TUCO].[Cabina]([cabi_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Pasaje] ADD CONSTRAINT FK_Compra FOREIGN KEY ([pasa_compra])
	REFERENCES [FIDEOS_CON_TUCO].[Compra]([comp_codigo])
GO


/********** <<RESERVA>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Reserva](
	[rese_codigo] int IDENTITY(1,1) NOT NULL,
	[rese_fecha] [datetime] NOT NULL,
	[rese_pasaje] int NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Reserva] ADD CONSTRAINT PK_RESERVA
	PRIMARY KEY ([rese_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Reserva] ADD CONSTRAINT FK_Rese_Pasaje FOREIGN KEY ([rese_pasaje])
	REFERENCES [FIDEOS_CON_TUCO].[Pasaje]([pasa_codigo])
GO


/********** <<CANCELACION_RESERVA>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Cancelacion_reserva](
	[canc_codigo] int IDENTITY(1,1) NOT NULL,
	[canc_reserva] int NOT NULL,
	[canc_fecha] [datetime] NOT NULL,
	[canc_detalle] [varchar](255))
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Cancelacion_reserva] ADD CONSTRAINT PK_CANCELACION_RESERVA
	PRIMARY KEY ([canc_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Cancelacion_reserva] ADD CONSTRAINT FK_Reserva FOREIGN KEY ([canc_reserva])
	REFERENCES [FIDEOS_CON_TUCO].[Reserva]([rese_codigo])
GO


/****************************************MIGRACION DE DATOS********************************************************************/

/**********************************Carga de Clientes**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Cliente](clie_nombre, clie_apellido, clie_dni, clie_direccion, clie_telefono, clie_mail, clie_fecha_nacimiento)
select DISTINCT CLI_NOMBRE, CLI_APELLIDO, CLI_DNI, CLI_DIRECCION, CLI_TELEFONO,CLI_MAIL, CLI_FECHA_NAC  
from gd_esquema.Maestra
GO



/**********************************Carga de Modelos de cruceros**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Modelo](mode_descripcion)
select DISTINCT CRUCERO_MODELO  
from gd_esquema.Maestra
GO


/**********************************Carga de Marcas de cruceros**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Marca](marc_descripcion)
select DISTINCT CRU_FABRICANTE
FROM gd_esquema.Maestra
GO


/**********************************Carga de Tipos cabinas**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Tipo_cabina](tipo_descripcion, tipo_porcentaje_recargo)
SELECT DISTINCT CABINA_TIPO, CABINA_TIPO_PORC_RECARGO
FROM gd_esquema.Maestra
GO


/**********************************Carga de Cruceros**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Crucero](cruc_codigo, cruc_marca, cruc_modelo, cruc_cantidad_cabinas, cruc_esta_habilitado)
SELECT CRUCERO_IDENTIFICADOR, marc_codigo, mode_codigo, COUNT(DISTINCT CABINA_NRO), 1
FROM gd_esquema.Maestra 
JOIN [FIDEOS_CON_TUCO].[Marca] ON (CRU_FABRICANTE = marc_descripcion)
JOIN [FIDEOS_CON_TUCO].[Modelo] ON (CRUCERO_MODELO = mode_descripcion)
GROUP BY CRUCERO_IDENTIFICADOR, marc_codigo, mode_codigo
GO


/**********************************Carga de Cabinas**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Cabina](cabi_numero, cabi_piso, cabi_tipo, cabi_crucero, cabi_esta_disponible)
SELECT DISTINCT CABINA_NRO, CABINA_PISO, tipo_codigo, cruc_codigo, 1
FROM gd_esquema.Maestra
JOIN [FIDEOS_CON_TUCO].[Tipo_cabina] ON (CABINA_TIPO = tipo_descripcion)
JOIN [FIDEOS_CON_TUCO].[Crucero] ON (CRUCERO_IDENTIFICADOR = cruc_codigo)
GO


/**********************************Carga de Puertos**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Puerto](puer_esta_habilitado, puer_ciudad)
SELECT 1, PUERTO_DESDE
FROM gd_esquema.Maestra
UNION
SELECT 1, PUERTO_HASTA
FROM gd_esquema.Maestra
GO



/**********************************Carga de Tramos**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Tramo](tram_puerto_origen, tram_puerto_destino, tram_precio)
SELECT DISTINCT p1.puer_codigo, p2.puer_codigo, RECORRIDO_PRECIO_BASE
FROM gd_esquema.Maestra
JOIN [FIDEOS_CON_TUCO].[Puerto] p1 ON (p1.puer_ciudad = PUERTO_DESDE)
JOIN [FIDEOS_CON_TUCO].[Puerto] p2 ON (p2.puer_ciudad = PUERTO_HASTA)
GO


/**********************************Carga de Recorridos**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Recorrido](reco_codigo, reco_puerto_origen, reco_puerto_destino, reco_precio, reco_esta_habilitado)
SELECT DISTINCT RECORRIDO_CODIGO, p1.puer_codigo, p2.puer_codigo, RECORRIDO_PRECIO_BASE, 1
FROM gd_esquema.Maestra
JOIN [FIDEOS_CON_TUCO].[Puerto] p1 ON (p1.puer_ciudad = PUERTO_DESDE)
JOIN [FIDEOS_CON_TUCO].[Puerto] p2 ON (p2.puer_ciudad = PUERTO_HASTA)
GO


/**********************************Carga de Tramos por recorridos**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Tramos_por_recorrido](tram_por_reco_tramo, tram_por_reco_recorrido)
SELECT tram_codigo, reco_id 
FROM [FIDEOS_CON_TUCO].[Recorrido]
JOIN [FIDEOS_CON_TUCO].[Tramo] ON (reco_puerto_origen = tram_puerto_origen AND reco_puerto_destino = tram_puerto_destino)
GO


/**********************************Carga de Viajes**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Viaje](viaj_recorrido, viaj_crucero, viaj_fecha_inicio, viaj_fecha_finalizacion, viaj_fecha_finalizacion_estimada)
SELECT DISTINCT reco_id, CRUCERO_IDENTIFICADOR, FECHA_SALIDA, FECHA_LLEGADA, FECHA_LLEGADA_ESTIMADA
FROM gd_esquema.Maestra
JOIN [FIDEOS_CON_TUCO].[Puerto] p1 ON (p1.puer_ciudad = PUERTO_DESDE)
JOIN [FIDEOS_CON_TUCO].[Puerto] p2 ON (p2.puer_ciudad = PUERTO_HASTA)
JOIN [FIDEOS_CON_TUCO].[Recorrido] ON (reco_puerto_origen = p1.puer_codigo 
	AND reco_puerto_destino = p2.puer_codigo)
GO


/**********************************Carga de Compra**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Compra](comp_cliente, comp_monto_total, comp_fecha)
SELECT clie_codigo, PASAJE_PRECIO, PASAJE_FECHA_COMPRA
FROM gd_esquema.Maestra
JOIN [FIDEOS_CON_TUCO].[Cliente] ON (clie_dni = CLI_DNI AND clie_nombre = CLI_NOMBRE AND clie_apellido = CLI_APELLIDO)
WHERE PASAJE_CODIGO IS NOT NULL
GO


/**********************************Carga de Pasajes Comprados**************************************************************************/


SET IDENTITY_INSERT [FIDEOS_CON_TUCO].[Pasaje] ON
GO

INSERT INTO [FIDEOS_CON_TUCO].[Pasaje](pasa_codigo, pasa_cliente, pasa_viaje, pasa_cabina, pasa_compra)
SELECT PASAJE_CODIGO, clie_codigo, viaj_codigo, cabi_codigo, comp_codigo
FROM gd_esquema.Maestra
--obtengo el codigo del cliente
JOIN [FIDEOS_CON_TUCO].[Cliente] ON (clie_dni = CLI_DNI AND clie_nombre = CLI_NOMBRE AND clie_apellido = CLI_APELLIDO)
--obtengo el codigo del recorrido para luego asociarlo al viaje
JOIN [FIDEOS_CON_TUCO].[Puerto] p1 ON (p1.puer_ciudad = PUERTO_DESDE)
JOIN [FIDEOS_CON_TUCO].[Puerto] p2 ON (p2.puer_ciudad = PUERTO_HASTA)
JOIN [FIDEOS_CON_TUCO].[Recorrido] ON (reco_puerto_origen = p1.puer_codigo 
	AND reco_puerto_destino = p2.puer_codigo)
--obtengo el codigo de viaje
JOIN [FIDEOS_CON_TUCO].[Viaje] ON (viaj_recorrido = reco_id
	AND viaj_fecha_inicio = FECHA_SALIDA
	AND viaj_crucero = CRUCERO_IDENTIFICADOR)
--obtengo la cabina
JOIN [FIDEOS_CON_TUCO].[Cabina] ON (cabi_numero = CABINA_NRO
	AND cabi_piso = CABINA_PISO
	AND cabi_crucero = CRUCERO_IDENTIFICADOR)
--obtengo la compra
JOIN [FIDEOS_CON_TUCO].[Compra] ON (comp_cliente = clie_codigo
	AND comp_monto_total = PASAJE_PRECIO
	AND comp_fecha = PASAJE_FECHA_COMPRA)
WHERE PASAJE_CODIGO IS NOT NULL
GO

SET IDENTITY_INSERT [FIDEOS_CON_TUCO].[Pasaje] OFF
GO


/**********************************Carga de Pasajes Posiblemente Cancelados**************************************************************************/
--Son posiblemente cancelados porque hay pasajes "duplicados": uno cuando se hace la reserva y otro cuando se paga la reserva, y deberia ser el mismo
--Los demas si son todos cancelados por no pagar la reserva


INSERT INTO [FIDEOS_CON_TUCO].[Pasaje](pasa_cliente, pasa_viaje, pasa_cabina)
SELECT clie_codigo, viaj_codigo, cabi_codigo
FROM gd_esquema.Maestra
--obtengo el codigo del cliente
JOIN [FIDEOS_CON_TUCO].[Cliente] ON (clie_dni = CLI_DNI AND clie_nombre = CLI_NOMBRE AND clie_apellido = CLI_APELLIDO)
--obtengo el codigo del recorrido para luego asiciarlo al viaje
JOIN [FIDEOS_CON_TUCO].[Puerto] p1 ON (p1.puer_ciudad = PUERTO_DESDE)
JOIN [FIDEOS_CON_TUCO].[Puerto] p2 ON (p2.puer_ciudad = PUERTO_HASTA)
JOIN [FIDEOS_CON_TUCO].[Recorrido] ON (reco_puerto_origen = p1.puer_codigo 
	AND reco_puerto_destino = p2.puer_codigo)
--obtengo el codigo de viaje
JOIN [FIDEOS_CON_TUCO].[Viaje] ON (viaj_recorrido = reco_id
	AND viaj_fecha_inicio = FECHA_SALIDA
	AND viaj_crucero = CRUCERO_IDENTIFICADOR)
--obtengo la cabina
JOIN [FIDEOS_CON_TUCO].[Cabina] ON (cabi_numero = CABINA_NRO
	AND cabi_piso = CABINA_PISO
	AND cabi_crucero = CRUCERO_IDENTIFICADOR)
WHERE PASAJE_CODIGO IS NULL
GO


/**********************************Carga de Reservas**************************************************************************/
--Las vincula a pasajes que no tienen una compra hecha


SET IDENTITY_INSERT [FIDEOS_CON_TUCO].[Reserva] ON
GO

INSERT INTO [FIDEOS_CON_TUCO].[Reserva](rese_codigo, rese_pasaje, rese_fecha)
SELECT RESERVA_CODIGO, pasa_codigo, RESERVA_FECHA
FROM gd_esquema.Maestra
--obtego el cliente para luego obtener el pasaje
JOIN [FIDEOS_CON_TUCO].[Cliente] ON (clie_dni = CLI_DNI AND clie_nombre = CLI_NOMBRE AND clie_apellido = CLI_APELLIDO)
--obtengo el codigo del recorrido para luego asiciarlo al viaje
JOIN [FIDEOS_CON_TUCO].[Puerto] p1 ON (p1.puer_ciudad = PUERTO_DESDE)
JOIN [FIDEOS_CON_TUCO].[Puerto] p2 ON (p2.puer_ciudad = PUERTO_HASTA)
JOIN [FIDEOS_CON_TUCO].[Recorrido] ON (reco_puerto_origen = p1.puer_codigo 
	AND reco_puerto_destino = p2.puer_codigo)
--obtengo el viaje para luego obtener el pasaje
JOIN [FIDEOS_CON_TUCO].[Viaje] ON (viaj_recorrido = reco_id
	AND viaj_fecha_inicio = FECHA_SALIDA
	AND viaj_crucero = CRUCERO_IDENTIFICADOR)
--obtengo el pasaje
JOIN [FIDEOS_CON_TUCO].[Pasaje] ON (pasa_cliente = clie_codigo
	AND pasa_viaje = viaj_codigo
	AND pasa_compra IS NULL)
WHERE RESERVA_CODIGO IS NOT NULL
GO

SET IDENTITY_INSERT [FIDEOS_CON_TUCO].[Reserva] OFF
GO


/**********************Vinculo pasajes comprados que hayan sido reservados*******************************/

UPDATE [FIDEOS_CON_TUCO].[Reserva] SET rese_pasaje = p2.pasa_codigo FROM [FIDEOS_CON_TUCO].[Reserva]
JOIN [FIDEOS_CON_TUCO].[Pasaje] p1 ON (p1.pasa_codigo = rese_pasaje)
JOIN [FIDEOS_CON_TUCO].[Pasaje] p2 ON (p2.pasa_cliente = p1.pasa_cliente AND p2.pasa_viaje = p1.pasa_viaje AND p2.pasa_compra IS NOT NULL)
JOIN [FIDEOS_CON_TUCO].[Compra] ON (comp_codigo = p2.pasa_compra)
WHERE DATEDIFF(DAY, rese_fecha, comp_fecha) <= 3
GO


/**********************Elimino los pasajes "duplicados", aquellos que quedaron sin reservas ni compra**********************/


DELETE p1 FROM [FIDEOS_CON_TUCO].[Pasaje] p1
WHERE p1.pasa_compra IS NULL AND NOT EXISTS (SELECT rese_codigo FROM [FIDEOS_CON_TUCO].[Reserva] WHERE rese_pasaje = p1.pasa_codigo)
GO


/**********************************Carga de Cancelaciones de reservas**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Cancelacion_reserva] (canc_reserva, canc_fecha)
SELECT rese_codigo, DATEADD(DAY, 4, rese_fecha)
FROM [FIDEOS_CON_TUCO].[Reserva]
JOIN [FIDEOS_CON_TUCO].[Pasaje] ON (pasa_codigo = rese_pasaje)
WHERE pasa_compra IS NULL
GO






/************************** STORED PROCEDURES **************************/

/************************** ABM DE ROLES **************************/ 


/******************** CREAR UN ROL ********************/

/************* AGREGAR ROL *************/

CREATE PROCEDURE agregarRol @rolAgregar varchar(255), @flag int output /* El flag está para devolver un mensaje según la situación que se presente*/
AS
BEGIN
	if EXISTS(SELECT rol_descripcion FROM FIDEOS_CON_TUCO.Rol WHERE rol_descripcion = @rolAgregar)
		SET @flag = 0
	else
		SET @flag = 1;
		INSERT INTO FIDEOS_CON_TUCO.Rol (rol_descripcion, rol_esta_habilitado) VALUES (@rolAgregar, 1);
END
GO

/************* AGREGAR FUNCIONALIDAD A ROL *************/


CREATE PROCEDURE FIDEOS_CON_TUCO.AgregarFuncionalidadARol(@nombrerol varchar(255), @funcionalidad varchar(255)) 
AS
BEGIN
	INSERT INTO FIDEOS_CON_TUCO.Funcionalidad_Por_Rol (func_por_rol_funcionalidad, func_por_rol_rol)
VALUES ((SELECT func_codigo FROM FIDEOS_CON_TUCO.Funcionalidad WHERE func_descripcion = @funcionalidad),(SELECT rol_codigo FROM FIDEOS_CON_TUCO.Rol WHERE rol_descripcion = @nombrerol))
END
GO


/******************** MODIFICAR UN ROL ********************/

/************* MODIFICAR NOMBRE *************/

CREATE PROCEDURE actualizarNombreRol @codigo int, @nombreRol varchar(255)
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Rol SET rol_descripcion = @nombreRol WHERE rol_codigo = @codigo;
END
GO

/************* ELIMINAR UNA FUNCIONALIDAD DE UN ROL  *************/

CREATE PROCEDURE eliminarFuncionalidadARol @nombreFuncionalidad varchar(255), @codigoRol int
AS
BEGIN
	DELETE FROM FIDEOS_CON_TUCO.Funcionalidad_Por_Rol WHERE func_por_rol_funcionalidad = (SELECT func_codigo
																						  FROM FIDEOS_CON_TUCO.Funcionalidad
																						  WHERE func_descripcion = @nombreFuncionalidad)
													  AND func_por_rol_rol = @codigoRol
END
GO

/************* AGREGAR UNA FUNCIONALIDAD A UN ROL *************/

/* SP ya resuelto en CREAR UN ROL*/ 


/******************** ELIMINAR UN ROL ********************/

/************* DESHABILITAR UN ROL *************/

CREATE PROCEDURE deshabilitarRol @codigo int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Rol SET rol_esta_habilitado = 0 WHERE rol_codigo = @codigo;
	DELETE FROM FIDEOS_CON_TUCO.Rol_Por_Usuario WHERE rol_por_usua_rol = @codigo;
END
GO

/************* HABILITAR UN ROL *************/

CREATE PROCEDURE habilitarRol @codigo int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Rol SET rol_esta_habilitado = 1 WHERE rol_codigo = @codigo
END
GO


/******************** MOSTRAR DATOS PARA BAJA Y MODIFICACION DE ROLES ********************/

/************* SP PARA MOSTRAR FUNCINALIDADES CANDIDATAS A SER AGREGADAS A UN ROL *************/

CREATE PROCEDURE mostrarFuncionalidadesNoAgregadasARol @nombreRol varchar(255)
AS
BEGIN
	SELECT func_descripcion FROM FIDEOS_CON_TUCO.Funcionalidad
	WHERE func_codigo NOT IN (SELECT func_por_rol_funcionalidad FROM FIDEOS_CON_TUCO.Funcionalidad_por_rol, FIDEOS_CON_TUCO.Rol
							  WHERE func_por_rol_rol = rol_codigo AND rol_descripcion = @nombreRol)
END
GO

/************* SP PARA MOSTRAR TODOS LOS ROLES (SIRVE PARA ALTA Y BAJA DE ROLES YA CREADOS) *************/

CREATE PROCEDURE mostrarRoles
AS
BEGIN
	SELECT rol_codigo AS Codigo, 
	       rol_descripcion AS Descripcion, 
		   CASE WHEN rol_esta_habilitado = 1 THEN 'SI'
		        WHEN rol_esta_habilitado = 0 THEN 'NO'
		   END AS Habilitado
	FROM FIDEOS_CON_TUCO.Rol
END
GO

/************* SP PARA MOSTRAR FUNCINALIDADES QUE PUEDEN SER ELIMINADAS DE UN ROL *************/

CREATE PROCEDURE mostrarFuncionalidadesAgregadasARol @nombreRol varchar(255)
AS
BEGIN
	SELECT func_descripcion FROM FIDEOS_CON_TUCO.Funcionalidad
	WHERE func_codigo IN (SELECT func_por_rol_funcionalidad FROM FIDEOS_CON_TUCO.Funcionalidad_por_rol, FIDEOS_CON_TUCO.Rol
						  where func_por_rol_rol = rol_codigo AND rol_descripcion = @nombreRol)
END
GO

/************* SP PARA MOSTRAR LOS ROLES QUE PUEDEN SER ELIMINADOS *************/

CREATE PROCEDURE mostrarRolesHabilitados
AS
BEGIN
	SELECT rol_codigo AS Codigo, rol_descripcion AS Descripcion FROM FIDEOS_CON_TUCO.Rol
	WHERE rol_esta_habilitado = 1
END
GO



/************************** LOGIN Y SEGURIDAD **************************/


/******************** LOGUEO DE UN ADMINISTRADOR ********************/

/************* SUMA DE INTENTOS FALLIDOS  *************/

CREATE PROCEDURE sumaDeIntentosFallidos @username varchar(255), @intentos_fallidos int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Usuario SET usua_intentos_fallidos = usua_intentos_fallidos + 1 WHERE usua_username = @username
	if(@intentos_fallidos = 2)
	/*if((SELECT usua_intentos_fallidos FROM FIDEOS_CON_TUCO.Usuario WHERE usua_username = @username) = 3)*/
		UPDATE FIDEOS_CON_TUCO.Usuario SET usua_esta_habilitado = 0 WHERE usua_username = @username	
END
GO

/************* LOGIN  *************/

CREATE PROCEDURE adminLogin @username varchar(255), @password varchar(255)
AS
DECLARE @usua_contrasenia varchar(255)
DECLARE @usua_intentos_fallidos int
SELECT  @usua_contrasenia = usua_contrasenia, @usua_intentos_fallidos = usua_intentos_fallidos FROM	FIDEOS_CON_TUCO.Usuario WHERE usua_username = @username
/*IF POR SI NO ES LA CONTRASEÑA*/
BEGIN
	if(HASHBYTES('SHA2_256', @password) <> @usua_contrasenia)
		EXEC sumaDeIntentosFallidos @username, @usua_intentos_fallidos
END
/*IF PARA VER SI ES LA CONTRASEÑA CORRECTA*/
BEGIN
	if(HASHBYTES('SHA2_256', @password) = @usua_contrasenia and @usua_intentos_fallidos < 3)
		UPDATE	FIDEOS_CON_TUCO.Usuario SET	usua_intentos_fallidos = 0 WHERE usua_username = @username
END
/*SELECT PARA MOSTRAR EL USUARIO INGRESADO*/
SELECT usua_username, usua_contrasenia, usua_esta_habilitado FROM FIDEOS_CON_TUCO.Usuario WHERE usua_username = @username and usua_contrasenia = HASHBYTES('SHA2_256', @password)
GO


/*######################## CREACION DE ROLES Y FUNCIONALIDADES ############################*/


INSERT INTO [FIDEOS_CON_TUCO].[Rol](rol_descripcion, rol_esta_habilitado) VALUES ('Administrativo', 1)
INSERT INTO [FIDEOS_CON_TUCO].[Rol](rol_descripcion, rol_esta_habilitado) VALUES ('Cliente', 1)
GO

INSERT INTO [FIDEOS_CON_TUCO].[Funcionalidad](func_descripcion) VALUES ('Login')
INSERT INTO [FIDEOS_CON_TUCO].[Funcionalidad](func_descripcion) VALUES ('ABM Roles')
INSERT INTO [FIDEOS_CON_TUCO].[Funcionalidad](func_descripcion) VALUES ('ABM Puertos')
INSERT INTO [FIDEOS_CON_TUCO].[Funcionalidad](func_descripcion) VALUES ('ABM Recorridos')
INSERT INTO [FIDEOS_CON_TUCO].[Funcionalidad](func_descripcion) VALUES ('ABM Cruceros')
INSERT INTO [FIDEOS_CON_TUCO].[Funcionalidad](func_descripcion) VALUES ('Generar viaje')
INSERT INTO [FIDEOS_CON_TUCO].[Funcionalidad](func_descripcion) VALUES ('Comprar viaje')
INSERT INTO [FIDEOS_CON_TUCO].[Funcionalidad](func_descripcion) VALUES ('Reservar viaje')
INSERT INTO [FIDEOS_CON_TUCO].[Funcionalidad](func_descripcion) VALUES ('Pagar reserva')
INSERT INTO [FIDEOS_CON_TUCO].[Funcionalidad](func_descripcion) VALUES ('Listados estadisticos')
GO

/************************** RELACIONO Roles a sus respectivas funcionalidades *******************************************/

EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Administrativo', 'Login'
EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Administrativo', 'ABM Roles'
EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Administrativo', 'ABM Puertos'
EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Administrativo', 'ABM Recorridos'
EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Administrativo', 'ABM Cruceros'
EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Administrativo', 'Generar viaje'
EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Administrativo', 'Comprar viaje'
EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Administrativo', 'Reservar viaje'
EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Administrativo', 'Pagar reserva'
EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Administrativo', 'Listados estadisticos'
GO

EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Cliente', 'Comprar viaje'
EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Cliente', 'Reservar viaje'
EXEC FIDEOS_CON_TUCO.AgregarFuncionalidadARol 'Cliente', 'Pagar reserva'
GO


/*######################## [04]::[ABM Puerto] ############################*/


/************************** ALTA Puerto*******************************************/

CREATE PROCEDURE agregarPuerto @ciudad varchar(255), @resultado int output, @descripcion varchar(255)= NULL
AS 
BEGIN
	IF NOT EXISTS(SELECT * FROM [FIDEOS_CON_TUCO].[Puerto] WHERE puer_ciudad = @ciudad AND puer_descripcion = @descripcion)
		BEGIN
		INSERT INTO [FIDEOS_CON_TUCO].[Puerto](puer_descripcion, puer_ciudad, puer_esta_habilitado) VALUES (@descripcion, @ciudad, 1)
		SET @resultado = 1
		END
	ELSE 
		SET @resultado = 0
END
GO

/************************** MODIFICACION Puerto*******************************************/

CREATE PROCEDURE modificarPuerto @codigoPuerto int, @ciudad varchar(255), @descripcion varchar(255) = NULL
AS
BEGIN
	UPDATE [FIDEOS_CON_TUCO].[Puerto] SET puer_ciudad = @ciudad, puer_descripcion = @descripcion WHERE puer_codigo = @codigoPuerto
END
GO

/************************** BAJA LOGICA Puerto (DESHABILITAR)*******************************************/

CREATE PROCEDURE deshabilitarPuerto @codigoPuerto int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Puerto SET puer_esta_habilitado = 0 WHERE puer_codigo = @codigoPuerto
	--deshabilito el recorrido que tuviese como origen o destino este puerto
	UPDATE FIDEOS_CON_TUCO.Recorrido SET reco_esta_habilitado = 0 FROM FIDEOS_CON_TUCO.Recorrido
		JOIN [FIDEOS_CON_TUCO].[Tramo] ON (tram_puerto_origen = @codigoPuerto OR tram_puerto_destino = @codigoPuerto)
		JOIN [FIDEOS_CON_TUCO].[Tramos_por_recorrido] ON (tram_por_reco_tramo = tram_codigo)
		WHERE reco_id = tram_por_reco_recorrido
END
GO

/************************** HABILITAR Puerto *******************************************/

CREATE PROCEDURE habilitarPuerto @codigoPuerto int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Puerto SET puer_esta_habilitado = 1 WHERE puer_codigo = @codigoPuerto
END
GO

/************************** LISTADO Todos los Puertos *******************************************/

CREATE PROCEDURE mostrarPuertos
AS
BEGIN
	SELECT puer_codigo AS Codigo, puer_ciudad AS Ciudad, 
		CASE WHEN puer_descripcion IS NULL THEN '-'
				ELSE puer_descripcion
		END AS Descripcion,
		CASE WHEN puer_esta_habilitado = 1 THEN 'SI'
				ELSE 'NO'
		END AS Habilitado
		FROM FIDEOS_CON_TUCO.Puerto
END
GO

/************************** LISTADO Puertos habilitados *******************************************/

CREATE PROCEDURE mostrarPuertosHabilitados 
AS
BEGIN
	SELECT puer_codigo AS Codigo, puer_ciudad AS Ciudad, 
		CASE WHEN puer_descripcion IS NULL THEN '-'
			ELSE puer_descripcion
		END AS Descripcion
		FROM FIDEOS_CON_TUCO.Puerto
		WHERE puer_esta_habilitado = 1
END
GO

/************************** LISTADO Puertos deshabilitados *******************************************/

CREATE PROCEDURE mostrarPuertosDeshabilitados 
AS
BEGIN
	SELECT puer_codigo AS Codigo, puer_ciudad AS Ciudad, 
		CASE WHEN puer_descripcion IS NULL THEN '-'
			ELSE puer_descripcion
		END AS Descripcion
		FROM FIDEOS_CON_TUCO.Puerto
		WHERE puer_esta_habilitado = 0
END
GO


/*######################## [05]::[ABM Recorrido] ############################*/


/************************** ALTA Recorrido*******************************************/

--si el resultado fue exitoso, devuelve el id del recorrido ingresado
CREATE PROCEDURE agregarRecorrido @ciudadPuertoOrigen varchar (255), @ciudadPuertoDestino varchar(255), @precio numeric (10,2), @resultado int output, @codigoRecorrido int = NULL
AS
BEGIN
	DECLARE @codigoPuertoOrigen int
	DECLARE @codigoPuertoDestino int
	SELECT @codigoPuertoOrigen = puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = @ciudadPuertoOrigen
	SELECT @codigoPuertoDestino = puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = @ciudadPuertoDestino
	IF NOT EXISTS (SELECT reco_id FROM FIDEOS_CON_TUCO.Recorrido WHERE reco_puerto_origen = @codigoPuertoOrigen AND reco_puerto_destino = @codigoPuertoDestino AND reco_precio = @precio)
		BEGIN
		INSERT INTO FIDEOS_CON_TUCO.Recorrido(reco_puerto_origen, reco_puerto_destino, reco_precio, reco_esta_habilitado, reco_codigo) 
			VALUES (@codigoPuertoOrigen, @codigoPuertoDestino, @precio, 1, @codigoRecorrido)
		SET @resultado = SCOPE_IDENTITY()
		END
	ELSE
		SET @resultado = 0
END
GO


CREATE PROCEDURE agregarTramoAUnRecorrido @ciudadPuertoOrigen varchar(255), @ciudadPuertoDestino varchar(255), @idRecorrido int
AS
BEGIN
	DECLARE @codigoPuertoOrigen int
	DECLARE @codigoPuertoDestino int
	SELECT @codigoPuertoOrigen = puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = @ciudadPuertoOrigen
	SELECT @codigoPuertoDestino = puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = @ciudadPuertoDestino
	IF NOT EXISTS (SELECT tram_codigo FROM FIDEOS_CON_TUCO.Tramo WHERE tram_puerto_origen = @codigoPuertoOrigen AND tram_puerto_destino = @codigoPuertoDestino)
		INSERT INTO FIDEOS_CON_TUCO.Tramo(tram_puerto_origen, tram_puerto_destino) VALUES (@codigoPuertoOrigen, @codigoPuertoDestino)
	DECLARE @codigoTramo int
	SELECT @codigoTramo = tram_codigo FROM FIDEOS_CON_TUCO.Tramo WHERE tram_puerto_origen = @codigoPuertoOrigen AND tram_puerto_destino = @codigoPuertoDestino
	INSERT INTO FIDEOS_CON_TUCO.Tramos_por_recorrido(tram_por_reco_tramo, tram_por_reco_recorrido) VALUES (@codigoTramo, @idRecorrido)
END
GO


/************************** MODIFICACION Recorrido*******************************************/


CREATE PROCEDURE modificarRecorrido @idRecorrido int, @ciudadPuertoOrigen varchar(255), @ciudadPuertoDestino varchar(255), @precio numeric(10,2), @codigoRecorrido int = NULL
AS
BEGIN
	DECLARE @codigoPuertoOrigen int
	DECLARE @codigoPuertoDestino int
	SELECT @codigoPuertoOrigen = puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = @ciudadPuertoOrigen
	SELECT @codigoPuertoDestino = puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = @ciudadPuertoDestino
	UPDATE FIDEOS_CON_TUCO.Recorrido SET reco_puerto_origen = @codigoPuertoOrigen,
		reco_puerto_destino = @codigoPuertoDestino, reco_precio = @precio, reco_codigo = @codigoRecorrido 
		WHERE reco_id = @idRecorrido
END
GO


CREATE PROCEDURE eliminarTramoDeUnRecorrido @ciudadPuertoOrigen varchar(255), @ciudadPuertoDestino varchar(255), @idRecorrido int
AS
BEGIN
	DECLARE @codigoPuertoOrigen int
	DECLARE @codigoPuertoDestino int
	SELECT @codigoPuertoOrigen = puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = @ciudadPuertoOrigen
	SELECT @codigoPuertoDestino = puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = @ciudadPuertoDestino
	DELETE FROM FIDEOS_CON_TUCO.Tramos_por_recorrido 
		WHERE tram_por_reco_tramo = (SELECT tram_codigo FROM FIDEOS_CON_TUCO.Tramo WHERE (tram_puerto_origen = @codigoPuertoOrigen AND tram_puerto_destino = @codigoPuertoDestino))
		AND tram_por_reco_recorrido = @idRecorrido
END
GO


/************************** BAJA LOGICA Recorrido (DESHABILITAR) *******************************************/

CREATE PROCEDURE deshabilitarRecorrido @idRecorrido int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Recorrido SET reco_esta_habilitado = 0 WHERE reco_id = @idRecorrido
END
GO

/************************** HABILITAR Recorrido *******************************************/

CREATE PROCEDURE habilitarRecorrido @idRecorrido int, @resultado int output
AS
BEGIN
	--Verifico que el recorrido que se desea habilitar no tenga un puerto deshabilitado
	IF NOT EXISTS(SELECT tram_codigo FROM FIDEOS_CON_TUCO.Tramo 
			JOIN FIDEOS_CON_TUCO.Tramos_por_recorrido ON (tram_por_reco_tramo = tram_codigo AND tram_por_reco_recorrido = @idRecorrido)
			JOIN FIDEOS_CON_TUCO.Puerto puertoOrigen ON (puertoOrigen.puer_codigo = tram_puerto_origen)
			JOIN FIDEOS_CON_TUCO.Puerto puertoDestino ON (puertoDestino.puer_codigo = tram_puerto_destino)
			WHERE puertoOrigen.puer_esta_habilitado = 0 OR puertoDestino.puer_esta_habilitado = 0)		
		BEGIN
		UPDATE FIDEOS_CON_TUCO.Recorrido SET reco_esta_habilitado = 1 WHERE reco_id = @idRecorrido 
		SET @resultado = 1
		END
	ELSE
		SET @resultado = 0
END
GO

/************************** LISTADO Recorridos *******************************************/

CREATE PROCEDURE mostrarRecorridos
AS
BEGIN
	SELECT reco_id AS ID, puertoOrigen.puer_ciudad AS Puerto_origen, 
		puertoDestino.puer_ciudad AS Puerto_destino, reco_precio AS Precio, 
		CASE WHEN reco_esta_habilitado = 1 THEN 'SI'
			ELSE 'NO'
		END AS Habilitado
		FROM FIDEOS_CON_TUCO.Recorrido
		JOIN FIDEOS_CON_TUCO.Puerto puertoOrigen ON (puertoOrigen.puer_codigo = reco_puerto_origen)
		JOIN FIDEOS_CON_TUCO.Puerto puertoDestino ON (puertoDestino.puer_codigo = reco_puerto_destino)
END
GO

CREATE PROCEDURE mostrarRecorridosHabilitados
AS
BEGIN
	SELECT reco_id AS ID, puertoOrigen.puer_ciudad AS Puerto_origen, puertoDestino.puer_ciudad AS Puerto_destino, reco_precio AS Precio
		FROM FIDEOS_CON_TUCO.Recorrido 
		JOIN FIDEOS_CON_TUCO.Puerto puertoOrigen ON (puertoOrigen.puer_codigo = reco_puerto_origen)
		JOIN FIDEOS_CON_TUCO.Puerto puertoDestino ON (puertoDestino.puer_codigo = reco_puerto_destino)
		WHERE reco_esta_habilitado = 1
END
GO

CREATE PROCEDURE mostrarRecorridosDeshabilitados
AS
BEGIN
	SELECT reco_id AS ID, puertoOrigen.puer_ciudad AS Puerto_origen, puertoDestino.puer_ciudad AS Puerto_destino, reco_precio AS Precio
		FROM FIDEOS_CON_TUCO.Recorrido 
		JOIN FIDEOS_CON_TUCO.Puerto puertoOrigen ON (puertoOrigen.puer_codigo = reco_puerto_origen)
		JOIN FIDEOS_CON_TUCO.Puerto puertoDestino ON (puertoDestino.puer_codigo = reco_puerto_destino)
		WHERE reco_esta_habilitado = 0
END
GO

/************************** LISTADO Tramos de un Recorrido *******************************************/

CREATE PROCEDURE mostrarTramosDeUnRecorrido @idRecorrido int
AS
BEGIN
	SELECT tram_codigo AS Codigo, puertoOrigen.puer_codigo AS Puerto_origen, puertoDestino.puer_codigo AS Puerto_destino
		FROM FIDEOS_CON_TUCO.Tramo
		JOIN FIDEOS_CON_TUCO.Tramos_por_recorrido ON (tram_por_reco_recorrido = @idRecorrido)
		JOIN FIDEOS_CON_TUCO.Puerto puertoOrigen ON (puertoOrigen.puer_codigo = tram_puerto_origen)
		JOIN FIDEOS_CON_TUCO.Puerto puertoDestino ON (puertoDestino.puer_codigo = tram_puerto_destino)
		WHERE tram_codigo = tram_por_reco_tramo
END
GO
