USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spNotaCredito')IS NOT NULL
BEGIN
DROP PROCEDURE spNotaCredito;
END;
GO

CREATE PROCEDURE spNotaCredito(
@Accion				CHAR(1),
@IdNotaCredito		 INT = NULL,
@idProducto			 INT = NULL,
@idTicket			 INT = NULL,
@cantidad			 decimal(10,2) =NULL,
@subtotal			 decimal(10,2) =NULL,
@total			   	decimal(10,2) =NULL,
@FechaDevolucion    DATETIME = NULL,
@IdCaja				INT = NULL,
@IdDevolucion		INT = NULL

)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO NotaCredito(idProducto,idTicket,cantidad,subtotal,total,FechaDevolucion,IdCaja, IdDevolucion)
		VALUES(@idProducto,@idTicket,@cantidad,@subtotal,@total,@FechaDevolucion,@IdCaja, @IdDevolucion);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE NotaCredito
		SET
			@idProducto		 = @idProducto	,	
			@idTicket		= @idTicket	,	
			@cantidad		= @cantidad	,	
			@subtotal		= @subtotal	,	
			@total			= @total	,		
			@FechaDevolucion= @FechaDevolucion,
			@IdCaja			= @IdCaja			

		WHERE IdNotaCredito = @IdNotaCredito;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE 
		FROM NotaCredito 
		WHERE   IdNotaCredito = @IdNotaCredito;
	END;

	IF @Accion = 'M'
	BEGIN
		Select MAX(IdNotaCredito) + 1
		 from NotaCredito
	END;
	
	IF @Accion = 'T'
	BEGIN
		SELECT IdNotaCredito[IdNotaCredito],idProducto[idProducto],idTicket[idTicket],cantidad[cantidad],subtotal[subtotal],total[total],FechaDevolucion[FechaDevolucion],IdCaja[IdCaja]
		FROM NotaCredito  
		WHERE IdNotaCredito = @IdNotaCredito;
 END;

	IF @Accion = '*'
	BEGIN
		SELECT IdNotaCredito[IdNotaCredito],idProducto[idProducto],idTicket[idTicket],cantidad[cantidad],subtotal[subtotal],total[total],FechaDevolucion[FechaDevolucion],IdCaja[IdCaja],IdDevolucion[IdDevolucion]
		FROM NotaCredito  
		ORDER BY IdNotaCredito;

 END;
END;



/*------------------------------------------------------------------------*/