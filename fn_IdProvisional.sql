--FUNCIONES
USE DB_MAD

IF OBJECT_ID('fn_IdProvisional')IS NOT NULL
	DROP FUNCTION fn_IdProvisional;
Go
CREATE FUNCTION fn_IdProvisional
(
)
RETURNS int
BEGIN

	DECLARE @IdEmpleadoProvicional int;

	Select @IdEmpleadoProvicional= MAX(IdEmpleados) 
	
	from Empleados

	SET @IdEmpleadoProvicional= @IdEmpleadoProvicional + 1;
	
		RETURN @IdEmpleadoProvicional;

END;
Go

