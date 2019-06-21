USE [GD1C2019]
GO


/************************************************************************************************************/
/*********************************** ELIMINO LAS STORED PROCEDURES SI YA EXISTEN ***************************************/


if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[AgregarFuncionalidadARol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[AgregarFuncionalidadARol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[agregarRol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[agregarRol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[actualizarNombreRol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[actualizarNombreRol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[habilitarRol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[habilitarRol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[deshabilitarRol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[deshabilitarRol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[eliminarFuncionalidadARol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[eliminarFuncionalidadARol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarFuncionalidadesNoAgregadasARol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarFuncionalidadesNoAgregadasARol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarRoles]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarRoles]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarFuncionalidadesAgregadasARol]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarFuncionalidadesAgregadasARol]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarRolesHabilitados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarRolesHabilitados]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[sumaDeIntentosFallidos]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[sumaDeIntentosFallidos]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[adminLogin]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[adminLogin]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[agregarPuerto]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[agregarPuerto]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[modificarPuerto]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[modificarPuerto]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[habilitarPuerto]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[habilitarPuerto]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[deshabilitarPuerto]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[deshabilitarPuerto]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarPuertos]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarPuertos]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarPuertosHabilitados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarPuertosHabilitados]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarPuertosDeshabilitados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarPuertosDeshabilitados]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[agregarRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[agregarRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[agregarTramoAUnRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[agregarTramoAUnRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[modificarRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[modificarRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[eliminarTramoDeUnRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[eliminarTramoDeUnRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[habilitarRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[habilitarRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[deshabilitarRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[deshabilitarRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarRecorridos]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarRecorridos]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarRecorridosHabilitados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarRecorridosHabilitados]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarRecorridosDeshabilitados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarRecorridosDeshabilitados]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarTramosDeUnRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarTramosDeUnRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[agregarUsuario]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[agregarUsuario]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[agregarRolAUnUsuario]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[agregarRolAUnUsuario]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[crearUsuariosIniciales]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[crearUsuariosIniciales]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarLosCincoRecorridosConMasPasajesComprados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarLosCincoRecorridosConMasPasajesComprados]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarLosCincoRecorridosConMasCabinasLibresEnCadaViaje]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarLosCincoRecorridosConMasCabinasLibresEnCadaViaje]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarLosCincoCrucerosConMasDiasFueraDeServicio]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarLosCincoCrucerosConMasDiasFueraDeServicio]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[generarViaje]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[generarViaje]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[ingresarCliente]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[ingresarCliente]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[traerCliente]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[traerCliente]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[actualizarCliente]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[actualizarCliente]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarViajesParaComprar]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarViajesParaComprar]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarCabinasDisponiblesDeUnViaje]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarCabinasDisponiblesDeUnViaje]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cargarTiposdeBajasDeCrucerosIniciales]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cargarTiposdeBajasDeCrucerosIniciales]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cargarTiposDeMediosDePagoIniciales]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cargarTiposDeMediosDePagoIniciales]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cargarEmpresasDeTarjetasIniciales]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cargarEmpresasDeTarjetasIniciales]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cargarCantidadDeCuotasDeEmpresasIniciales]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cargarCantidadDeCuotasDeEmpresasIniciales]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[generarPasaje]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[generarPasaje]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[generarReservaDeUnPasaje]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[generarReservaDeUnPasaje]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[generarCompra]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[generarCompra]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[agregarPasajeAUnaCompra]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[agregarPasajeAUnaCompra]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarTiposDeMediosDePago]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarTiposDeMediosDePago]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarEmpresasDeTarjetas]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarEmpresasDeTarjetas]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarCuotasDeUnaEmpresa]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarCuotasDeUnaEmpresa]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[ingresarTarjeta]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[ingresarTarjeta]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[ingresarMedioDePagoConTarjeta]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[ingresarMedioDePagoConTarjeta]
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.existenViajesConPasajesVendidosDeEsePuerto') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.existenViajesConPasajesVendidosDeEsePuerto
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cancelarPasajesPorBajaDePuerto]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cancelarPasajesPorBajaDePuerto]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cargarTiposdeBajasDeCrucerosIniciales]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cargarTiposdeBajasDeCrucerosIniciales]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cargarCrucero]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cargarCrucero]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[actualizarMarca]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[actualizarMarca]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[listadoCabinas]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[listadoCabinas]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[listadoTipoCabinas]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[listadoTipoCabinas]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[modificarTipoCabina]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[modificarTipoCabina]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[corrimientoDiasViaje]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[corrimientoDiasViaje]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[crucerosDisponibles]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[crucerosDisponibles]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[reemplazoCrucero]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[reemplazoCrucero]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cancelacionViajesParaBajaPermanente]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cancelacionViajesParaBajaPermanente]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cancelacionViajesParaBajaTemporal]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cancelacionViajesParaBajaTemporal]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[bajaCrucero]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[bajaCrucero]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarDatosFinalizadaLaCompra]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarDatosFinalizadaLaCompra]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cancelarReservas]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cancelarReservas]
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.pasajeDeUnaReserva') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.pasajeDeUnaReserva
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.stringDestinos') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.stringDestinos
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.stringConPuertosDeUnRecorrido') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.stringConPuertosDeUnRecorrido
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.clienteDeUnPasaje') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.clienteDeUnPasaje
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[actualizarCrucerosHabilitados]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[actualizarCrucerosHabilitados]
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.unCruceroEstaHabilitado') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.unCruceroEstaHabilitado
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.unCruceroEstaHabilitadoDurante') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.unCruceroEstaHabilitadoDurante
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[agregarCrucero]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[agregarCrucero]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[agregarCabinaAUnCrucero]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[agregarCabinaAUnCrucero]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarMarcas]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarMarcas]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarModelos]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarModelos]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarTipoCabinas]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarTipoCabinas]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarCruceros]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarCruceros]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarCabinasDeUnCrucero]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarCabinasDeUnCrucero]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarTipoBaja]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarTipoBaja]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[modificarCrucero]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[modificarCrucero]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarBajas]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarBajas]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarTodosLosViajesParaComprar]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarTodosLosViajesParaComprar]
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.precioDeUnPasaje') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.precioDeUnPasaje
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cruceroTieneViajes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cruceroTieneViajes]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[correrViajesSuperpuestosUnDia]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[correrViajesSuperpuestosUnDia]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[modificarViajesSuperpuestosConMismoCrucero]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[modificarViajesSuperpuestosConMismoCrucero]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarViajesParaComprarParaUnCliente]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarViajesParaComprarParaUnCliente]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cancelacionViajes]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cancelacionViajes]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarPuertosDeUnRecorrido]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarPuertosDeUnRecorrido]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[mostrarCrucerosParaUnViaje]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[mostrarCrucerosParaUnViaje]
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.cantidadCabinasEstandar') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.cantidadCabinasEstandar
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.cantidadCabinasExteriores') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.cantidadCabinasExteriores
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.cantidadCabinasSuites') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.cantidadCabinasSuites
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.cantidadCabinasBalcones') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.cantidadCabinasBalcones
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.cantidadCabinasEjecutivas') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.cantidadCabinasEjecutivas
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.unCruceroTieneViajesDurante') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.unCruceroTieneViajesDurante
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.comparacionCruceros') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.comparacionCruceros
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.unCruceroEsIgualAOtro') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.unCruceroEsIgualAOtro
GO

IF 
OBJECT_ID('FIDEOS_CON_TUCO.unCruceroPuedeHacerLosViajesDeOtro') IS NOT NULL
DROP FUNCTION FIDEOS_CON_TUCO.unCruceroPuedeHacerLosViajesDeOtro
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[cruceroParaReemplazarAOtro]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[cruceroParaReemplazarAOtro]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[crearCruceroIgualAlAnterior]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[crearCruceroIgualAlAnterior]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[actualizarViajesdeCruceroDadoDeBajaPermanente]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[actualizarViajesdeCruceroDadoDeBajaPermanente]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[actualizarPasajesDeCruceroDadoDeBajaPermanente]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[actualizarPasajesDeCruceroDadoDeBajaPermanente]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[actualizarViajesYPasajesDeCruceroDadoDeBajaPermanente]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[actualizarViajesYPasajesDeCruceroDadoDeBajaPermanente]
GO

