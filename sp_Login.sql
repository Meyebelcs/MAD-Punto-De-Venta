use DB_MAD

IF OBJECT_ID('SP_ValidaUser') IS NOT NULL
BEGIN
	DROP PROCEDURE SP_ValidaUser
END;
Go

CREATE PROCEDURE SP_ValidaUser
(
	@Op							CHAR(1),
	@Contraseņa					VARCHAR(20),
	@IdRol						INT = NULL
)
AS
BEGIN

	IF @Op='A'
	BEGIN
		SELECT E.IdEmpleados[IdEmpleados], A.IdEmpleado[IdEmpleado], A.IdAdministrador[IdAdministrador],A.CodigoAcceso[Codigo Acceso],
		E.Nombre[Nombre], E.APpellidoP[Apellido Paterno], E.APpellidoM[Apellido Materno], E.Telefono[Telefono], E.Email[Email],
		E.FechaIngreso[Fecha Ingreso], E.CURP[CURP], E.Contraseņa[Contraseņa], E.FechaNac[Fecha Nacimiento], E.NumNomina[Numero Nomina], E.Eliminacion[Eliminacion]

		FROM Empleados E JOIN Administrador A
		on E.IdEmpleados = A.IdEmpleado
		WHERE A.IdEmpleado = @IdRol AND E.Contraseņa=@Contraseņa AND E.Eliminacion = 0;

	END;

	IF @Op='C'
	BEGIN
		SELECT C.IdAdmin[IdAdministrador], C.IdCajero[IdCajero], C.IdEmpleado[IdEmpleado], E.IdEmpleados[IdEmpleado], E.Nombre[Nombre],
		E.APpellidoP[Apellido Paterno], E.APpellidoM[Apellido Materno], E.Telefono[Telefono], E.Email[Email],E.FechaIngreso[Fecha Ingreso],
		E.CURP[CURP], E.Contraseņa[Contraseņa], E.FechaNac[Fecha Nacimiento], E.NumNomina[Numero Nomina], E.Eliminacion[Eliminacion]

		FROM Empleados E JOIN Cajero C
		on E.IdEmpleados = C.IdEmpleado
		WHERE C.IdEmpleado = @IdRol AND E.Contraseņa=@Contraseņa AND E.Eliminacion = 0;
		
	END


END
Go

