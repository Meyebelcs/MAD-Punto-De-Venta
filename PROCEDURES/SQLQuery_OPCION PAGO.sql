USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spOpcion_Pago')IS NOT NULL
BEGIN
DROP PROCEDURE spOpcion_Pago;
END;
GO

CREATE PROCEDURE spOpcion_Pago(
@Accion				CHAR(1),
@IdPago             INT = NULL,
@Nombre             VARCHAR(30) = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Opcion_Pago(Nombre)
		VALUES(@Nombre);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Opcion_Pago
		SET
			Nombre = @Nombre
		WHERE IdPago = @IdPago;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Opcion_Pago WHERE  IdPago = @IdPago;
	END;


	IF @Accion = '*'
	BEGIN
		SELECT IdPago[IdPago],Nombre[Nombre]
		FROM Opcion_Pago  
		ORDER BY IdPago;

 END;
END;



/*------------------------------------------------------------------------*/