if exists (select * from dbo.sysobjects where id =
object_id(N'[FIDEOS_CON_TUCO].[agregarTramo]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [FIDEOS_CON_TUCO].[agregarTramo]
GO

 if exists (select * from dbo.sysobjects where id=
 object_id(N'[FIDEOS_CON_TUCO].[mostrarViajesDeUnCrucero]') and OBJECTPROPERTY(id, N'IsProcedure')=1)
 drop procedure [FIDEOS_CON_TUCO].[mostrarViajesDeUnCrucero]
 GO

  if exists (select * from dbo.sysobjects where id=
 object_id(N'[FIDEOS_CON_TUCO].[mostrarCrucerosSinBajaPermanente]') and OBJECTPROPERTY(id, N'IsProcedure')=1)
 drop procedure [FIDEOS_CON_TUCO].[mostrarCrucerosSinBajaPermanente]
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
object_id(N'[FIDEOS_CON_TUCO].[Tipo_baja]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Tipo_baja]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Cancelacion_pasaje]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Cancelacion_pasaje]
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
object_id(N'[FIDEOS_CON_TUCO].[Tipo_medio_de_pago]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Tipo_medio_de_pago]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Tarjeta]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Tarjeta]
GO

if exists(select * from dbo.sysobjects where id = 
object_id(N'[FIDEOS_CON_TUCO].[Cantidad_cuotas]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [FIDEOS_CON_TUCO].[Cantidad_cuotas]
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
	[cabi_crucero] [varchar](255) NOT NULL)				
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
	[viaj_fecha_finalizacion] [datetime],
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


/********** <<TIPO_BAJA>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Tipo_baja] (
	[tipo_baja_codigo] int IDENTITY(1,1) NOT NULL,
	[tipo_baja_descripcion] varchar(255) NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Tipo_baja] ADD CONSTRAINT PK_TIPO_BAJA
	PRIMARY KEY ([tipo_baja_codigo])
GO


/********** <<REGISTRO_BAJA>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Registro_baja](
	[regi_codigo] int IDENTITY(1,1) NOT NULL,
	[regi_tipo] int NOT NULL,	
	[regi_crucero] [varchar](255) NOT NULL,			
	[regi_fecha_de_baja] [datetime] NOT NULL,
	[regi_fecha_de_alta] [datetime])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Registro_baja] ADD CONSTRAINT PK_REGISTRO_BAJA
	PRIMARY KEY ([regi_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Registro_baja] ADD CONSTRAINT FK_Crucero FOREIGN KEY ([regi_crucero])
	REFERENCES [FIDEOS_CON_TUCO].[Crucero]([cruc_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Registro_baja] ADD CONSTRAINT FK_Regi_tipo FOREIGN KEY ([regi_tipo])
	REFERENCES [FIDEOS_CON_TUCO].[Tipo_baja]([tipo_baja_codigo])
GO


/********** <<CLIENTE>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Cliente](
	[clie_codigo] int IDENTITY(1,1) NOT NULL,
	[clie_nombre] [varchar](255) NOT NULL,
	[clie_apellido] [varchar](255) NOT NULL,
	[clie_telefono] numeric(18,0) NOT NULL,
	[clie_mail] [varchar](255),
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
	[empr_descripcion] [varchar](255) NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Empresa_tarjeta] ADD CONSTRAINT PK_EMPRESA_TARJETA
	PRIMARY KEY ([empr_codigo])
GO


/********** <<CANTIDAD CUOTAS>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Cantidad_cuotas](
	[cant_codigo] int IDENTITY(1,1) NOT NULL,
	[cant_cantidad] int NOT NULL,
	[cant_empresa] int NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Cantidad_cuotas] ADD CONSTRAINT PK_CANTIDAD_CUOTAS
	PRIMARY KEY ([cant_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Cantidad_cuotas] ADD CONSTRAINT FK_Empresa_Cuotas FOREIGN KEY ([cant_empresa])
	REFERENCES [FIDEOS_CON_TUCO].[Empresa_tarjeta]([empr_codigo])
GO


/********** <<TARJETA>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Tarjeta](
	[tarj_numero] numeric(20,0) NOT NULL,
	[tarj_empresa] int NOT NULL,
	[tarj_codigo_verificador] int NOT NULL,
	[tarj_tipo] [varchar](255) NOT NULL CHECK([tarj_tipo] IN('DEBITO', 'CREDITO')))
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Tarjeta] ADD CONSTRAINT PK_TARJETA
	PRIMARY KEY ([tarj_numero])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Tarjeta] ADD CONSTRAINT FK_Empresa FOREIGN KEY ([tarj_empresa])
	REFERENCES [FIDEOS_CON_TUCO].[Empresa_tarjeta]([empr_codigo])
GO


/********** <<TIPO MEDIO DE PAGO>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Tipo_medio_de_pago](
	[tipo_medi_codigo] int IDENTITY(1,1) NOT NULL,
	[tipo_medi_descripcion] [varchar](255) NOT NULL)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Tipo_medio_de_pago] ADD CONSTRAINT PK_TIPO_MEDIO_DE_PAGO
	PRIMARY KEY ([tipo_medi_codigo])
GO


/********** <<MEDIO_DE_PAGO>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Medio_de_pago](
	[medi_codigo] int IDENTITY(1,1) NOT NULL,
	[medi_tipo] int NOT NULL,
	[medi_tarjeta] numeric(20,0),
	[medi_cantidad_de_cuotas] int)
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Medio_de_pago] ADD CONSTRAINT PK_MEDIO_DE_PAGO
	PRIMARY KEY ([medi_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Medio_de_pago] ADD CONSTRAINT FK_Tarjeta FOREIGN KEY ([medi_tarjeta])
	REFERENCES [FIDEOS_CON_TUCO].[Tarjeta]([tarj_numero])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Medio_de_pago] ADD CONSTRAINT FK_Tipo_Medio_De_Pago FOREIGN KEY ([medi_tipo])
	REFERENCES [FIDEOS_CON_TUCO].[Tipo_medio_de_pago]([tipo_medi_codigo])
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
	[pasa_precio] numeric (10,2),
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


/********** <<CANCELACION_PASAJE>> ************/


CREATE TABLE [FIDEOS_CON_TUCO].[Cancelacion_pasaje](
	[canc_pasa_codigo] int IDENTITY(1,1) NOT NULL,
	[canc_pasa_fecha] datetime NOT NULL,
	[canc_pasa_descripcion] varchar(255) NOT NULL,
	[canc_pasa_pasaje] int NOT NULL)

ALTER TABLE [FIDEOS_CON_TUCO].[Cancelacion_pasaje] ADD CONSTRAINT PK_CANCELACION_PASAJE
	PRIMARY KEY ([canc_pasa_codigo])
GO

ALTER TABLE [FIDEOS_CON_TUCO].[Cancelacion_pasaje] ADD CONSTRAINT FK_Canc_pasa_pasaje FOREIGN KEY ([canc_pasa_pasaje])
	REFERENCES [FIDEOS_CON_TUCO].[Pasaje]([pasa_codigo])
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
SELECT M1.CRUCERO_IDENTIFICADOR, marc_codigo, mode_codigo
, (SELECT COUNT(*) FROM (SELECT DISTINCT M2.CRUCERO_IDENTIFICADOR, M2.CABINA_NRO, M2.CABINA_PISO FROM gd_esquema.Maestra M2 
	WHERE M1.CRUCERO_IDENTIFICADOR = M2.CRUCERO_IDENTIFICADOR) AS cabinas), 1
FROM gd_esquema.Maestra M1
JOIN [FIDEOS_CON_TUCO].[Marca] ON (M1.CRU_FABRICANTE = marc_descripcion)
JOIN [FIDEOS_CON_TUCO].[Modelo] ON (M1.CRUCERO_MODELO = mode_descripcion)
GROUP BY M1.CRUCERO_IDENTIFICADOR, marc_codigo, mode_codigo
GO


/**********************************Carga de Cabinas**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Cabina](cabi_numero, cabi_piso, cabi_tipo, cabi_crucero)
SELECT DISTINCT CABINA_NRO, CABINA_PISO, tipo_codigo, cruc_codigo
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

INSERT INTO [FIDEOS_CON_TUCO].[Pasaje](pasa_codigo, pasa_cliente, pasa_viaje, pasa_cabina, pasa_compra, pasa_precio)
SELECT PASAJE_CODIGO, clie_codigo, viaj_codigo, cabi_codigo, comp_codigo, PASAJE_PRECIO
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


INSERT INTO [FIDEOS_CON_TUCO].[Pasaje](pasa_cliente, pasa_viaje, pasa_cabina, pasa_precio)
SELECT clie_codigo, viaj_codigo, cabi_codigo, RECORRIDO_PRECIO_BASE*CABINA_TIPO_PORC_RECARGO
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


/**********************Actualizo los precios de los pasajes para que concuerden con los de la compra**********************/


UPDATE [FIDEOS_CON_TUCO].[Pasaje] SET pasa_precio = comp_monto_total FROM [FIDEOS_CON_TUCO].[Pasaje]
JOIN [FIDEOS_CON_TUCO].[Compra] ON (comp_codigo = pasa_compra)
GO



/**********************************Carga de Cancelaciones de reservas**************************************************************************/


INSERT INTO [FIDEOS_CON_TUCO].[Cancelacion_reserva] (canc_reserva, canc_fecha)
SELECT rese_codigo, DATEADD(DAY, 4, rese_fecha)
FROM [FIDEOS_CON_TUCO].[Reserva]
JOIN [FIDEOS_CON_TUCO].[Pasaje] ON (pasa_codigo = rese_pasaje)
WHERE pasa_compra IS NULL
GO


/********************************** Modificaci�n de viajes que se realizan al mismo tiempo con el mismo crucero*********************************/  


CREATE PROCEDURE FIDEOS_CON_TUCO.correrViajesSuperpuestosUnDia @codigoViaje int, @codigoCrucero varchar(255), @fechaInicio datetime, @fechaFin datetime
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Viaje SET viaj_fecha_inicio = DATEADD(DAY, 1, viaj_fecha_inicio),
	viaj_fecha_finalizacion_estimada = DATEADD(DAY, 1, viaj_fecha_finalizacion_estimada),
	viaj_fecha_finalizacion = DATEADD(DAY, 1, viaj_fecha_finalizacion)
	WHERE viaj_crucero = @codigoCrucero AND viaj_codigo <> @codigoViaje AND
	(
	viaj_fecha_inicio BETWEEN @fechaInicio AND @fechaFin
	OR viaj_fecha_finalizacion_estimada BETWEEN @fechaInicio AND @fechaFin
	OR @fechaInicio BETWEEN viaj_fecha_inicio AND viaj_fecha_finalizacion_estimada
	OR @fechaFin BETWEEN viaj_fecha_inicio AND viaj_fecha_finalizacion_estimada
	)
END
GO



CREATE PROCEDURE FIDEOS_CON_TUCO.modificarViajesSuperpuestosConMismoCrucero
AS
BEGIN
	DECLARE @codigoViaje int, @codigoCrucero varchar(255), @fechaInicio datetime, @fechaFin datetime
	DECLARE c1 CURSOR DYNAMIC FOR SELECT viaj_codigo, viaj_crucero, viaj_fecha_inicio, viaj_fecha_finalizacion_estimada
	FROM FIDEOS_CON_TUCO.Viaje ORDER BY viaj_crucero, viaj_fecha_inicio
	FOR UPDATE 
	OPEN c1
	FETCH NEXT FROM c1 INTO @codigoViaje, @codigoCrucero, @fechaInicio, @fechaFin
	WHILE @@FETCH_STATUS = 0
	BEGIN
		EXEC correrViajesSuperpuestosUnDia @codigoViaje, @codigoCrucero, @fechaInicio, @fechaFin
		FETCH NEXT FROM c1 INTO @codigoViaje, @codigoCrucero, @fechaInicio, @fechaFin
	END
	CLOSE c1
	DEALLOCATE c1
END
GO

EXEC FIDEOS_CON_TUCO.modificarViajesSuperpuestosConMismoCrucero
GO


/************************** STORED PROCEDURES **************************/

/************************** ABM DE ROLES **************************/ 


/******************** CREAR UN ROL ********************/

/************* AGREGAR ROL *************/

CREATE PROCEDURE FIDEOS_CON_TUCO.agregarRol @rolAgregar varchar(255), @flag int output /* El flag est� para devolver un mensaje seg�n la situaci�n que se presente*/
AS
BEGIN
	if EXISTS(SELECT rol_descripcion FROM FIDEOS_CON_TUCO.Rol WHERE rol_descripcion = @rolAgregar)
		BEGIN
		SET @flag = 0
		RETURN
		END
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

CREATE PROCEDURE FIDEOS_CON_TUCO.actualizarNombreRol @codigo int, @nombreRol varchar(255), @resultado int output
AS
BEGIN
	IF EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Rol WHERE rol_descripcion = @nombreRol AND rol_codigo <> @codigo)
		BEGIN
		SET @resultado = 0
		RETURN
		END
	SET @resultado = 1 
	UPDATE FIDEOS_CON_TUCO.Rol SET rol_descripcion = @nombreRol WHERE rol_codigo = @codigo;
END
GO

/************* ELIMINAR UNA FUNCIONALIDAD DE UN ROL  *************/

CREATE PROCEDURE FIDEOS_CON_TUCO.eliminarFuncionalidadARol @nombreFuncionalidad varchar(255), @codigoRol int
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

CREATE PROCEDURE FIDEOS_CON_TUCO.deshabilitarRol @codigo int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Rol SET rol_esta_habilitado = 0 WHERE rol_codigo = @codigo;
	DELETE FROM FIDEOS_CON_TUCO.Rol_Por_Usuario WHERE rol_por_usua_rol = @codigo;
END
GO

/************* HABILITAR UN ROL *************/

CREATE PROCEDURE FIDEOS_CON_TUCO.habilitarRol @codigo int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Rol SET rol_esta_habilitado = 1 WHERE rol_codigo = @codigo
END
GO


/******************** MOSTRAR DATOS PARA BAJA Y MODIFICACION DE ROLES ********************/

/************* SP PARA MOSTRAR FUNCINALIDADES CANDIDATAS A SER AGREGADAS A UN ROL *************/

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarFuncionalidadesNoAgregadasARol @nombreRol varchar(255)
AS
BEGIN
	SELECT func_descripcion FROM FIDEOS_CON_TUCO.Funcionalidad
	WHERE func_codigo NOT IN (SELECT func_por_rol_funcionalidad FROM FIDEOS_CON_TUCO.Funcionalidad_por_rol, FIDEOS_CON_TUCO.Rol
							  WHERE func_por_rol_rol = rol_codigo AND rol_descripcion = @nombreRol)
END
GO

/************* SP PARA MOSTRAR TODOS LOS ROLES (SIRVE PARA ALTA Y BAJA DE ROLES YA CREADOS) *************/

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarRoles
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

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarFuncionalidadesAgregadasARol @nombreRol varchar(255)
AS
BEGIN
	SELECT func_descripcion FROM FIDEOS_CON_TUCO.Funcionalidad
	WHERE func_codigo IN (SELECT func_por_rol_funcionalidad FROM FIDEOS_CON_TUCO.Funcionalidad_por_rol, FIDEOS_CON_TUCO.Rol
						  where func_por_rol_rol = rol_codigo AND rol_descripcion = @nombreRol)
END
GO

/************* SP PARA MOSTRAR LOS ROLES QUE PUEDEN SER ELIMINADOS *************/

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarRolesHabilitados
AS
BEGIN
	SELECT rol_codigo AS Codigo, rol_descripcion AS Descripcion FROM FIDEOS_CON_TUCO.Rol
	WHERE rol_esta_habilitado = 1
END
GO



/************************** LOGIN Y SEGURIDAD **************************/


/******************** LOGUEO DE UN ADMINISTRADOR ********************/

/************* SUMA DE INTENTOS FALLIDOS  *************/

CREATE PROCEDURE FIDEOS_CON_TUCO.sumaDeIntentosFallidos @username varchar(255), @intentos_fallidos int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Usuario SET usua_intentos_fallidos = usua_intentos_fallidos + 1 WHERE usua_username = @username
	if(@intentos_fallidos = 2)
	/*if((SELECT usua_intentos_fallidos FROM FIDEOS_CON_TUCO.Usuario WHERE usua_username = @username) = 3)*/
		UPDATE FIDEOS_CON_TUCO.Usuario SET usua_esta_habilitado = 0 WHERE usua_username = @username	
END
GO

/************* CANCELAR RESERVAS EN EL LOGIN  *************/

CREATE PROCEDURE FIDEOS_CON_TUCO.cancelarReservas @fechaSistema datetime
AS
BEGIN
	INSERT INTO FIDEOS_CON_TUCO.Cancelacion_reserva(canc_fecha, canc_reserva, canc_detalle)
	SELECT @fechaSistema, rese_codigo, 'Reserva expirada' FROM FIDEOS_CON_TUCO.Reserva
	JOIN FIDEOS_CON_TUCO.Pasaje ON (pasa_codigo = rese_pasaje)
	WHERE DATEDIFF(DAY, rese_fecha, @fechaSistema) > 3 
	AND pasa_compra IS NULL
	AND NOT EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Cancelacion_pasaje WHERE rese_pasaje = canc_pasa_pasaje)
	AND NOT EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Cancelacion_reserva WHERE rese_codigo = canc_reserva)
END
GO

/************* LOGIN  *************/

CREATE PROCEDURE FIDEOS_CON_TUCO.adminLogin @username varchar(255), @password varchar(255), @fechaSistema datetime
AS
DECLARE @usua_contrasenia varchar(255)
DECLARE @usua_intentos_fallidos int
SELECT  @usua_contrasenia = usua_contrasenia, @usua_intentos_fallidos = usua_intentos_fallidos FROM	FIDEOS_CON_TUCO.Usuario WHERE usua_username = @username
/*IF POR SI NO ES LA CONTRASE�A*/
BEGIN
	if(HASHBYTES('SHA2_256', @password) <> @usua_contrasenia)
		EXEC FIDEOS_CON_TUCO.sumaDeIntentosFallidos @username, @usua_intentos_fallidos
END
/*IF PARA VER SI ES LA CONTRASE�A CORRECTA*/
BEGIN
	if(HASHBYTES('SHA2_256', @password) = @usua_contrasenia and @usua_intentos_fallidos < 3)
		BEGIN
		UPDATE	FIDEOS_CON_TUCO.Usuario SET	usua_intentos_fallidos = 0 WHERE usua_username = @username
		EXEC FIDEOS_CON_TUCO.cancelarReservas @fechaSistema
		END
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


/*######################## CREACION USUARIOS ADMINISTRATIVOS ############################*/


CREATE PROCEDURE FIDEOS_CON_TUCO.agregarUsuario @username varchar(255), @contrasenia varchar(255), @resultado int output
AS 
BEGIN
	IF NOT EXISTS(SELECT usua_username FROM FIDEOS_CON_TUCO.Usuario WHERE usua_username = @username)
		BEGIN
		INSERT INTO FIDEOS_CON_TUCO.Usuario(usua_username, usua_contrasenia, usua_esta_habilitado, usua_intentos_fallidos) 
			VALUES (@username, HASHBYTES('SHA2_256', @contrasenia), 1, 0) 
		SET @resultado = 1
		END
	ELSE
		SET @resultado = 0
END
GO


CREATE PROCEDURE FIDEOS_CON_TUCO.agregarRolAUnUsuario @nombreRol varchar(255), @username varchar(255)
AS
BEGIN
	IF NOT EXISTS (SELECT rol_por_usua_rol FROM FIDEOS_CON_TUCO.Rol_por_usuario 
			JOIN FIDEOS_CON_TUCO.Rol ON (rol_descripcion = @nombreRol)
			JOIN FIDEOS_CON_TUCO.Usuario ON (usua_username = @username)
			WHERE rol_por_usua_rol = rol_codigo AND rol_por_usua_usuario = usua_codigo)
		INSERT INTO FIDEOS_CON_TUCO.Rol_por_usuario(rol_por_usua_rol, rol_por_usua_usuario) 
			VALUES ((SELECT rol_codigo FROM FIDEOS_CON_TUCO.Rol WHERE rol_descripcion = @nombreRol)
			, (SELECT usua_codigo FROM FIDEOS_CON_TUCO.Usuario WHERE usua_username = @username))
END
GO

CREATE PROCEDURE FIDEOS_CON_TUCO.crearUsuariosIniciales
AS
BEGIN
	DECLARE @resultado int
	EXEC FIDEOS_CON_TUCO.agregarUsuario 'admin', 'w23e', @resultado
	EXEC FIDEOS_CON_TUCO.agregarUsuario 'BlacuttMatias', 'w23e', @resultado
	EXEC FIDEOS_CON_TUCO.agregarUsuario 'MonjaLucas', 'w23e', @resultado
	EXEC FIDEOS_CON_TUCO.agregarUsuario 'MontiFernando', 'w23e', @resultado
	EXEC FIDEOS_CON_TUCO.agregarUsuario 'MauroGaston', 'w23e', @resultado
	EXEC FIDEOS_CON_TUCO.agregarRolAUnUsuario 'Administrativo', 'admin'
	EXEC FIDEOS_CON_TUCO.agregarRolAUnUsuario 'Administrativo', 'BlacuttMatias' 
	EXEC FIDEOS_CON_TUCO.agregarRolAUnUsuario 'Administrativo', 'MonjaLucas'
	EXEC FIDEOS_CON_TUCO.agregarRolAUnUsuario 'Administrativo', 'MontiFernando' 
	EXEC FIDEOS_CON_TUCO.agregarRolAUnUsuario 'Administrativo', 'MauroGaston' 
END
GO

EXEC FIDEOS_CON_TUCO.crearUsuariosIniciales
GO


/*######################## [04]::[ABM Puerto] ############################*/


/************************** ALTA Puerto*******************************************/

CREATE PROCEDURE FIDEOS_CON_TUCO.agregarPuerto @ciudad varchar(255), @resultado int output, @descripcion varchar(255)= NULL
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

CREATE PROCEDURE FIDEOS_CON_TUCO.modificarPuerto @codigoPuerto int, @ciudad varchar(255), @resultado int output,@descripcion varchar(255) = NULL
AS
BEGIN
	IF EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = @ciudad AND puer_codigo <> @codigoPuerto)
		BEGIN
		SET @resultado = 0
		RETURN
		END
	SET @resultado = 1
	UPDATE [FIDEOS_CON_TUCO].[Puerto] SET puer_ciudad = @ciudad, puer_descripcion = @descripcion WHERE puer_codigo = @codigoPuerto
END
GO

/************************** BAJA LOGICA Puerto (DESHABILITAR)*******************************************/

CREATE FUNCTION FIDEOS_CON_TUCO.existenViajesConPasajesVendidosDeEsePuerto (@codigoPuerto int, @fechaSistema datetime) returns bit
AS
BEGIN
	DECLARE @resultado bit
	IF EXISTS(SELECT TOP 1 pasa_codigo FROM FIDEOS_CON_TUCO.Pasaje
		JOIN [FIDEOS_CON_TUCO].[Tramo] ON (tram_puerto_origen = @codigoPuerto OR tram_puerto_destino = @codigoPuerto)
		JOIN [FIDEOS_CON_TUCO].[Tramos_por_recorrido] ON (tram_por_reco_tramo = tram_codigo)
		JOIN FIDEOS_CON_TUCO.Recorrido ON (reco_id = tram_por_reco_recorrido)
		JOIN FIDEOS_CON_TUCO.Viaje ON (viaj_recorrido = reco_id)
		WHERE pasa_viaje = viaj_codigo AND viaj_fecha_inicio >= @fechaSistema AND NOT EXISTS (SELECT canc_codigo FROM FIDEOS_CON_TUCO.Cancelacion_reserva 
			JOIN FIDEOS_CON_TUCO.Reserva ON (rese_pasaje = pasa_codigo) WHERE canc_reserva = rese_codigo) AND 
			NOT EXISTS (SELECT canc_pasa_codigo FROM FIDEOS_CON_TUCO.Cancelacion_pasaje WHERE canc_pasa_pasaje = pasa_codigo)) 
		BEGIN
		RETURN 1
		END
	RETURN 0
END
GO
/*
CREATE PROCEDURE cancelarPasajesPorBajaDePuerto @codigoPuerto int, @fechaSistema datetime
AS
BEGIN
	IF FIDEOS_CON_TUCO.existenViajesConPasajesVendidosDeEsePuerto(@codigoPuerto) = 1
		BEGIN
		INSERT INTO FIDEOS_CON_TUCO.Cancelacion_pasaje(canc_pasa_pasaje, canc_pasa_descripcion, canc_pasa_fecha)
		SELECT pasa_codigo, 'Cancelacion por puerto deshabilitado', @fechaSistema FROM FIDEOS_CON_TUCO.Pasaje
		JOIN [FIDEOS_CON_TUCO].[Tramo] ON (tram_puerto_origen = @codigoPuerto OR tram_puerto_destino = @codigoPuerto)
		JOIN [FIDEOS_CON_TUCO].[Tramos_por_recorrido] ON (tram_por_reco_tramo = tram_codigo)
		JOIN FIDEOS_CON_TUCO.Recorrido ON (reco_id = tram_por_reco_recorrido)
		JOIN FIDEOS_CON_TUCO.Viaje ON (viaj_recorrido = reco_id)
		WHERE pasa_viaje = viaj_codigo AND NOT EXISTS (SELECT canc_codigo FROM FIDEOS_CON_TUCO.Cancelacion_reserva 
			JOIN FIDEOS_CON_TUCO.Reserva ON (rese_pasaje = pasa_codigo) WHERE canc_reserva = rese_codigo) AND 
			NOT EXISTS (SELECT canc_pasa_codigo FROM FIDEOS_CON_TUCO.Cancelacion_pasaje WHERE canc_pasa_pasaje = pasa_codigo)
		END
END
GO
*/
CREATE PROCEDURE FIDEOS_CON_TUCO.deshabilitarPuerto @codigoPuerto int
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

CREATE PROCEDURE FIDEOS_CON_TUCO.habilitarPuerto @codigoPuerto int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Puerto SET puer_esta_habilitado = 1 WHERE puer_codigo = @codigoPuerto
END
GO

/************************** LISTADO Todos los Puertos *******************************************/

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarPuertos
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

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarPuertosHabilitados 
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

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarPuertosDeshabilitados 
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
CREATE PROCEDURE FIDEOS_CON_TUCO.agregarRecorrido @ciudadPuertoOrigen varchar (255), @ciudadPuertoDestino varchar(255), @precio numeric (10,2), @resultado int output, @codigoRecorrido int = NULL
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


CREATE PROCEDURE FIDEOS_CON_TUCO.agregarTramo @ciudadPuertoOrigen varchar(255), @ciudadPuertoDestino varchar(255), @precio numeric(10, 2)
AS
BEGIN
	IF EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Tramo JOIN FIDEOS_CON_TUCO.Puerto p1 ON (p1.puer_codigo = tram_puerto_origen)
			JOIN FIDEOS_CON_TUCO.Puerto p2 ON (p2.puer_codigo = tram_puerto_destino) 
			WHERE p1.puer_ciudad = @ciudadPuertoOrigen AND p2.puer_ciudad = @ciudadPuertoDestino)
		BEGIN
		UPDATE FIDEOS_CON_TUCO.Tramo SET tram_precio = @precio FROM FIDEOS_CON_TUCO.Tramo
			JOIN FIDEOS_CON_TUCO.Puerto p1 ON (p1.puer_codigo = tram_puerto_origen)
			JOIN FIDEOS_CON_TUCO.Puerto p2 ON (p2.puer_codigo = tram_puerto_destino) 
			WHERE p1.puer_ciudad = @ciudadPuertoOrigen AND p2.puer_ciudad = @ciudadPuertoDestino
		UPDATE FIDEOS_CON_TUCO.Tramo SET tram_precio = @precio FROM FIDEOS_CON_TUCO.Tramo
			JOIN FIDEOS_CON_TUCO.Puerto p1 ON (p1.puer_codigo = tram_puerto_origen)
			JOIN FIDEOS_CON_TUCO.Puerto p2 ON (p2.puer_codigo = tram_puerto_destino) 
			WHERE p1.puer_ciudad = @ciudadPuertoDestino AND p2.puer_ciudad = @ciudadPuertoOrigen
		END
	INSERT INTO FIDEOS_CON_TUCO.Tramo(tram_puerto_origen, tram_puerto_destino, tram_precio)
		SELECT p1.puer_codigo, p2.puer_codigo, @precio FROM FIDEOS_CON_TUCO.Puerto p1
		JOIN FIDEOS_CON_TUCO.Puerto p2 ON (p2.puer_ciudad = @ciudadPuertoDestino) 
		WHERE p1.puer_ciudad = @ciudadPuertoOrigen
