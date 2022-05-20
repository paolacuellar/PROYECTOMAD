/*Todas las consultas a la base de datos (Select,
Update, Insert o Delete, etc.) a tablas o a vistas,
deberán de realizarse a través de procedimientos
almacenados (Stored Procedures), nunca de
forma directa.*/
/*No se permite el símbolo * (asterisco) para
cualquier tipo de consultas donde se utilice el
SELECT, ni para tablas ni para vistas, se deben de
especificar siempre los campos a mostrar*/

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

--INSERT INTO Empleado si no se especifican las columnas se tienen que llenar todas
INSERT INTO Empleado(Contrasenia,NumEmpresa,ID_Departamento,ID_Puesto, Banco, NumCuentaBan)
VALUES	('Roberto01', 1, 1, 5, 'Azteca', 19690129),
		('Gigipass', 1, 2, 1, 'Azteca', 19590311),
		('Reb', 1, 1, 2, 'Bancomer', 19790121),
		('Brandon03', 1, 4, 3, 'Banamex', 19561008),
		('Kath', 1, 5, 4, 'Azteca', 19890928);

SELECT * FROM Empleado; 

--INSERT INTO DatosPersonales la fecha se puede poner como numeros seguidos='19690129'
INSERT INTO DatosPersonales(CveEmpleado, CURP, Nombre, A_Paterno, Fecha_nacimiento)
VALUES	(1000000, '5FC28C0E6D36', 'Roberto', 'Tamburello', '1969-01-29'),
		(1000001,'F2D7CE0638B3', 'Gigi', 'Matthew', '1959-03-11'),
		(1000002, '686BD5AF6F30', 'Rebecca', 'Laszlo', '1979-01-21'),
		(1000003, '4CC8EDC25502', 'Brandon', 'Heidepriem', '1956-10-08'),
		(1000004, '5AFEAA76646A', 'Katherine', 'Swan', '1989-09-28');

SELECT * FROM DatosPersonales; 

UPDATE Empleado
SET Rol = 'GG'
WHERE CveEmpleado = 1000004;

--INSERT INTO Deduccion
INSERT INTO Deduccion(Motivo, Cantidad, Es_porcentaje)
VALUES	('Seguro social', 9.5, 1),
		('Impuesto sobre la Renta', 142.25, 0);

SELECT * FROM Deduccion;

--INSERT INTO Percepcion Percepcion basica= sueldo base*cantidad de dias trabajados en ese mes osea esa percepcion basica se va a calcular ps
INSERT INTO Percepcion(Motivo, Cantidad, Es_porcentaje)
VALUES	('Aguinaldo', 50, 1);

SELECT * FROM Percepcion;

--INSERT INTO Telefono Mucho Texto Ahorita no

--INSERT INTO Domicilio Mucho texto ahorita no

--INSERT INTO Nomina Calcular

--INSERT INTO Asign_Empleado_Percepcion Calcular

--INSERT INTO Asign_Empleado_Deduccion Calculae