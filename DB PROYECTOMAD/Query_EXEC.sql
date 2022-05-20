USE PROYECTOMAD

DROP DATABASE PROYECTOMAD

----------------
EXEC sp_ValidaUsuario 1000004, 'Kath'

EXEC sp_ValidaUsuario 1000001, 'Gigipass'

EXEC sp_ValidaUsuario 1000003, 'abc'

------------------
EXEC sp_GestionEmpleado 'INSERT','92C4279F1207', 'Ken', 'Sánchez', NULL, '1969-01-29', NULL, NULL, NULL, NULL, 'BarbieyKen', NULL, NULL, NULL, NULL, 1, 1, NULL, 'Banamex', 19690129;

EXEC sp_GestionEmpleado 'INSERT','D87634598AA8', 'Terri', 'Duffy', 'Lee', '1974-11-12', NULL, NULL, NULL, NULL, 'Duffys', NULL, NULL, NULL, NULL, 6, 10, NULL, 'Bancomer', 19741112;

EXEC sp_GestionEmpleado 'DELETE', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1000000;

EXEC sp_GestionEmpleado 'VIEW';

EXEC sp_GestionEmpleado 'UPDATE', NULL, NULL, NULL , 'Lee', NULL, NULL, NULL, NULL, 1000005, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL;

EXEC sp_GestionEmpleado 'UPDATE', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1000005, NULL, NULL, NULL, NULL, NULL, NULL, 10, NULL, NULL, NULL;

-----------------
EXEC sp_GestionPuesto 'INSERT', NULL, 'Empleado', 1.0;

EXEC sp_GestionPuesto 'VIEW';

EXEC sp_GestionPuesto 'UPDATE', 10, NULL, 1.22;

EXEC sp_GestionPuesto 'DELETE', 10;

--------------------
EXEC sp_GestionDepartamento 'INSERT', NULL, 'Recursos Humanos', 200;

EXEC sp_GestionDepartamento 'INSERT', NULL, 'Recursos Humanos', 200.4;

EXEC sp_GestionDepartamento 'UPDATE', 6, NULL, 180;

EXEC sp_GestionDepartamento 'VIEW';

EXEC sp_GestionDepartamento 'DELETE', 8;

------------------
EXEC sp_GestionPercepcion 'VIEW';

EXEC sp_GestionPercepcion 'DELETE', 1;

EXEC sp_GestionPercepcion 'INSERT', NULL, 'Bono de productividad', NULL, 30, 1;