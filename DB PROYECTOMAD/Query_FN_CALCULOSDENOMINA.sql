USE PROYECTOMAD;

---------Calculo Salario Diario = sueldo base del Departamento*Nivel de Puesto
IF OBJECT_ID ('fn_SalarioDiario') IS NOT NULL
BEGIN
	DROP FUNCTION fn_SalarioDiario
END
GO

CREATE FUNCTION fn_SalarioDiario(
	@Sueldo_BaseD INT,
	@Nivel_SalarialP DECIMAL(10,5)
)
RETURNS DECIMAL(18,2)
AS
BEGIN
	DECLARE @SalarioDiario DECIMAL(18,2)

	SELECT @SalarioDiario=(@Sueldo_BaseD*@Nivel_SalarialP);

	RETURN @SalarioDiario
END
GO

---------Calculo Sueldo Mensual Bruto = Salario Diario*Numerio de dìas del mes
IF OBJECT_ID ('fn_SueldoBruto') IS NOT NULL
BEGIN
	DROP FUNCTION fn_SueldoBruto
END
GO

CREATE FUNCTION fn_SueldoBruto(
	@SalarioDiario DECIMAL(18,2),
	@NumDiasMes INT
)
RETURNS DECIMAL(18,2)
AS 
BEGIN
	DECLARE @SueldoBruto DECIMAL(18,2)

	SELECT @SueldoBruto=(@SalarioDiario*@NumDiasMes);
	
	RETURN @SueldoBruto
END
GO

---------Determina si es año bisiesto
IF OBJECT_ID ('fn_EsBisiesto') IS NOT NULL
BEGIN
	DROP FUNCTION fn_EsBisiesto
END
GO

CREATE FUNCTION fn_EsBisiesto(
	@Fecha DATE
) 
RETURNS BIT
AS
BEGIN
	
	IF	(YEAR(@Fecha)%4 = 0 AND YEAR(@Fecha)%100 != 0) OR
		YEAR(@Fecha)%400 = 0
		RETURN 1

	RETURN 0
END
GO

---------Obtener el numero de dìas por mes
IF OBJECT_ID ('fn_NumDiasMes') IS NOT NULL
BEGIN
	DROP FUNCTION fn_NumDiasMes
END
GO

CREATE FUNCTION fn_NumDiasMes(
	@Fecha DATE
)
RETURNS INT
AS
BEGIN

	DECLARE @Dias INT;

	

	 
	 IF MONTH(@Fecha) IN ( 1, 3, 5, 7, 8, 10, 12)BEGIN SET @Dias = 31; END
				ELSE IF MONTH(@Fecha) IN ( 4, 6, 9, 11)BEGIN SET @Dias = 30; END
				ELSE IF MONTH(@Fecha)=2 BEGIN SET @Dias = dbo.fn_EsBisiesto(@Fecha) + 28 END
		

	RETURN @Dias
END
GO

---------Obtener el numero de dìas trabajados FECHA DE COBRO: ULTIMO DE CADA MES calcular numero de dias desde el ultimo cobro
IF OBJECT_ID ('fn_NumDiasTrabajados') IS NOT NULL
BEGIN
	DROP FUNCTION fn_NumDiasTrabajados
END
GO

CREATE FUNCTION fn_NumDiasTrabajados(
	@Fecha DATE,
	@Fecha_ingreso DATE
	-- @Fecha_UNomina DATE = NULL -- Fecha de la ultima nomina
)
RETURNS INT
AS
BEGIN
	DECLARE @NumDiasTrabajados INT
	DECLARE @Diferencia INT
	DECLARE @NumDiasMes INT

	IF (MONTH(@Fecha_ingreso) = MONTH(@Fecha) AND YEAR(@Fecha_ingreso) = YEAR(@Fecha)) --Compara si la fecha pertenece al mismo mes y el mismo año en que ingreso el empleado
	BEGIN
		SELECT @Diferencia = DATEPART(DAY, @Fecha_ingreso);
		SELECT @NumDiasMes = dbo.fn_NumDiasMes(@Fecha);
		SELECT @NumDiasTrabajados = @NumDiasMes-@Diferencia;
	END
	ELSE 
	BEGIN
		SELECT @NumDiasTrabajados = dbo.fn_NumDiasMes(@Fecha);
	END

	RETURN @NumDiasTrabajados
	
