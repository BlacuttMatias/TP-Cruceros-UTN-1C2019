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
object_id(N'[MostrarRoles]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [MostrarRoles]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarFuncionalidadesAgregadasARol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarFuncionalidadesAgregadasARol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[mostrarRolesHabilitados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [mostrarRolesHabilitados]
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
	[usua_habilitado] [bit])
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
	[puer_ciudad] int)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Puerto] ADD CONSTRAINT PK_PUERTO
	PRIMARY KEY(puer_codigo)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Puerto] ADD CONSTRAINT [FK_Puerto_ciudad] FOREIGN KEY ([puer_ciudad])
	REFERENCES [FIDEOS_CON_TUCO].[Ciudad]([ciud_codigo])
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
	[pasa_codigo] int NOT NULL,
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
	[rese_codigo] int NOT NULL,
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


INSERT INTO [FIDEOS_CON_TUCO].[Puerto](puer_descripcion, puer_esta_habilitado)
SELECT PUERTO_DESDE, 1
FROM gd_esquema.Maestra
UNION
SELECT PUERTO_HASTA, 1
FROM gd_esquema.Maestra
GO


/**********************************Carga de Ciudades**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Ciudad](ciud_descripcion)
SELECT PUERTO_DESDE
FROM gd_esquema.Maestra
UNION
SELECT PUERTO_HASTA
FROM gd_esquema.Maestra
GO


/**********************************Carga de Puertos**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Puerto](puer_esta_habilitado, puer_ciudad)
SELECT 1, ciud_codigo
FROM [FIDEOS_CON_TUCO].[Ciudad]
GO



/**********************************Carga de Tramos**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Tramo](tram_puerto_origen, tram_puerto_destino, tram_precio)
SELECT DISTINCT p1.puer_codigo, p2.puer_codigo, RECORRIDO_PRECIO_BASE
FROM gd_esquema.Maestra
JOIN [FIDEOS_CON_TUCO].[Ciudad] c1 ON (c1.ciud_descripcion = PUERTO_DESDE)
JOIN [FIDEOS_CON_TUCO].[Ciudad] c2 ON (c2.ciud_descripcion = PUERTO_HASTA)
JOIN [FIDEOS_CON_TUCO].[Puerto] p1 ON (p1.puer_ciudad = c1.ciud_codigo)
JOIN [FIDEOS_CON_TUCO].[Puerto] p2 ON (p2.puer_ciudad = c2.ciud_codigo)
GO


/**********************************Carga de Recorridos**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Recorrido](reco_codigo, reco_puerto_origen, reco_puerto_destino, reco_precio, reco_esta_habilitado)
SELECT DISTINCT RECORRIDO_CODIGO, p1.puer_codigo, p2.puer_codigo, RECORRIDO_PRECIO_BASE, 1
FROM gd_esquema.Maestra
JOIN [FIDEOS_CON_TUCO].[Ciudad] c1 ON (c1.ciud_descripcion = PUERTO_DESDE)
JOIN [FIDEOS_CON_TUCO].[Ciudad] c2 ON (c2.ciud_descripcion = PUERTO_HASTA)
JOIN [FIDEOS_CON_TUCO].[Puerto] p1 ON (p1.puer_ciudad = c1.ciud_codigo)
JOIN [FIDEOS_CON_TUCO].[Puerto] p2 ON (p2.puer_ciudad = c2.ciud_codigo)
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
JOIN [FIDEOS_CON_TUCO].[Ciudad] c1 ON (c1.ciud_descripcion = PUERTO_DESDE)
JOIN [FIDEOS_CON_TUCO].[Ciudad] c2 ON (c2.ciud_descripcion = PUERTO_HASTA)
JOIN [FIDEOS_CON_TUCO].[Puerto] p1 ON (p1.puer_ciudad = c1.ciud_codigo)
JOIN [FIDEOS_CON_TUCO].[Puerto] p2 ON (p2.puer_ciudad = c2.ciud_codigo)
JOIN [FIDEOS_CON_TUCO].[Recorrido] ON (reco_codigo = RECORRIDO_CODIGO 
	AND reco_puerto_origen = p1.puer_codigo 
	AND reco_puerto_destino = p2.puer_codigo)
GO


/**********************************Carga de Compra**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Compra](comp_cliente, comp_monto_total, comp_fecha)
SELECT clie_codigo, PASAJE_PRECIO, PASAJE_FECHA_COMPRA
FROM gd_esquema.Maestra
JOIN [FIDEOS_CON_TUCO].[Cliente] ON (clie_dni = CLI_DNI AND clie_nombre = CLI_NOMBRE AND clie_apellido = CLI_APELLIDO)
WHERE PASAJE_CODIGO IS NOT NULL
GO














/************************** STORED PROCEDURES **************************/

