USE DB_MAD;
Go

/*-----------------------------spAdministrador-------------------------------------------*/
IF OBJECT_ID('spDevolucion')IS NOT NULL
BEGIN
DROP PROCEDURE spDevolucion;
END;
GO

CREATE PROCEDURE spDevolucion(
@Accion				CHAR(1),
@IdDevolucion       INT = NULL,
@IdVenta            INT = NULL,
@Merma              BIT = NULL,
@IdProducto         INT = NULL,
@IdDepartamento     INT = NULL,
@IdAdministrador    INT = NULL
)
AS

BEGIN

	DECLARE @HOY SMALLDATETIME;
		SET @HOY = GETDATE();

	IF @Accion = 'I'
	BEGIN
		INSERT INTO Devolucion(Merma)
		VALUES(@Merma);
	END;

	IF @Accion = 'D'
	BEGIN
		DELETE FROM Devolucion WHERE  IdDevolucion = @IdDevolucion;
	END;

	IF @Accion = 'A'
    BEGIN
        UPDATE Devolucion SET
        Merma = 0 WHERE  IdDevolucion = @IdDevolucion;
    END;

    IF @Accion = 'U'
    BEGIN
        UPDATE Devolucion SET
        Merma = 1 WHERE IdDevolucion = @IdDevolucion;
    END;


	IF @Accion = '*'
	BEGIN
		SELECT IdDevolucion[IdDevoluion],IdVenta[IdVenta],Merma[Merma], IdProducto[IdPreductos],IdDepartamento[IdDepartamento],IdAdministrador[IdAdministrador]
		FROM Devolucion  
		ORDER BY IdDevolucion;

 END;
END;



/*------------------------------------------------------------------------*/