END
GO

--------- Calculo Suma Percepciones y Deducciones
IF OBJECT_ID ('fn_SumPD') IS NOT NULL
BEGIN
	DROP FUNCTION fn_SumPD
END
GO

CREATE FUNCTION fn_SumPD(
	@Opcion VARCHAR(10),
	@Es_porcentaje BIT,
	@Sueldo_Bruto DECIMAL(18,2),
	@Fecha DATE,
	@CveEmpleado INT
)
RETURNS INT
AS
BEGIN
-- Es percepcion
	-- Es Fijo
	-- Es Porcentaje

--Es Deduccion
	-- Es Fijo
	-- Es Porcentaje
	DECLARE @SumPD DECIMAL(18,2)
	DECLARE @ValoraSumPD DECIMAL(18,2)
	
	IF @Opcion='P' -- Es una percepcion
	BEGIN

		IF @Es_porcentaje=1 -- El valor es porcentaje
		BEGIN
			SET @SumPD = (SELECT SUM(Cantidad) FROM Asign_Empleado_Percepcion 
			JOIN Percepcion ON Percepcion.ID_Percepcion = Asign_Empleado_Percepcion.ID_Percepcion
			JOIN Empleado ON Empleado.CveEmpleado=Asign_Empleado_Percepcion.CveEmpleado
			WHERE Percepcion.Es_porcentaje=1 AND Percepcion.Tipo= 'O' AND (MONTH(Asign_Empleado_Percepcion.Fecha) = MONTH(@Fecha)) AND (YEAR(Asign_Empleado_Percepcion.Fecha) = YEAR(@Fecha)) AND Asign_Empleado_Percepcion.CveEmpleado=@CveEmpleado)

			IF (@SumPD IS NULL)
			BEGIN
				SET @ValoraSumPD = 0
			END
			ELSE
			BEGIN
				SET @ValoraSumPD = @Sueldo_Bruto*(@SumPD/100)
			END
		END
		ELSE -- El valor es fijo
		BEGIN
			SET @SumPD = (SELECT SUM(Cantidad) FROM Asign_Empleado_Percepcion 
			JOIN Percepcion ON Percepcion.ID_Percepcion = Asign_Empleado_Percepcion.ID_Percepcion
			JOIN Empleado ON Empleado.CveEmpleado=Asign_Empleado_Percepcion.CveEmpleado
			WHERE Percepcion.Es_porcentaje=0 AND Percepcion.Tipo= 'O' AND (MONTH(Asign_Empleado_Percepcion.Fecha) = MONTH(@Fecha)) AND (YEAR(Asign_Empleado_Percepcion.Fecha) = YEAR(@Fecha)) AND Asign_Empleado_Percepcion.CveEmpleado=@CveEmpleado)
			
			IF (@SumPD IS NULL)
			BEGIN
				SET @ValoraSumPD = 0
			END
			ELSE
			BEGIN
				SET @ValoraSumPD = @SumPD
			END
		END
	END

	IF @Opcion='D' -- Es una deduccion
	BEGIN

		IF @Es_porcentaje=1 -- El valor es porcentaje
		BEGIN
			SET @SumPD = (SELECT SUM(Cantidad) FROM Asign_Empleado_Deduccion 
			JOIN Deduccion ON Deduccion.ID_Deduccion = Asign_Empleado_Deduccion.ID_Deduccion
			JOIN Empleado ON Empleado.CveEmpleado=Asign_Empleado_Deduccion.CveEmpleado
			WHERE Deduccion.Es_porcentaje=1 AND Deduccion.Tipo= 'O' AND (MONTH(Asign_Empleado_Deduccion.Fecha) = MONTH(@Fecha)) AND (YEAR(Asign_Empleado_Deduccion.Fecha) = YEAR(@Fecha)) AND Asign_Empleado_Deduccion.CveEmpleado=@CveEmpleado)

			IF (@SumPD IS NULL)
			BEGIN
				SET @ValoraSumPD = 0
			END
			ELSE
			BEGIN
			SET @ValoraSumPD = @Sueldo_Bruto*(@SumPD/100)
			END
		END
		ELSE -- El valor es fijo
		BEGIN
			SELECT @SumPD = (SELECT SUM(Cantidad) FROM Asign_Empleado_Deduccion 
			JOIN Deduccion ON Deduccion.ID_Deduccion = Asign_Empleado_Deduccion.ID_Deduccion
			JOIN Empleado ON Empleado.CveEmpleado=Asign_Empleado_Deduccion.CveEmpleado
			WHERE Deduccion.Es_porcentaje=0 AND Deduccion.Tipo= 'O' AND (MONTH(Asign_Empleado_Deduccion.Fecha) = MONTH(@Fecha)) AND (YEAR(Asign_Empleado_Deduccion.Fecha) = YEAR(@Fecha)) AND Asign_Empleado_Deduccion.CveEmpleado=@CveEmpleado)

			IF (@SumPD IS NULL)
			BEGIN
				SET @ValoraSumPD = 0
			END
			ELSE
			BEGIN
				SET @ValoraSumPD = @SumPD
			END
		END
	END

	RETURN @ValoraSumPD