END
GO


CREATE PROCEDURE FIDEOS_CON_TUCO.agregarTramoAUnRecorrido @ciudadPuertoOrigen varchar(255), @ciudadPuertoDestino varchar(255), @precio numeric(10,2), @idRecorrido int
AS
BEGIN
	DECLARE @codigoPuertoOrigen int
	DECLARE @codigoPuertoDestino int
	SELECT @codigoPuertoOrigen = puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = @ciudadPuertoOrigen
	SELECT @codigoPuertoDestino = puer_codigo FROM FIDEOS_CON_TUCO.Puerto WHERE puer_ciudad = @ciudadPuertoDestino
	--IF NOT EXISTS (SELECT tram_codigo FROM FIDEOS_CON_TUCO.Tramo WHERE tram_puerto_origen = @codigoPuertoOrigen AND tram_puerto_destino = @codigoPuertoDestino)
	--	INSERT INTO FIDEOS_CON_TUCO.Tramo(tram_puerto_origen, tram_puerto_destino, tram_precio) VALUES (@codigoPuertoOrigen, @codigoPuertoDestino, @precio)
	DECLARE @codigoTramo int
	SELECT @codigoTramo = tram_codigo FROM FIDEOS_CON_TUCO.Tramo WHERE tram_puerto_origen = @codigoPuertoOrigen AND tram_puerto_destino = @codigoPuertoDestino
	INSERT INTO FIDEOS_CON_TUCO.Tramos_por_recorrido(tram_por_reco_tramo, tram_por_reco_recorrido) VALUES (@codigoTramo, @idRecorrido)
END
GO


/************************** MODIFICACION Recorrido*******************************************/


CREATE PROCEDURE FIDEOS_CON_TUCO.modificarRecorrido @idRecorrido int, @ciudadPuertoOrigen varchar(255), @ciudadPuertoDestino varchar(255), @precio numeric(10,2), @codigoRecorrido int = NULL
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


CREATE PROCEDURE FIDEOS_CON_TUCO.eliminarTramoDeUnRecorrido @ciudadPuertoOrigen varchar(255), @ciudadPuertoDestino varchar(255), @idRecorrido int
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

CREATE PROCEDURE FIDEOS_CON_TUCO.deshabilitarRecorrido @idRecorrido int
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Recorrido SET reco_esta_habilitado = 0 WHERE reco_id = @idRecorrido
END
GO

/************************** HABILITAR Recorrido *******************************************/

CREATE PROCEDURE FIDEOS_CON_TUCO.habilitarRecorrido @idRecorrido int, @resultado int output
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

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarRecorridos
AS
BEGIN
	SELECT reco_id AS ID, puertoOrigen.puer_ciudad AS Puerto_origen, 
		puertoDestino.puer_ciudad AS Puerto_destino
		, reco_precio AS Precio
		, FIDEOS_CON_TUCO.stringConPuertosDeUnRecorrido(reco_id) AS Recorrido
		, CASE WHEN reco_esta_habilitado = 1 THEN 'SI'
			ELSE 'NO'
		END AS Habilitado
		FROM FIDEOS_CON_TUCO.Recorrido
		JOIN FIDEOS_CON_TUCO.Puerto puertoOrigen ON (puertoOrigen.puer_codigo = reco_puerto_origen)
		JOIN FIDEOS_CON_TUCO.Puerto puertoDestino ON (puertoDestino.puer_codigo = reco_puerto_destino)
END
GO

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarRecorridosHabilitados
AS
BEGIN
	SELECT reco_id AS ID, puertoOrigen.puer_ciudad AS Puerto_origen, puertoDestino.puer_ciudad AS Puerto_destino, reco_precio AS Precio
		FROM FIDEOS_CON_TUCO.Recorrido 
		JOIN FIDEOS_CON_TUCO.Puerto puertoOrigen ON (puertoOrigen.puer_codigo = reco_puerto_origen)
		JOIN FIDEOS_CON_TUCO.Puerto puertoDestino ON (puertoDestino.puer_codigo = reco_puerto_destino)
		WHERE reco_esta_habilitado = 1
END
GO

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarRecorridosDeshabilitados
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

CREATE PROCEDURE [FIDEOS_CON_TUCO].[mostrarTramosDeUnRecorrido] @idRecorrido int
AS
BEGIN
	SELECT tram_codigo AS Codigo, puertoOrigen.puer_ciudad AS Origen, puertoDestino.puer_ciudad AS Destino, tram_precio as Precio
		FROM FIDEOS_CON_TUCO.Tramo
		JOIN FIDEOS_CON_TUCO.Tramos_por_recorrido ON (tram_por_reco_recorrido = @idRecorrido)
		JOIN FIDEOS_CON_TUCO.Puerto puertoOrigen ON (puertoOrigen.puer_codigo = tram_puerto_origen)
		JOIN FIDEOS_CON_TUCO.Puerto puertoDestino ON (puertoDestino.puer_codigo = tram_puerto_destino)
		WHERE tram_codigo = tram_por_reco_tramo
END
GO


/*######################## [04]::[ABM Cruceros] ############################*/


/******************************* funciones para determinar si un crucero esta habilitado en una fecha *********************************/


CREATE FUNCTION FIDEOS_CON_TUCO.unCruceroEstaHabilitadoDurante (@codigoCrucero varchar(255), @fechaInicio datetime, @fechaFin datetime) RETURNS bit
AS
BEGIN
	IF EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Registro_baja JOIN FIDEOS_CON_TUCO.Tipo_baja ON (tipo_baja_codigo = regi_tipo) 
			WHERE regi_crucero = @codigoCrucero AND tipo_baja_descripcion = 'Temporal'
			AND (
				(regi_fecha_de_baja <= @fechaInicio AND @fechaInicio < regi_fecha_de_alta)
				OR (regi_fecha_de_baja <= @fechaFin AND @fechaFin <= regi_fecha_de_alta)
				OR (@fechaInicio <= regi_fecha_de_baja AND regi_fecha_de_baja <= @fechaFin)
				OR (@fechaInicio < regi_fecha_de_alta AND regi_fecha_de_alta <= @fechaFin)
			))
			OR EXISTS (SELECT * FROM FIDEOS_CON_TUCO.Registro_baja JOIN FIDEOS_CON_TUCO.Tipo_baja ON (tipo_baja_codigo = regi_tipo) 
			WHERE regi_crucero = @codigoCrucero AND tipo_baja_descripcion = 'Permanente'
			AND (regi_fecha_de_baja < @fechaInicio OR regi_fecha_de_baja < @fechaFin))
		BEGIN
		RETURN 0
		END
	RETURN 1
END
GO


CREATE FUNCTION FIDEOS_CON_TUCO.unCruceroEstaHabilitado (@codigoCrucero varchar(255), @fechaSistema datetime) RETURNS bit
AS
BEGIN
	IF EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Registro_baja JOIN FIDEOS_CON_TUCO.Tipo_baja ON (tipo_baja_codigo = regi_tipo) 
			WHERE regi_crucero = @codigoCrucero AND tipo_baja_descripcion = 'Temporal'
			AND regi_fecha_de_baja <= @fechaSistema AND @fechaSistema < regi_fecha_de_alta)
			OR EXISTS (SELECT * FROM FIDEOS_CON_TUCO.Registro_baja JOIN FIDEOS_CON_TUCO.Tipo_baja ON (tipo_baja_codigo = regi_tipo) 
			WHERE regi_crucero = @codigoCrucero AND tipo_baja_descripcion = 'Permanente'
			AND regi_fecha_de_baja < @fechaSistema)
		BEGIN
		RETURN 0
		END
	RETURN 1
END
GO



/************************** ACTUALIZACION de cruceros habilitados *******************************************/
--se llama al comienzo de la App para actualizar el campo cruc_esta_habilitado de los cruceros cuya fecha de alta en la baja ya se cumplio

