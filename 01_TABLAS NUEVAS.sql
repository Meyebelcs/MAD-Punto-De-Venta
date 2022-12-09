CREATE DATABASE DB_MAD

USE DB_MAD

IF OBJECT_ID('Empleados')IS NOT NULL
	DROP TABLE Empleados

CREATE TABLE Empleados(
IdEmpleados			INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
Nombre				VARCHAR(50) NOT NULL,
APpellidoP			VARCHAR(20) NOT NULL,
APpellidoM			VARCHAR(20) NOT NULL,
Telefono            INT NOT NULL,
Email               VARCHAR(50) NOT NULL,
FechaIngreso        DATETIME NOT NULL,
CURP				VARCHAR(20) NOT NULL,
FechaNac			DATETIME NOT NULL,
Contraseña			VARCHAR(10) NOT NULL,
NumNomina			INT NULL,
Eliminacion			BIT NULL,
);

ALTER TABLE Empleados
ALTER COLUMN FechaIngreso DATETIME NULL

ALTER TABLE Empleados
ALTER COLUMN FechaNac DATETIME NULL

IF OBJECT_ID('Administrador')IS NOT NULL
	DROP TABLE Administrador;

CREATE TABLE Administrador(
IdAdministrador	    INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdEmpleado	        INT NOT NULL,
CodigoAcceso        INT NOT NULL,

CONSTRAINT FK_ADMINISTRADOR_IDEMPLEADO FOREIGN KEY (IdEmpleado)
   REFERENCES Empleados(IdEmpleados)
);

ALTER TABLE Administrador
ADD Eliminacion BIT NULL

IF OBJECT_ID('Cajero')IS NOT NULL
	DROP TABLE Cajero;

CREATE TABLE Cajero(
IdCajero        INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdEmpleado	    INT NOT NULL,
IdAdmin         INT NOT NULL,

CONSTRAINT FK_CAJERO_AD FOREIGN KEY (IdAdmin)
   REFERENCES Administrador(IdAdministrador),

CONSTRAINT FK_CAJERO_EM FOREIGN KEY (IdEmpleado)
   REFERENCES Empleados(IdEmpleados)

);

ALTER TABLE Cajero
ADD Eliminacion BIT NULL

ALTER TABLE Cajero
ADD IdCaja int NULL

IF OBJECT_ID('Departamento')IS NOT NULL
	DROP TABLE Departamento;

CREATE TABLE Departamento(
IdDepartamento        INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdAdminstrador        INT NOT NULL,
Nombre                VARCHAR(50) NOT NULL,
Descripcion           VARCHAR(100) NOT NULL,


CONSTRAINT FK_DEPARTAMENTO_IDAD FOREIGN KEY (IdAdminstrador)
   REFERENCES Administrador(IdAdministrador)
);
ALTER TABLE Departamento
ADD PermiteDevolucion BIT NULL

ALTER TABLE Departamento
ADD Eliminacion BIT NULL

ALTER TABLE Departamento
ADD FechaIngreso DATETIME NULL
-----------------------------------------------------------------

IF OBJECT_ID('Productos')IS NOT NULL
	DROP TABLE Productos

CREATE TABLE Productos(
IdProducto		    INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdDepartamento		INT NOT NULL,
Nombre			    VARCHAR(20) NOT NULL,
Descripcion			VARCHAR (100) NOT NULL,
Descuento           BIT NULL, --ES BIT PARA DECIRLE SI HAY Q BUSCAR O NO EN LA TABLA DE DESCUENTO
UnidaddeMedida	    VARCHAR(20) NOT NULL,
Costo				MONEY NOT NULL, --precio al q lo vende en la tienda
Eliminacion         BIT NOT NULL,
CantidadDeInventario INT NOT NULL,

CONSTRAINT FK_PRODUCTOS_DEP FOREIGN KEY (IdDepartamento)
   REFERENCES Departamento(IdDepartamento),

);

