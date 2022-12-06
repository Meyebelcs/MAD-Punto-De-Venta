USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spDepartamento')IS NOT NULL
BEGIN
DROP PROCEDURE spDepartamento;
END;
GO

CREATE PROCEDURE spDepartamento(
@Accion				CHAR(1),
@IdDepartamento	    INT = NULL,
@Nombre             VARCHAR(20) = NULL,
@Descripcion        VARCHAR(100) = NULL,
@IdAdmins     		INT = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Departamento(Nombre, Descripcion)
		VALUES(@Nombre,@Descripcion);
	END;

	IF @Accion = 'U'
	BEGIN
		UPDATE Departamento
		SET
			Nombre = @Nombre,
			Descripcion = @Descripcion
		WHERE IdDepartamento = @IdDepartamento;
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Departamento WHERE  IdDepartamento = @IdDepartamento;
	END;



	IF @Accion = '*'
	BEGIN
		SELECT  IdDepartamento[IdDepartamento], Nombre[Nombre],Descripcion[Descripcion],IdAdmins[IdAdmins] 
		FROM Departamento  
		ORDER BY IdDepartamento;

 END;
END;



/*------------------------------------------------------------------------*/