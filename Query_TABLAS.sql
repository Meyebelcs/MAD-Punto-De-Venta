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


IF OBJECT_ID('Administrador')IS NOT NULL
	DROP TABLE Administrador;

CREATE TABLE Administrador(
IdAdministrador	    INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdEmpleado	        INT NOT NULL,
CodigoAcceso        INT NOT NULL,

CONSTRAINT FK_ADMINISTRADOR_IDEMPLEADO FOREIGN KEY (IdEmpleado)
   REFERENCES Empleados(IdEmpleados)
);


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

IF OBJECT_ID('Departamento')IS NOT NULL
	DROP TABLE Departamento;

CREATE TABLE Departamento(
IdDepartamento        INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
Nombre                VARCHAR(50) NOT NULL,
Descripcion           VARCHAR(100) NOT NULL,
IdAdmins              INT NOT NULL,

CONSTRAINT FK_DEPARTAMENTO_IDAD FOREIGN KEY (IdAdmins)
   REFERENCES Administrador(IdAdministrador)
);

IF OBJECT_ID('Productos')IS NOT NULL
	DROP TABLE Productos

CREATE TABLE Productos(
IdProducto		    INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
Nombre			    VARCHAR(20) NOT NULL,
Descripcion			VARCHAR (100) NOT NULL,
Departamento		INT NOT NULL,
Descuento           BIT NULL, --ES BIT PARA DECIRLE SI HAY Q BUSCAR O NO EN LA TABLA DE DESCUENTO
UnidaddeMedida	    VARCHAR(20) NOT NULL,
Costo				MONEY NOT NULL, --precio al q lo vende en la tienda
Eliminacion         BIT NOT NULL,
CantidadDeInventario INT NOT NULL,

CONSTRAINT FK_PRODUCTOS_DEP FOREIGN KEY (Departamento)
   REFERENCES Departamento(IdDepartamento),

);

IF OBJECT_ID('Info_Productos')IS NOT NULL
	DROP TABLE Info_Productos;

CREATE TABLE Info_Productos(
IdInfoProductos	    INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdProducto	        INT NOT NULL,
FechaDeAlta         DATETIME NOT NULL,
PuntoReorden		INT NOT NULL,
PrecioUnitario      MONEY NOT NULL, --precio al cual compró a los proveedores
IdAdministrador     INT NOT NULL

CONSTRAINT FK_Info_Productos_IDP FOREIGN KEY (IdProducto)
   REFERENCES Productos(IdProducto),

CONSTRAINT FK_Info_Productos_IDAD FOREIGN KEY (IdAdministrador)
   REFERENCES Administrador(IdAdministrador)
);


IF OBJECT_ID('Historial_Productos')IS NOT NULL
	DROP TABLE Historial_Productos;

CREATE TABLE Historial_Productos(
IdHistorialIp	      INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
IdInfoProducto	      INT NOT NULL,
FechaDeCambios        DATETIME NOT NULL,
IdUsuarioModificacion   INT NOT NULL

CONSTRAINT FK_HISTORIAL_PRODUCTOS_IDINFO FOREIGN KEY (IdInfoProducto)
   REFERENCES Info_Productos(IdInfoProductos),

CONSTRAINT FK_HISTORIAL_PRODUCTOS_IDUSERMOD FOREIGN KEY (IdUsuarioModificacion)
   REFERENCES Empleados(IdEmpleados)
);


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


IF OBJECT_ID('Descuento')IS NOT NULL
	DROP TABLE Descuento;

