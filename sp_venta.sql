USE DB_MAD;
Go

/*-----------------------------spVenta-------------------------------------------*/
IF OBJECT_ID('spVenta')IS NOT NULL
BEGIN
DROP PROCEDURE spVenta;
END;
GO

CREATE PROCEDURE spVenta(
@Accion				CHAR(1),
@IdVenta            INT = NULL,
@IdProducto			INT = NULL,
@NombreProducto	    VARCHAR(30) = NULL,
@CantidadProducto    decimal(10,2)= NULL,
@CostoUnitario		decimal(10,2)= NULL,
@Costo				decimal(10,2)= NULL,
@Descuento           VARCHAR(10) = NULL, --AQUI ES VARCHAR PARA GUARDAR ASI 30%, YA Q SOLO ES POR SI CAMBIAN EN LA BASE
@subtotal			decimal(10,2)= NULL,
@Total				decimal(10,2)= NULL,
@Departamento        VARCHAR(20) = NULL,
@MontoCambio			decimal(10,2) = NULL,
@MontopPagado		decimal(10,2)= NULL,
@FechaRegistro		datetime= NULL,
@NombreCajero		VARCHAR(100) = NULL,
@IdCajero			INT= NULL,
@IdDepartamento		INT = NULL,
@UnidadMedida		VARCHAR(30) = NULL,
@Identificador   INT = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Venta(IdProducto,NombreProducto,CantidadProducto,CostoUnitario,Costo,Descuento,subtotal,Total,Departamento,MontoCambio,MontopPagado,FechaRegistro,NombreCajero,IdCajero,IdDepartamento,UnidadMedida,Identificador)
		VALUES(@IdProducto,@NombreProducto,@CantidadProducto,@CostoUnitario,@Costo,@Descuento,@subtotal,@Total,@Departamento,@MontoCambio,@MontopPagado,@FechaRegistro,@NombreCajero,@IdCajero,@IdDepartamento,@UnidadMedida,@Identificador);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Venta
		SET
			IdProducto			=@IdProducto,			
			NombreProducto		=@NombreProducto,	    
			CantidadProducto	=@CantidadProducto,   
			CostoUnitario		=@CostoUnitario	,	
			Costo				=@Costo		,		
			Descuento			=@Descuento ,         
			subtotal			=@subtotal	,		
			Total				=@Total	,			
			Departamento		=@Departamento ,      
			MontoCambio			=@MontoCambio,		
			MontopPagado		=@MontopPagado,		
			FechaRegistro		=@FechaRegistro,		
			NombreCajero		=@NombreCajero,		
			IdCajero			=@IdCajero	,		
			IdDepartamento		=@IdDepartamento,		
			UnidadMedida		=@UnidadMedida,
			Identificador		=@Identificador		

		WHERE IdVenta = @IdVenta;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE 
		FROM Venta 
		WHERE  IdVenta = @IdVenta;
	END;

	
	IF @Accion = 'M'
	BEGIN
		Select MAX(IdVenta) 
		FROM Venta 
	END;

	IF @Accion = 'T'
	BEGIN
		SELECT NombreProducto[Nombre Producto],CantidadProducto[Cantidad Vendida],UnidadMedida[Unidad de Medida],Costo[Costo],Descuento[Descuento],subtotal[subtotal],Total[Total],
		Departamento[Departamento],IdVenta[IdVenta],IdProducto[IdProducto]
		FROM Venta  
		WHERE Identificador = @Identificador;
	END;

	IF @Accion = 'X'
	BEGIN
		SELECT IdVenta[IdVenta],IdProducto[IdProducto],NombreProducto[Nombre Producto],CantidadProducto[Cantidad Vendida],CostoUnitario[CostoUnitario],Costo[Costo],Descuento[Descuento],subtotal[subtotal],Total[Total],
		Departamento[Departamento],MontoCambio[Monto Cambio],MontopPagado[Monto Pagado],FechaRegistro[FechaRegistro],NombreCajero[Nombre Cajero],IdCajero[IdCajero],IdDepartamento[IdDepartamento],UnidadMedida[Unidad de Medida]
		FROM Venta  
		WHERE IdVenta = @IdVenta;
	 END;

	IF @Accion = '*'
	BEGIN
		SELECT IdVenta[IdVenta],IdProducto[IdProducto],NombreProducto[Nombre Producto],CantidadProducto[Cantidad Vendida],CostoUnitario[CostoUnitario],Costo[Costo],Descuento[Descuento],subtotal[subtotal],Total[Total],
		Departamento[Departamento],MontoCambio[Monto Cambio],MontopPagado[Monto Pagado],FechaRegistro[FechaRegistro],NombreCajero[Nombre Cajero],IdCajero[IdCajero],IdDepartamento[IdDepartamento],UnidadMedida[Unidad de Medida]
		FROM Venta  
		ORDER BY IdVenta;

 END;
END;



/*------------------------------------------------------------------------*/