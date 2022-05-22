USE PROYECTOMAD

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_ViewNomina' AND type = 'P')
    DROP PROCEDURE sp_ViewNomina;
GO

CREATE PROCEDURE sp_ViewNomina(
	@Fecha DATE = NULL,
	@CveEmpleado INT = NULL
)
AS
BEGIN
	
	SELECT	Nomina.ID_Nomina, 
			Nomina.CveEmpleado 'Clave Empleado', 
			Departamento.Nombre 'Departamento',
			Departamento.Sueldo_Base 'Sueldo Base', 
			Puesto.Nombre 'Puesto',
			Puesto.Nivel_Salarial 'Nivel Salarial',
			Nomina.Salario_Diario 'Salario Diario',
			Nomina.Sueldo_Bruto 'Sueldo Bruto',
			Nomina.Sueldo_Neto 'Sueldo Neto'
			-- Ver como mostrar todas las percepciones de ese empleado
			-- Ver como mostrar todas las deducciones de ese empleado
	FROM Empleado
	JOIN Nomina ON Empleado.CveEmpleado=Nomina.CveEmpleado
	JOIN Departamento ON Empleado.ID_Departamento=Departamento.ID_Departamento
	JOIN Puesto ON Empleado.ID_Puesto=Puesto.ID_Puesto
	WHERE Nomina.CveEmpleado=@CveEmpleado AND Nomina.Fecha=@Fecha;

END