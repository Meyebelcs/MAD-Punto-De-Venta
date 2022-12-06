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
@IdAdmin            INT = NULL,
@NumCaja     		INT = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Cajero(NumCaja)
		VALUES(@NumCaja);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Cajero
		SET
			NumCaja = @NumCaja
		WHERE IdCajero = @IdCajero;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Cajero WHERE  IdCajero = @IdCajero;
	END;



	IF @Accion = '*'
	BEGIN
		SELECT  IdCajero[IdCajero], IdEmpleado[IdEmpleado], IdAdmin[IdAdmin], NumCaja[NumCaja]
		FROM Cajero  
		ORDER BY IdCajero;

 END;
END;



/*------------------------------------------------------------------------*/