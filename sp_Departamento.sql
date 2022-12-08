USE DB_MAD;
Go

/*-----------------------------spDepartamento-------------------------------------------*/
IF OBJECT_ID('spDepartamento')IS NOT NULL
BEGIN
DROP PROCEDURE spDepartamento;
END;
GO

CREATE PROCEDURE spDepartamento(
@Accion				CHAR(1),
@IdDepartamento	    INT = NULL,
@Nombre             VARCHAR(50) = NULL,
@Descripcion        VARCHAR(100) = NULL,
@IdAdminstrador    	INT = NULL,
@PermiteDevolucion	BIT= NULL,
@Eliminacion		BIT =NULL,
@FechaIngreso		DATETIME= NULL

)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Departamento(Nombre, Descripcion,IdAdminstrador,PermiteDevolucion,Eliminacion,FechaIngreso)
		VALUES(@Nombre,@Descripcion,@IdAdminstrador,@PermiteDevolucion,@Eliminacion,@FechaIngreso);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Departamento
		SET
			Nombre = @Nombre ,            
			Descripcion  = @Descripcion ,       
			IdAdminstrador  = @IdAdminstrador  ,  	
			PermiteDevolucion =	@PermiteDevolucion	,
			Eliminacion	=@Eliminacion	,	
			FechaIngreso=@FechaIngreso		

		WHERE IdDepartamento = @IdDepartamento;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE 
		FROM Departamento 
		WHERE  IdDepartamento = @IdDepartamento;
	END;

	IF @Accion = 'E' 
	/*eliminacion logica*/
	BEGIN
		UPDATE Departamento 
		SET
			Eliminacion = 1 
			WHERE  IdDepartamento = @IdDepartamento;
	END;

	IF @Accion = 'S'
	BEGIN
		SELECT  IdDepartamento[IdDepartamento], Nombre[Nombre],Descripcion[Descripcion],IdAdminstrador[IdAdmins],PermiteDevolucion[Permite Devolucion],Eliminacion[Eliminacion],FechaIngreso[Fecha Ingreso]
		FROM Departamento  
		WHERE IdDepartamento = @IdDepartamento;
	END;

	IF @Accion = 'V'
	BEGIN
		SELECT  IdDepartamento[IdDepartamento], Nombre[Nombre],Descripcion[Descripcion],IdAdminstrador[IdAdmins],PermiteDevolucion[Permite Devolucion],Eliminacion[Eliminacion],FechaIngreso[Fecha Ingreso]
		FROM Departamento  
		WHERE IdDepartamento = @IdDepartamento and Eliminacion = 0;
	END;

	IF @Accion = 'T'
	BEGIN
		SELECT  IdDepartamento[IdDepartamento], Nombre[Nombre],Descripcion[Descripcion],IdAdminstrador[IdAdmins],PermiteDevolucion[Permite Devolucion],Eliminacion[Eliminacion],FechaIngreso[Fecha Ingreso]
		FROM Departamento  
		WHERE  Eliminacion = 0;
	END;

	IF @Accion='P'
	BEGIN
		SELECT dbo.fn_IdProvisionalDepartamento() 
	END

	IF @Accion = '*'
	BEGIN

		SELECT  IdDepartamento[IdDepartamento], Nombre[Nombre],Descripcion[Descripcion],IdAdminstrador[IdAdmins],PermiteDevolucion[Permite Devolucion],Eliminacion[Eliminacion],FechaIngreso[Fecha Ingreso]
		FROM Departamento  
		WHERE  Eliminacion = 0
		ORDER BY IdDepartamento;

 END;
END;



/*------------------------------------------------------------------------*/