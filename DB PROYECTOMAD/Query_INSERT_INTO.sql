/*Todas las consultas a la base de datos (Select,
Update, Insert o Delete, etc.) a tablas o a vistas,
deber�n de realizarse a trav�s de procedimientos
almacenados (Stored Procedures), nunca de
forma directa.*/
/*No se permite el s�mbolo * (asterisco) para
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
VALUES	('Administraci�n', 150),
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

--INSERT INTO DatosPersonales
INSERT INTO DatosPersonales(CURP, Nombre, A_Paterno, Fecha_nacimiento)
VALUES	('5FC28C0E6D36', 'Roberto', 'Tamburello', '1969-01-29'),
		('F2D7CE0638B3', 'Gigi', 'Matthew', '1959-03-11'),
		('686BD5AF6F30', 'Rebecca', 'Laszlo', '1979-01-21'),
		('4CC8EDC25502', 'Brandon', 'Heidepriem', '1956-10-08'),
		('5AFEAA76646A', 'Katherine', 'Swan', '1989-09-28');

SELECT * FROM DatosPersonales; 
--INSERT INTO Empleado


--INSERT INTO Telefono

--INSERT INTO Domicilio

--INSERT INTO Nomina

--INSERT INTO Percepcion

--INSERT INTO Deduccion

--INSERT INTO Asign_Empleado_Percepcion

--INSERT INTO Asign_Empleado_Deduccion