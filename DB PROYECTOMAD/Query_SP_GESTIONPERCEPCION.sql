USE PROYECTOMAD

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_GestionPercepcion' AND type = 'P')
    DROP PROCEDURE sp_GestionPercepcion;
GO

CREATE PROCEDURE sp_GestionPercepcion(
	@Opcion VARCHAR(10) = NULL,
	@ID_Percepcion TINYINT = NULL, 
	@Motivo VARCHAR(255) = NULL, 
	@Tipo CHAR = NULL, 
	@Cantidad DECIMAL(10,2) = NULL, 
	@Es_porcentaje BIT = NULL
)
AS
BEGIN

	-- Agregar una percepcion
	IF @Opcion = 'INSERT'
	BEGIN
		IF NOT EXISTS (
			SELECT Motivo
			FROM Percepcion
			WHERE Motivo=@Motivo
		)
		BEGIN
			INSERT INTO Percepcion(Motivo, Tipo, Cantidad, Es_porcentaje)
			VALUES	(@Motivo, ISNULL(@Tipo, 'O'), @Cantidad, @Es_porcentaje);
		END	
	END

	-- Elimina un percepcion
	IF @Opcion = 'DELETE'
	BEGIN

		IF EXISTS (SELECT 1 FROM Percepcion WHERE ID_Percepcion=@ID_Percepcion AND Tipo='B')
		BEGIN
			RAISERROR(15600,1,1,'Error, No se puede borrar una percepcion basica');
			RETURN;
		END;

		DELETE Asign_Empleado_Percepcion
		WHERE ID_Percepcion=@ID_Percepcion;

		DELETE Percepcion
		WHERE ID_Percepcion=@ID_Percepcion;
	END

	-- Ver la lista de Percepciones
	IF @Opcion = 'VIEW'
	BEGIN
		SELECT	Motivo,
				Tipo,
				Cantidad,
				Es_porcentaje
		FROM Percepcion
	END

END



