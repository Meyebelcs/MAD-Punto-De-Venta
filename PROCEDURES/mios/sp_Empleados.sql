USE DB_MAD;
Go

/*-----------------------------spEmpleados-------------------------------------------*/
IF OBJECT_ID('spEmpleados')IS NOT NULL
BEGIN
	DROP PROCEDURE spEmpleados;
END;
GO

CREATE PROCEDURE spEmpleados(
@Accion				CHAR(1),
@IdEmpleados		INT = NULL,
@Nombre				VARCHAR(20) = NULL,
@APpellidoP			VARCHAR(20) = NULL,
@APpellidoM			VARCHAR(20) = NULL,
@Telefono           INT  = NULL,
@Email              VARCHAR(50) = NULL,
@FechaIngreso       DATETIME = NULL,
@CURP				VARCHAR(20) = NULL,
@FechaNac			DATETIME = NULL,
@Contraseña			VARCHAR(10) = NULL,
@NumNomina			INT = NULL,
@Eliminacion		BIT = NULL,
@CodigoAcceso		INT = NULL

)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Empleados(Nombre,APpellidoP,APpellidoM,Telefono,Email,FechaIngreso,CURP,FechaNac,Contraseña,NumNomina,Eliminacion)
		VALUES(@Nombre,@APpellidoP,@APpellidoM,@Telefono,@Email,@FechaIngreso,@CURP,@FechaNac,@Contraseña, @NumNomina,@Eliminacion);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Empleados
		SET
			Nombre = @Nombre,
			APpellidoP = @APpellidoP,
			APpellidoM = @APpellidoM,
			Telefono = @Telefono,
			Email = @Email,
			FechaIngreso = @FechaIngreso,
			CURP = @CURP,
			FechaNac = @FechaNac,
			Contraseña = @Contraseña,
			NumNomina = @NumNomina,
			Eliminacion = @Eliminacion
		WHERE IdEmpleados = @IdEmpleados;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Empleados WHERE  IdEmpleados = @IdEmpleados;
	END;

	IF @Accion = 'E' 
	/*eliminacion logica*/
	BEGIN
		UPDATE Empleados 
		SET
			Eliminacion = 1 
			WHERE  IdEmpleados = @IdEmpleados;
	END;

	IF @Accion = '*'
	BEGIN
		SELECT  IdEmpleados, Nombre, APpellidoP, APpellidoM, Email, FechaIngreso, CURP, NumNomina, Telefono, FechaNac
		FROM Empleados  
		WHERE  Eliminacion = 0
		ORDER BY Nombre;
	END;

	IF @Accion = 'S'
	BEGIN
		SELECT  IdEmpleados, Nombre, APpellidoP, APpellidoM, Email, FechaIngreso, CURP, NumNomina, Telefono, FechaNac, Contraseña
		FROM Empleados  
		WHERE  IdEmpleados = @IdEmpleados;
	END;

	IF @Accion = 'T'
	BEGIN
		SELECT  IdEmpleados, Nombre, APpellidoP, APpellidoM, Email, FechaIngreso, CURP[CURP], NumNomina[Nomina], Telefono, FechaNac
		FROM Empleados  
	END;

	IF @Accion = 'V'
	BEGIN
		SELECT  IdAdministrador, IdEmpleado, CodigoAcceso
		FROM Administrador  
		WHERE IdEmpleado = @IdEmpleados and Eliminacion = 0;
	END;

	IF @Accion='P'
	BEGIN
		SELECT dbo.fn_IdProvisional() 
	END

END;



/*------------------------------------------------------------------------*/