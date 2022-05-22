USE PROYECTOMAD

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_AsignacionPD' AND type = 'P')
    DROP PROCEDURE sp_AsignacionPD;
GO

CREATE PROCEDURE sp_AsignacionPD(
	@Opcion VARCHAR(10) = NULL,
	@CveEmpleado INT = NULL,
	@ID_Departamento TINYINT = NULL,
	@ID_Deduccion TINYINT = NULL, 
	@ID_Percepcion TINYINT = NULL, 
	@ID_ADeduccion INT = NULL, 
	@ID_APercepcion INT = NULL, 
	@Fecha DATE = NULL, 
	@Cantidad DECIMAL(10,2) = NULL
)
AS
BEGIN

-- Asignar todas las deducciones basicas a todos los empleados
/*DECLARE @FechaA DATE;
SET @FechaA = DATEDIFF(month, 0, GETDATE()-1)
SELECT @ID_Deduccion=ID_Deduccion FROM Deduccion WHERE Deduccion.Tipo='B';
SELECT @CveEmpleado=CveEmpleado FROM Empleado;
INSERT INTO Asign_Empleado_Deduccion(CveEmpleado, ID_Deduccion, Fecha)
			VALUES	(@CveEmpleado, @ID_Deduccion, @FechaA);*/

-----------------------EMPLEADO------------------------------
		-- Asignar una deduccion a un empleado
		IF @Opcion = 'DxE'
		BEGIN
			SELECT @ID_Deduccion=ID_Deduccion FROM Deduccion WHERE ID_Deduccion=@ID_Deduccion;
			INSERT INTO Asign_Empleado_Deduccion(CveEmpleado, ID_Deduccion, Fecha)
			VALUES	(@CveEmpleado, @ID_Deduccion, @Fecha);
		END

		-- Asignar una percepcion a un empleado
		IF @Opcion = 'PxE'
		BEGIN
			SELECT @ID_Percepcion=ID_Percepcion FROM Percepcion WHERE ID_Percepcion=@ID_Percepcion;
			INSERT INTO Asign_Empleado_Percepcion(CveEmpleado, ID_Percepcion, Fecha)
			VALUES	(@CveEmpleado, @ID_Percepcion, @Fecha);
		END

-----------------------DEPARTAMENTO------------------------------
		-- Asignar una deduccion a un departamento
		IF @Opcion = 'DxD'
		BEGIN
			CREATE TABLE #DEmpleadosDepartamento(
				CveEmpleado INT
			)
			INSERT INTO #DEmpleadosDepartamento(CveEmpleado)
			SELECT CveEmpleado FROM Empleado WHERE ID_Departamento=@ID_Departamento;
			DECLARE @CountE INT = (SELECT COUNT(CveEmpleado) FROM #DEmpleadosDepartamento);

			WHILE @CountE>0
			BEGIN
				DECLARE @Empleado INT = (SELECT TOP(1) CveEmpleado FROM #DEmpleadosDepartamento ORDER BY CveEmpleado)

				SELECT @ID_Deduccion=ID_Deduccion FROM Deduccion WHERE ID_Deduccion=@ID_Deduccion;
				INSERT INTO Asign_Empleado_Deduccion(CveEmpleado, ID_Deduccion, Fecha)
				VALUES	(@Empleado, @ID_Deduccion, @Fecha);

				DELETE #DEmpleadosDepartamento WHERE CveEmpleado=@Empleado
				SET @CountE = (SELECT COUNT(CveEmpleado) FROM #DEmpleadosDepartamento);
			END
		END

		-- Asignar una percepcion a un departamento
		IF @Opcion = 'PxD'
		BEGIN
			CREATE TABLE #PEmpleadosDepartamento(
				CveEmpleado INT
			)
			INSERT INTO #PEmpleadosDepartamento(CveEmpleado)
			SELECT CveEmpleado FROM Empleado WHERE ID_Departamento=@ID_Departamento;
			DECLARE @CountEP INT = (SELECT COUNT(CveEmpleado) FROM #PEmpleadosDepartamento);

			WHILE @CountEP>0
			BEGIN
				DECLARE @EmpleadoP INT = (SELECT TOP(1) CveEmpleado FROM #PEmpleadosDepartamento ORDER BY CveEmpleado)

				SELECT @ID_Percepcion=ID_Percepcion FROM Percepcion WHERE ID_Percepcion=@ID_Percepcion;
				INSERT INTO Asign_Empleado_Percepcion(CveEmpleado, ID_Percepcion, Fecha)
				VALUES	(@EmpleadoP, @ID_Percepcion, @Fecha);

				DELETE #PEmpleadosDepartamento WHERE CveEmpleado=@EmpleadoP
				SET @CountEP = (SELECT COUNT(CveEmpleado) FROM #PEmpleadosDepartamento);
			END
		END


END