ALTER TABLE Productos
ALTER COLUMN Costo decimal(10,2) NULL
-----------------------------------------------------------------
IF OBJECT_ID('Info_Productos')IS NOT NULL
	DROP TABLE Info_Productos;

CREATE TABLE Info_Productos(
IdInfoProductos	    INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdAdministrador     INT NOT NULL,
IdProducto	        INT NOT NULL,
FechaDeAlta         DATETIME NOT NULL,
PuntoReorden		INT NOT NULL,
PrecioUnitario      MONEY NOT NULL, --precio al cual compró a los proveedores


CONSTRAINT FK_Info_Productos_IDP FOREIGN KEY (IdProducto)
   REFERENCES Productos(IdProducto),

CONSTRAINT FK_Info_Productos_IDAD FOREIGN KEY (IdAdministrador)
   REFERENCES Administrador(IdAdministrador)
);
ALTER TABLE Info_Productos
ALTER COLUMN PrecioUnitario decimal(10,2) NULL

ALTER TABLE Info_Productos
ADD Eliminacion BIT NULL
-----------------------------------------------------------------

IF OBJECT_ID('Historial_Productos')IS NOT NULL
	DROP TABLE Historial_Productos;

CREATE TABLE Historial_Productos(
IdHistorialIp	      INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdUsuarioModificacion   INT NOT NULL,
IdInfoProducto	      INT NOT NULL,
FechaDeCambios        DATETIME NOT NULL,


CONSTRAINT FK_HISTORIAL_PRODUCTOS_IDINFO FOREIGN KEY (IdInfoProducto)
   REFERENCES Info_Productos(IdInfoProductos),

CONSTRAINT FK_HISTORIAL_PRODUCTOS_IDUSERMOD FOREIGN KEY (IdUsuarioModificacion)
   REFERENCES Empleados(IdEmpleados),


);

ALTER TABLE Historial_Productos
ADD Eliminacion BIT NULL

ALTER TABLE Historial_Productos
ADD IdProducto	 INT NULL

CONSTRAINT FK_HISTORIAL_PRODUCTOS_IDUSERPROD FOREIGN KEY (IdProducto)
   REFERENCES Productos(IdProducto)
-----------------------------------------------------------------


IF OBJECT_ID('Venta')IS NOT NULL
	DROP TABLE Venta;

CREATE TABLE Venta(
/*NO SE MANDAN A LLAMAR CON EL ID PORQ ES NECESARIO GUARDAR LOS DATOS EN CASO DE SER MODIFICADOS*/
IdVenta             INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdProducto			INT NOT NULL,
NombreProducto	    VARCHAR(30) NOT NULL,
CantidadProducto    INT NOT NULL,
CostoUnitario		MONEY NOT NULL,
Descuento           VARCHAR(10) NOT NULL, --AQUI ES VARCHAR PARA GUARDAR ASI 30%, YA Q SOLO ES POR SI CAMBIAN EN LA BASE
subtotal			MONEY NOT NULL,
Total				MONEY NOT NULL,
Departamento        VARCHAR(20) NOT NULL

CONSTRAINT FK_VENTA_IDP FOREIGN KEY (IdProducto)
   REFERENCES Productos(IdProducto),
);
ALTER TABLE Venta
ALTER COLUMN CostoUnitario decimal(10,2) NULL

ALTER TABLE Venta
ALTER COLUMN subtotal decimal(10,2) NULL

ALTER TABLE Venta
ALTER COLUMN Total decimal(10,2) NULL

ALTER TABLE Venta
ADD MontoCambio decimal(10,2) NULL

ALTER TABLE Venta
ADD MontopPagado decimal(10,2) NULL

ALTER TABLE Venta
ADD FechaRegistro datetime NULL

ALTER TABLE Venta
ADD Costo VARCHAR(100)  NULL

ALTER TABLE Venta
ALTER COLUMN Costo decimal(10,2) NULL

ALTER TABLE Venta
ADD NombreCajero VARCHAR(100)  NULL

ALTER TABLE Venta
ADD IdCajero INT NULL

-----------------------------------------------------------------

IF OBJECT_ID('Descuento')IS NOT NULL
	DROP TABLE Descuento;

