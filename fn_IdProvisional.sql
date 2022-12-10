--FUNCIONES

IF OBJECT_ID('fn_busquedaCajero')IS NOT NULL
	DROP FUNCTION fn_busquedaCajero;
Go
CREATE FUNCTION fn_busquedaCajero
(
@IdCaja  int
)
RETURNS int
BEGIN

	DECLARE @Empleado int;

	SET @Empleado = 0 

	Select @Empleado = IdEmpleado
	
	from Cajero

	WHERE IdCaja = @IdCaja and Eliminacion = 0

	
		RETURN @Empleado;

END;
Go

--FUNCIONES

IF OBJECT_ID('fn_busquedaDepartamento')IS NOT NULL
	DROP FUNCTION fn_busquedaDepartamento;
Go
CREATE FUNCTION fn_busquedaDepartamento
(
@IdDepartamento  int
)
RETURNS int
BEGIN

	DECLARE @Encontrado int;

	SET @Encontrado = 0

	Select @Encontrado = 1
	
	from Productos

	WHERE Productos.IdDepartamento = @IdDepartamento and Eliminacion = 0

	
		RETURN @Encontrado;

END;
Go
-------------------------------------------------------------------------------

--FUNCIONES

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




