USE PROYECTOMAD

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_GestionPuesto' AND type = 'P')
    DROP PROCEDURE sp_GestionPuesto;
GO

CREATE PROCEDURE sp_GestionPuesto(
	@Opcion VARCHAR(10) = NULL,
	@ID_Puesto TINYINT = NULL, 
	@Nombre VARCHAR(25) = NULL, 
	@Nivel_Salarial DECIMAL(10,5) = NULL
)
AS
BEGIN

	-- Agregar un puesto
	IF @Opcion = 'INSERT'
	BEGIN
		IF NOT EXISTS (
			SELECT Nombre
			FROM Puesto
			WHERE Nombre=@Nombre
		)
		BEGIN
			INSERT INTO Puesto(Nombre,Nivel_Salarial)
			VALUES	(@Nombre, @Nivel_Salarial);
		END	
	END

	-- Ver la lista de puestos
	IF @Opcion = 'VIEW'
	BEGIN
		SELECT	ID_Puesto,
				Nombre,
				Nivel_Salarial 'Nivel Salarial'
		FROM Puesto
	END

		-- Ver la lista de puestos
	IF @Opcion = 'VIEWE'
	BEGIN
		SELECT	ID_Puesto,
				Nombre,
				Nivel_Salarial 'Nivel Salarial'
		FROM Puesto
		WHERE ID_Puesto=@ID_Puesto
	END
	-- Actualizar un puesto
	IF @Opcion = 'UPDATE'
	BEGIN
		UPDATE Puesto
		SET
		Nombre = ISNULL(@Nombre, Nombre), 
		Nivel_Salarial = ISNULL(@Nivel_Salarial, Nivel_Salarial)
		WHERE ID_Puesto=@ID_Puesto
	END

	-- Elimina un puesto
	IF @Opcion = 'DELETE'
	BEGIN
		IF NOT EXISTS (SELECT 1 FROM Puesto WHERE ID_Puesto=@ID_Puesto)
			BEGIN
				RAISERROR(15600,1,1,'Error, el puesto no se puede borrar porque este no existe');
				RETURN;
			END;
		IF EXISTS (SELECT 1 FROM Empleado WHERE ID_Puesto=@ID_Puesto)
			BEGIN
				RAISERROR(15600,1,1,'Error, el puesto no se puede borrar porque tiene asignado algun empleado');
				RETURN;
			END;
		DELETE Puesto
		WHERE ID_Puesto=@ID_Puesto;
	END
END