CREATE TABLE Descuento(
IdDescuento         INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdProducto          INT NOT NULL,
IdDepartamento      INT NOT NULL,
IdAdmin             INT NOT NULL,
Porcentaje  	    INT NOT NULL,
FechaInicio         DATETIME NOT NULL,
FechaFinal          DATETIME NOT NULL,


CONSTRAINT FK_DESCUENTO_IDP FOREIGN KEY (IdProducto)
   REFERENCES Productos(IdProducto),

CONSTRAINT FK_DESCUENTO_IDD FOREIGN KEY (IdDepartamento)
   REFERENCES Departamento(IdDepartamento),

CONSTRAINT FK_DESCUENTO_IDA FOREIGN KEY (IdAdmin)
   REFERENCES Administrador(IdAdministrador)
);

IF OBJECT_ID('Opcion_Pago')IS NOT NULL
	DROP TABLE Opcion_Pago;

CREATE TABLE Opcion_Pago(
IdPago        INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
Nombre        VARCHAR(30) NOT NULL,
);

IF OBJECT_ID('Tipo_Pago')IS NOT NULL
	DROP TABLE Tipo_Pago;

CREATE TABLE Tipo_Pago(
IdTipo         INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdCajero       INT NOT NULL,
IdPago         INT NOT NULL,
IdVenta        INT NOT NULL

CONSTRAINT FK_TIPO_PAGO_IDC FOREIGN KEY (IdCajero)
   REFERENCES Cajero(IdCajero),

CONSTRAINT FK_TIPO_PAGO_IDP FOREIGN KEY (IdPago)
   REFERENCES Opcion_Pago(IdPago),

CONSTRAINT FK_TIPO_PAGO_IDV FOREIGN KEY (IdVenta)
   REFERENCES Venta(IdVenta)
);

IF OBJECT_ID('Devolucion')IS NOT NULL
	DROP TABLE Devolucion;

CREATE TABLE Devolucion(
IdDevolucion          INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdProducto            INT NOT NULL,
IdDepartamento        INT NOT NULL,
IdAdministrador       INT NOT NULL,
IdVenta               INT NOT NULL,
Merma                 BIT NOT NULL,


CONSTRAINT FK_DEVOLUCION_IDP FOREIGN KEY (IdProducto)
   REFERENCES Productos(IdProducto),

CONSTRAINT FK_DEVOLUCION_IDV FOREIGN KEY (IdVenta)
   REFERENCES Venta(IdVenta),

CONSTRAINT FK_DEVOLUCION_IDD FOREIGN KEY (IdDepartamento)
   REFERENCES Departamento(IdDepartamento),

CONSTRAINT FK_DEVOLUCION_IDAD FOREIGN KEY (IdAdministrador)
   REFERENCES Administrador(IdAdministrador)
);

ALTER TABLE Devolucion
ADD Motivo VARCHAR(80) NULL
-----------------------------------------------------------------

IF OBJECT_ID('NotaCredito')IS NOT NULL
	DROP TABLE NotaCredito;

CREATE TABLE NotaCredito(
IdNotaCredito	INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
idProducto		INT NOT NULL,
idTicket		INT NOT NULL,
cantidad		FLOAT NOT NULL,
subtotal		MONEY NOT NULL,
total			MONEY NOT NULL,


CONSTRAINT FK_NotaCredito_IDProducto FOREIGN KEY (idProducto)
   REFERENCES Productos(IdProducto),

CONSTRAINT FK_NotaCredito_IDTicket FOREIGN KEY (idTicket)
   REFERENCES Ticket(IdTicket)
);

ALTER TABLE NotaCredito
ALTER COLUMN subtotal decimal(10,2) NULL

ALTER TABLE NotaCredito
ALTER COLUMN total decimal(10,2) NULL
-----------------------------------------------------------------

IF OBJECT_ID('Caja')IS NOT NULL
	DROP TABLE Caja;

