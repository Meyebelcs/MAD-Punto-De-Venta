USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spHistorial_Productos')IS NOT NULL
BEGIN
DROP PROCEDURE spHistorial_Productos;
END;
GO

CREATE PROCEDURE spHistorial_Productos(
@Accion				CHAR(1),
@IdHistorialIp      INT = NULL,
@IdInfoProducto     INT = NULL,
@FechaDeCambios     DATETIME = NULL,
@IdUsuarioModificacion INT = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Historial_Productos(FechaDeCambios)
		VALUES(@FechaDeCambios);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Historial_Productos
		SET
			FechaDeCambios = @FechaDeCambios
		WHERE IdHistorialIp = @IdHistorialIp;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Historial_Productos WHERE  IdHistorialIp = @IdHistorialIp;
	END;


	IF @Accion = '*'
	BEGIN
		SELECT IdHistorialIp[IdHistorialIp],IdInfoProducto[IdInfoProducto],FechaDeCambios[FechaDeCambios],IdUsuarioModificacion[IdUsuarioModificacion]
		FROM Historial_Productos  
		ORDER BY IdHistorialIp;

 END;
END;



/*------------------------------------------------------------------------*/