use DB_MAD

IF OBJECT_ID('SP_ValidaUser') IS NOT NULL
BEGIN
	DROP PROCEDURE SP_ValidaUser
END;
Go

CREATE PROCEDURE SP_ValidaUser
(
	@Op							CHAR(1),
	@Contraseña					VARCHAR(20),
	@IdRol						INT = NULL
)
AS
BEGIN

	IF @Op='A'
	BEGIN
		SELECT E.IdEmpleados, A.IdEmpleado, A.IdAdministrador,A.CodigoAcceso, E.Nombre, E.APpellidoP, E.APpellidoM, E.Telefono, E.Email,E.FechaIngreso, E.CURP, E.Contraseña, E.FechaNac, E.NumNomina, E.Eliminacion
		FROM Empleados E JOIN Administrador A
		on E.IdEmpleados = A.IdEmpleado
		WHERE A.IdEmpleado = @IdRol AND E.Contraseña=@Contraseña AND E.Eliminacion = 0;

	END;

	IF @Op='C'
	BEGIN
		SELECT C.IdAdmin, C.IdCajero, C.IdEmpleado, E.IdEmpleados, E.Nombre, E.APpellidoP, E.APpellidoM, E.Telefono, E.Email,E.FechaIngreso, E.CURP, E.Contraseña, E.FechaNac, E.NumNomina, E.Eliminacion
		FROM Empleados E JOIN Cajero C
		on E.IdEmpleados = C.IdEmpleado
		WHERE C.IdEmpleado = @IdRol AND E.Contraseña=@Contraseña AND E.Eliminacion = 0;
		
	END


END
Go