CREATE TABLE Caja(
IdCaja                INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdAdministrador       INT NOT NULL,
IdCajero              INT NOT NULL,
Numero				  INT NOT NULL, --Ejemplo Caja 1


CONSTRAINT FK_CAJA_IDA FOREIGN KEY (IdAdministrador)
   REFERENCES Administrador(IdAdministrador),

CONSTRAINT FK_CAJA_IDC FOREIGN KEY (IdCajero)
   REFERENCES Cajero(IdCajero)
);
ALTER TABLE Caja
ALTER COLUMN IdCajero INT NULL

ALTER TABLE Caja
ADD Eliminacion BIT NULL

ALTER TABLE Caja
 DROP COLUMN IdCajero;


-----------------------------------------------------------------


IF OBJECT_ID('Ticket')IS NOT NULL
	DROP TABLE Ticket;

CREATE TABLE Ticket(
IdTicket          INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdVenta           INT NOT NULL,
IdCajero          INT NOT NULL,
IdTipoPago          INT NOT NULL,
FechaHr           DATETIME NOT NULL,
NumCaja           INT NOT NULL,
Subtotal          MONEY NOT NULL,
DescuentoTotal    MONEY NOT NULL

CONSTRAINT FK_TICKET_IDV FOREIGN KEY (IdVenta)
   REFERENCES Venta(IdVenta),

CONSTRAINT FK_TICKET_CJ FOREIGN KEY (IdCajero)
   REFERENCES Cajero(IdCajero),

CONSTRAINT FK_TICKET_IDTP FOREIGN KEY (IdTipoPago)
   REFERENCES Tipo_Pago(IdTipo)
);

ALTER TABLE Ticket
ALTER COLUMN Subtotal decimal(10,2) NULL

ALTER TABLE Ticket
ALTER COLUMN DescuentoTotal decimal(10,2) NULL

ALTER TABLE Ticket
ADD MontoCambio decimal(10,2) NULL
-----------------------------------------------------------------



/*----------------------------------*/

INSERT INTO Empleados( Nombre,APpellidoP,APpellidoM,Telefono, Email, FechaIngreso, CURP, FechaNac, Contraseña, NumNomina, Eliminacion)
VALUES('Melany', 'Jimenez' , 'Gomez', '12345678', 'arleth.melany@hotmail.com', '11-11-2022', '12345ABCDE','11-11-2002' ,'coco2020','123', '0');

INSERT INTO Empleados( Nombre,APpellidoP,APpellidoM,Telefono, Email, FechaIngreso, CURP, FechaNac, Contraseña, NumNomina, Eliminacion)
VALUES('Boing', 'Eguia' , 'Villa', '1245678', 'boing.eguia@hotmail.com','03-11-2022' , '12fhBCDE','11-01-2002' ,'giza2020','124','0');

INSERT INTO Empleados( Nombre,APpellidoP,APpellidoM,Telefono, Email, FechaIngreso, CURP, FechaNac, Contraseña, NumNomina,Eliminacion)
VALUES('jose', 'jimenez' , 'barcenas', '1245678', 'jluis.311@hotmail.com', '03-11-2022', '12fdhBCDE','11-01-2002' ,'joss2020','124','0');

INSERT INTO Empleados( Nombre,APpellidoP,APpellidoM,Telefono, Email, FechaIngreso, CURP, FechaNac, Contraseña, NumNomina,Eliminacion)
VALUES('Denisse', 'Cardoza' , 'Pezina', '124436678', 'denisse.123@hotmail.com', '03-11-2022', '12f4rfCDE','09-01-2002' ,'blue2020','234','0');


INSERT INTO Empleados( Nombre,APpellidoP,APpellidoM,Telefono, Email, FechaIngreso, CURP, FechaNac, Contraseña, NumNomina,Eliminacion)
VALUES('Aurora Isabel', 'Martinez' , 'Rosa', '3456789', 'isa.aurora@hotmail.com', '02-12-2022', 'jdhfgc643ge','06-12-2001' ,'isa2020','544','0');

----

INSERT INTO Administrador( IdEmpleado, CodigoAcceso)
VALUES(1000004, 144);

