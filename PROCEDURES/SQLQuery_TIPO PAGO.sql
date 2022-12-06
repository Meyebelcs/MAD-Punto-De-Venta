USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spTipo_Pago')IS NOT NULL
BEGIN
DROP PROCEDURE spTipo_Pago;
END;
GO

CREATE PROCEDURE spTipo_Pago(
@Accion				CHAR(1),
@IdTipo             INT = NULL,
@IdCajero           INT = NULL,
@IdPago             INT = NULL,
@IdVenta            INT = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	
	IF @Accion = 'D'
	BEGIN
		DELETE FROM Tipo_Pago WHERE  IdTipo = @IdTipo;
	END;


	IF @Accion = '*'
	BEGIN
		SELECT IdPago[IdPago],IdCajero[IdCajero],IdTipo[IdTipo],IdVenta[IdVenta]
		FROM Tipo_Pago  
		ORDER BY IdPago;

    END;
END;



/*------------------------------------------------------------------------*/