CREATE PROCEDURE FIDEOS_CON_TUCO.actualizarCrucerosHabilitados @fechaSistema datetime
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Crucero SET cruc_esta_habilitado = 1 FROM FIDEOS_CON_TUCO.Crucero
		WHERE FIDEOS_CON_TUCO.unCruceroEstaHabilitado(cruc_codigo, @fechaSistema) = 1 AND cruc_esta_habilitado = 0
END
GO



/************************** CREACION de tipos de baja de los cruceros *******************************************/

CREATE PROCEDURE FIDEOS_CON_TUCO.cargarTiposdeBajasDeCrucerosIniciales
AS
BEGIN
	INSERT INTO FIDEOS_CON_TUCO.Tipo_baja(tipo_baja_descripcion) VALUES ('Permanente')
	INSERT INTO FIDEOS_CON_TUCO.Tipo_baja(tipo_baja_descripcion) VALUES ('Temporal')
END
GO

EXEC FIDEOS_CON_TUCO.cargarTiposdeBajasDeCrucerosIniciales
GO

/*************************** ALTA CRUCEROS ***************************/

CREATE PROCEDURE FIDEOS_CON_TUCO.agregarCrucero @cruceroCodigo varchar(255),@cruceroMarca varchar(255), @cruceroModelo varchar(255),@cantidadCabinas int,@fecha DateTime, @resultado int output
AS 
BEGIN
	DECLARE @codigoMarca int
	DECLARE @codigoModelo int
	SELECT @codigoMarca = marc_codigo FROM FIDEOS_CON_TUCO.Marca WHERE marc_descripcion = @cruceroMarca
	SELECT @codigoModelo = mode_codigo FROM FIDEOS_CON_TUCO.Modelo WHERE mode_descripcion = @cruceroModelo
	IF NOT EXISTS(SELECT cruc_codigo FROM FIDEOS_CON_TUCO.Crucero WHERE cruc_codigo = @cruceroCodigo)
		BEGIN
		INSERT INTO FIDEOS_CON_TUCO.Crucero(cruc_codigo,cruc_marca, cruc_modelo, cruc_cantidad_cabinas, cruc_esta_habilitado, cruc_fecha_de_alta) 
			VALUES (@cruceroCodigo,@codigoMarca, @codigoModelo, @cantidadCabinas, 1, @fecha) 
		SET @resultado = 1
		END
	ELSE
		SET @resultado = 0
END
GO

CREATE PROCEDURE FIDEOS_CON_TUCO.agregarCabinaAUnCrucero @cabiCrucero varchar(255),@cabiNumero int,@cabiPiso int, @cabiTipo varchar(255)
AS
BEGIN
	DECLARE @codigoTipoCabina int
	SELECT @codigoTipoCabina = tipo_codigo FROM FIDEOS_CON_TUCO.Tipo_cabina WHERE tipo_descripcion = @cabiTipo
	IF NOT EXISTS (SELECT cabi_codigo FROM FIDEOS_CON_TUCO.Cabina WHERE cabi_crucero = @cabiCrucero AND cabi_piso = @cabiPiso AND cabi_numero=@cabiNumero)
			INSERT INTO FIDEOS_CON_TUCO.Cabina(cabi_crucero, cabi_piso,cabi_numero,cabi_tipo) VALUES (@cabiCrucero, @cabiPiso,@cabiNumero,@codigoTipoCabina)
END
GO
/*************************** MODIFICAR MARCAS DE CRUCERO ***************************/
CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarMarcas
AS
BEGIN
	SELECT marc_codigo as Codigo, marc_descripcion as Marca FROM FIDEOS_CON_TUCO.Marca
END
GO
/*************************** MODIFICAR MODELOS DE CRUCERO ***************************/
CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarModelos
AS
BEGIN
	SELECT mode_codigo as Codigo, mode_descripcion as Modelo FROM FIDEOS_CON_TUCO.Modelo
END
GO
/*************************** MOSTRAR CRUCEROS ***************************/
CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarCruceros
AS
BEGIN
	SELECT [cruc_codigo] as Codigo, 
		[marc_descripcion] as Marca,
		[mode_descripcion] as Modelo,
		[cruc_cantidad_cabinas] as 'Cantidad de Cabinas',
		[cruc_fecha_de_alta] as 'Fecha de Alta',
		CASE WHEN cruc_esta_habilitado = 1 THEN 'SI'
		     WHEN cruc_esta_habilitado = 0 THEN 'NO'
		END as Habilitado
	FROM [FIDEOS_CON_TUCO].[Crucero]
	JOIN [FIDEOS_CON_TUCO].[Marca] on ([cruc_marca]=marc_codigo)
	JOIN [FIDEOS_CON_TUCO].[Modelo] on ([cruc_modelo]=mode_codigo)
END
GO
/*************************** MODIFICAR CRUCEROS ***************************/
CREATE PROCEDURE [FIDEOS_CON_TUCO].[modificarCrucero] @cruceroCodigo Varchar(255), @cruceroMarca Varchar(255), @cruceroModelo Varchar(255)
AS
BEGIN
	DECLARE @codigoMarca int
	DECLARE @codigoModelo int
	SELECT @codigoMarca = marc_codigo FROM [FIDEOS_CON_TUCO].[Marca] WHERE marc_descripcion=@cruceroMarca
	SELECT @codigoModelo = mode_codigo FROM [FIDEOS_CON_TUCO].[Modelo] WHERE mode_descripcion=@cruceroModelo
	UPDATE [FIDEOS_CON_TUCO].[Crucero] SET cruc_marca = @codigoMarca, cruc_modelo = @codigoModelo WHERE cruc_codigo = @cruceroCodigo
END
GO

/*************************** LISTADO DE CABINAS  ***************************/

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarCabinasDeUnCrucero @cruceroCodigo varchar(255)
AS
BEGIN
	SELECT [cabi_codigo] as Codigo
      ,[cabi_numero] as Numero
      ,[cabi_piso] as Piso
      ,[tipo_descripcion] as Descripcion
      ,[cabi_crucero] as Crucero
  FROM [GD1C2019].[FIDEOS_CON_TUCO].[Cabina]
  JOIN [GD1C2019].[FIDEOS_CON_TUCO].[Tipo_cabina] on (cabi_tipo=tipo_codigo)
  WHERE cabi_crucero=@cruceroCodigo
  Order by cabi_piso,cabi_numero
END
GO

/*************************** LISTADO DE TIPOS DE CABINAS  ***************************/

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarTipoCabinas
AS
BEGIN
	SELECT tipo_codigo as Codigo, tipo_descripcion as Cabina FROM FIDEOS_CON_TUCO.Tipo_cabina
END
GO
/*************************** LISTADO DE TIPOS DE BAJAS  ***************************/
CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarTipoBaja
AS
BEGIN
	SELECT [tipo_baja_codigo] as Codigo
			,[tipo_baja_descripcion] as Descripcion
	FROM [GD1C2019].[FIDEOS_CON_TUCO].[Tipo_baja]
END
GO
/*************************** LISTADO DE VIAJES DE UN CRUCERO **********************/
CREATE PROCEDURE [FIDEOS_CON_TUCO].[mostrarViajesDeUnCrucero] @crucero_a_dar_de_baja varchar(255), @inicio DateTime, @fin DateTime
AS
BEGIN
	SELECT viaj_codigo as Codigo, viaj_fecha_inicio as 'Fecha Inicio',  viaj_fecha_finalizacion_estimada as 'Fecha Finalizacion' 
	FROM FIDEOS_CON_TUCO.Viaje join FIDEOS_CON_TUCO.Pasaje on (viaj_codigo=pasa_viaje)
	WHERE viaj_crucero = @crucero_a_dar_de_baja 
			AND viaj_fecha_inicio >= @inicio 
			AND viaj_fecha_finalizacion_estimada <= @fin
			AND pasa_codigo not in (SELECT canc_pasa_pasaje FROM [FIDEOS_CON_TUCO].Cancelacion_pasaje)
			AND pasa_compra is not NULL
	GROUP By viaj_codigo,viaj_fecha_inicio,viaj_fecha_finalizacion_estimada
END
GO

/*****************************LISTADO CRUCEROS SIN BAJA PERMANENTE *****************************/

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarCrucerosSinBajaPermanente @fechaSistema DateTime
AS
BEGIN
	SELECT cruc_codigo AS Codigo_crucero
		, marc_descripcion AS Marca
		, mode_descripcion AS Modelo
		, cruc_cantidad_cabinas AS Cantidad_cabinas
		, cruc_fecha_de_alta AS Fecha_de_alta
	FROM FIDEOS_CON_TUCO.Crucero 
	JOIN FIDEOS_CON_TUCO.Marca ON (marc_codigo = cruc_marca)
	JOIN FIDEOS_CON_TUCO.Modelo ON (mode_codigo = cruc_modelo)
	WHERE NOT EXISTS (SELECT * FROM FIDEOS_CON_TUCO.Registro_baja
		JOIN FIDEOS_CON_TUCO.Tipo_baja ON (tipo_baja_codigo = regi_tipo)
		WHERE regi_crucero = cruc_codigo 
			AND tipo_baja_descripcion = 'Permanente'
			AND regi_fecha_de_baja <= @fechaSistema
		)
END
GO

/*************************** LISTADO DE TIPOS DE BAJAS  ***************************/
CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarBajas
AS
BEGIN
SELECT [cruc_codigo] as Codigo
      ,[tipo_baja_descripcion] as 'Tipo Baja'
      ,[regi_fecha_de_baja] as 'Fecha de Baja'
      ,[regi_fecha_de_alta] as 'Fecha de Alta'
  FROM [GD1C2019].[FIDEOS_CON_TUCO].[Crucero]
  JOIN [GD1C2019].[FIDEOS_CON_TUCO].[Registro_baja] on (regi_crucero=cruc_codigo)
  JOIN [GD1C2019].[FIDEOS_CON_TUCO].[Tipo_baja] on (regi_tipo=tipo_baja_codigo)
END
GO
/*************************** Consulta de Viajes Existentes de un Crucero  ***************************/
CREATE PROCEDURE FIDEOS_CON_TUCO.cruceroTieneViajes @codigoCrucero varchar(255), @fecha DateTime, @respuesta int output
AS
BEGIN
	IF EXISTS(SELECT COUNT(*) FROM [GD1C2019].[FIDEOS_CON_TUCO].[Viaje] WHERE viaj_crucero=@codigoCrucero 
	AND YEAR(viaj_fecha_inicio) >= YEAR(@fecha)
	AND MONTH(viaj_fecha_inicio) >= MONTH(@fecha)
	AND DAY(viaj_fecha_inicio) >= DAY(@fecha))
		SET @respuesta = 1
	ElSE
		SET @respuesta = 0
END
GO
/*************************** MODIFICAR TIPO DE CABINA ***************************/

--CREATE PROCEDURE modificarTipoCabina @cabina_codigo int, @cabina_tipo int
--AS
--BEGIN
--	UPDATE FIDEOS_CON_TUCO.Cabina SET cabi_tipo = @cabina_tipo WHERE cabi_codigo = @cabina_codigo
--END
--GO

/*************************** CORRIMIENTO DE DIAS POR ESTAR FUERA DE SERVICIO ***************************/
/*Se ejecuta cuando se decide no cancelar los pasajes y el crucero est� fuera de servicio*/

CREATE PROCEDURE FIDEOS_CON_TUCO.corrimientoDiasViaje @crucero_codigo varchar(255), @corrimiento int, @fechaInicioBajaTemporal datetime
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Viaje 
	SET viaj_fecha_inicio = DATEADD (DAY, @corrimiento, viaj_fecha_inicio) 
		, viaj_fecha_finalizacion = DATEADD (DAY, @corrimiento, viaj_fecha_finalizacion)
		, viaj_fecha_finalizacion_estimada = DATEADD(DAY, @corrimiento, viaj_fecha_finalizacion_estimada)
	WHERE viaj_crucero = @crucero_codigo 
	AND viaj_fecha_inicio >= @fechaInicioBajaTemporal 
END
GO


/*************************** CRUCERO DISPONIBLE PARA REEMPLAZAR A OTRO DADO DE BAJA PERMANENTE ***************************/

/*Se debe ejecutar tantas veces como viajes tenga el crucero que se da de baja*/

/*
CREATE FUNCTION FIDEOS_CON_TUCO.comparacionCruceros (@codigo_crucero_anterior varchar(255), @codigo_crucero_nuevo varchar(255))
RETURNS bit
AS
BEGIN
	DECLARE @cantidad_nueva int
	DECLARE @tipo_cabina int
	DECLARE @cantidad int
	DECLARE cCabinas CURSOR FOR	SELECT cabi_tipo, count(cabi_codigo) FROM FIDEOS_CON_TUCO.Cabina 
								WHERE cabi_crucero = @codigo_crucero_anterior
								GROUP BY cabi_tipo ORDER BY cabi_tipo
	OPEN cCabinas
	FETCH NEXT FROM cCabinas INTO @tipo_cabina, @cantidad
	WHILE(@@FETCH_STATUS = 0)
	BEGIN
		SELECT @cantidad_nueva = count(cabi_codigo) FROM FIDEOS_CON_TUCO.Cabina 
		WHERE cabi_crucero = @codigo_crucero_nuevo AND cabi_tipo = @tipo_cabina
		GROUP BY cabi_tipo ORDER BY	cabi_tipo
		if (@cantidad_nueva < @cantidad)
			RETURN 0
		FETCH NEXT FROM cCabinas INTO @tipo_cabina, @cantidad
	END
	RETURN 1
END
GO
*/


CREATE FUNCTION FIDEOS_CON_TUCO.unCruceroEsIgualAOtro (@codigoCrucero varchar(255), @codigoOtroCrucero varchar(255)) RETURNS bit
AS
BEGIN
	DECLARE @modelo int, @marca int, @cantidadCabinas int
	SELECT @modelo = cruc_modelo, @marca = cruc_marca, @cantidadCabinas = cruc_cantidad_cabinas FROM FIDEOS_CON_TUCO.Crucero WHERE cruc_codigo = @codigoCrucero
	IF NOT EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Crucero WHERE cruc_codigo = @codigoOtroCrucero 
			AND cruc_marca = @marca AND cruc_marca = @marca AND cruc_cantidad_cabinas = @cantidadCabinas)
		BEGIN
		RETURN 0
		END
	DECLARE @numeroCabina int, @pisoCabina int, @tipoCabina int
	DECLARE c1 CURSOR FOR SELECT cabi_numero, cabi_piso, cabi_tipo FROM FIDEOS_CON_TUCO.Cabina WHERE cabi_crucero = @codigoCrucero
	OPEN c1
	FETCH NEXT FROM c1 INTO @numeroCabina, @pisoCabina, @tipoCabina
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF NOT EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Cabina WHERE cabi_crucero = @codigoOtroCrucero
				AND cabi_piso = @pisoCabina AND cabi_tipo = @tipoCabina AND cabi_numero = @numeroCabina)
			BEGIN
			RETURN 0
			END
		FETCH NEXT FROM c1 INTO @numeroCabina, @pisoCabina, @tipoCabina
	END
	CLOSE c1
	DEALLOCATE c1
	RETURN 1