INSERT INTO Administrador( IdEmpleado, CodigoAcceso)
VALUES(1000001, 123);

INSERT INTO Administrador( IdEmpleado, CodigoAcceso)
VALUES(1000001, 123);

----
INSERT INTO Cajero( IdEmpleado,IdAdmin )
VALUES(1000002, 1000000 );

INSERT INTO Cajero( IdEmpleado,IdAdmin )
VALUES(1000003, 1000001 );
----
INSERT INTO Departamento( Nombre, Descripcion, IdAdminstrador)
VALUES('Limpieza', 'Para el hogar',1000000);

INSERT INTO Departamento( Nombre, Descripcion, IdAdminstrador)
VALUES('Carnes', 'Alimentos carnivoros',1000001);

--producto1

INSERT INTO Productos( Nombre, Descripcion,IdDepartamento,Descuento, UnidaddeMedida,Costo,Eliminacion, CantidadDeInventario)
VALUES('Fabuloso', 'Dura 24 horas',1000000, '0','lts',60,'0',300);

INSERT INTO Info_Productos( IdProducto, FechaDeAlta, PuntoReorden, PrecioUnitario, IdAdministrador)
VALUES(1000000, '20220618',40, 1200, 1000000);

INSERT INTO Historial_Productos( IdInfoProducto,FechaDeCambios, IdUsuarioModificacion)
VALUES(1000001, '20220618 10:34:09 AM', 1000000);
----
--producto2

INSERT INTO Productos( Nombre, Descripcion,IdDepartamento,Descuento, UnidaddeMedida,Costo,Eliminacion, CantidadDeInventario)
VALUES('Filete de res', 'Carne importada',1000001, '0','kg',80,'0',120);

INSERT INTO Info_Productos( IdProducto, FechaDeAlta, PuntoReorden, PrecioUnitario, IdAdministrador)
VALUES(1000001, '20221018',30, 1500, 1000001);

INSERT INTO Historial_Productos( IdInfoProducto,FechaDeCambios, IdUsuarioModificacion)
VALUES(1000002, '20221122 10:34:09 AM', 1000001);
----

INSERT INTO Venta( IdProducto,NombreProducto,CantidadProducto,CostoUnitario,Descuento,subtotal,Total, Departamento)
VALUES(1000000, 'Fabuloso', 2, 60, '20%', 120, 96, 'Limpieza');

INSERT INTO Venta( IdProducto,NombreProducto,CantidadProducto,CostoUnitario,Descuento,subtotal,Total, Departamento)
VALUES(1000001, 'Filete de res', 1, 80, '0%', 80, 80, 'Carnes');
----
INSERT INTO Descuento(Porcentaje,FechaInicio,FechaFinal,IdProducto,IdDepartamento,IdAdmin)
VALUES (10,'11-01-2022','11-04-2022',1000000,1000000,1000000)

INSERT INTO Descuento(Porcentaje,FechaInicio,FechaFinal,IdProducto,IdDepartamento,IdAdmin)
VALUES (30,'11-01-2022','11-04-2022',1000001,1000001,1000001)
----
INSERT INTO Opcion_Pago( Nombre)
VALUES('Efectivo');

INSERT INTO Opcion_Pago( Nombre)
VALUES('Tarjeta de Credito');
----

INSERT INTO Tipo_Pago( IdCajero,IdPago, IdVenta)
VALUES(1000002,1000000,1000000);

INSERT INTO Tipo_Pago( IdCajero,IdPago, IdVenta)
VALUES(1000003,1000001,1000001);
----

INSERT INTO Devolucion( IdVenta,Merma, IdProducto, IdDepartamento, IdAdministrador)
VALUES(1000000,'0', 1000000,1000000,1000000);
----

INSERT INTO Caja(Numero, IdAdministrador,IdCajero)
VALUES(1, 1000000,1000002);

INSERT INTO Caja(Numero, IdAdministrador,IdCajero)
VALUES(2, 1000001,1000003);
----

