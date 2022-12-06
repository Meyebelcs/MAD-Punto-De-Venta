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
@IdAdmin            INT = NULL /*quien lo dio de alta*/
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Cajero(IdEmpleado, IdAdmin)
		VALUES(@IdEmpleado, @IdAdmin);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Cajero
		SET
			IdEmpleado = @IdEmpleado,
			IdAdmin    = @IdAdmin   

		WHERE IdCajero = @IdCajero;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE 
		FROM Cajero 
		WHERE  IdCajero = @IdCajero;
	END;



	IF @Accion = '*'
	BEGIN
		SELECT  IdCajero[IdCajero], IdEmpleado[IdEmpleado], IdAdmin[IdAdmin]
		FROM Cajero  
		ORDER BY IdCajero;

 END;
END;



/*------------------------------------------------------------------------*/