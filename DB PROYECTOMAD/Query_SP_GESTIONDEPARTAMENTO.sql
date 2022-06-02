USE PROYECTOMAD

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_GestionDepartamento' AND type = 'P')
    DROP PROCEDURE sp_GestionDepartamento;
GO

CREATE PROCEDURE sp_GestionDepartamento(
	@Opcion VARCHAR(10) = NULL,
	@ID_Departamento TINYINT = NULL, 
	@Nombre VARCHAR(25) = NULL, 
	@Sueldo_Base DECIMAL = NULL
)
AS
BEGIN

	-- Agregar un departamento
	IF @Opcion = 'INSERT'
	BEGIN
		IF NOT EXISTS (
			SELECT Nombre
			FROM Departamento
			WHERE Nombre=@Nombre
		)
		BEGIN
			INSERT INTO Departamento(Nombre,Sueldo_Base)
			VALUES	(@Nombre, @Sueldo_Base);
		END	
	END

	-- Eliminar departamento
	IF @Opcion = 'DELETE'
	BEGIN
		IF NOT EXISTS (SELECT 1 FROM Departamento WHERE ID_Departamento=@ID_Departamento)
			BEGIN
				RAISERROR(15600,1,1,'Error, el departamento no se puede borrar porque este no existe');
				RETURN;
			END;
		IF EXISTS (SELECT 1 FROM Empleado WHERE ID_Departamento=@ID_Departamento)
			BEGIN
				RAISERROR(15600,1,1,'Error, el puesto no se puede borrar porque tiene asignado algun empleado');
				RETURN;
			END;
		DELETE Departamento
		WHERE ID_Departamento=@ID_Departamento;
	END

	-- Actualizar informacion de un departamento
	IF @Opcion = 'UPDATE'
	BEGIN
		UPDATE Departamento
		SET
		Nombre = ISNULL(@Nombre, Nombre), 
		Sueldo_Base = ISNULL(@Sueldo_Base, Sueldo_Base)
		WHERE ID_Departamento=@ID_Departamento
	END

	-- Ver todos los departamentos existentes
	IF @Opcion = 'VIEW'
	BEGIN
		SELECT	ID_Departamento,
				Nombre,
				Sueldo_Base 'Sueldo Base'
		FROM Departamento
	END

	IF @Opcion = 'VIEWE'
	BEGIN
		SELECT	ID_Departamento,
				Nombre,
				Sueldo_Base 'Sueldo Base'
		FROM Departamento
		WHERE ID_Departamento=@ID_Departamento
	END

END