END
GO


CREATE FUNCTION FIDEOS_CON_TUCO.unCruceroPuedeHacerLosViajesDeOtro(@codigoCruceroAReemplazar varchar(255), @codigoCruceroQueLoReemplaza varchar(255)
, @fechaBajaCruceroAReemplazar datetime) RETURNS bit
AS
BEGIN
	DECLARE @fechaInicioViaje datetime, @fechaFinalizacionViaje datetime
	DECLARE c1 CURSOR FOR SELECT viaj_fecha_inicio, viaj_fecha_finalizacion_estimada FROM FIDEOS_CON_TUCO.Viaje 
		WHERE viaj_crucero = @codigoCruceroAReemplazar AND viaj_fecha_inicio >= @fechaBajaCruceroAReemplazar
	OPEN c1
	FETCH NEXT FROM c1 INTO @fechaInicioViaje, @fechaFinalizacionViaje
	WHILE @@FETCH_STATUS = 0
	BEGIN
		--Si el crucero que los intenta reemplazar no puede cubrir un viaje porque ya tiene un viaje programado 
		--para esas fechas o porque no va a estar habilitado en esas fechas
		IF(FIDEOS_CON_TUCO.unCruceroTieneViajesDurante(@codigoCruceroQueLoReemplaza, @fechaInicioViaje, @fechaFinalizacionViaje) = 1
				OR FIDEOS_CON_TUCO.unCruceroEstaHabilitadoDurante(@codigoCruceroQueLoReemplaza, @fechaInicioViaje, @fechaFinalizacionViaje) = 0)
			BEGIN
			RETURN 0
			END
		FETCH NEXT FROM c1 INTO @fechaInicioViaje, @fechaFinalizacionViaje
	END
	CLOSE c1
	DEALLOCATE c1
	RETURN 1
END
GO

--Este SP se debe ejecutar para obtener un crucero que pueda reemplazar a otro dado de baja permanente
--Si devuelve el SELECT vac�o es porque no existe uno que lo pueda reemplazar

CREATE PROCEDURE FIDEOS_CON_TUCO.cruceroParaReemplazarAOtro @codigoCruceroAReemplazar varchar(255), @fechaBajaPermanente datetime
AS
BEGIN
	SELECT TOP 1 cruc_codigo AS Codigo FROM FIDEOS_CON_TUCO.Crucero
	WHERE cruc_codigo <> @codigoCruceroAReemplazar
	AND FIDEOS_CON_TUCO.unCruceroEsIgualAOtro(@codigoCruceroAReemplazar, cruc_codigo) = 1
	AND FIDEOS_CON_TUCO.unCruceroPuedeHacerLosViajesDeOtro(@codigoCruceroAReemplazar, cruc_codigo, @fechaBajaPermanente) = 1
END
GO


/*************************** GENERO UN CRUCERO NUEVO IGUAL AL DADO DE BAJA PERMANENTE ***************************/


--Se deber�a ejecutar este SP en el caso de que se desee reemplazar un crucero dado de baja permanente y no exista uno que lo pueda hacer
--devuelve 1 si se pudo crear el nuevo crucero o 0 si no se puedo crear porque ya existe un crucero con ese codigo nuevo
CREATE PROCEDURE FIDEOS_CON_TUCO.crearCruceroIgualAlAnterior @codigoCruceroAnterior varchar(255), @codigoNuevoCrucero varchar(255)
, @fechaAltaCruceroNuevo datetime, @resultado int output
AS
BEGIN
	IF EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Crucero WHERE cruc_codigo = @codigoNuevoCrucero)
		BEGIN
		SET @resultado = 0
		RETURN
		END

	SET @resultado = 1
	DECLARE @marca int, @modelo int, @cantidadCabinas int

	SELECT @marca = cruc_marca, @modelo = cruc_modelo, @cantidadCabinas = cruc_cantidad_cabinas FROM FIDEOS_CON_TUCO.Crucero 
		WHERE cruc_codigo = @codigoCruceroAnterior

	INSERT INTO FIDEOS_CON_TUCO.Crucero(cruc_codigo, cruc_modelo, cruc_marca, cruc_cantidad_cabinas, cruc_esta_habilitado, cruc_fecha_de_alta)
		VALUES (@codigoNuevoCrucero, @modelo, @marca, @cantidadCabinas, 1, @fechaAltaCruceroNuevo)

	INSERT INTO FIDEOS_CON_TUCO.Cabina(cabi_crucero, cabi_numero, cabi_piso, cabi_tipo)
		SELECT @codigoNuevoCrucero, cabi_numero, cabi_piso, cabi_tipo 
		FROM FIDEOS_CON_TUCO.Cabina 
		WHERE cabi_crucero = @codigoCruceroAnterior
END
GO

/*************************** REASIGNACI�N DE PASAJES Y VIAJES DEL CRUCERO DADO DE BAJA PERMANENTE ***************************/


CREATE PROCEDURE FIDEOS_CON_TUCO.actualizarViajesdeCruceroDadoDeBajaPermanente @codigoCruceroReemplazado varchar(255)
, @codigoCruceroQueLoReemplazo varchar(255), @fechaBajaPermanenteDeCruceroReemplazado datetime
AS 
BEGIN
	UPDATE FIDEOS_CON_TUCO.Viaje SET viaj_crucero = @codigoCruceroQueLoReemplazo FROM FIDEOS_CON_TUCO.Viaje
	WHERE viaj_crucero = @codigoCruceroReemplazado AND viaj_fecha_inicio >= @fechaBajaPermanenteDeCruceroReemplazado
END
GO


CREATE PROCEDURE FIDEOS_CON_TUCO.actualizarPasajesDeCruceroDadoDeBajaPermanente @codigoCruceroReemplazado varchar(255)
, @codigoCruceroQueLoReemplazo varchar(255), @fechaBajaPermanenteDeCruceroReemplazado datetime
AS
BEGIN

	UPDATE FIDEOS_CON_TUCO.Pasaje SET pasa_cabina = c2.cabi_codigo FROM FIDEOS_CON_TUCO.Pasaje
	JOIN FIDEOS_CON_TUCO.Viaje ON (viaj_codigo = pasa_viaje)
	JOIN FIDEOS_CON_TUCO.Cabina c1 ON (c1.cabi_codigo = pasa_cabina) 
	JOIN FIDEOS_CON_TUCO.Cabina c2 ON (c2.cabi_numero = c1.cabi_numero AND c2.cabi_piso = c1.cabi_piso AND c2.cabi_crucero = @codigoCruceroQueLoReemplazo)
	WHERE viaj_crucero = @codigoCruceroReemplazado AND viaj_fecha_inicio >= @fechaBajaPermanenteDeCruceroReemplazado
END
GO


--Se debe ejecutar solo este SP para actualizar los viajes y pasajes al crucero que reemplazara al dado de baja permanente
CREATE PROCEDURE FIDEOS_CON_TUCO.actualizarViajesYPasajesDeCruceroDadoDeBajaPermanente @codigoCruceroReemplazado varchar(255)
, @codigoCruceroQueLoReemplazo varchar(255), @fechaBajaPermanenteDeCruceroReemplazado datetime
AS
BEGIN
	EXEC FIDEOS_CON_TUCO.actualizarPasajesDeCruceroDadoDeBajaPermanente @codigoCruceroReemplazado , @codigoCruceroQueLoReemplazo
		, @fechaBajaPermanenteDeCruceroReemplazado 
	EXEC FIDEOS_CON_TUCO.actualizarViajesdeCruceroDadoDeBajaPermanente @codigoCruceroReemplazado, @codigoCruceroQueLoReemplazo
		, @fechaBajaPermanenteDeCruceroReemplazado
END
GO


/*************************** CANCELAR VIAJES ANTE BAJA DE CRUCERO ***************************/


CREATE PROCEDURE FIDEOS_CON_TUCO.cancelacionViajesParaBajaPermanente @codigoCrucero varchar(255), @fechaSistema datetime, @fechaBaja datetime
AS
BEGIN
	INSERT INTO FIDEOS_CON_TUCO.Cancelacion_pasaje(canc_pasa_pasaje, canc_pasa_descripcion, canc_pasa_fecha)
	SELECT pasa_codigo, 'Cancelaci�n por baja de crucero', @fechaSistema FROM FIDEOS_CON_TUCO.Pasaje
	JOIN FIDEOS_CON_TUCO.Viaje ON (viaj_crucero = @codigoCrucero)
	WHERE pasa_viaje = viaj_codigo AND viaj_fecha_inicio >= @fechaBaja
	AND NOT EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Cancelacion_reserva 
		JOIN FIDEOS_CON_TUCO.Reserva ON (rese_pasaje = pasa_codigo) WHERE canc_reserva = rese_codigo)
END
GO

CREATE PROCEDURE FIDEOS_CON_TUCO.cancelacionViajesParaBajaTemporal @codigoCrucero varchar(255)
	, @fechaSistema datetime, @fechaBaja datetime, @fechaAlta datetime
AS
BEGIN
	INSERT INTO FIDEOS_CON_TUCO.Cancelacion_pasaje(canc_pasa_pasaje, canc_pasa_descripcion, canc_pasa_fecha)
	SELECT pasa_codigo, 'Cancelaci�n por baja de crucero', @fechaSistema FROM FIDEOS_CON_TUCO.Pasaje
	JOIN FIDEOS_CON_TUCO.Viaje ON (viaj_crucero = @codigoCrucero)
	WHERE pasa_viaje = viaj_codigo 
	AND (
		(@fechaBaja <= viaj_fecha_inicio AND viaj_fecha_inicio < @fechaAlta)
		OR (@fechaBaja <= viaj_fecha_finalizacion_estimada AND viaj_fecha_finalizacion_estimada <= @fechaAlta)
		OR (viaj_fecha_inicio <= @fechaBaja AND @fechaBaja <= viaj_fecha_finalizacion_estimada)
		OR (viaj_fecha_inicio < @fechaAlta AND @fechaAlta <= viaj_fecha_finalizacion_estimada)
	)
	AND NOT EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Cancelacion_reserva 
		JOIN FIDEOS_CON_TUCO.Reserva ON (rese_pasaje = pasa_codigo) WHERE canc_reserva = rese_codigo)
END
GO

/*************************** BAJA CRUCEROS ***************************/


CREATE PROCEDURE FIDEOS_CON_TUCO.bajaCrucero @codigo varchar(255), @tipoBaja varchar(255), @fechaSistema datetime, @fechaAlta datetime
AS
DECLARE @tipo_baja int
BEGIN
	if (@tipoBaja = 'Temporal')
	BEGIN
		UPDATE FIDEOS_CON_TUCO.Crucero SET cruc_esta_habilitado = 0 WHERE cruc_codigo = @codigo;
		SELECT @tipo_baja = tipo_baja_codigo FROM FIDEOS_CON_TUCO.Tipo_baja WHERE tipo_baja_descripcion = 'Temporal'
		INSERT INTO FIDEOS_CON_TUCO.Registro_baja(regi_tipo, regi_fecha_de_baja, regi_fecha_de_alta, regi_crucero)
					VALUES (@tipo_baja, @fechaSistema, @fechaAlta, @codigo) 
	END
	if (@tipoBaja = 'Permanente')
	BEGIN
		UPDATE FIDEOS_CON_TUCO.Crucero SET cruc_esta_habilitado = 0 WHERE cruc_codigo = @codigo;
		SELECT @tipo_baja = tipo_baja_codigo FROM FIDEOS_CON_TUCO.Tipo_baja WHERE tipo_baja_descripcion = 'Permanente'
		INSERT INTO FIDEOS_CON_TUCO.Registro_baja(regi_tipo, regi_fecha_de_baja, regi_crucero)
					VALUES (@tipo_baja, @fechaSistema, @codigo) 
	END
END
GO



/*######################## [07]::[GENERAR VIAJE] ############################*/


/******************** SPs para mostrar los datos a ingresar para generar el viaje ****************************************************/ 


CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarPuertosDeUnRecorrido
AS
BEGIN
	SELECT reco_id AS ID, FIDEOS_CON_TUCO.stringConPuertosDeUnRecorrido(reco_id) AS Puertos_recorridos 
	FROM FIDEOS_CON_TUCO.Recorrido 
	WHERE reco_esta_habilitado = 1
	ORDER BY 2
END
GO

CREATE FUNCTION FIDEOS_CON_TUCO.cantidadCabinasEstandar (@codigoCrucero varchar(255)) RETURNS int
AS
BEGIN
	DECLARE @cantidadCabinas int
	SELECT @cantidadCabinas = COUNT(*) FROM FIDEOS_CON_TUCO.Cabina JOIN FIDEOS_CON_TUCO.Tipo_cabina ON (tipo_codigo = cabi_tipo)
		WHERE cabi_crucero = @codigoCrucero AND tipo_descripcion = 'Cabina estandar'
	RETURN @cantidadCabinas
END
GO

CREATE FUNCTION FIDEOS_CON_TUCO.cantidadCabinasExteriores (@codigoCrucero varchar(255)) RETURNS int
AS
BEGIN
	DECLARE @cantidadCabinas int
	SELECT @cantidadCabinas = COUNT(*) FROM FIDEOS_CON_TUCO.Cabina JOIN FIDEOS_CON_TUCO.Tipo_cabina ON (tipo_codigo = cabi_tipo)
		WHERE cabi_crucero = @codigoCrucero AND tipo_descripcion = 'Cabina exterior'
	RETURN @cantidadCabinas
END
GO

CREATE FUNCTION FIDEOS_CON_TUCO.cantidadCabinasSuites (@codigoCrucero varchar(255)) RETURNS int
AS
BEGIN
	DECLARE @cantidadCabinas int
	SELECT @cantidadCabinas = COUNT(*) FROM FIDEOS_CON_TUCO.Cabina JOIN FIDEOS_CON_TUCO.Tipo_cabina ON (tipo_codigo = cabi_tipo)
		WHERE cabi_crucero = @codigoCrucero AND tipo_descripcion = 'Suite'
	RETURN @cantidadCabinas
END
GO

CREATE FUNCTION FIDEOS_CON_TUCO.cantidadCabinasBalcones (@codigoCrucero varchar(255)) RETURNS int
AS
BEGIN
	DECLARE @cantidadCabinas int
	SELECT @cantidadCabinas = COUNT(*) FROM FIDEOS_CON_TUCO.Cabina JOIN FIDEOS_CON_TUCO.Tipo_cabina ON (tipo_codigo = cabi_tipo)
		WHERE cabi_crucero = @codigoCrucero AND tipo_descripcion = 'Cabina Balc�n'
	RETURN @cantidadCabinas
END
GO

