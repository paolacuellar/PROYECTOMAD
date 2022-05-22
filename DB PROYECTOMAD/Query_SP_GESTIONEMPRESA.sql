USE PROYECTOMAD

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_GestionEmpresa' AND type = 'P')
    DROP PROCEDURE sp_GestionEmpresa;
GO

CREATE PROCEDURE sp_GestionEmpresa(
	@Opcion VARCHAR(10) = NULL,
	@NumEmpresa TINYINT = NULL, 
	@RFC VARCHAR(25) = NULL, 
	@Nombre VARCHAR(255) = NULL, 
	@Email VARCHAR(25) = NULL, 
	@Telefono VARCHAR(15) = NULL, 
	@Razon_social VARCHAR(255) = NULL, 
	@Fecha_Operaciones DATE = NULL
)
AS
BEGIN

		-- Ver datos de la empresa
	IF @Opcion = 'VIEW'
	BEGIN
		SELECT	RFC,
				Nombre,
				Email,
				Telefono,
				Razon_social 'Razon social',
				Fecha_Operaciones 'Fecha de Inicio de Operaciones'
		FROM Empresa
		WHERE NumEmpresa = @NumEmpresa;

	END

	-- Actualiza los datos de la empresa
	IF @Opcion = 'UPDATE'
	BEGIN
		UPDATE Empresa
		SET
		RFC = ISNULL(@RFC, RFC), 
		Nombre = ISNULL(@Nombre, Nombre), 
		Email = ISNULL(@Email, Email), 
		Telefono = ISNULL(@Telefono, Telefono), 
		Razon_social = ISNULL(@Razon_social, Razon_social), 
		Fecha_Operaciones = ISNULL(@Fecha_Operaciones, Fecha_Operaciones)
		WHERE NumEmpresa=@NumEmpresa
	END
END

EXEC sp_GestionEmpresa 'VIEW', 1;

EXEC sp_GestionEmpresa 'UPDATE', 1, NULL, NULL, 'monsters.inc@gmail.com', '1234-5678', NULL, NULL;



