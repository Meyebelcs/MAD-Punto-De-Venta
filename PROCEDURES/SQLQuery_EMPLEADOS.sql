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
@Contrase�a			VARCHAR(10) = NULL,
@NumNomina			INT = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Empleados(Nombre,APpellidoP,APpellidoM,Telefono,Email,FechaIngreso,CURP,FechaNac,Contrase�a,NumNomina)
		VALUES(@Nombre,@APpellidoP,@APpellidoM,@Telefono,@Email,@FechaIngreso,@CURP,@FechaNac,@Contrase�a, @NumNomina);
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
			Contrase�a = @Contrase�a,
			NumNomina = @NumNomina
		WHERE IdEmpleados = @IdEmpleados;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Empleados WHERE  IdEmpleados = @IdEmpleados;
	END;



	IF @Accion = '*'
	BEGIN
		SELECT  IdEmpleados, Nombre, APpellidoP, APpellidoM, Email, FechaIngreso, CURP, NumNomina, Telefono, FechaNac
		FROM Empleados  
		ORDER BY Nombre;

	IF @Accion = 'L'
	BEGIN
		SELECT  IdEmpleados[IdEmpleados], Nombre[Nombre], APpellidoP[APpellidoP], APpellidoM[APpellidoM]
		FROM Empleados  
		WHERE IdEmpleados = @IdEmpleados AND Contrase�a = @Contrase�a;

 END;
END;



/*------------------------------------------------------------------------*/