CREATE FUNCTION FIDEOS_CON_TUCO.cantidadCabinasEjecutivas (@codigoCrucero varchar(255)) RETURNS int
AS
BEGIN
	DECLARE @cantidadCabinas int
	SELECT @cantidadCabinas = COUNT(*) FROM FIDEOS_CON_TUCO.Cabina JOIN FIDEOS_CON_TUCO.Tipo_cabina ON (tipo_codigo = cabi_tipo)
		WHERE cabi_crucero = @codigoCrucero AND tipo_descripcion = 'Ejecutivo'
	RETURN @cantidadCabinas
END
GO


CREATE FUNCTION FIDEOS_CON_TUCO.unCruceroTieneViajesDurante (@codigoCrucero varchar(255), @fechaInicio datetime, @fechaFin datetime) RETURNS bit
AS
BEGIN
	IF EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Viaje WHERE viaj_crucero = @codigoCrucero
		AND (
			(viaj_fecha_inicio BETWEEN @fechaInicio AND @fechaFin)
			OR (viaj_fecha_finalizacion_estimada BETWEEN @fechaInicio AND @fechaFin)
			OR (@fechaInicio BETWEEN viaj_fecha_inicio AND viaj_fecha_finalizacion_estimada)
			OR (@fechaFin BETWEEN viaj_fecha_inicio AND viaj_fecha_finalizacion_estimada)
		)
		)
		BEGIN
		RETURN 1
		END
	RETURN 0
END
GO


CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarCrucerosParaUnViaje @fechaInicio datetime, @fechaFin datetime
AS
BEGIN
	SELECT cruc_codigo AS Codigo
		, marc_descripcion AS Marca
		, mode_descripcion AS Modelo
		, FIDEOS_CON_TUCO.cantidadCabinasEstandar(cruc_codigo) AS Cantidad_Cabinas_Estandar
		, FIDEOS_CON_TUCO.cantidadCabinasExteriores(cruc_codigo) AS Cantidad_Cabinas_Exteriores
		, FIDEOS_CON_TUCO.cantidadCabinasSuites(cruc_codigo) AS Cantidad_Cabinas_Suites
		, FIDEOS_CON_TUCO.cantidadCabinasBalcones(cruc_codigo) AS Cantidad_Cabinas_Balcones
		, FIDEOS_CON_TUCO.cantidadCabinasEjecutivas(cruc_codigo) AS Cantidad_Cabinas_Ejecutivas
		, cruc_cantidad_cabinas AS Cantidad_Total_Cabinas
	FROM FIDEOS_CON_TUCO.Crucero
	JOIN FIDEOS_CON_TUCO.Marca ON (cruc_marca = marc_codigo)
	JOIN FIDEOS_CON_TUCO.Modelo ON (cruc_modelo = mode_codigo)
	WHERE FIDEOS_CON_TUCO.unCruceroTieneViajesDurante(cruc_codigo, @fechaInicio, @fechaFin) = 0
		AND FIDEOS_CON_TUCO.unCruceroEstaHabilitadoDurante(cruc_codigo, @fechaInicio, @fechaFin) = 1
END
GO


/*******************************************  Generacion del viaje *****************************************************/


--Errores
--resultado = 0 -> la fecha de inicio del viajes es menor que la actual
--resultado = -1 -> El crucero ya tiene un viaje programado para ese intervalo de fechas
--resultado = -2 -> El crucero esta deshabilitado
--resultado = -3 -> El recorrido esta deshabilitado

CREATE PROCEDURE FIDEOS_CON_TUCO.generarViaje @idRecorrido int, @codigoCrucero varchar(255), @fechaInicio datetime, @fechaFinalizacion datetime
	, @fechaSistema datetime, @resultado int output
AS
BEGIN
	IF (@fechaInicio < @fechaSistema)
		BEGIN
		SET @resultado = 0
		END
	ELSE IF EXISTS(SELECT viaj_codigo FROM FIDEOS_CON_TUCO.Viaje 
			WHERE viaj_crucero = @codigoCrucero AND ((viaj_fecha_inicio BETWEEN @fechaInicio AND @fechaFinalizacion)
			OR (viaj_fecha_finalizacion_estimada BETWEEN @fechaInicio AND @fechaFinalizacion)
			OR (@fechaInicio BETWEEN viaj_fecha_inicio AND viaj_fecha_finalizacion_estimada)
			OR (@fechaFinalizacion BETWEEN viaj_fecha_inicio AND viaj_fecha_finalizacion_estimada)))
		BEGIN
		SET @resultado = -1
		END
	ELSE IF (SELECT cruc_esta_habilitado FROM FIDEOS_CON_TUCO.Crucero WHERE cruc_codigo = @codigoCrucero) = 0
		BEGIN
		SET @resultado = -2
		END
	ELSE IF (SELECT reco_esta_habilitado FROM FIDEOS_CON_TUCO.Recorrido WHERE reco_id = @idRecorrido) = 0
		BEGIN
		SET @resultado = -3
		END
	ELSE 
		BEGIN
		INSERT INTO FIDEOS_CON_TUCO.Viaje(viaj_recorrido, viaj_crucero, viaj_fecha_inicio, viaj_fecha_finalizacion_estimada)
			VALUES (@idRecorrido, @codigoCrucero, @fechaInicio, @fechaFinalizacion)
		SET @resultado = 1
		END
END
GO



/*######################## [08]::[COMPRA O RESERVA DE VIAJE] ############################*/


/************************** CREACION de tipos de medios de pago, empresas de tarjetas y cantidad de cuotas disponibles *******************************************/


CREATE PROCEDURE FIDEOS_CON_TUCO.cargarTiposDeMediosDePagoIniciales
AS
BEGIN
	INSERT INTO FIDEOS_CON_TUCO.Tipo_medio_de_pago(tipo_medi_descripcion) VALUES ('Tarjeta de credito')
	INSERT INTO FIDEOS_CON_TUCO.Tipo_medio_de_pago(tipo_medi_descripcion) VALUES ('Tarjeta de debito')
END
GO

CREATE PROCEDURE FIDEOS_CON_TUCO.cargarEmpresasDeTarjetasIniciales
AS
BEGIN
	INSERT INTO FIDEOS_CON_TUCO.Empresa_tarjeta(empr_descripcion) VALUES('Visa')
	INSERT INTO FIDEOS_CON_TUCO.Empresa_tarjeta(empr_descripcion) VALUES('MasterCard')
END
GO

CREATE PROCEDURE FIDEOS_CON_TUCO.cargarCantidadDeCuotasDeEmpresasIniciales
AS
BEGIN
	INSERT INTO FIDEOS_CON_TUCO.Cantidad_cuotas(cant_cantidad, cant_empresa)
		SELECT 6, empr_codigo FROM FIDEOS_CON_TUCO.Empresa_tarjeta WHERE empr_descripcion = 'Visa'
	INSERT INTO FIDEOS_CON_TUCO.Cantidad_cuotas(cant_cantidad, cant_empresa)
		SELECT 12, empr_codigo FROM FIDEOS_CON_TUCO.Empresa_tarjeta WHERE empr_descripcion = 'Visa'
	INSERT INTO FIDEOS_CON_TUCO.Cantidad_cuotas(cant_cantidad, cant_empresa)
		SELECT 18, empr_codigo FROM FIDEOS_CON_TUCO.Empresa_tarjeta WHERE empr_descripcion = 'Visa'
	INSERT INTO FIDEOS_CON_TUCO.Cantidad_cuotas(cant_cantidad, cant_empresa)
		SELECT 6, empr_codigo FROM FIDEOS_CON_TUCO.Empresa_tarjeta WHERE empr_descripcion = 'MasterCard'
	INSERT INTO FIDEOS_CON_TUCO.Cantidad_cuotas(cant_cantidad, cant_empresa)
		SELECT 12, empr_codigo FROM FIDEOS_CON_TUCO.Empresa_tarjeta WHERE empr_descripcion = 'MasterCard'
END
GO

EXEC FIDEOS_CON_TUCO.cargarTiposDeMediosDePagoIniciales
EXEC FIDEOS_CON_TUCO.cargarEmpresasDeTarjetasIniciales
EXEC FIDEOS_CON_TUCO.cargarCantidadDeCuotasDeEmpresasIniciales
GO


/************************** Manejo de CLIENTES *******************************************/


CREATE PROCEDURE FIDEOS_CON_TUCO.ingresarCliente @nombre varchar(255), @apellido varchar(255), @dni numeric(18,0), @telefono numeric(18,0)
	, @direccion varchar(255), @fechaNacimiento datetime, @codigoCliente int output, @mail varchar(255) = NULL
AS
BEGIN
	INSERT INTO FIDEOS_CON_TUCO.Cliente(clie_nombre, clie_apellido, clie_dni, clie_telefono, clie_mail, clie_direccion, clie_fecha_nacimiento)
		VALUES (@nombre, @apellido, @dni, @telefono, @mail, @direccion, @fechaNacimiento)
	SET @codigoCliente = SCOPE_IDENTITY()
END
GO


CREATE PROCEDURE FIDEOS_CON_TUCO.traerCliente @dni numeric(18,0)
AS
BEGIN
	SELECT clie_codigo AS ID, clie_nombre AS Nombre, clie_apellido AS Apellido, clie_dni AS DNI, clie_telefono AS Telefono, clie_mail AS Mail,
		clie_direccion AS Direccion, clie_fecha_nacimiento AS fechaNacimiento
		FROM FIDEOS_CON_TUCO.Cliente WHERE clie_dni = @dni
END
GO

CREATE PROCEDURE FIDEOS_CON_TUCO.actualizarCliente @codigoCliente int, @nombre varchar(255), @apellido varchar(255), @dni numeric(18,0), @telefono numeric(18,0)
	, @direccion varchar(255), @fechaNacimiento datetime, @mail varchar(255) = NULL
AS
BEGIN
	UPDATE FIDEOS_CON_TUCO.Cliente SET clie_nombre = @nombre, clie_apellido = @apellido, clie_telefono = @telefono, clie_mail = @mail
		, clie_direccion = @direccion, clie_fecha_nacimiento = @fechaNacimiento
		WHERE clie_codigo = @codigoCliente
END
GO


/*************************** Funciones para mostrar tramos de un recorrido   *********************************/


CREATE FUNCTION FIDEOS_CON_TUCO.stringDestinos(@idRecorrido int, @codigoPuertoDestino int) RETURNS varchar(255)
AS
BEGIN
	DECLARE @ciudadPuertoDestino varchar(255)
	SET @ciudadPuertoDestino = ''
	SELECT @ciudadPuertoDestino = puer_ciudad FROM FIDEOS_CON_TUCO.Puerto WHERE puer_codigo = @codigoPuertoDestino
	IF NOT EXISTS(SELECT * FROM FIDEOS_CON_TUCO.Tramo JOIN FIDEOS_CON_TUCO.Tramos_por_recorrido ON (tram_por_reco_recorrido = @idRecorrido)
			WHERE tram_codigo = tram_por_reco_tramo AND tram_puerto_origen = @codigoPuertoDestino)
		BEGIN
		RETURN @ciudadPuertoDestino
		END
	DECLARE @codigoPuertoFinalRecorrido int
	SELECT @codigoPuertoFinalRecorrido = reco_puerto_destino FROM FIDEOS_CON_TUCO.Recorrido WHERE reco_id = @idRecorrido
	IF (@codigoPuertoDestino = @codigoPuertoFinalRecorrido)
		BEGIN
		RETURN @ciudadPuertoDestino
		END
	DECLARE @codigoPuertoSiguienteDestino int
	SELECT @codigoPuertoSiguienteDestino = tram_puerto_destino FROM FIDEOS_CON_TUCO.Tramo 
		JOIN FIDEOS_CON_TUCO.Tramos_por_recorrido ON (tram_por_reco_recorrido = @idRecorrido) 
		WHERE tram_codigo = tram_por_reco_tramo AND tram_puerto_origen = @codigoPuertoDestino
	RETURN @ciudadPuertoDestino + '-' + FIDEOS_CON_TUCO.stringDestinos(@idRecorrido, @codigoPuertoSiguienteDestino)
END
GO


CREATE FUNCTION FIDEOS_CON_TUCO.stringConPuertosDeUnRecorrido (@idRecorrido int) RETURNS varchar(255)
AS
BEGIN
	DECLARE @ciudadPuertoOrigen varchar(255)
	DECLARE @codigoPuertoDestinoPrierTramo int
	SELECT @ciudadPuertoOrigen = puer_ciudad FROM FIDEOS_CON_TUCO.Puerto 
		JOIN FIDEOS_CON_TUCO.Recorrido ON (reco_id = @idRecorrido)
		WHERE puer_codigo = reco_puerto_origen
	SELECT @codigoPuertoDestinoPrierTramo = tram_puerto_destino FROM FIDEOS_CON_TUCO.Tramo 
		JOIN FIDEOS_CON_TUCO.Tramos_por_recorrido ON (tram_por_reco_recorrido = @idRecorrido)
		JOIN FIDEOS_CON_TUCO.Recorrido ON (reco_id = @idRecorrido)
		WHERE tram_puerto_origen = reco_puerto_origen AND tram_codigo = tram_por_reco_tramo
	RETURN @ciudadPuertoOrigen + ' - ' + FIDEOS_CON_TUCO.stringDestinos(@idRecorrido, @codigoPuertoDestinoPrierTramo)
END
GO


/************************** LISTADO de viajes para comprar *******************************************/


CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarViajesParaComprar @fechaInicio date, @ciudadPuertoOrigen varchar(255), @ciudadPuertoDestino varchar(255)
AS 
BEGIN
	SELECT viaj_codigo AS Codigo_de_viaje, viaj_fecha_inicio AS Fecha_de_inicio, viaj_fecha_finalizacion_estimada AS Fecha_finalizacion,
		cruc_cantidad_cabinas - (SELECT COUNT(*) FROM (
			SELECT pasa_codigo FROM FIDEOS_CON_TUCO.Pasaje 
			WHERE pasa_viaje = viaj_codigo AND NOT EXISTS(SELECT canc_pasa_codigo FROM FIDEOS_CON_TUCO.Cancelacion_pasaje 
				WHERE canc_pasa_pasaje = pasa_codigo)
				AND NOT EXISTS (SELECT canc_codigo FROM FIDEOS_CON_TUCO.Reserva
					JOIN FIDEOS_CON_TUCO.Cancelacion_reserva ON (canc_reserva = rese_codigo)
					WHERE rese_pasaje = pasa_codigo)
			) AS t1) AS Cantidad_cabinas_disponibles,
		FIDEOS_CON_TUCO.stringConPuertosDeUnRecorrido(reco_id) AS Recorrido
		FROM FIDEOS_CON_TUCO.Viaje 
		JOIN FIDEOS_CON_TUCO.Puerto p1 ON (p1.puer_ciudad = @ciudadPuertoOrigen)
		JOIN FIDEOS_CON_TUCO.Puerto p2 ON (p2.puer_ciudad = @ciudadPuertoDestino)
		JOIN FIDEOS_CON_TUCO.Crucero ON (cruc_codigo = viaj_crucero)
		JOIN FIDEOS_CON_TUCO.Recorrido ON (reco_puerto_origen = p1.puer_codigo AND reco_puerto_destino = p2.puer_codigo)
		WHERE CONVERT(DATE, viaj_fecha_inicio) = @fechaInicio AND viaj_recorrido = reco_id AND reco_esta_habilitado = 1 AND cruc_esta_habilitado = 1
