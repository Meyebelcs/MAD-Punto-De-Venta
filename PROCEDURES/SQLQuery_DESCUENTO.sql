USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spDescuento')IS NOT NULL
BEGIN
DROP PROCEDURE spDescuento;
END;
GO

CREATE PROCEDURE spDescuento(
@Accion				CHAR(1),
@IdDescuento         INT = NULL,
@IdProducto          INT = NULL,
@IdDepartamento      INT = NULL,
@IdAdmin             INT = NULL,
@Porcentaje  	    INT = NULL,
@FechaInicio         DATETIME= NULL,
@FechaFinal          DATETIME= NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Descuento(IdProducto,IdDepartamento,IdAdmin,Porcentaje,FechaInicio,FechaFinal)
		VALUES(@IdProducto,@IdDepartamento,@IdAdmin,@Porcentaje,@FechaInicio,@FechaFinal);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Descuento
		SET
			IdProducto = @IdProducto,
			IdDepartamento = @IdDepartamento,
			IdAdmin = @IdAdmin,
			Porcentaje = @Porcentaje,
			FechaInicio = @FechaInicio,
			FechaFinal = @FechaFinal

		WHERE IdDescuento = @IdDescuento;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Descuento WHERE  IdDescuento = @IdDescuento;
	END;


	IF @Accion = '*'
	BEGIN
		SELECT IdProducto[código Producto],IdDepartamento[IdDepartamento],IdAdmin[quién dió de alta],Porcentaje[Porcentaje], FechaInicio[FechaInicio],FechaFinal[FechaFinal]
		FROM Descuento  
		ORDER BY IdDescuento;

 END;
END;



/*------------------------------------------------------------------------*/