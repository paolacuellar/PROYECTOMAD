USE PROYECTOMAD

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_ReporteGeneralNomina' AND type = 'P')
    DROP PROCEDURE sp_ReporteGeneralNomina;
GO

-- Listado de empleados que laboran en 	cada departamento de una empresa
CREATE PROCEDURE sp_ReporteGeneralNomina(
	@Fecha DATE = NULL
)
AS
BEGIN

	IF @Fecha IS NULL -- FILTRO AÑO-MES
	BEGIN
		SELECT	Departamento,
				Puesto,
				CONCAT (A_Paterno, ' ', A_Materno) AS [Nombre del empleado],
				[Fecha de contratacion],
				DATEDIFF(yy, Fecha_nacimiento, GETDATE()) Edad,
				[Salario Diario]
		FROM vw_ReporteGeneralNomina
		ORDER BY Departamento, Puesto, [Nombre del empleado]
			--ORDER BY Departamento, Puesto, A_Paterno
	END
	ELSE
	BEGIN 
		--DECLARE @Fecha DATE
		--SET @Fecha='2022-02-22'
		SELECT	Departamento,
				Puesto,
				CONCAT (A_Paterno, ' ', A_Materno) AS [Nombre del empleado],
				[Fecha de contratacion],
				DATEDIFF(yy, Fecha_nacimiento, GETDATE()) Edad,
				[Salario Diario]
		FROM vw_ReporteGeneralNomina
		WHERE MONTH([Fecha de contratacion])=MONTH(@Fecha) AND YEAR([Fecha de contratacion])=YEAR(@Fecha)
		ORDER BY Departamento, Puesto, [Nombre del empleado]
	END
END