/************* AGREGAR FUNCIONALIDAD A ROL *************/


CREATE PROCEDURE FIDEOS_CON_TUCO.AgregarFuncionalidadARol(@nombrerol varchar(255), @funcionalidad varchar(255)) 
AS
BEGIN
	INSERT INTO FIDEOS_CON_TUCO.Funcionalidad_Por_Rol (func_por_rol_funcionalidad, func_por_rol_rol)
VALUES ((SELECT func_codigo FROM FIDEOS_CON_TUCO.Funcionalidad WHERE func_descripcion = @funcionalidad),(SELECT rol_codigo FROM FIDEOS_CON_TUCO.Rol WHERE rol_descripcion = @nombrerol))
END
GO

/************* AGREGAR ROL *************/

CREATE PROCEDURE agregarRol @rolAgregar varchar(255), @flag int output
AS
BEGIN
	if EXISTS(SELECT rol_descripcion FROM FIDEOS_CON_TUCO.Rol WHERE rol_descripcion = @rolAgregar)
		SET @flag = 0
	else
		SET @flag = 1;
		INSERT INTO FIDEOS_CON_TUCO.Rol (rol_descripcion, rol_esta_habilitado) VALUES (@rolAgregar, 1);
END
GO

/************* MODIFICAR ROL *************/

CREATE PROCEDURE actualizarNombreRol @codigo int, @nombreRol varchar(255)
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Rol SET rol_descripcion = @nombreRol WHERE rol_codigo = @codigo;
END
GO

CREATE PROCEDURE habilitarRol @codigo int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Rol SET rol_esta_habilitado = 1 WHERE rol_codigo = @codigo
END
GO

/************* DESHABILITAR ROL *************/

CREATE PROCEDURE deshabilitarRol @codigo int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Rol SET rol_esta_habilitado = 0 WHERE rol_codigo = @codigo;
	DELETE FROM FIDEOS_CON_TUCO.Rol_Por_Usuario WHERE rol_por_usua_rol = @codigo;
END
GO

/************* ELIMINAR RELACION FUNCIONALIDAD-ROL *************/

CREATE PROCEDURE eliminarFuncionalidadARol @nombreFuncionalidad varchar(255), @codigoRol int
AS
BEGIN
	DELETE FROM FIDEOS_CON_TUCO.Funcionalidad_Por_Rol WHERE func_por_rol_funcionalidad = (SELECT func_codigo
																						  FROM FIDEOS_CON_TUCO.Funcionalidad
																						  WHERE func_descripcion = @nombreFuncionalidad)
													  AND func_por_rol_rol = @codigoRol
END
GO


/************* MOSTRAR DATOS *************/

CREATE PROCEDURE mostrarFuncionalidadesNoAgregadasARol @nombreRol varchar(255)
AS
BEGIN
	SELECT func_descripcion FROM FIDEOS_CON_TUCO.Funcionalidad
	WHERE func_codigo NOT IN (SELECT func_por_rol_funcionalidad FROM FIDEOS_CON_TUCO.Funcionalidad_por_rol, FIDEOS_CON_TUCO.Rol
							  WHERE func_por_rol_rol = rol_codigo and rol_descripcion = @nombreRol)
END
GO

CREATE PROCEDURE MostrarRoles
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

CREATE PROCEDURE mostrarFuncionalidadesAgregadasARol @nombreRol varchar(255)
AS
BEGIN
	SELECT func_descripcion FROM FIDEOS_CON_TUCO.Funcionalidad
	WHERE func_codigo IN (SELECT func_por_rol_funcionalidad FROM FIDEOS_CON_TUCO.Funcionalidad_por_rol, FIDEOS_CON_TUCO.Rol
						  where func_por_rol_rol = rol_codigo AND rol_descripcion = @nombreRol)
END
GO

CREATE PROCEDURE mostrarRolesHabilitados
AS
BEGIN
	SELECT rol_codigo AS Codigo, rol_descripcion AS Descripcion FROM FIDEOS_CON_TUCO.Rol
	WHERE rol_esta_habilitado = 1
END
GO



