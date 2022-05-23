USE PROYECTOMAD
-- PARTE 1
/*	Datos a mostrar: Departamento, Puesto, Cantidad de empleados de ese puesto-departamento
	Orden: Departamento y puesto	*/
IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'vw_HeadcounterP1' AND type = 'V')
DROP VIEW vw_HeadcounterP1;
GO

CREATE VIEW vw_HeadcounterP1
AS
SELECT      
dbo.Puesto.Nombre AS Puesto, 
dbo.Departamento.Nombre AS Departamento, 
dbo.Empleado.CveEmpleado,
dbo.Empleado.Fecha_contratacion 'Fecha de contratacion'
--COUNT(dbo.Empleado.CveEmpleado) 'Cantidad de empleados'
FROM dbo.Departamento 
INNER JOIN dbo.Empleado ON dbo.Departamento.ID_Departamento = dbo.Empleado.ID_Departamento 
INNER JOIN dbo.Puesto ON dbo.Empleado.ID_Puesto = dbo.Puesto.ID_Puesto
--GROUP BY Departamento.Nombre, Puesto.Nombre
