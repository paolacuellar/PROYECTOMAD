USE PROYECTOMAD;
/*Calcular sueldo bruto y neto
Calcular percepciones
Agregar al sueldo bruto
Calcular deducciones
Agregar al sueldo bruto
Calcular percepciones basicas
Agregar al sueldo bruto
Calcular deducciones basicas
Agregar al sueldo bruto
Calcular Neto total*/

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_CalculoNomina' AND type = 'P')
    DROP PROCEDURE sp_CalculoNomina;
GO

CREATE PROCEDURE sp_CalculoNomina(
	@Fecha DATE = NULL
)
AS
BEGIN

	DECLARE @nomina INT

	SET @nomina=(SELECT TOP(1) ID_Nomina FROM Nomina WHERE MONTH(Fecha)=MONTH(@Fecha) AND YEAR(Fecha)=YEAR(@Fecha))
	IF(@nomina IS NULL)
	BEGIN

		DECLARE @SalarioDiario DECIMAL (18,2)
		DECLARE @SueldoBruto DECIMAL (18,2)
		DECLARE @SueldoNeto DECIMAL (18,2)
		DECLARE @TotalPercepciones DECIMAL (18,2)
		DECLARE @TotalDeducciones DECIMAL (18,2)
		DECLARE @SumPercepcionesBasicas DECIMAL (18,2)
		DECLARE @SumDeduccionesBasicas DECIMAL (18,2)

		-- Sacar la nomina de cada empleado
		CREATE TABLE #EmpleadosNomina(
				CveEmpleado INT,
				Fecha_contratacion DATE
		)
		INSERT INTO #EmpleadosNomina(CveEmpleado, Fecha_contratacion)
		SELECT CveEmpleado, Fecha_contratacion FROM Empleado
		DECLARE @CountE INT = (SELECT COUNT(CveEmpleado) FROM #EmpleadosNomina);

		WHILE @CountE>0
		BEGIN
			DECLARE @CveEmpleado INT = (SELECT TOP(1) CveEmpleado FROM #EmpleadosNomina ORDER BY CveEmpleado)
			DECLARE @Fecha_Ingreso DATE = (SELECT TOP(1) Fecha_contratacion FROM #EmpleadosNomina ORDER BY CveEmpleado)

			-- Calcular Sueldo Bruto
			SELECT @SueldoBruto = dbo.fn_SueldoBruto(dbo.fn_SalarioDiario(Departamento.Sueldo_Base, Puesto.Nivel_Salarial), 20),
			 @SalarioDiario = dbo.fn_SalarioDiario(Departamento.Sueldo_Base, Puesto.Nivel_Salarial)  FROM Empleado 
			JOIN Departamento ON Departamento.ID_Departamento=Empleado.ID_Departamento
			JOIN Puesto ON Puesto.ID_Puesto=Empleado.ID_Puesto;
						 
			--WHERE CveEmpleado=@CveEmpleado

			-- En este momento nuestro Sueldo Neto es igual al Sueldo Bruto
			SELECT @SueldoNeto=@SueldoBruto;

			-- Calcular percepciones
			SELECT @TotalPercepciones = dbo.fn_SumPD('P', 0, @SueldoBruto, @Fecha, @CveEmpleado) + dbo.fn_SumPD('P', 1, @SueldoBruto, @Fecha, @CveEmpleado) FROM Asign_Empleado_Percepcion
			JOIN Percepcion ON Percepcion.ID_Percepcion=Asign_Empleado_Percepcion.ID_Percepcion
			JOIN Empleado ON Empleado.CveEmpleado=Asign_Empleado_Percepcion.CveEmpleado
			WHERE Empleado.CveEmpleado=@CveEmpleado AND (MONTH(Asign_Empleado_Percepcion.Fecha)=MONTH(@Fecha) AND YEAR(Asign_Empleado_Percepcion.Fecha)=YEAR(@Fecha))

			-- Calcular deducciones
			SELECT @TotalDeducciones = dbo.fn_SumPD('D', 0, @SueldoBruto, @Fecha, @CveEmpleado) + dbo.fn_SumPD('D', 1, @SueldoBruto, @Fecha, @CveEmpleado) FROM Asign_Empleado_Deduccion
			JOIN Deduccion ON Deduccion.ID_Deduccion=Asign_Empleado_Deduccion.ID_Deduccion
			JOIN Empleado ON Empleado.CveEmpleado=Asign_Empleado_Deduccion.CveEmpleado
			WHERE Empleado.CveEmpleado=@CveEmpleado AND (MONTH(Asign_Empleado_Deduccion.Fecha)=MONTH(@Fecha) AND YEAR(Asign_Empleado_Deduccion.Fecha)=YEAR(@Fecha))

			-- Calcular percepciones basicas
			SELECT @SumPercepcionesBasicas=SUM(Cantidad) FROM Percepcion WHERE Tipo='B'
			SELECT @TotalPercepciones = @TotalPercepciones+@SumPercepcionesBasicas;

			-- Calcular deducciones basicas
			SELECT @SumDeduccionesBasicas=SUM(Cantidad) FROM Deduccion WHERE Tipo='B'
			SELECT @TotalDeducciones = @TotalDeducciones+@SumDeduccionesBasicas;


			SELECT @SueldoNeto=@SueldoBruto+@TotalDeducciones-@TotalPercepciones;

			INSERT INTO Nomina (CveEmpleado, Salario_Diario, Sueldo_Bruto, Sueldo_Neto, Fecha)
			VALUES (@CveEmpleado, @SalarioDiario, @SueldoBruto, @SueldoNeto, @Fecha);

			DELETE #EmpleadosNomina WHERE CveEmpleado=@CveEmpleado
			SET @CountE = (SELECT COUNT(CveEmpleado) FROM #EmpleadosNomina);
		END
	END
	ELSE
	BEGIN
		RAISERROR(15600,1,1,'Esta nomina ya ha sido calculada');
		RETURN;
	END
END