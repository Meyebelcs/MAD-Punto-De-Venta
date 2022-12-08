USE DB_MAD;
Go

/*-----------------------------spHistorial_Productos-------------------------------------------*/
IF OBJECT_ID('spHistorial_Productos')IS NOT NULL
BEGIN
DROP PROCEDURE spHistorial_Productos;
END;
GO

CREATE PROCEDURE spHistorial_Productos(
@Accion					CHAR(1),
@IdHistorialIp			INT = NULL,
@IdUsuarioModificacion INT = NULL,
@IdInfoProducto			INT = NULL,
@FechaDeCambios			DATETIME = NULL,
@Eliminacion			BIT= NULL,
@IdProducto				INT= NULL

)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Historial_Productos(IdUsuarioModificacion,IdInfoProducto,FechaDeCambios,Eliminacion,IdProducto)
		VALUES(@IdUsuarioModificacion,@IdInfoProducto,@FechaDeCambios,@Eliminacion,@IdProducto);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Historial_Productos
		SET
			
			IdUsuarioModificacion  =@IdUsuarioModificacion ,
			IdInfoProducto			=@IdInfoProducto,			
			FechaDeCambios			=@FechaDeCambios,			
			Eliminacion				=@Eliminacion	,		
			IdProducto				=@IdProducto				

		WHERE IdHistorialIp = @IdHistorialIp;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE 
		FROM Historial_Productos 
		WHERE  IdHistorialIp = @IdHistorialIp;
	END;

	IF @Accion = 'E'
    BEGIN
	/*ELIMINACION LOGICA*/
        UPDATE Historial_Productos 
		SET
			Eliminacion = 1 
		WHERE IdHistorialIp = @IdHistorialIp;
    END;

	IF @Accion = 'S'
	BEGIN
		SELECT IdHistorialIp[IdHistorialIp],IdUsuarioModificacion[IdUsuarioModificacion],IdInfoProducto[IdInfoProducto],FechaDeCambios[FechaDeCambios],Eliminacion[Eliminacion],IdProducto[IdProducto]
		FROM Historial_Productos  
		WHERE  IdHistorialIp = @IdHistorialIp;
	END;

	IF @Accion = 'V'
	BEGIN
		SELECT IdHistorialIp[IdHistorialIp],IdUsuarioModificacion[IdUsuarioModificacion],IdInfoProducto[IdInfoProducto],FechaDeCambios[FechaDeCambios],Eliminacion[Eliminacion],IdProducto[IdProducto]
		FROM Historial_Productos  
		WHERE IdHistorialIp = @IdHistorialIp and Eliminacion = 0;
	END;

	IF @Accion = '*'
	BEGIN
		SELECT IdHistorialIp[IdHistorialIp],IdUsuarioModificacion[IdUsuarioModificacion],IdInfoProducto[IdInfoProducto],FechaDeCambios[FechaDeCambios],Eliminacion[Eliminacion],IdProducto[IdProducto]
		FROM Historial_Productos  
		ORDER BY IdHistorialIp;

 END;
END;



/*------------------------------------------------------------------------*/