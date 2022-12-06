USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spInfo_Productos')IS NOT NULL
BEGIN
DROP PROCEDURE spInfo_Productos;
END;
GO

CREATE PROCEDURE spInfo_Productos(
@Accion				CHAR(1),
@IdInfoProductos   INT = NULL,
@IdProducto         INT = NULL,
@FechaDeAlta        DATETIME = NULL,
@PuntoReorden		INT = NULL,
@PrecioUnitario      MONEY = NULL,
@IdAdministrador     INT = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Info_Productos(FechaDeAlta, PuntoReorden,PrecioUnitario )
		VALUES(@FechaDeAlta,@PuntoReorden, @PrecioUnitario);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Info_Productos
		SET
			FechaDeAlta = @FechaDeAlta,
			PuntoReorden = @PuntoReorden,
			PrecioUnitario = @PrecioUnitario
		WHERE IdInfoProductos = @IdInfoProductos;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Info_Productos WHERE  IdInfoProductos = @IdInfoProductos;
	END;


	IF @Accion = '*'
	BEGIN
		SELECT IdInfoProductos[IdInfoProductos],IdProducto[IdProducto],FechaDeAlta[FechaDeAlta],PuntoReorden[PuntoReorden],PrecioUnitario[PrecioUnitario],
		IdAdministrador[IdAdministrar]
		FROM Info_Productos  
		ORDER BY IdProducto;

 END;
END;



/*------------------------------------------------------------------------*/