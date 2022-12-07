USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spProductos')IS NOT NULL
BEGIN
DROP PROCEDURE spProductos;
END;
GO

CREATE PROCEDURE spProductos(
@Accion				CHAR(1),
@IdProducto         INT = NULL,
@IdDepartamento     INT = NULL,
@Nombre             VARCHAR(20) = NULL,
@Descripcion        VARCHAR(100) = NULL,
@Descuento     		BIT = NULL,
@UnidaddeMedida     VARCHAR(20) = NULL,
@Costo              MONEY = NULL,
@Eliminacion        BIT = NULL,
@CantidadDeInventario INT = NULL

)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Productos(Nombre,IdDepartamento, Descripcion,Descuento,UnidaddeMedida, Costo, Eliminacion,
		CantidadDeInventario )
		VALUES(@Nombre,@IdDepartamento,@Descripcion, @Descuento, @UnidaddeMedida,@Costo,@Eliminacion,
		@CantidadDeInventario);
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
		DELETE FROM Productos WHERE  IdProducto = @IdProducto;
	END;

	IF @Accion = 'L'
    BEGIN
        UPDATE Productos SET
        Descuento = 0 WHERE  IdProducto = @IdProducto;
    END;

    IF @Accion = 'A'
    BEGIN
        UPDATE Productos SET
        Descuento = 1 WHERE IdProducto = @IdProducto;
    END;

		IF @Accion = 'M'
    BEGIN
        UPDATE Productos SET
        Eliminacion = 0 WHERE  IdProducto = @IdProducto;
    END;

    IF @Accion = 'N'
    BEGIN
        UPDATE Productos SET
        Eliminacion = 1 WHERE IdProducto = @IdProducto;
    END;

	 IF @Accion = 'J'
    BEGIN
        SELECT P.IdProducto [IdProducto],P.Nombre [Nombre],P.IdDepartamento [Departamento],P.Descuento [Descuento],
		P.UnidaddeMedida [UnidadMedida],P.Costo [Costo],P.CantidadDeInventario [Inventario]
		FROM Productos P JOIN Info_Productos I
		on P.IdProducto = I.IdProducto
		WHERE P.CantidadDeInventario <= I.PuntoReorden
		AND P.Eliminacion = 0

    END;

	IF @Accion = '*'
	BEGIN
		SELECT IdProducto [IdProducto],IdDepartamento [Departamento],Nombre [Nombre],Descripcion [Descripcion],Descuento [Descuento],UnidaddeMedida [UnidadMedida],Costo [Costo],Eliminacion [Eliminacion],
		CantidadDeInventario [CantidadInventario]
		FROM Productos  
		ORDER BY Nombre;

 END;
END;



/*------------------------------------------------------------------------*/