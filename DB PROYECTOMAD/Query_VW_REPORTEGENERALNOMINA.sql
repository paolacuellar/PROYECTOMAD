USE PROYECTOMAD;

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'vw_ReporteGeneralNomina' AND type = 'V')
DROP VIEW vw_ReporteGeneralNomina;
GO

CREATE VIEW vw_ReporteGeneralNomina
AS
SELECT	dbo.Departamento.Nombre AS Departamento, 
		dbo.Puesto.Nombre AS Puesto, 
		dbo.Empleado.CveEmpleado,
		dbo.DatosPersonales.A_Paterno, 
		dbo.DatosPersonales.A_Materno, 
		dbo.Empleado.Fecha_contratacion AS [Fecha de contratacion], 
		dbo.DatosPersonales.Fecha_nacimiento, 
		dbo.Nomina.Salario_Diario AS [Salario Diario],
		dbo.Nomina.Fecha AS [Fecha Nomina]
FROM  dbo.Departamento 
INNER JOIN dbo.Empleado ON dbo.Departamento.ID_Departamento = dbo.Empleado.ID_Departamento 
INNER JOIN dbo.Nomina ON dbo.Empleado.CveEmpleado = dbo.Nomina.CveEmpleado 
INNER JOIN dbo.Puesto ON dbo.Empleado.ID_Puesto = dbo.Puesto.ID_Puesto 
INNER JOIN dbo.DatosPersonales ON dbo.Empleado.CveEmpleado = dbo.DatosPersonales.CveEmpleado


--ORDER BY Departamento, Puesto, A_Paterno
