USE PROYECTOMAD

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_ComboBox' AND type = 'P')
    DROP PROCEDURE sp_ComboBox;
GO

CREATE PROCEDURE sp_ComboBox(
	@Opcion INT
)
AS
BEGIN
	
	IF(@Opcion=1) -- Para el combobox de los departamentos
	BEGIN
		SELECT Nombre FROM Departamento;
	END

	IF(@Opcion=2) -- Para el combobox de los puestos
	BEGIN
		SELECT Nombre FROM Puesto;
	END

	IF(@Opcion=3) -- Para el combobox de las percepciones
	BEGIN
		SELECT Motivo FROM Percepcion;
	END

	IF(@Opcion=4) -- Para el combobox de las deducciones
	BEGIN
		SELECT Motivo FROM Deduccion;
	END
END