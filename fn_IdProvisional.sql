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


--FUNCIONES DEPARTAMENTO-----------------------------------------------------

IF OBJECT_ID('fn_IdProvisionalDepartamento')IS NOT NULL
	DROP FUNCTION fn_IdProvisionalDepartamento;
Go
CREATE FUNCTION fn_IdProvisionalDepartamento
(
)
RETURNS int
BEGIN

	DECLARE @IdDepartamentoProvicional int;

	Select @IdDepartamentoProvicional= MAX(IdDepartamento) 
	
	from Departamento

	SET @IdDepartamentoProvicional= @IdDepartamentoProvicional + 1;
	
		RETURN @IdDepartamentoProvicional;

END;
Go


