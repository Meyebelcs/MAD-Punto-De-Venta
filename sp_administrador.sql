USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spAdministrador')IS NOT NULL
BEGIN
DROP PROCEDURE spAdministrador;
END;
GO

CREATE PROCEDURE spAdministrador(
@Accion				CHAR(1),
@IdAdministrador	INT = NULL,
@IdEmpleado			INT = NULL,
@CodigoAcceso		INT = NULL,
@Eliminacion		BIT=NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Administrador(IdEmpleado, CodigoAcceso,Eliminacion)
		VALUES(@IdEmpleado, @CodigoAcceso,@Eliminacion);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Administrador
		SET
			IdEmpleado = @IdEmpleado,
			CodigoAcceso = @CodigoAcceso
		WHERE IdAdministrador = @IdAdministrador;
	END;

	IF @Accion = 'E' 
	/*eliminacion logica*/
	BEGIN
		UPDATE Administrador 
		SET
			Eliminacion = 1 
			WHERE IdAdministrador = @IdAdministrador;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE 
			FROM Administrador 
			WHERE  IdAdministrador = @IdAdministrador;
	END;

	IF @Accion = 'V'
	BEGIN
		SELECT  IdAdministrador, IdEmpleado, CodigoAcceso
		FROM Administrador  
		WHERE IdEmpleado = @IdEmpleado AND Eliminacion = 0;
	END;

	IF @Accion = '*'
	BEGIN
		SELECT  IdAdministrador[IdAdministrador], IdEmpleado[IdEmpleado], CodigoAcceso[CodigoAcceso]
		FROM Administrador  
		ORDER BY IdAdministrador;


 END;
END;



/*------------------------------------------------------------------------*/