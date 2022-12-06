USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spTicket')IS NOT NULL
BEGIN
DROP PROCEDURE spTicket;
END;
GO

CREATE PROCEDURE spTicket(
@Accion				CHAR(1),
@IdTicket           INT = NULL,
@IdVenta            INT = NULL,
@IdCajero           INT = NULL,
@IdProductos        INT = NULL,
@FechaHr            DATETIME = NULL,
@NumCaja            INT = NULL,
@TipoPago           VARCHAR(20)  = NULL,
@Subtotal           MONEY = NULL,
@DescuentoTotal      MONEY = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Ticket(FechaHr,NumCaja,TipoPago,Subtotal,DescuentoTotal)
		VALUES(@FechaHr,@NumCaja,@TipoPago,@Subtotal,@DescuentoTotal);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Ticket
		SET
			FechaHr = @FechaHr,
			NumCaja = @NumCaja,
			TipoPago = @TipoPago,
			Subtotal = @Subtotal,
			DescuentoTotal = @DescuentoTotal
		WHERE IdTicket = @IdTicket;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Ticket WHERE  IdTicket = @IdTicket;
	END;


	IF @Accion = '*'
	BEGIN
		SELECT IdTicket [IdTicket],IdVenta[IdVenta],IdCajero[IdCajero],IdProductos[IdProductos],FechaHr[Fecha],NumCaja[Numero de Caja],TipoPago[Tipo de Pago],
		Subtotal[Subtotal],DescuentoTotal[Descuento Total]
		FROM Ticket  
		ORDER BY IdTicket;

 END;
END;



/*------------------------------------------------------------------------*/