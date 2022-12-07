USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spBusqueda_Producto')IS NOT NULL
BEGIN
DROP PROCEDURE spBusqueda_Producto;
END;
GO

CREATE PROCEDURE spBusqueda_Producto(
@Accion				CHAR(1),
@IdBusqueda         INT = NULL,
@IdEmpleado         INT = NULL,
@IdProductos        INT = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Busqueda_Producto WHERE  IdBusqueda = @IdBusqueda;
	END;


	IF @Accion = '*'
	BEGIN
		SELECT IdBusqueda[IdBusqueda],IdEmpleado[IdEmpleado],IdProductos[IdProductos]
		FROM Busqueda_Producto  
		ORDER BY IdBusqueda;

 END;
END;



/*------------------------------------------------------------------------*/