CREATE TABLE Descuento(
IdDescuento         INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
Porcentaje  	    INT NOT NULL,
FechaInicio         DATETIME NOT NULL,
FechaFinal          DATETIME NOT NULL,
IdProducto          INT NOT NULL,
IdDepartamento      INT NOT NULL,
IdAdmin             INT NOT NULL

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
IdVenta               INT NOT NULL,
Merma                 BIT NOT NULL,
IdProducto            INT NOT NULL,
IdDepartamento        INT NOT NULL,
IdAdministrador       INT NOT NULL

CONSTRAINT FK_DEVOLUCION_IDP FOREIGN KEY (IdProducto)
   REFERENCES Productos(IdProducto),

CONSTRAINT FK_DEVOLUCION_IDV FOREIGN KEY (IdVenta)
   REFERENCES Venta(IdVenta),

CONSTRAINT FK_DEVOLUCION_IDD FOREIGN KEY (IdDepartamento)
   REFERENCES Departamento(IdDepartamento),

CONSTRAINT FK_DEVOLUCION_IDAD FOREIGN KEY (IdAdministrador)
   REFERENCES Administrador(IdAdministrador)
);


IF OBJECT_ID('Caja')IS NOT NULL
	DROP TABLE Caja;

CREATE TABLE Caja(
IdCaja                INT IDENTITY(1000000,1) NOT NULL PRIMARY KEY,
Numero				  INT NOT NULL, --Ejemplo Caja 1
IdAdministrador       INT NOT NULL,
IdCajero              INT NOT NULL

CONSTRAINT FK_CAJA_IDA FOREIGN KEY (IdAdministrador)
   REFERENCES Administrador(IdAdministrador),

CONSTRAINT FK_CAJA_IDC FOREIGN KEY (IdCajero)
   REFERENCES Cajero(IdCajero)
);

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




/*----------------------------------*/

INSERT INTO Empleados( Nombre,APpellidoP,APpellidoM,Telefono, Email, FechaIngreso, CURP, FechaNac, Contraseña, NumNomina, Eliminacion)
VALUES('Melany', 'Jimenez' , 'Gomez', '12345678', 'arleth.melany@hotmail.com', '11-11-2022', '12345ABCDE','11-11-2002' ,'coco2020','123', '1');

INSERT INTO Empleados( Nombre,APpellidoP,APpellidoM,Telefono, Email, FechaIngreso, CURP, FechaNac, Contraseña, NumNomina, Eliminacion)
VALUES('Boing', 'Eguia' , 'Villa', '1245678', 'boing.eguia@hotmail.com','03-11-2022' , '12fhBCDE','11-01-2002' ,'giza2020','124','1');

INSERT INTO Empleados( Nombre,APpellidoP,APpellidoM,Telefono, Email, FechaIngreso, CURP, FechaNac, Contraseña, NumNomina,Eliminacion)
VALUES('jose', 'jimenez' , 'barcenas', '1245678', 'jluis.311@hotmail.com', '03-11-2022', '12fdhBCDE','11-01-2002' ,'joss2020','124','1');

INSERT INTO Empleados( Nombre,APpellidoP,APpellidoM,Telefono, Email, FechaIngreso, CURP, FechaNac, Contraseña, NumNomina,Eliminacion)
VALUES('Denisse', 'Cardoza' , 'Pezina', '124436678', 'denisse.123@hotmail.com', '03-11-2022', '12f4rfCDE','09-01-2002' ,'blue2020','234','1');
----

INSERT INTO Administrador( IdEmpleado, CodigoAcceso)
VALUES(1000012, 132);

INSERT INTO Administrador( IdEmpleado, CodigoAcceso)
VALUES(1000011, 123);

----
INSERT INTO Cajero( IdEmpleado,IdAdmin )
VALUES(1000001, 1000011 );

INSERT INTO Cajero( IdEmpleado,IdAdmin )
VALUES(1000002, 1000012 );
----
INSERT INTO Departamento( Nombre, Descripcion, IdAdmins)
VALUES('Limpieza', 'Para el hogar',1000012);

INSERT INTO Departamento( Nombre, Descripcion, IdAdmins)
VALUES('Carnes', 'Alimentos carnivoros',1000012);

--producto1

