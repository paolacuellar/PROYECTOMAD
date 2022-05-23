CREATE TRIGGER trg_Eliminar_Empleado
ON Empleado
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @CveEmpleado INT

	SELECT @CveEmpleado=Empleado.CveEmpleado
	FROM Empleado
	JOIN deleted ON deleted.CveEmpleado=Empleado.CveEmpleado

	UPDATE Empleado
	SET Estado=0
	WHERE @CveEmpleado=Empleado.CveEmpleado
END