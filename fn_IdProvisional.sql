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

--FUNCIONES productos-----------------------------------------------------

IF OBJECT_ID('fn_IdProvisionalProductos')IS NOT NULL
	DROP FUNCTION fn_IdProvisionalProductos;
Go
CREATE FUNCTION fn_IdProvisionalProductos
(
)
RETURNS int
BEGIN

	DECLARE @IdProductoProvicional int;

	Select @IdProductoProvicional= MAX(IdProducto) 
	
	from Productos

	SET @IdProductoProvicional= @IdProductoProvicional + 1;
	
		RETURN @IdProductoProvicional;

END;
Go




