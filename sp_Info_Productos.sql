USE DB_MAD;
Go

/*-----------------------------spInfo_Productos-------------------------------------------*/
IF OBJECT_ID('spInfo_Productos')IS NOT NULL
BEGIN
DROP PROCEDURE spInfo_Productos;
END;
GO

CREATE PROCEDURE spInfo_Productos(
@Accion				CHAR(1),
@IdInfoProductos   INT = NULL,
@IdAdministrador     INT = NULL,
@IdProducto         INT = NULL,
@FechaDeAlta        DATETIME = NULL,
@PuntoReorden		INT = NULL,
@PrecioUnitario     decimal(10,2) = NULL,
@Eliminacion		BIT = NULL

)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Info_Productos(IdAdministrador,IdProducto,FechaDeAlta, PuntoReorden,PrecioUnitario, Eliminacion)
		VALUES(@IdAdministrador,@IdProducto,@FechaDeAlta,@PuntoReorden, @PrecioUnitario,@Eliminacion);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Info_Productos
		SET
			IdAdministrador= @IdAdministrador,
			IdProducto    = @IdProducto ,    
			FechaDeAlta  = @FechaDeAlta  ,  
			PuntoReorden	=@PuntoReorden	,
			PrecioUnitario =@PrecioUnitario ,
			Eliminacion	=@Eliminacion	
		WHERE IdInfoProductos = @IdInfoProductos;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE 
		FROM Info_Productos 
		WHERE  IdInfoProductos = @IdInfoProductos;
	END;

	IF @Accion = 'E'
    BEGIN
	/*ELIMINACION LOGICA*/
        UPDATE Info_Productos 
		SET
			Eliminacion = 1 
		WHERE  IdInfoProductos = @IdInfoProductos;
    END;

	IF @Accion = 'S'
	BEGIN
		SELECT IdInfoProductos[IdInfoProductos],IdAdministrador[IdAdministrador], IdProducto[IdProducto],FechaDeAlta[FechaDeAlta],PuntoReorden[PuntoReorden],PrecioUnitario[PrecioUnitario],Eliminacion[Eliminacion]
		FROM Info_Productos  
		WHERE  IdInfoProductos = @IdInfoProductos;
	END;

	IF @Accion = 'V'
	BEGIN
		SELECT IdInfoProductos[IdInfoProductos],IdAdministrador[IdAdministrador], IdProducto[IdProducto],FechaDeAlta[FechaDeAlta],PuntoReorden[PuntoReorden],PrecioUnitario[PrecioUnitario],Eliminacion[Eliminacion]	
		FROM Info_Productos  
		WHERE IdInfoProductos = @IdInfoProductos and Eliminacion = 0;
	END;

	IF @Accion = '*'
	BEGIN
		SELECT IdInfoProductos[IdInfoProductos],IdAdministrador[IdAdministrador], IdProducto[IdProducto],FechaDeAlta[FechaDeAlta],PuntoReorden[PuntoReorden],PrecioUnitario[PrecioUnitario],Eliminacion[Eliminacion]
		FROM Info_Productos  
		ORDER BY IdProducto;

 END;
END;



/*------------------------------------------------------------------------*/