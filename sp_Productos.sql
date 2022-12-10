USE DB_MAD;
Go

/*-----------------------------spProductos-------------------------------------------*/
IF OBJECT_ID('spProductos')IS NOT NULL
BEGIN
DROP PROCEDURE spProductos;
END;
GO

CREATE PROCEDURE spProductos(
@Accion				CHAR(1),
@IdProducto         INT = NULL,
@Nombre             VARCHAR(20) = NULL,
@IdDepartamento     INT = NULL,
@Descripcion        VARCHAR(100) = NULL,
@Descuento     		BIT = NULL,
@UnidaddeMedida     VARCHAR(20) = NULL,
@Costo              decimal(10,2) = NULL,
@Eliminacion        BIT = NULL,
@CantidadDeInventario INT = NULL



)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Productos(Nombre,IdDepartamento, Descripcion,Descuento,UnidaddeMedida, Costo, Eliminacion,CantidadDeInventario )
		VALUES(@Nombre,@IdDepartamento,@Descripcion, @Descuento, @UnidaddeMedida,@Costo,@Eliminacion,@CantidadDeInventario);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Productos
		SET
			Nombre = @Nombre,
			IdDepartamento = @IdDepartamento,
			Descripcion = @Descripcion,
			Descuento = @Descuento,
			UnidaddeMedida = @UnidaddeMedida,
			Costo = @Costo,
			Eliminacion = @Eliminacion,
			CantidadDeInventario = @CantidadDeInventario

		WHERE IdProducto = @IdProducto;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE 
		FROM Productos 
		WHERE  IdProducto = @IdProducto;
	END;

	IF @Accion = 'L'
    BEGIN
	/*se habilitará el hecho de q contiene descuento*/
        UPDATE Productos 
		SET
			Descuento = 1 
		WHERE  IdProducto = @IdProducto and Eliminacion = 0;
    END;

    IF @Accion = 'A'
    BEGIN
	/*se deshabilitará el hecho de q contiene descuento*/
        UPDATE Productos 
		SET
        Descuento = 0 
		WHERE IdProducto = @IdProducto and Eliminacion = 0;
    END;

		IF @Accion = 'E'
    BEGIN
	/*ELIMINACION LOGICA*/
        UPDATE Productos 
		SET
			Eliminacion = 1 
		WHERE  IdProducto = @IdProducto ;
    END;

		IF @Accion = 'C'
    BEGIN
	/*ACTUALIZA DESCUENTO*/
        UPDATE Productos 
		SET
			Descuento = 1 
		WHERE  IdProducto = @IdProducto ;
    END;

	IF @Accion = 'O'
    BEGIN
	/*ACTUALIZA DESCUENTO*/
        UPDATE Productos 
		SET
			Descuento = 0 
		WHERE  IdProducto = @IdProducto ;
    END;

	IF @Accion = 'S'
	BEGIN
	SELECT IdProducto [IdProducto],IdDepartamento [Departamento],Nombre [Nombre],Descripcion [Descripcion],Descuento [Descuento],
		UnidaddeMedida [UnidadMedida],Costo [Costo],Eliminacion [Eliminacion],CantidadDeInventario [CantidadInventario]
		
		FROM Productos  
		WHERE  IdProducto = @IdProducto;
	END;

	IF @Accion = 'V'
	BEGIN
		SELECT IdProducto [IdProducto],IdDepartamento [Departamento],Nombre [Nombre],Descripcion [Descripcion],Descuento [Descuento],
		UnidaddeMedida [UnidadMedida],Costo [Costo],Eliminacion [Eliminacion],CantidadDeInventario [CantidadInventario]
		FROM Productos  
		WHERE IdProducto = @IdProducto and Eliminacion = 0;
	END;

	 IF @Accion = 'J'
    BEGIN
	/*iMPRIME LOS PRODUCTOS QUE YA LLEGARON AL PUNTO DE REORDEN*/
        SELECT P.IdProducto [IdProducto],P.Nombre [Nombre],P.IdDepartamento [Departamento],P.Descuento [Descuento],
		P.UnidaddeMedida [UnidadMedida],P.Costo [Costo],P.CantidadDeInventario [Inventario], P.Descripcion [Descripcion]

		FROM Productos P JOIN Info_Productos I
		on P.IdProducto = I.IdProducto
		WHERE P.CantidadDeInventario <= I.PuntoReorden AND P.Eliminacion = 0;

    END;

	IF @Accion = 'T'
	BEGIN
		SELECT IdProducto [IdProducto],IdDepartamento [Departamento],Nombre [Nombre]
		FROM Productos  
		WHERE Descuento = 0 and Eliminacion = 0;
	END;

	IF @Accion = '*'
	BEGIN
		SELECT IdProducto [IdProducto],IdDepartamento [Departamento],Nombre [Nombre],Descripcion [Descripcion],Descuento [Descuento],
		UnidaddeMedida [UnidadMedida],Costo [Costo],Eliminacion [Eliminacion],CantidadDeInventario [CantidadInventario]

		FROM Productos  
		ORDER BY Nombre;

	END;

	IF @Accion='P'
	BEGIN
		SELECT dbo.fn_IdProvisionalProductos() 
	END
END;






/*------------------------------------------------------------------------*/