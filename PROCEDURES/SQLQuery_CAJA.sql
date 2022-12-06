USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spCaja')IS NOT NULL
BEGIN
DROP PROCEDURE spCaja;
END;
GO

CREATE PROCEDURE spCaja(
@Accion				CHAR(1),
@IdCaja             INT = NULL,
@IdCajero           INT = NULL,
@IdAdministrador    INT = NULL,
@Numero				  INT = NULL --Ejemplo Caja 1
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Caja(IdCajero,IdAdministrador,Numero)
		VALUES(@IdCajero,@IdAdministrador,@Numero);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Caja
		SET
			IdCajero = @IdCajero,
			IdAdministrador = @IdAdministrador,
			Numero = @Numero

		WHERE IdCaja = @IdCaja;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Caja WHERE  IdCaja = @IdCaja;
	END;


	IF @Accion = '*'
	BEGIN
		SELECT IdCaja[IdCaja],IdAdministrador[Quién dió de alta],Numero[Num Caja]
		FROM Caja  
		ORDER BY IdCaja;

 END;
END;



/*------------------------------------------------------------------------*/