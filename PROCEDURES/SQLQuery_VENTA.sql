USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spVenta')IS NOT NULL
BEGIN
DROP PROCEDURE spVenta;
END;
GO

CREATE PROCEDURE spVenta(
@Accion				CHAR(1),
@IdVenta            INT = NULL,
@NombreProducto     VARCHAR(20) = NULL,
@CantidadProducto   INT = NULL,
@Costo              MONEY = NULL,
@Descuento          INT = NULL,
@Departamento       VARCHAR(20) = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Venta(NombreProducto,CantidadProducto,Costo,Descuento,Departamento)
		VALUES(@NombreProducto,@CantidadProducto,@Costo,@Descuento,@Departamento);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Venta
		SET
			NombreProducto = @NombreProducto,
			CantidadProducto = @CantidadProducto,
			Costo = @Costo,
			Descuento = @Descuento,
			Departamento = @Departamento
		WHERE IdVenta = @IdVenta;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Venta WHERE  IdVenta = @IdVenta;
	END;


	IF @Accion = '*'
	BEGIN
		SELECT IdVenta[IdVenta],NombreProducto[NombreProducto],CantidadProducto[Cantidad],Costo[Costo], Descuento[Descuento],Departamento[Departamento]
		FROM Venta  
		ORDER BY IdVenta;

 END;
END;



/*------------------------------------------------------------------------*/