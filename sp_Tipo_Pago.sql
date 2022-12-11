USE DB_MAD;
Go

/*-----------------------------spTipo_Pago-------------------------------------------*/
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
@IdVenta            INT = NULL,
@Identificador		INT = NULL,
@Opcion				VARCHAR(50)= NULL,
@MontoCambio	decimal(10,2) =NULL,
@MontopPagado	 decimal(10,2) =NULL,
@Eliminacion		 BIT= NULL
)

AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Tipo_Pago(IdCajero, IdPago,IdVenta, Identificador,Opcion,MontoCambio,MontopPagado,Eliminacion)
		VALUES(@IdCajero,@IdPago, @IdVenta, @Identificador,@Opcion,0,0,0);
	END;


	IF @Accion = 'D'
	BEGIN
		DELETE 
		FROM Tipo_Pago 
		WHERE Identificador = @Identificador
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Tipo_Pago
		SET
			MontopPagado = @MontopPagado
		WHERE IdTipo = @IdTipo;
	END;

	IF @Accion = 'T'
	BEGIN
		SELECT Opcion[Opcion de pago], IdPago[IdPago],IdTipo[IdTipo],MontopPagado[Monto a Pagar]
		FROM Tipo_Pago
		WHERE  Identificador = @Identificador

    END;

	IF @Accion = '*'
	BEGIN
		SELECT IdPago[IdPago],IdCajero[IdCajero],IdTipo[IdTipo],IdVenta[IdVenta],Opcion[Opcion de pago],MontoCambio[Monto Cambio],MontopPagado[Monto Pagado]
		FROM Tipo_Pago  
		ORDER BY IdPago;

    END;
END;



/*------------------------------------------------------------------------*/