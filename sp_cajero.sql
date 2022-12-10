USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spCajero')IS NOT NULL
BEGIN
DROP PROCEDURE spCajero;
END;
GO

CREATE PROCEDURE spCajero(
@Accion				CHAR(1),
@IdCajero	        INT = NULL,
@IdEmpleado	        INT = NULL,
@IdAdmin            INT = NULL, /*quien lo dio de alta*/
@Eliminacion		BIT=NULL,
@IdCaja				INT = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Cajero(IdEmpleado, IdAdmin, Eliminacion,IdCaja)
		VALUES(@IdEmpleado, @IdAdmin, @Eliminacion,0);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Cajero
		SET
			IdEmpleado = @IdEmpleado,
			IdAdmin    = @IdAdmin   

		WHERE IdCajero = @IdCajero;
	END;

	IF @Accion = 'M'
	BEGIN
		UPDATE Cajero
		SET
			IdCaja = @IdCaja

		WHERE IdEmpleado = @IdEmpleado;
	END;

	IF @Accion = 'E' 
	/*eliminacion logica*/
	BEGIN
		UPDATE Cajero 
		SET
			Eliminacion = 1 
			WHERE IdCajero = @IdCajero;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE 
		FROM Cajero 
		WHERE  IdCajero = @IdCajero;
	END;

	IF @Accion = 'T'
	BEGIN
		SELECT  IdCajero[IdCajero], IdEmpleado[IdEmpleado], IdAdmin[IdAdmin]
		FROM Cajero  
		WHERE IdCaja = 0 and Eliminacion = 0
	END;

	IF @Accion = 'V'
	BEGIN
		SELECT IdCajero, IdEmpleado, IdAdmin
		FROM Cajero  
		WHERE IdEmpleado = @IdEmpleado AND Eliminacion = 0;
	END;

	IF @Accion='B'
	BEGIN
		SELECT dbo.fn_busquedaCajero(@IdCaja)
	END

	IF @Accion = '*'
	BEGIN
		SELECT  IdCajero[IdCajero], IdEmpleado[IdEmpleado], IdAdmin[IdAdmin]
		FROM Cajero  
		ORDER BY IdCajero;
 END;
END;



/*------------------------------------------------------------------------*/