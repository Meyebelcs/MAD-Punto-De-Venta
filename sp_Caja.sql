USE DB_MAD;
Go

/*-----------------------------spCaja-------------------------------------------*/
IF OBJECT_ID('spCaja')IS NOT NULL
BEGIN
DROP PROCEDURE spCaja;
END;
GO

CREATE PROCEDURE spCaja(
@Accion				CHAR(1),
@IdCaja             INT = NULL,
@IdAdministrador    INT = NULL,
@IdCajero           INT = NULL,
@Numero				INT = NULL, --Ejemplo Caja 1
@Eliminacion		BIT = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Caja(IdCajero,IdAdministrador,Numero, Eliminacion)
		VALUES(NULL,@IdAdministrador,@Numero,0);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Caja
		SET
			IdAdministrador = @IdAdministrador,
			Numero = @Numero

		WHERE IdCaja = @IdCaja;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE 
		FROM Caja 
		WHERE  IdCaja = @IdCaja;
	END;

	IF @Accion = 'E' 
	/*eliminacion logica*/
	BEGIN
		UPDATE Caja 
		SET
			Eliminacion = 1 
			WHERE  IdCaja = @IdCaja;
	END;

	IF @Accion = 'M'
	BEGIN
		Select MAX(IdCaja) 
		from Caja
	END;

	IF @Accion = '*'
	BEGIN
		SELECT IdCaja[IdCaja],IdAdministrador[Quién dió de alta],Numero[Num Caja]
		FROM Caja 
		WHERE Eliminacion = 0 
		ORDER BY IdCaja;

 END;
END;



/*------------------------------------------------------------------------*/