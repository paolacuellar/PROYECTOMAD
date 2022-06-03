USE PROYECTOMAD

IF EXISTS (SELECT 1 FROM sysobjects WHERE name = 'sp_GestionEmpleado' AND type = 'P')
    DROP PROCEDURE sp_GestionEmpleado;
GO

CREATE PROCEDURE sp_GestionEmpleado(
	@Opcion VARCHAR(10) = NULL,
	-- Datos Personales
	@CURP VARCHAR(25) = NULL, 
	@Nombre VARCHAR(255) = NULL,  
	@A_Paterno VARCHAR(25) = NULL, 
	@A_Materno VARCHAR(25) = NULL,
	@Fecha_nacimiento DATE = NULL, 
	@Email VARCHAR(25) = NULL, 
	@RFC VARCHAR(25) = NULL,  
	@NumSeguro_Social INT = NULL,
	-- Datos Empleado
	@CveEmpleado INT = NULL,
	@Contrasenia VARCHAR(25) = NULL,  
	@Fecha_contratacion DATE = NULL,
	@Rol VARCHAR(50) = NULL,
	@Estado BIT = NULL,
	@NumEmpresa TINYINT = NULL, 
	@ID_Departamento TINYINT = NULL,
	@ID_Puesto TINYINT = NULL,
	@Fecha_POcupacion DATE = NULL,
	@Banco VARCHAR(50) = NULL,
	@NumCuentaBan INT = NULL,
	-- Domicilio
	@calle VARCHAR(25)  = NULL, 
	@numero INT  = NULL, 
	@colonia VARCHAR(25)  = NULL, 
	@municipio VARCHAR(25)  = NULL, 
	@estadoPais VARCHAR(25)  = NULL, 
	@codigo_postal INT  = NULL,
	-- Telefono
	@Telefono VARCHAR(18) = NULL
)
AS
BEGIN

	-- Agregar un nuevo usuario
	IF @Opcion = 'INSERT'
	BEGIN
		IF NOT EXISTS ( --Valida que no inserte un empleado que tiene el mismo curp que otro
			SELECT CURP
			FROM DatosPersonales
			WHERE CURP=@CURP
		)
		BEGIN
			IF NOT EXISTS (SELECT ID_Departamento FROM Departamento WHERE ID_Departamento=@ID_Departamento)
			BEGIN
				RAISERROR(15600,1,1,'Error, el departamento no existe');
				RETURN;
			END;
			IF NOT EXISTS (SELECT ID_Puesto FROM Puesto WHERE ID_Puesto=@ID_Puesto)
			BEGIN
				RAISERROR(15600,1,1,'Error, el puesto no existe');
				RETURN;
			END;

			INSERT INTO Empleado(Contrasenia, NumEmpresa, ID_Departamento, ID_Puesto, Banco, NumCuentaBan)
			VALUES (@Contrasenia, ISNULL(@NumEmpresa, 1), @ID_Departamento, @ID_Puesto, @Banco, @NumCuentaBan);
			SET @CveEmpleado=(SELECT @@IDENTITY);

			INSERT INTO DatosPersonales(CveEmpleado, CURP, Nombre, A_Paterno, A_Materno, Fecha_nacimiento, Email, RFC, NumSeguro_Social)
			VALUES (@CveEmpleado, @CURP, @Nombre, @A_Paterno, @A_Materno, @Fecha_nacimiento, @Email, @RFC, @NumSeguro_Social);

			INSERT INTO Domicilio(calle, numero, colonia, municipio, estado, codigo_postal, CveEmpleado)
			VALUES (@calle, @numero, @colonia, @municipio, 'Nuevo Leon', @codigo_postal, @CveEmpleado);

			INSERT INTO Telefono( Telefono, CveEmpleado)
			VALUES (@Telefono, @CveEmpleado);
		END
	END
	
	-- Eliminar un empleado
	IF @Opcion = 'DELETE'
	BEGIN

		DELETE DatosPersonales
		WHERE CveEmpleado=@CveEmpleado;

		DELETE Domicilio
		WHERE CveEmpleado=@CveEmpleado;

		DELETE Telefono
		WHERE CveEmpleado=@CveEmpleado;
		
		DELETE Empleado
		WHERE CveEmpleado=@CveEmpleado;
		/*UPDATE Empleado
		SET Estado = 0
		WHERE CveEmpleado=@CveEmpleado;*/
	END

	-- Actualizar un empleado
	IF @Opcion = 'UPDATE'
	BEGIN

		UPDATE Domicilio
		SET
		calle = ISNULL(@calle, calle), 
		colonia = ISNULL(@colonia, colonia), 
		municipio = ISNULL(@CURP, municipio), 		
		codigo_postal = ISNULL(codigo_postal, codigo_postal)
		WHERE CveEmpleado=@CveEmpleado;

		UPDATE Telefono
		SET
		Telefono = ISNULL(@Telefono, Telefono)
		WHERE CveEmpleado=@CveEmpleado;

		UPDATE DatosPersonales
		SET 
		CURP = ISNULL(@CURP, CURP),
		Nombre = ISNULL(@Nombre, Nombre), 
		A_Paterno = ISNULL(@A_Paterno, A_Paterno), 
		A_Materno = ISNULL(@A_Materno, A_Materno), 
		Fecha_nacimiento = ISNULL(@Fecha_nacimiento, Fecha_nacimiento), 
		Email = ISNULL(@Email, Email), 
		RFC = ISNULL(@RFC, RFC), 
		NumSeguro_Social = ISNULL(@NumSeguro_Social, NumSeguro_Social)
		WHERE CveEmpleado=@CveEmpleado;

		UPDATE Empleado
		SET
		Contrasenia = ISNULL(@Contrasenia, Contrasenia), 
		ID_Departamento = ISNULL(@ID_Departamento, ID_Departamento), 
		ID_Puesto = ISNULL(@ID_Puesto, ID_Puesto),
		Banco = ISNULL(@Banco, Banco),
		NumCuentaBan = ISNULL(@NumCuentaBan, NumCuentaBan)
		WHERE CveEmpleado=@CveEmpleado
	END

	-- Ver la informacion de todos los empleados
	IF @Opcion = 'VIEW'
	BEGIN
		SELECT	Empleado.CveEmpleado 'Clave',
				DatosPersonales.CURP,
				DatosPersonales.Nombre,
				DatosPersonales.A_Paterno 'Apellido Paterno',
				ISNULL(DatosPersonales.A_Materno, 'SIN APELLIDO') 'Apellido Materno',
				Empleado.Fecha_contratacion 'Fecha de Contratacion',
				Departamento.Nombre 'Departamento',
				Puesto.Nombre 'Puesto',
				Empleado.Fecha_POcupacion 'Fecha de Ocupacion de Puesto'
		FROM Empleado
		JOIN DatosPersonales ON Empleado.CveEmpleado=DatosPersonales.CveEmpleado
		JOIN Departamento ON Empleado.ID_Departamento=Departamento.ID_Departamento
		JOIN Puesto ON Empleado.ID_Puesto=Puesto.ID_Puesto
		WHERE Empleado.Estado=1;
	END

	-- Ver la informacion de un empleado en especifico
	IF @Opcion = 'VIEWE'
	BEGIN
		SELECT	Empleado.CveEmpleado as Clave,
				DatosPersonales.CURP,
				DatosPersonales.RFC,
				DatosPersonales.NumSeguro_Social,
				DatosPersonales.Nombre,
				DatosPersonales.A_Paterno,
				DatosPersonales.A_Materno,
				DatosPersonales.Fecha_nacimiento,
				DatosPersonales.Email,
				Empleado.Fecha_contratacion,
				Departamento.ID_Departamento as id_Depto,
				Departamento.Nombre as Depto,
				Departamento.Sueldo_Base,
				Puesto.ID_Puesto as id_Puesto,
				Puesto.Nombre as Puesto,
				Puesto.Nivel_Salarial,
				Empleado.Fecha_POcupacion,
				Telefono.Telefono,
				Domicilio.calle,
				Domicilio.numero,
				Domicilio.colonia,
				Domicilio.codigo_postal,
				Domicilio.municipio,
				Domicilio.estado,
				Empleado.NumCuentaBan,
				Empleado.Banco,
				Empleado.Contrasenia
		FROM Empleado
		JOIN DatosPersonales ON Empleado.CveEmpleado=DatosPersonales.CveEmpleado
		JOIN Telefono ON Empleado.CveEmpleado=Telefono.CveEmpleado
		JOIN Domicilio ON Empleado.CveEmpleado=Domicilio.CveEmpleado
		JOIN Departamento ON Empleado.ID_Departamento=Departamento.ID_Departamento
		JOIN Puesto ON Empleado.ID_Puesto=Puesto.ID_Puesto
		WHERE Empleado.CveEmpleado=@CveEmpleado;
	END
END