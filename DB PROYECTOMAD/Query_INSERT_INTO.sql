USE PROYECTOMAD

--INSERT INTO Empresa
INSERT INTO Empresa(RFC, Nombre, Razon_social, Fecha_Operaciones)
VALUES	('MONIAW8305281H0', 'Monsters, Inc.','MonsterWorlds Business','1810-12-29');
SELECT * FROM Empresa; 

--INSERT INTO Departamento
INSERT INTO Departamento(Nombre,Sueldo_Base)
VALUES	('Administración', 150),
		('Inventario', 80),
		('Almacen', 132),
		('Finanzas', 165),
		('Contabilidad', 120);

SELECT * FROM Departamento;

--INSERT INTO Puesto
INSERT INTO Puesto(Nombre, Nivel_Salarial)
VALUES	('Ayudante', 0.5),
		('Asociado', 0.8),
		('Contador Junior', 1),
		('Contador Senior', 2),
		('Jefe', 2.5),
		('Gerente', 6),
		('SubGerente', 5),
		('Director', 10),
		('SubDirector', 7);

SELECT * FROM Puesto; 

--INSERT INTO DatosPersonales la fecha se puede poner como numeros seguidos='19690129'
INSERT INTO DatosPersonales(CURP, Nombre, A_Paterno, Fecha_nacimiento)
VALUES	('5FC28C0E6D36', 'Roberto', 'Tamburello', '1969-01-29'),
		('F2D7CE0638B3', 'Gigi', 'Matthew', '1959-03-11'),
		('686BD5AF6F30', 'Rebecca', 'Laszlo', '1979-01-21'),
		('4CC8EDC25502', 'Brandon', 'Heidepriem', '1956-10-08'),
		('5AFEAA76646A', 'Katherine', 'Swan', '1989-09-28');

SELECT * FROM DatosPersonales; 

--INSERT INTO Empleado si no se especifican las columnas se tienen que llenar todas
INSERT INTO Empleado(Contrasenia,CURP,NumEmpresa,ID_Departamento,ID_Puesto)
VALUES	('Roberto01', '5FC28C0E6D36', 1, 1, 5),
		('Gigipass', 'F2D7CE0638B3', 1, 2, 1),
		('Reb', '686BD5AF6F30', 1, 1, 2),
		('Brandon03', '4CC8EDC25502', 1, 4, 3),
		('Kath', '5AFEAA76646A', 1, 5, 4);

SELECT * FROM Empleado; 

-- GG = GERENTE GENERAL
UPDATE Empleado
SET Rol = 'GG'
WHERE CveEmpleado = 1000004;

--INSERT INTO Deduccion
INSERT INTO Deduccion(Motivo, Cantidad, Es_porcentaje)
VALUES	('Seguro social', 9.5, 1),
		('Impuesto sobre la Renta', 142.25, 0);

SELECT * FROM Deduccion;

--INSERT INTO Percepcion Percepcion basica= sueldo base*cantidad de dias trabajados en ese mes osea esa percepcion basica se va a calcular ps

--INSERT INTO Telefono Mucho Texto Ahorita no

--INSERT INTO Domicilio Mucho texto ahorita no

--INSERT INTO Nomina Calcular

--INSERT INTO Asign_Empleado_Percepcion Calcular

--INSERT INTO Asign_Empleado_Deduccion Calcular