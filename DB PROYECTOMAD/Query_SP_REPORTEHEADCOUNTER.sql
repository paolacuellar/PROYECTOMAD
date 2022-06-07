USE PROYECTOMAD

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_ReporteHeadcounter' AND type = 'P')
    DROP PROCEDURE sp_ReporteHeadcounter;
GO

-- Listado de los departamentos por la 	cantidad de empleados por puesto y por 	departamento
CREATE PROCEDURE sp_ReporteHeadcounter(
	@Departamento VARCHAR (25) = NULL,
	@Fecha DATE = NULL,
	@Parte CHAR(1) = '1'
)
AS
BEGIN
-- PARTE 1
/*	Datos a mostrar: Departamento, Puesto, Cantidad de empleados de ese puesto-departamento
	Orden: Departamento y puesto	*/
	-- PARTE 2
/*	Datos a mostrar: Departamento, Cantidad de empleados de cada departamento
	Orden: Departamento	*/
	-- FILTROS: DEPARTAMENTOS(uno o todos), Año-Mes
	
	-- DEPARTAMENTOS TODOS
	IF @Departamento IS NULL
	BEGIN
		
		IF @Fecha IS NULL -- DEPARTAMENTOS TODOS SIN NECESIDAD DE FECHA
		BEGIN

		IF @Parte = '1'
			BEGIN
			-------------PARTE 1------------------------
				SELECT 
					Departamento,     
					Puesto,  
					COUNT(CveEmpleado) 'Cantidad de empleados'
				FROM vw_HeadcounterP1
				GROUP BY Departamento, Puesto
				ORDER BY Departamento,Puesto
			---------------------------------------------
			END
		ELSE
			BEGIN
			-------------PARTE 2------------------------
				SELECT 
					Departamento,     
					COUNT(CveEmpleado) 'Cantidad de empleados'
				FROM vw_HeadcounterP2
				GROUP BY Departamento
				ORDER BY Departamento
			---------------------------------------------
			END
		END
		ELSE -- DEPARTAMENTOS TODOS, MES-AÑO
		BEGIN

		/*DECLARE @Fecha DATE 
		SET @Fecha='2022-05-22'*/
		IF @Parte = '1' 
			BEGIN
		-------------PARTE 1------------------------
				SELECT 
				Departamento,     
				Puesto,  
				COUNT(CveEmpleado) 'Cantidad de empleados'
				FROM vw_HeadcounterP1
				WHERE MONTH([Fecha de contratacion])=MONTH(@Fecha) AND YEAR([Fecha de contratacion])=YEAR(@Fecha)
				GROUP BY Departamento, Puesto, [Fecha de contratacion]
				ORDER BY Departamento,Puesto
		---------------------------------------------
		END
		ELSE
			BEGIN
			-------------PARTE 2------------------------
				SELECT 
				Departamento,     
				COUNT(CveEmpleado) 'Cantidad de empleados'
				FROM vw_HeadcounterP2
				WHERE MONTH([Fecha de contratacion])=MONTH(@Fecha) AND YEAR([Fecha de contratacion])=YEAR(@Fecha)
				GROUP BY Departamento, [Fecha de contratacion]
				ORDER BY Departamento
			---------------------------------------------
			END
		END
	END
	ELSE -- DEPARTAMENTO ESPECIFICO
	BEGIN
		
		IF @Fecha IS NULL -- DEPARTAMENTO ESPECIFICO SIN NECESIDAD DE FECHA
		BEGIN

		/*DECLARE @Departamento VARCHAR(25)
		SET @Departamento='Administración'*/
		IF @Parte = '1' 
			BEGIN
			-------------PARTE 1------------------------
				SELECT 
					Departamento,     
					Puesto,  
					COUNT(CveEmpleado) 'Cantidad de empleados'
				FROM vw_HeadcounterP1
				WHERE Departamento=@Departamento
				GROUP BY Departamento, Puesto
				ORDER BY Departamento,Puesto
			---------------------------------------------
			END
			ELSE
			BEGIN
			-------------PARTE 2------------------------
				SELECT 
					Departamento,       
					COUNT(CveEmpleado) 'Cantidad de empleados'
				FROM vw_HeadcounterP2
				WHERE Departamento=@Departamento
				GROUP BY Departamento
				ORDER BY Departamento
			---------------------------------------------
			END
		END
		ELSE -- DEPARTAMENTO ESPECIFICO, MES-AÑO
		BEGIN
		/*DECLARE @Fecha DATE 
		SET @Fecha='2022-05-22'
		DECLARE @Departamento VARCHAR(25)
		SET @Departamento='Administración'*/
		IF @Parte = '1' 
			BEGIN
			-------------PARTE 1------------------------
				SELECT 
					Departamento,     
					Puesto,  
					COUNT(CveEmpleado) 'Cantidad de empleados',
					[Fecha de contratacion]
				FROM vw_HeadcounterP1
				WHERE Departamento=@Departamento AND (MONTH([Fecha de contratacion])=MONTH(@Fecha) AND YEAR([Fecha de contratacion])=YEAR(@Fecha))
				GROUP BY Departamento, Puesto, [Fecha de contratacion]
				ORDER BY Departamento,Puesto
			---------------------------------------------
			END
			ELSE
			BEGIN
			-------------PARTE 2------------------------
				SELECT 
					Departamento,     
					COUNT(CveEmpleado) 'Cantidad de empleados',
					[Fecha de contratacion]
				FROM vw_HeadcounterP2
				WHERE Departamento=@Departamento AND (MONTH([Fecha de contratacion])=MONTH(@Fecha) AND YEAR([Fecha de contratacion])=YEAR(@Fecha))
				GROUP BY Departamento, [Fecha de contratacion]
				ORDER BY Departamento
			---------------------------------------------
			END
		END
	END

END