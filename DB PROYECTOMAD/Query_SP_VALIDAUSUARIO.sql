IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_ValidaUsuario' AND type = 'P') -- Tipo procedure
    DROP PROCEDURE sp_ValidaUsuario;
GO

CREATE PROCEDURE sp_ValidaUsuario(
		@CveEmpleado INT,
		@Contrasenia VARCHAR(25)
)
AS
		SELECT CveEmpleado,Rol 
		FROM Empleado 
		WHERE CveEmpleado=@CveEmpleado AND Contrasenia=@Contrasenia

GO


EXEC sp_ValidaUsuario 1000004, 'Kath'

EXEC sp_ValidaUsuario 1000001, 'Gigipass'

EXEC sp_ValidaUsuario 1000003, 'abc'