END
GO


/************************** LISTADO de viajes para comprar para un cliente, mostrando solo viajes no solapados *******************************************/



CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarViajesParaComprarParaUnCliente @fechaInicio datetime, @ciudadPuertoOrigen varchar(255)
, @ciudadPuertoDestino varchar(255), @codigoCliente int, @fechaSistema datetime
AS 
BEGIN
	SELECT v1.viaj_codigo AS Codigo_de_viaje, v1.viaj_fecha_inicio AS Fecha_de_inicio, v1.viaj_fecha_finalizacion_estimada AS Fecha_finalizacion,
		cruc_cantidad_cabinas - (SELECT COUNT(*) FROM (
			SELECT pasa_codigo FROM FIDEOS_CON_TUCO.Pasaje 
			WHERE pasa_viaje = v1.viaj_codigo AND NOT EXISTS(SELECT canc_pasa_codigo FROM FIDEOS_CON_TUCO.Cancelacion_pasaje 
				WHERE canc_pasa_pasaje = pasa_codigo)
				AND NOT EXISTS (SELECT canc_codigo FROM FIDEOS_CON_TUCO.Reserva
					JOIN FIDEOS_CON_TUCO.Cancelacion_reserva ON (canc_reserva = rese_codigo)
					WHERE rese_pasaje = pasa_codigo)
			) AS t1) AS Cantidad_cabinas_disponibles,
		FIDEOS_CON_TUCO.stringConPuertosDeUnRecorrido(reco_id) AS Recorrido
		FROM FIDEOS_CON_TUCO.Viaje v1
		JOIN FIDEOS_CON_TUCO.Puerto p1 ON (p1.puer_ciudad = @ciudadPuertoOrigen)
		JOIN FIDEOS_CON_TUCO.Puerto p2 ON (p2.puer_ciudad = @ciudadPuertoDestino)
		JOIN FIDEOS_CON_TUCO.Crucero ON (cruc_codigo = v1.viaj_crucero)
		JOIN FIDEOS_CON_TUCO.Recorrido ON (reco_puerto_origen = p1.puer_codigo AND reco_puerto_destino = p2.puer_codigo)
		WHERE CONVERT(DATE, v1.viaj_fecha_inicio) = CONVERT(DATE, @fechaInicio)
		AND v1.viaj_fecha_inicio >= @fechaSistema
		AND v1.viaj_recorrido = reco_id 
		AND reco_esta_habilitado = 1 
		AND cruc_esta_habilitado = 1
			AND NOT EXISTS(
				SELECT * FROM FIDEOS_CON_TUCO.Viaje v2 JOIN FIDEOS_CON_TUCO.Pasaje ON (pasa_viaje = v2.viaj_codigo)
				WHERE NOT EXISTS(SELECT canc_pasa_codigo FROM FIDEOS_CON_TUCO.Cancelacion_pasaje WHERE canc_pasa_pasaje = pasa_codigo)
				AND NOT EXISTS (SELECT canc_codigo FROM FIDEOS_CON_TUCO.Reserva JOIN FIDEOS_CON_TUCO.Cancelacion_reserva ON (canc_reserva = rese_codigo)
					WHERE rese_pasaje = pasa_codigo)
					AND pasa_cliente = @codigoCliente 
					AND v1.viaj_recorrido <> v2.viaj_recorrido
					AND (
						v2.viaj_fecha_inicio BETWEEN v1.viaj_fecha_inicio AND v1.viaj_fecha_finalizacion_estimada
						OR v2.viaj_fecha_finalizacion_estimada BETWEEN v1.viaj_fecha_inicio AND v1.viaj_fecha_finalizacion_estimada
						OR v1.viaj_fecha_inicio BETWEEN v2.viaj_fecha_inicio AND v2.viaj_fecha_finalizacion_estimada
						OR v1.viaj_fecha_finalizacion_estimada BETWEEN v2.viaj_fecha_inicio AND v2.viaj_fecha_finalizacion_estimada
					)
				)
END
GO


/************************** LISTADO de TODOS los viajes para comprar *******************************************/



CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarTodosLosViajesParaComprar @fechaSistema datetime, @codigoCliente int
AS 
BEGIN
	SELECT v1.viaj_codigo AS Codigo_de_viaje, v1.viaj_fecha_inicio AS Fecha_de_inicio, v1.viaj_fecha_finalizacion_estimada AS Fecha_finalizacion,
		cruc_cantidad_cabinas - (SELECT COUNT(*) FROM (
			SELECT pasa_codigo FROM FIDEOS_CON_TUCO.Pasaje 
			WHERE pasa_viaje = v1.viaj_codigo AND NOT EXISTS(SELECT canc_pasa_codigo FROM FIDEOS_CON_TUCO.Cancelacion_pasaje 
				WHERE canc_pasa_pasaje = pasa_codigo)
				AND NOT EXISTS (SELECT canc_codigo FROM FIDEOS_CON_TUCO.Reserva
					JOIN FIDEOS_CON_TUCO.Cancelacion_reserva ON (canc_reserva = rese_codigo)
					WHERE rese_pasaje = pasa_codigo)
			) AS t1) AS Cantidad_cabinas_disponibles,
		FIDEOS_CON_TUCO.stringConPuertosDeUnRecorrido(reco_id) AS Recorrido
		FROM FIDEOS_CON_TUCO.Viaje v1
		JOIN FIDEOS_CON_TUCO.Crucero ON (cruc_codigo = v1.viaj_crucero)
		JOIN FIDEOS_CON_TUCO.Recorrido ON (reco_id = v1.viaj_recorrido)
		WHERE v1.viaj_fecha_inicio >= @fechaSistema AND reco_esta_habilitado = 1 AND cruc_esta_habilitado = 1
		AND NOT EXISTS(
				SELECT * FROM FIDEOS_CON_TUCO.Viaje v2 JOIN FIDEOS_CON_TUCO.Pasaje ON (pasa_viaje = v2.viaj_codigo)
				WHERE NOT EXISTS(SELECT canc_pasa_codigo FROM FIDEOS_CON_TUCO.Cancelacion_pasaje WHERE canc_pasa_pasaje = pasa_codigo)
				AND NOT EXISTS (SELECT canc_codigo FROM FIDEOS_CON_TUCO.Reserva JOIN FIDEOS_CON_TUCO.Cancelacion_reserva ON (canc_reserva = rese_codigo)
					WHERE rese_pasaje = pasa_codigo)
					AND pasa_cliente = @codigoCliente 
					AND v1.viaj_recorrido <> v2.viaj_recorrido
					AND (
						v2.viaj_fecha_inicio BETWEEN v1.viaj_fecha_inicio AND v1.viaj_fecha_finalizacion_estimada
						OR v2.viaj_fecha_finalizacion_estimada BETWEEN v1.viaj_fecha_inicio AND v1.viaj_fecha_finalizacion_estimada
						OR v1.viaj_fecha_inicio BETWEEN v2.viaj_fecha_inicio AND v2.viaj_fecha_finalizacion_estimada
						OR v1.viaj_fecha_finalizacion_estimada BETWEEN v2.viaj_fecha_inicio AND v2.viaj_fecha_finalizacion_estimada
					)
				)
END
GO


/************************** LISTADO de cabinas disponibles de un viaje *******************************************/


CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarCabinasDisponiblesDeUnViaje @codigoViaje int
AS
BEGIN
	SELECT cabi_codigo AS Codigo, cabi_numero AS Numero, cabi_piso AS Piso, tipo_descripcion AS Tipo, reco_precio*tipo_porcentaje_recargo AS Precio
		FROM FIDEOS_CON_TUCO.Cabina
		JOIN FIDEOS_CON_TUCO.Tipo_cabina ON (tipo_codigo = cabi_tipo)
		JOIN FIDEOS_CON_TUCO.Viaje ON (viaj_codigo = @codigoViaje)
		JOIN FIDEOS_CON_TUCO.Recorrido ON (reco_id = viaj_recorrido)
		WHERE cabi_crucero = viaj_crucero AND NOT EXISTS(SELECT pasa_codigo FROM FIDEOS_CON_TUCO.Pasaje 
				WHERE pasa_cabina = cabi_codigo AND pasa_viaje = viaj_codigo
				AND NOT EXISTS(SELECT canc_pasa_codigo FROM FIDEOS_CON_TUCO.Cancelacion_pasaje 
				WHERE canc_pasa_pasaje = pasa_codigo) 
				AND NOT EXISTS (SELECT canc_codigo FROM FIDEOS_CON_TUCO.Reserva
					JOIN FIDEOS_CON_TUCO.Cancelacion_reserva ON (canc_reserva = rese_codigo)
					WHERE rese_pasaje = pasa_codigo))
		ORDER BY 4,3,2
END
GO


/************************** MANEJO de medios de pago *******************************************/


CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarTiposDeMediosDePago
AS
BEGIN
	SELECT tipo_medi_codigo, tipo_medi_descripcion FROM FIDEOS_CON_TUCO.Tipo_medio_de_pago
END
GO

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarEmpresasDeTarjetas
AS
BEGIN
	SELECT empr_codigo, empr_descripcion FROM FIDEOS_CON_TUCO.Empresa_tarjeta
END
GO

CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarCuotasDeUnaEmpresa @codigoEmpresa int
AS
BEGIN
	SELECT cant_cantidad FROM FIDEOS_CON_TUCO.Cantidad_cuotas WHERE cant_empresa = @codigoEmpresa
END
GO

--@tipoTarjeta debe ser 'DEBITO' O 'CREDITO'
CREATE PROCEDURE FIDEOS_CON_TUCO.ingresarTarjeta @numeroTarjeta numeric(20,0), @codigoVerificador int, @tipoTarjeta varchar(255), @codigoEmpresa int
AS
BEGIN
	IF NOT EXISTS(SELECT tarj_numero FROM FIDEOS_CON_TUCO.Tarjeta WHERE tarj_numero = @numeroTarjeta)
		BEGIN
		INSERT INTO FIDEOS_CON_TUCO.Tarjeta(tarj_numero, tarj_codigo_verificador, tarj_tipo, tarj_empresa) 
			VALUES (@numeroTarjeta, @codigoVerificador, @tipoTarjeta, @codigoEmpresa)
		END
END
GO

CREATE PROCEDURE FIDEOS_CON_TUCO.ingresarMedioDePagoConTarjeta @tipoMedioDePago int, @numeroTarjeta numeric (20,0), @cantidadDeCuotas int, @codigoMedioDePago int output
AS
BEGIN
	IF NOT EXISTS(SELECT medi_codigo FROM FIDEOS_CON_TUCO.Medio_de_pago WHERE medi_tarjeta = @numeroTarjeta 
			AND medi_tipo = @tipoMedioDePago AND medi_cantidad_de_cuotas = @cantidadDeCuotas)
		BEGIN
		INSERT INTO FIDEOS_CON_TUCO.Medio_de_pago(medi_tarjeta, medi_tipo, medi_cantidad_de_cuotas)
			VALUES(@numeroTarjeta, @tipoMedioDePago, @cantidadDeCuotas)
		SET @codigoMedioDePago = SCOPE_IDENTITY()
		END
	ELSE
		BEGIN
		SELECT @codigoMedioDePago = medi_codigo FROM FIDEOS_CON_TUCO.Medio_de_pago WHERE medi_tarjeta = @numeroTarjeta 
			AND medi_tipo = @tipoMedioDePago AND medi_cantidad_de_cuotas = @cantidadDeCuotas
		END
END
GO


/************************** GENERACION DE PASAJE, COMPRAS Y RESERVAS *******************************************/


CREATE PROCEDURE FIDEOS_CON_TUCO.generarPasaje @codigoCliente int, @codigoViaje int, @codigoCabina int, @codigoPasaje int output
AS
BEGIN
	DECLARE @precioPasaje int
	SELECT @precioPasaje = reco_precio*tipo_porcentaje_recargo FROM FIDEOS_CON_TUCO.Viaje
		JOIN FIDEOS_CON_TUCO.Recorrido ON (reco_id = viaj_recorrido)
		JOIN FIDEOS_CON_TUCO.Cabina ON (cabi_codigo = @codigoCabina)
		JOIN FIDEOS_CON_TUCO.Tipo_cabina ON (tipo_codigo = cabi_tipo)
		WHERE viaj_codigo = @codigoViaje
	INSERT INTO FIDEOS_CON_TUCO.Pasaje(pasa_precio, pasa_cliente, pasa_viaje, pasa_cabina)
		VALUES(@precioPasaje, @codigoCliente, @codigoViaje, @codigoCabina)
	SET @codigoPasaje = SCOPE_IDENTITY()
END
GO


CREATE PROCEDURE FIDEOS_CON_TUCO.generarReservaDeUnPasaje @codigoPasaje int, @fechaSistema datetime, @codigoReserva int output
AS
BEGIN
	INSERT INTO FIDEOS_CON_TUCO.Reserva(rese_fecha, rese_pasaje)
		VALUES(@fechaSistema, @codigoPasaje)
	SET @codigoReserva = SCOPE_IDENTITY()
END
GO


CREATE PROCEDURE FIDEOS_CON_TUCO.generarCompra @codigoCliente int, @fechaSistema datetime, @codigoMedioDePago int, @codigoCompra int output
AS
BEGIN
	INSERT INTO FIDEOS_CON_TUCO.Compra(comp_cliente, comp_fecha, comp_medio_de_pago, comp_monto_total)
		VALUES(@codigoCliente, @fechaSistema, @codigoMedioDePago, 0)
	SET @codigoCompra = SCOPE_IDENTITY()
END
GO


CREATE PROCEDURE FIDEOS_CON_TUCO.agregarPasajeAUnaCompra @codigoPasaje int, @codigoCompra int
AS
BEGIN
	IF NOT EXISTS(SELECT canc_codigo FROM FIDEOS_CON_TUCO.Reserva 
			JOIN FIDEOS_CON_TUCO.Cancelacion_reserva ON canc_reserva = rese_codigo WHERE rese_pasaje = @codigoPasaje)
		BEGIN
		DECLARE @precioPasaje numeric(10,2)
		UPDATE FIDEOS_CON_TUCO.Pasaje SET pasa_compra = @codigoCompra WHERE pasa_codigo =  @codigoPasaje
		SELECT @precioPasaje = pasa_precio FROM FIDEOS_CON_TUCO.Pasaje WHERE pasa_codigo = @codigoPasaje

		UPDATE FIDEOS_CON_TUCO.Compra SET comp_monto_total = comp_monto_total + @precioPasaje WHERE comp_codigo = @codigoCompra
		END