INSERT INTO Ticket(IdVenta, IdCajero,IdTipoPago, FechaHr, NumCaja, Subtotal, DescuentoTotal)
VALUES(1000000,1000002, 1000002,'20221110 03:51:09 PM', 1,120, 96 );

INSERT INTO Ticket(IdVenta, IdCajero,IdTipoPago, FechaHr, NumCaja, Subtotal, DescuentoTotal)
VALUES(1000001,1000003, 1000003,'20221113 07:13:02 PM', 2,80, 80 );
----

SELECT *FROM Empleados
SELECT *FROM Administrador
SELECT *FROM Cajero
SELECT *FROM Departamento
SELECT *FROM Productos
SELECT *FROM Info_Productos
SELECT *FROM Historial_Productos
SELECT *FROM Venta
SELECT *FROM Descuento
SELECT *FROM Opcion_Pago
SELECT *FROM Tipo_Pago
SELECT *FROM Caja
SELECT *FROM Ticket


Select MAX(IdEmpleados) AS maximo from Empleados

SELECT Top 1 IdEmpleados 
From Empleados
order by IdEmpleados desc

SELECT dbo.fn_IdProvisional() 

SELECT dbo.fn_busquedaDepartamento(1000000) 

SELECT IdCaja[IdCaja],IdAdministrador[Quién dió de alta],Numero[Num Caja],IdCajero[IdCajero]
FROM Caja 
WHERE Eliminacion = 0 AND IdCajero=NULL 

SELECT C.IdCajero[IdCajero], C.IdEmpleado[IdEmpleado], J.IdCajero
FROM Caja J  JOIN Cajero C
ON C.Eliminacion = 0 AND J.Eliminacion = 0
WHERE J.IdCajero = NULL

SELECT  IdCajero[IdCajero], IdEmpleado[IdEmpleado], IdAdmin[IdAdmin]
FROM Cajero  
WHERE IdCaja = 0;

	 

INSERT INTO Caja(IdCajero,IdAdministrador,Numero, Eliminacion)
VALUES(NULL,1000000,3,0);

/*-------------NO EJECUTAR, SOLO SON EJEMPLOS----------------------*/
ALTER TABLE Empleados
ALTER COLUMN Nombre VARCHAR(50) NOT NULL

DELETE FROM Empleados
WHERE Nombre = 'Boing'

DELETE 
		FROM Cajero 
		WHERE  IdCajero = 1000004;

UPDATE Caja
		SET
			IdCajero = NULL
WHERE IdCaja= 1000002;


UPDATE Historial_Productos
		SET
			Eliminacion = 0
WHERE IdEmpleado = 1000003;

UPDATE Empleados
		SET
			Nombre = 'Fernanda',
			APpellidoP = 'Fernanda',
			APpellidoM = 'Fernanda',
			Telefono = '1234567898',
			Email ='Fernanda@gmail.com',
			FechaIngreso = '2022-03-11 00:00:00.000',
			CURP = 'fgvbhyt678uyhgf',
			FechaNac = '2002-11-11 00:00:00.000',
			Contraseña ='fer2020',
			NumNomina = '629',
			Eliminacion = 0
WHERE IdEmpleados = 1000005;


update Productos
set Eliminacion = 1
WHERE IdProducto = 1000001

update Cajero
set Eliminacion = 0

update Empleados
set Eliminacion = 0

ALTER TABLE Productos
ADD Descuento BIT NULL

ALTER TABLE Productos
ADD CONSTRAINT FK_PRODUCTOS_DESC FOREIGN KEY (Descuento)
   REFERENCES Descuento(IdDescuento)

ALTER TABLE Productos
DROP COLUMN Descuento

ALTER TABLE Productos
DROP COLUMN Existencia


ALTER TABLE Ticket
ALTER COLUMN TipoPago INT NOT NULL

ALTER TABLE Ticket
ADD CONSTRAINT FK_TICKET_IDTP FOREIGN KEY (TipoPago)
   REFERENCES Tipo_Pago(IdTipo)

 sp_help 'dbo.Productos'
/*----------------------------------*/