END

GO
IF OBJECT_ID ('fn_SumPDB') IS NOT NULL
BEGIN
	DROP FUNCTION fn_SumPDB
END
GO

CREATE FUNCTION fn_SumPDB(
	@Opcion VARCHAR(10),
	@Es_porcentaje BIT,
	@Sueldo_Bruto DECIMAL(18,2)
)
RETURNS INT
AS
BEGIN
-- Es percepcion
	-- Es Fijo
	-- Es Porcentaje

--Es Deduccion
	-- Es Fijo
	-- Es Porcentaje
	DECLARE @SumPDB DECIMAL(18,2)
	DECLARE @ValoraSumPDB DECIMAL(18,2)
	
	IF @Opcion='P' -- Es una percepcion
	BEGIN

		IF @Es_porcentaje=1 -- El valor es porcentaje
		BEGIN
			SET @SumPDB = (SELECT SUM(Cantidad) FROM Percepcion 
			WHERE Percepcion.Es_porcentaje=1 AND Percepcion.Tipo = 'B');

			IF (@SumPDB IS NULL)
			BEGIN
				SET @ValoraSumPDB = 0
			END
			ELSE
			BEGIN
				SET @ValoraSumPDB = @Sueldo_Bruto*(@SumPDB/100)
			END
		END
		ELSE -- El valor es fijo
		BEGIN
			SET @SumPDB = (SELECT SUM(Cantidad) FROM Percepcion 
			WHERE Percepcion.Es_porcentaje=0 AND Percepcion.Tipo = 'B');

			IF (@SumPDB IS NULL)
			BEGIN
				SET @ValoraSumPDB = 0
			END
			ELSE
			BEGIN
				SET @ValoraSumPDB = @SumPDB
			END
		END
	END

	IF @Opcion='D' -- Es una deduccion
	BEGIN

		IF @Es_porcentaje=1 -- El valor es porcentaje
		BEGIN
			SET @SumPDB = (SELECT SUM(Cantidad) FROM Deduccion 
			WHERE Deduccion.Es_porcentaje=1 AND Deduccion.Tipo = 'B');
			IF (@SumPDB IS NULL)
			BEGIN
				SET @ValoraSumPDB = 0
			END
			ELSE
			BEGIN
			SET @ValoraSumPDB = @Sueldo_Bruto*(@SumPDB/100)
			END
		END
		ELSE -- El valor es fijo
		BEGIN
			SET @SumPDB = (SELECT SUM(Cantidad) FROM Deduccion 
			WHERE Deduccion.Es_porcentaje=0 AND Deduccion.Tipo = 'B');

			IF (@SumPDB IS NULL)
			BEGIN
				SET @ValoraSumPDB = 0
			END
			ELSE
			BEGIN
				SET @ValoraSumPDB = @SumPDB
			END
		END
	END

	RETURN @ValoraSumPDB
END

---------Calculo Sueldo Neto, el que se deposita a su cuenta, tomando en cuenta todas las percepciones y deducciones que apliquen






