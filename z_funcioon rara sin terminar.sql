--FUNCIONES
USE DB_MAD

IF OBJECT_ID('fn_ChecarRol')IS NOT NULL
	DROP FUNCTION fn_ChecarRol;
Go
CREATE FUNCTION fn_ChecarRol
(
	@IdEmpleado INT
)
RETURNS int
BEGIN

	DECLARE @EsAdmin int;
	
	SELECT @IdEmpleado= IdAdministrador 
	FROM Administrador
	WHERE IdEmpleado = @IdEmpleado
	
		RETURN @EsAdmin;

END;
Go