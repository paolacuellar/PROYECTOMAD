USE PROYECTOMAD

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_GestionDeduccion' AND type = 'P')
    DROP PROCEDURE sp_GestionDeduccion;
GO

CREATE PROCEDURE sp_GestionDeduccion(
	@Opcion VARCHAR(10) = NULL,
	@ID_Deduccion TINYINT = NULL, 
	@Motivo VARCHAR(255) = NULL, 
	@Tipo CHAR = NULL, 
	@Cantidad DECIMAL(10,2) = NULL, 
	@Es_porcentaje BIT = NULL
)
AS
BEGIN

	-- Agregar una deduccion
	IF @Opcion = 'INSERT'
	BEGIN
		IF NOT EXISTS (
			SELECT Motivo
			FROM Deduccion
			WHERE Motivo=@Motivo
		)
		BEGIN
			INSERT INTO Deduccion(Motivo, Tipo, Cantidad, Es_porcentaje)
			VALUES	(@Motivo, ISNULL(@Tipo, 'O'), @Cantidad, @Es_porcentaje);
		END	
	END

	-- Elimina un deduccion
	IF @Opcion = 'DELETE'
	BEGIN

		IF EXISTS (SELECT 1 FROM Deduccion WHERE ID_Deduccion=@ID_Deduccion AND Tipo='B')
		BEGIN
			RAISERROR(15600,1,1,'Error, No se puede borrar una deduccion basica');
			RETURN;
		END;

		DELETE Asign_Empleado_Deduccion
		WHERE ID_Deduccion=@ID_Deduccion;

		DELETE Deduccion
		WHERE ID_Deduccion=@ID_Deduccion;
	END

	-- Ver la lista de Deducciones
	IF @Opcion = 'VIEW'
	BEGIN
		SELECT	ID_Deduccion,
				Motivo,
				Tipo,
				Cantidad,
				Es_porcentaje
		FROM Deduccion
	END
END