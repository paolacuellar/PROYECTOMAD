-- PARTE 2
/*	Datos a mostrar: Departamento, Cantidad de empleados de cada departamento
	Orden: Departamento	*/
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'vw_HeadcounterP2' AND type = 'V')
DROP VIEW vw_HeadcounterP2;
GO

CREATE VIEW vw_HeadcounterP2
AS
SELECT 
dbo.Departamento.Nombre AS Departamento, 
dbo.Empleado.CveEmpleado,
dbo.Empleado.Fecha_contratacion 'Fecha de contratacion'
--COUNT(dbo.Empleado.CveEmpleado) 'Cantidad de empleados'
FROM dbo.Departamento 
INNER JOIN dbo.Empleado ON dbo.Departamento.ID_Departamento = dbo.Empleado.ID_Departamento
--GROUP BY Departamento.Nombre