INSERT INTO Productos( Nombre, Descripcion,Departamento,Descuento, UnidaddeMedida,Costo,Eliminacion, CantidadDeInventario)
VALUES('Fabuloso', 'Dura 24 horas',1000001, '0','lts',60,'0',300);

INSERT INTO Info_Productos( IdProducto, FechaDeAlta, PuntoReorden, PrecioUnitario, IdAdministrador)
VALUES(1000001, '15-11-2022',40, 1200, 1000001);

INSERT INTO Historial_Productos( IdInfoProducto,FechaDeCambios, IdUsuarioModificacion)
VALUES(1000002, '16-11-2022', 1000002);
----
--producto2

INSERT INTO Productos( Nombre, Descripcion,Departamento,Descuento, UnidaddeMedida,Costo,Eliminacion, CantidadDeInventario)
VALUES('Filete de res', 'Carne importada',1000002, '0','kg',80,'0',120);

INSERT INTO Info_Productos( IdProducto, FechaDeAlta, PuntoReorden, PrecioUnitario, IdAdministrador)
VALUES(1000002, '16-11-2022',30, 1500, 1000002);

INSERT INTO Historial_Productos( IdInfoProducto,FechaDeCambios, IdUsuarioModificacion)
VALUES(1000002, '16-11-2022', 1000002);
----

INSERT INTO Venta( IdProducto,NombreProducto,CantidadProducto,CostoUnitario,Descuento,subtotal,Total, Departamento)
VALUES(1000002, 'Fabuloso', 2, 60, '20%', 120, 96, 'Limpieza');

INSERT INTO Venta( IdProducto,NombreProducto,CantidadProducto,CostoUnitario,Descuento,subtotal,Total, Departamento)
VALUES(1000002, 'Filete de res', 1, 80, '0%', 80, 80, 'Carnes');
----
INSERT INTO Descuento(Porcentaje,FechaInicio,FechaFinal,IdProducto,IdDepartamento,IdAdmin)
VALUES (10,'11-01-2022','11-04-2022',100001,1000001,1000001)

INSERT INTO Descuento(Porcentaje,FechaInicio,FechaFinal,IdProducto,IdDepartamento,IdAdmin)
VALUES (30,'11-01-2022','11-04-2022',100001,1000001,1000001)

INSERT INTO Opcion_Pago( Nombre)
VALUES('Efectivo');

INSERT INTO Opcion_Pago( Nombre)
VALUES('Tarjeta de Credito');
----

INSERT INTO Tipo_Pago( IdCajero,IdPago, IdVenta)
VALUES(1000001,1000001,1000001);

INSERT INTO Tipo_Pago( IdCajero,IdPago, IdVenta)
VALUES(1000001,1000001,1000001);
----

INSERT INTO Devolucion( IdVenta,Merma, IdProducto, IdDepartamento, IdAdministrador)
VALUES(1000001,'0', 1000001,1000001,1000001);
----

INSERT INTO Caja(Numero, IdAdministrador,IdCajero)
VALUES(1, 1000001,1000001);

INSERT INTO Caja(Numero, IdAdministrador,IdCajero)
VALUES(2, 1000001,1000001);
----

INSERT INTO Ticket(IdVenta, IdCajero,IdTipoPago, FechaHr, NumCaja, Subtotal, DescuentoTotal)
VALUES(1000001,1000001, 1000001,'11-01-2022 05:40:10', 1,120, 96 );

INSERT INTO Ticket(IdVenta, IdCajero,IdTipoPago, FechaHr, NumCaja, Subtotal, DescuentoTotal)
VALUES(1000001,1000001, 1000001,'11-01-2022 07:20:10', 2,80, 80 );
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







/*-------------NO EJECUTAR, SOLO SON EJEMPLOS----------------------*/
ALTER TABLE Empleados
ALTER COLUMN Nombre VARCHAR(50) NOT NULL

DELETE FROM Empleados
WHERE Nombre = 'Boing'

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



/*----------------------------------*/