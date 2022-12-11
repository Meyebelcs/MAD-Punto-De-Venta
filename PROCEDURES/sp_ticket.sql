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
@IdTipoPago        INT = NULL,
@FechaHr            DATETIME = NULL,
@NumCaja            INT = NULL,
@Subtotal           decimal(10,2) =NULL,
@DescuentoTotal     decimal(10,2) =NULL,
@MontoCambio		decimal(10,2)= NULL

)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Ticket(IdVenta,IdCajero,IdTipoPago,FechaHr,NumCaja,Subtotal,DescuentoTotal,MontoCambio)
		VALUES(@IdVenta,@IdCajero,@IdTipoPago,@FechaHr,@NumCaja,@Subtotal,@DescuentoTotal,@MontoCambio);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Ticket
		SET
			@IdVenta        =@IdVenta   ,     
			@IdCajero       = @IdCajero  ,     
			@IdTipoPago     = @IdTipoPago,     
			@FechaHr        = @FechaHr ,       
			@NumCaja        = @NumCaja  ,      
			@Subtotal       = @Subtotal  ,     
			@DescuentoTotal  =@DescuentoTotal ,
			@MontoCambio	 =@MontoCambio	

		WHERE IdTicket = @IdTicket;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE 
		FROM Ticket 
		WHERE  IdTicket = @IdTicket;
	END;


	IF @Accion = '*'
	BEGIN
		SELECT IdTicket [IdTicket],IdVenta[IdVenta],IdCajero[IdCajero],IdTipoPago[IdTipoPago],FechaHr[Fecha],NumCaja[Numero de Caja],
		Subtotal[Subtotal],DescuentoTotal[Descuento Total],MontoCambio[MontoCambio]
		FROM Ticket  
		ORDER BY IdTicket;

 END;
END;



/*------------------------------------------------------------------------*/