USE DB_MAD;
Go

/*-----------------------------spDevolucion-------------------------------------------*/
IF OBJECT_ID('spDevolucion')IS NOT NULL
BEGIN
DROP PROCEDURE spDevolucion;
END;
GO

CREATE PROCEDURE spDevolucion(
@Accion				CHAR(1),
@IdDevolucion         INT = NULL,
@IdProducto			 INT = NULL,
@IdDepartamento		 INT = NULL,
@IdAdministrador	INT = NULL,
@IdVenta              INT = NULL,
@Merma                BIT  = NULL,
@Motivo				 VARCHAR(80)= NULL,
@FechaRegistro datetime =NULL,
@IdTicket INT =NULL

)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Devolucion(IdProducto,IdDepartamento,IdAdministrador,IdVenta, Merma,Motivo,FechaRegistro,IdTicket)
		VALUES(@IdProducto,@IdDepartamento,@IdAdministrador,@IdVenta, @Merma,@Motivo,@FechaRegistro,@IdTicket);
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE 
		FROM Devolucion 
		WHERE  IdDevolucion = @IdDevolucion;
	END;

	IF @Accion = 'A'
    BEGIN
        UPDATE Devolucion 
		SET Merma = 0 
		WHERE IdDevolucion = @IdDevolucion;
    END;

    IF @Accion = 'U'
    BEGIN
        UPDATE 
		Devolucion 
		SET Merma = 1 
		WHERE IdDevolucion = @IdDevolucion;
    END;

	IF @Accion = 'T'
	BEGIN
		SELECT IdDevolucion[IdDevoluion],IdVenta[IdVenta],Merma[Merma], IdProducto[IdPreductos],IdDepartamento[IdDepartamento],IdAdministrador[IdAdministrador],Motivo[IdAdministrador]
		FROM Devolucion 
		ORDER BY IdDevolucion;
	END;

		IF @Accion = 'C'
	BEGIN
		SELECT NombreProducto[Nombre Producto],CantidadProducto[Cantidad Vendida],UnidadMedida[Unidad de Medida],Costo[Costo],Descuento[Descuento],subtotal[subtotal],Total[Total],
		Departamento[Departamento],IdVenta[IdVenta],IdProducto[IdProducto]
		FROM Venta 
		where  Identificador = @IdVenta
	END;

		IF @Accion = 'V'
	BEGIN
		SELECT IdDevolucion[IdDevoluion]
		FROM Devolucion 
		where  IdVenta = @IdVenta
	END;

	IF @Accion = '*'
	BEGIN
		SELECT IdDevolucion[IdDevoluion],IdVenta[IdVenta],Merma[Merma], P.Nombre[Nombre],D.FechaRegistro[Fecha Registro],P.IdDepartamento[IdDepartamento],D.IdAdministrador[IdAdministrador],D.Motivo[IdAdministrador], D.IdTicket[IdTicket]
		FROM Devolucion D JOIN Productos P 
		ON D.IdProducto = P.IdProducto
		ORDER BY IdDevolucion;
 END;
END;



/*------------------------------------------------------------------------*/