USE PROYECTOMAD;

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
		WHERE CveEmpleado=@CveEmpleado AND Contrasenia=@Contrasenia COLLATE Latin1_General_CS_AS; 

GO