END
GO


CREATE FUNCTION FIDEOS_CON_TUCO.precioDeUnPasaje (@codigoPasaje int) RETURNS numeric(10,2)
AS
BEGIN
	DECLARE @precio numeric(10, 2)
	SELECT @precio = pasa_precio FROM FIDEOS_CON_TUCO.Pasaje WHERE pasa_codigo = @codigoPasaje 
	RETURN @precio
END
GO


CREATE FUNCTION FIDEOS_CON_TUCO.clienteDeUnPasaje (@codigoPasaje int) RETURNS int
AS
BEGIN
	DECLARE @codigoCliente int
	SELECT @codigoCliente = clie_codigo FROM FIDEOS_CON_TUCO.Cliente JOIN FIDEOS_CON_TUCO.Pasaje ON (pasa_codigo = @codigoPasaje)
	WHERE clie_codigo = pasa_cliente
	RETURN @codigoCliente
END
GO


--Obtiene el pasaje de una reserva. Se usaria cuando se quiere pagar una reserva.
--Devuelve el codigo del pasaje si tiene un pasaje esa reserva.
--Devuelve -1 si no existe ese numero de reserva.
--Devuelve -2 si la reserva fue cancelada.
--Devuelve -3 si el pasaje fue cancelado.
--Devuelve -4 si el fue pagada la reserva de ese pasaje.
CREATE FUNCTION FIDEOS_CON_TUCO.pasajeDeUnaReserva (@codigoReserva int) RETURNS int
AS
BEGIN
	DECLARE @codigoPasaje int
	IF NOT EXISTS(SELECT rese_codigo FROM FIDEOS_CON_TUCO.Reserva WHERE rese_codigo = @codigoReserva)
		BEGIN
		RETURN -1
		END
	ELSE IF EXISTS(SELECT canc_codigo FROM FIDEOS_CON_TUCO.Cancelacion_reserva WHERE canc_reserva = @codigoReserva)
		BEGIN
		RETURN -2
		END
	ELSE IF EXISTS(SELECT canc_pasa_codigo FROM FIDEOS_CON_TUCO.Cancelacion_pasaje JOIN FIDEOS_CON_TUCO.Reserva ON (rese_codigo = @codigoReserva)
			WHERE canc_pasa_pasaje = rese_pasaje)
		BEGIN
		RETURN -3
		END
	ELSE IF EXISTS(SELECT pasa_codigo FROM FIDEOS_CON_TUCO.Pasaje JOIN FIDEOS_CON_TUCO.Reserva ON (rese_codigo = @codigoReserva)
			WHERE pasa_codigo = rese_pasaje AND pasa_compra IS NOT NULL)
		BEGIN
		RETURN -4
		END
	SELECT @codigoPasaje = rese_pasaje FROM FIDEOS_CON_TUCO.Reserva WHERE rese_codigo = @codigoReserva
	RETURN @codigoPasaje
END
GO


/************************** LISTADO con la informaci�n de la compra hecha *******************************************/


CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarDatosFinalizadaLaCompra @codigoCompra int
AS
BEGIN
	SELECT comp_codigo AS Codigo_compra, viaj_fecha_inicio AS Fecha_inicio_viaje, viaj_fecha_finalizacion_estimada AS Fecha_finalizacion_viaje,
		p1.puer_ciudad AS Origen, p2.puer_ciudad AS Destino_final, FIDEOS_CON_TUCO.stringConPuertosDeUnRecorrido(reco_id) AS Recorrido
		, cruc_codigo AS ID_Crucero, pasa_codigo AS Codigo_pasaje, '$ ' + CONVERT(varchar(20), pasa_precio) AS Precio
		, cabi_numero AS Numero_cabina 
		,cabi_piso AS Piso_cabina, tipo_descripcion AS Tipo_Cabina, 
		(SELECT COUNT(*) FROM FIDEOS_CON_TUCO.Pasaje 
			WHERE pasa_viaje = viaj_codigo AND NOT EXISTS (SELECT canc_codigo FROM FIDEOS_CON_TUCO.Reserva
					JOIN FIDEOS_CON_TUCO.Cancelacion_reserva ON (canc_reserva = rese_codigo)
					WHERE rese_pasaje = pasa_codigo) AND NOT EXISTS (SELECT canc_pasa_codigo FROM FIDEOS_CON_TUCO.Cancelacion_pasaje 
					WHERE canc_pasa_pasaje = pasa_codigo)) AS Cantidad_de_pasajeros_hasta_el_momento
		, cruc_cantidad_cabinas AS Capacidad_maxima_de_pasajeros
	FROM FIDEOS_CON_TUCO.Compra
	JOIN FIDEOS_CON_TUCO.Pasaje ON (pasa_compra = @codigoCompra)
	JOIN FIDEOS_CON_TUCO.Viaje ON (viaj_codigo = pasa_viaje)
	JOIN FIDEOS_CON_TUCO.Recorrido ON (reco_id = viaj_recorrido)
	JOIN FIDEOS_CON_TUCO.Puerto p1 ON (p1.puer_codigo = reco_puerto_origen)
	JOIN FIDEOS_CON_TUCO.Puerto p2 ON (p2.puer_codigo = reco_puerto_destino)
	JOIN FIDEOS_CON_TUCO.Crucero ON (cruc_codigo = viaj_crucero)
	JOIN FIDEOS_CON_TUCO.Cabina ON (cabi_codigo = pasa_cabina)
	JOIN FIDEOS_CON_TUCO.Tipo_cabina ON (tipo_codigo = cabi_tipo)
	WHERE comp_codigo = @codigoCompra
END
GO


/*######################## [10]::[LISTADOS ESTADISTICOS] ############################*/

--TOP 5 DE LOS RECORRIDOS CON MAS PASAJES VENDIDOS
CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarLosCincoRecorridosConMasPasajesComprados @anio int, @semestre int
AS
BEGIN
	DECLARE @mesInicial int
	DECLARE @mesFinal int
	IF @semestre = 1
		BEGIN
		SET @mesInicial = 1
		SET @mesFinal = 6
		END
	IF @semestre = 2
		BEGIN
		SET @mesInicial = 7
		SET @mesFinal = 12
		END

	SELECT TOP 5 reco_id AS ID_Recorrido, puertoOrigen.puer_ciudad AS Puerto_origen, puertoDestino.puer_ciudad AS Puerto_destino 
		, FIDEOS_CON_TUCO.stringConPuertosDeUnRecorrido(reco_id) AS Recorrido,
		reco_precio AS Precio, COUNT(pasa_codigo) AS Pasajes_vendidos
		
		FROM FIDEOS_CON_TUCO.Recorrido
		JOIN FIDEOS_CON_TUCO.Viaje ON (viaj_recorrido = reco_id)
		JOIN FIDEOS_CON_TUCO.Pasaje ON (pasa_viaje = viaj_codigo)
		JOIN FIDEOS_CON_TUCO.Compra ON (comp_codigo = pasa_compra)
		JOIN FIDEOS_CON_TUCO.Puerto puertoOrigen ON (puertoOrigen.puer_codigo = reco_puerto_origen)
		JOIN FIDEOS_CON_TUCO.Puerto puertoDestino ON (puertoDestino.puer_codigo = reco_puerto_destino)
		WHERE YEAR(comp_fecha) = @anio AND MONTH(comp_fecha) BETWEEN @mesInicial AND @mesFinal
		GROUP BY reco_id, puertoOrigen.puer_ciudad, puertoDestino.puer_ciudad, reco_precio
		ORDER BY COUNT(pasa_codigo) DESC
END
GO

--TOP 5 DE LOS RECORRIDOS CON MAS CABINAS LIBRES EN CADA UNO DE LOS VIAJES
CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarLosCincoRecorridosConMasCabinasLibresEnCadaViaje @anio int, @semestre int
AS
BEGIN
	DECLARE @mesInicial int
	DECLARE @mesFinal int
	IF @semestre = 1
		BEGIN
		SET @mesInicial = 1
		SET @mesFinal = 6
		END
	IF @semestre = 2
		BEGIN
		SET @mesInicial = 7
		SET @mesFinal = 12
		END
	SELECT TOP 5 reco_id AS ID_Recorrido, puertoOrigen.puer_ciudad AS Puerto_origen, puertoDestino.puer_ciudad AS Puerto_destino
		, FIDEOS_CON_TUCO.stringConPuertosDeUnRecorrido(reco_id) AS Recorrido
		, reco_precio AS Precio
		, SUM(cruc_cantidad_cabinas) - (SELECT COUNT(*) FROM FIDEOS_CON_TUCO.Pasaje 
			JOIN FIDEOS_CON_TUCO.Viaje ON (viaj_recorrido = reco_id)
			WHERE pasa_viaje = viaj_codigo AND pasa_compra IS NOT NULL AND YEAR(viaj_fecha_inicio) = @anio 
				AND MONTH(viaj_fecha_inicio) BETWEEN @mesInicial AND @mesFinal AND NOT EXISTS (SELECT canc_codigo FROM FIDEOS_CON_TUCO.Cancelacion_reserva 
			JOIN FIDEOS_CON_TUCO.Reserva ON (rese_pasaje = pasa_codigo) WHERE canc_reserva = rese_codigo) AND NOT EXISTS(SELECT canc_pasa_codigo 
			FROM FIDEOS_CON_TUCO.Cancelacion_pasaje WHERE canc_pasa_pasaje = pasa_codigo)) AS Cabinas_libres_en_cada_viaje
		FROM FIDEOS_CON_TUCO.Recorrido
		JOIN FIDEOS_CON_TUCO.Viaje ON (viaj_recorrido = reco_id)
		JOIN FIDEOS_CON_TUCO.Crucero ON (cruc_codigo = viaj_crucero)
		JOIN FIDEOS_CON_TUCO.Puerto puertoOrigen ON (puertoOrigen.puer_codigo = reco_puerto_origen)
		JOIN FIDEOS_CON_TUCO.Puerto puertoDestino ON (puertoDestino.puer_codigo = reco_puerto_destino)
		WHERE YEAR(viaj_fecha_inicio) = @anio AND MONTH(viaj_fecha_inicio) BETWEEN @mesInicial AND @mesFinal
		GROUP BY reco_id, puertoOrigen.puer_ciudad, puertoDestino.puer_ciudad, reco_precio
		ORDER BY 5 DESC
END
GO


--TOP 5 DE LOS CRUCEROS CON MAS D�AS FUERA DE SERVICIO
CREATE PROCEDURE FIDEOS_CON_TUCO.mostrarLosCincoCrucerosConMasDiasFueraDeServicio @anio int, @semestre int
AS
BEGIN
	DECLARE @mesInicial int
	DECLARE @mesFinal int
	DECLARE @fechaInicio datetime
	DECLARE @fechaFin datetime
	IF @semestre = 1
		BEGIN
		SET @mesInicial = 1
		SET @mesFinal = 6
		SET @fechaInicio = DATETIMEFROMPARTS(@anio, @mesInicial, 1, 0, 0, 0, 0)
		SET @fechaFin = DATETIMEFROMPARTS(@anio, @mesFinal + 1, 1, 0, 0, 0, 0)

		SELECT TOP 5 cruc_codigo AS Codigo_crucero, cruc_marca AS Marca, cruc_modelo AS Modelo, cruc_cantidad_cabinas AS Cantidad_cabinas,
			CASE WHEN cruc_esta_habilitado = 1 THEN 'SI'
				ELSE 'NO'
			END AS Habilitado, 
			ISNULL((SELECT SUM(t1.DiasFueraDeServicio) FROM(
				SELECT 
					CASE WHEN regi_fecha_de_baja < @fechaInicio AND YEAR(regi_fecha_de_alta) = @anio 
						AND MONTH(regi_fecha_de_alta) <= @mesFinal THEN DATEDIFF(DAY, @fechaInicio, regi_fecha_de_alta)
					WHEN YEAR(regi_fecha_de_baja) = @anio  AND MONTH(regi_fecha_de_baja) <= @mesFinal
						AND regi_fecha_de_alta >= @fechaFin THEN DATEDIFF(DAY, regi_fecha_de_baja, @fechaFin)
					WHEN regi_fecha_de_baja >= @fechaInicio AND regi_fecha_de_alta < @fechaFin THEN DATEDIFF(DAY, regi_fecha_de_baja, regi_fecha_de_alta)
					END AS DiasFueraDeServicio
				FROM FIDEOS_CON_TUCO.Registro_baja
				JOIN FIDEOS_CON_TUCO.Tipo_baja ON (tipo_baja_codigo = regi_tipo)
				WHERE regi_crucero = cruc_codigo AND tipo_baja_descripcion = 'Temporal'
				) AS t1
			), 0) AS Dias_fuera_de_servicio
		FROM FIDEOS_CON_TUCO.Crucero
		ORDER BY 5 DESC
		END
	IF @semestre = 2
		BEGIN
		SET @mesInicial = 7
		SET @mesFinal = 12
		SET @fechaInicio = DATETIMEFROMPARTS(@anio, @mesInicial, 1, 0, 0, 0, 0)
		SET @fechaFin = DATETIMEFROMPARTS(@anio+1, 1, 1, 0, 0, 0, 0)

		SELECT TOP 5 cruc_codigo AS Codigo_crucero, cruc_marca AS Marca, cruc_modelo AS Modelo, cruc_cantidad_cabinas AS Cantidad_cabinas,
			CASE WHEN cruc_esta_habilitado = 1 THEN 'SI'
				ELSE 'NO'
			END AS Habilitado, 
			ISNULL((SELECT SUM(t1.DiasFueraDeServicio) FROM(
				SELECT 
					CASE WHEN regi_fecha_de_baja < @fechaInicio AND YEAR(regi_fecha_de_alta) = @anio 
						AND MONTH(regi_fecha_de_alta) <= @mesFinal THEN DATEDIFF(DAY, @fechaInicio, regi_fecha_de_alta)
					WHEN YEAR(regi_fecha_de_baja) = @anio  AND MONTH(regi_fecha_de_baja) BETWEEN @mesInicial AND @mesFinal
						AND regi_fecha_de_alta >= @fechaFin THEN DATEDIFF(DAY, regi_fecha_de_baja, @fechaFin)
					WHEN regi_fecha_de_baja >= @fechaInicio AND regi_fecha_de_alta < @fechaFin THEN DATEDIFF(DAY, regi_fecha_de_baja, regi_fecha_de_alta)
					END AS DiasFueraDeServicio
				FROM FIDEOS_CON_TUCO.Registro_baja 
				JOIN FIDEOS_CON_TUCO.Tipo_baja ON (tipo_baja_codigo = regi_tipo)
				WHERE regi_crucero = cruc_codigo AND tipo_baja_descripcion = 'Temporal'
				) AS t1
			), 0) AS Dias_fuera_de_servicio

		FROM FIDEOS_CON_TUCO.Crucero
		ORDER BY 5 DESC
		END
END
GO
