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
@CantidadDeInventario INT = NULL,
@Existencia         INT = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Productos(Nombre, Descripcion,Descuento,UnidaddeMedida, Costo, Eliminacion,
		CantidadDeInventario,Existencia )
		VALUES(@Nombre,@Descripcion, @Descuento, @UnidaddeMedida,@Costo,@Eliminacion,
		@CantidadDeInventario,@Existencia);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Productos
		SET
			Nombre = @Nombre,
			Descripcion = @Descripcion,
			Descuento = @Descuento,
			UnidaddeMedida = @UnidaddeMedida,
			Costo = @Costo,
			Eliminacion = @Eliminacion,
			CantidadDeInventario = @CantidadDeInventario,
			Existencia = @Existencia

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
        SELECT P.IdProducto
		FROM Productos P JOIN Info_Productos I
		on P.IdProducto = I.IdProducto
		WHERE P.CantidadDeInventario <= I.PuntoReorden

    END;

	IF @Accion = '*'
	BEGIN
		SELECT IdProducto[IdProducto],Departamento[Departamento],Nombre[Nombre],Descripcion,Descuento[Descuento],UnidaddeMedida[UnidadMedida],Costo[Costo],Eliminacion[Eliminacion],
		CantidadDeInventario[CantidadInventario],Existencia[Existencia]
		FROM Productos  
		ORDER BY Nombre;

 END;
END;



/*------------------------------------------------------------------------*/