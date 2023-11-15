---------------------------------------------------------
-- PROCEDIMIENTO TABLA CARGOS
---------------------------------------------------------

ALTER PROCEDURE INSERTAR_CARGO
@Descripcion varchar(50)
AS
DECLARE @Activo bit
SET @Activo = 1
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT Descripcion FROM Cargos WHERE Descripcion = @Descripcion)
			RAISERROR('YA EXISTE UN REGISTRO CON ESA DESCRIPCION, INSERTE UNA NUEVA',16,1)
		ELSE
			INSERT INTO Cargos VALUES(
								@Descripcion,
								@Activo)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH
END
--EXEC INSERTAR_CATEGORIA

ALTER PROCEDURE MOSTRAR_CARGOS
AS
BEGIN
	SELECT * FROM Cargos WHERE Activo = 1
	ORDER BY Descripcion
END
--EXEC MOSTRAR_CARGOS

ALTER PROCEDURE BUSCAR_CARGOS
@Buscador varchar(50)
AS
BEGIN
	SELECT * FROM Cargos WHERE (Descripcion like '%' + @Buscador + '%') AND Activo=1
END
--EXEC BUSCAR_CARGOS

ALTER PROCEDURE ACTUALIZAR_CARGO
@Id_Cargo int,
@Descripcion varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT * FROM Cargos WHERE Descripcion=@Descripcion AND Id_Cargo<>@Id_Cargo)
			RAISERROR('ERROR, HAY OTRO REGISTRO QUE COINCIDE CON EL CODIGO',16,1)
		ELSE
			UPDATE Cargos SET
			Descripcion = @Descripcion
			WHERE Id_Cargo = @Id_Cargo
			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH
		
END


CREATE PROCEDURE ELIMINAR_CARGO
@Id_Cargo int
AS
BEGIN
	BEGIN TRY
		UPDATE Cargos SET
		Activo = 0
		WHERE Id_Cargo = @Id_Cargo
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END


---------------------------------------------------------
-- PROCEDIMIENTO TABLA EMPLEADOS
---------------------------------------------------------
CREATE PROCEDURE INSERTAR_EMPLEADO
@Cedula varchar(50),
@NombreCompleto varchar(50),
@Direccion varchar(50),
@Telefono varchar(50),
@Correo varchar(50),
@IdCargo int,
@Foto image
AS
DECLARE @Activo bit
SET @Activo = 1
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT Cedula FROM Empleados WHERE Cedula = @Cedula)
			RAISERROR('YA EXISTE UN REGISTRO CON ESE DOCUMENTO, INSERTE UNO NUEVO',16,1)
		ELSE
			INSERT INTO Empleados VALUES(
								@Cedula,
								@NombreCompleto,
								@Direccion,
								@Telefono,
								@Correo,
								@IdCargo,
								@Foto,
								@Activo)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH
END

CREATE PROCEDURE MOSTRAR_EMPLEADOS
AS
BEGIN
	SELECT * FROM Empleados WHERE Activo = 1
	ORDER BY NombreCompleto
END

ALTER PROCEDURE MOSTRAR_EMPLEADOS
AS
BEGIN
	SELECT E.Id_Empleado, E.Cedula, E.NombreCompleto as 'Nombre Completo', E.Direccion, E.Telefono, E.Correo, C.Descripcion as Cargo, E.Foto, E.Activo
	FROM Empleados E INNER JOIN Cargos C ON E.Id_Cargo=C.Id_Cargo
	WHERE E.Activo = 1
	ORDER BY NombreCompleto
END

CREATE PROCEDURE MOSTRAR_MEDICOS
AS
BEGIN
	SELECT E.Id_Empleado, E.NombreCompleto
	FROM Empleados E
	WHERE E.Activo = 1 and E.Id_Cargo = 2
	ORDER BY NombreCompleto
END

ALTER PROCEDURE BUSCAR_EMPLEADO
@Buscador varchar(50)
AS
BEGIN
	SELECT E.Id_Empleado, E.Cedula, E.NombreCompleto as 'Nombre Completo', E.Direccion, E.Telefono, E.Correo, C.Descripcion as Cargo, E.Foto, E.Activo
	FROM Empleados E INNER JOIN Cargos C ON E.Id_Cargo=C.Id_Cargo
	WHERE ((E.NombreCompleto like '%' + @Buscador + '%') OR (E.Cedula like '%' + @Buscador + '%')) AND E.Activo=1
END

CREATE PROCEDURE BUSCAR_EMPLEADO_ID
@Id_Empleado int
AS
BEGIN
	SELECT * FROM Empleados WHERE Id_Empleado = @Id_Empleado AND Activo=1
END

CREATE PROCEDURE ACTUALIZAR_EMPLEADO
@Id_Empleado int,
@Cedula varchar(50),
@NombreCompleto varchar(50),
@Direccion varchar(50),
@Telefono varchar(50),
@Correo varchar(50),
@IdCargo int
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT * FROM Empleados WHERE Cedula=@Cedula AND Id_Empleado<>@Id_Empleado)
			RAISERROR('ERROR, HAY OTRO REGISTRO QUE COINCIDE CON EL DOCUMENTO',16,1)
		ELSE
			UPDATE Empleados SET
			Cedula = @Cedula,
			NombreCompleto = @NombreCompleto,
			Direccion = @Direccion,
			Telefono = @Telefono,
			Correo = @Correo,
			Id_Cargo = @IdCargo
			WHERE Id_Empleado = @Id_Empleado
			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH	
END

CREATE PROCEDURE ACTUALIZAR_EMPLEADO_FOTO
@Id_Empleado int,
@Cedula varchar(50),
@Foto image
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT * FROM Empleados WHERE Cedula=@Cedula AND Id_Empleado<>@Id_Empleado)
			RAISERROR('ERROR, HAY OTRO REGISTRO QUE COINCIDE CON EL DOCUMENTO',16,1)
		ELSE
			UPDATE Empleados SET
			Foto = @Foto
			WHERE Id_Empleado = @Id_Empleado
			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH	
END

CREATE PROCEDURE ELIMINAR_EMPLEADO
@Id_Empleado int
AS
BEGIN
	BEGIN TRY
		UPDATE Empleados SET
		Activo = 0
		WHERE Id_Empleado = @Id_Empleado
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END

---------------------------------------------------------
-- PROCEDIMIENTO TABLA CLIENTES
---------------------------------------------------------

CREATE PROCEDURE INSERTAR_CLIENTE
@Cedula varchar(50),
@NombreCompleto varchar(50),
@Direccion varchar(50),
@Telefono varchar(50),
@Correo varchar(50)
AS
DECLARE @Activo bit
SET @Activo = 1
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT Cedula FROM Clientes WHERE Cedula = @Cedula)
			RAISERROR('YA EXISTE UN REGISTRO CON ESE DOCUMENTO, INSERTE UNO NUEVO',16,1)
		ELSE
			INSERT INTO Clientes VALUES(
								@Cedula,
								@NombreCompleto,
								@Direccion,
								@Telefono,
								@Correo,
								@Activo)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH
END

CREATE PROCEDURE MOSTRAR_CLIENTES
AS
BEGIN
	SELECT * FROM Clientes WHERE Activo = 1
	ORDER BY NombreCompleto
END

CREATE PROCEDURE BUSCAR_CLIENTE
@Buscador varchar(50)
AS
BEGIN
	SELECT * FROM Clientes WHERE (NombreCompleto like '%' + @Buscador + '%') AND Activo=1
END

CREATE PROCEDURE BUSCAR_CLIENTE_ID
@Id_Cliente int
AS
BEGIN
	SELECT * FROM Clientes WHERE Id_Cliente = @Id_Cliente AND Activo=1
END

CREATE PROCEDURE BUSCAR_CLIENTE_CEDULA
@Cedula int
AS
BEGIN
	SELECT Id_Cliente FROM Clientes WHERE Cedula = @Cedula AND Activo=1
END

CREATE PROCEDURE ACTUALIZAR_CLIENTE
@Id_Cliente int,
@Cedula varchar(50),
@NombreCompleto varchar(50),
@Direccion varchar(50),
@Telefono varchar(50),
@Correo varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT * FROM Clientes WHERE Cedula=@Cedula AND Id_Cliente<>@Id_Cliente)
			RAISERROR('ERROR, HAY OTRO REGISTRO QUE COINCIDE CON EL DOCUMENTO',16,1)
		ELSE
			UPDATE Clientes SET
			Cedula = @Cedula,
			NombreCompleto = @NombreCompleto,
			Direccion = @Direccion,
			Telefono = @Telefono,
			Correo = @Correo
			WHERE Id_Cliente = @Id_Cliente
			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH	
END

CREATE PROCEDURE ELIMINAR_CLIENTE
@Id_Cliente int
AS
BEGIN
	BEGIN TRY
		UPDATE Clientes SET
		Activo = 0
		WHERE Id_Cliente = @Id_Cliente
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END

---------------------------------------------------------
-- PROCEDIMIENTO TABLA TIPOS
---------------------------------------------------------

CREATE PROCEDURE INSERTAR_TIPO
@Descripcion varchar(50)
AS
DECLARE @Activo bit
SET @Activo = 1
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT Descripcion FROM Tipos WHERE Descripcion = @Descripcion)
			RAISERROR('YA EXISTE UN REGISTRO CON ESA DESCRIPCION, INSERTE UNA NUEVA',16,1)
		ELSE
			INSERT INTO Tipos VALUES(
								@Descripcion,
								@Activo)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH
END
--EXEC INSERTAR_CATEGORIA

CREATE PROCEDURE MOSTRAR_TIPOS
AS
BEGIN
	SELECT * FROM Tipos WHERE Activo = 1
	ORDER BY Descripcion
END
--EXEC MOSTRAR_CARGOS

CREATE PROCEDURE BUSCAR_TIPOS
@Buscador varchar(50)
AS
BEGIN
	SELECT * FROM Tipos WHERE (Descripcion like '%' + @Buscador + '%') AND Activo=1
END
--EXEC BUSCAR_CARGOS

CREATE PROCEDURE ACTUALIZAR_TIPOS
@Id_Tipo int,
@Descripcion varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT * FROM Tipos WHERE Descripcion=@Descripcion AND Id_Tipo<>@Id_Tipo)
			RAISERROR('ERROR, HAY OTRO REGISTRO QUE COINCIDE CON EL CODIGO',16,1)
		ELSE
			UPDATE Tipos SET
			Descripcion = @Descripcion
			WHERE Id_Tipo = @Id_Tipo
			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH
		
END


CREATE PROCEDURE ELIMINAR_TIPO
@Id_Tipo int
AS
BEGIN
	BEGIN TRY
		UPDATE Tipos SET
		Activo = 0
		WHERE Id_Tipo = @Id_Tipo
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END

---------------------------------------------------------
-- PROCEDIMIENTO TABLA MASCOTAS
---------------------------------------------------------
exec INSERTAR_MASCOTA 'a','ade',2,null,1,'dw','wd'
ALTER PROCEDURE INSERTAR_MASCOTA
@Nombre varchar(50),
@Edad varchar(50),
@Id_Cliente int,
@Foto image,
@Id_Tipo int,
@Raza varchar(50),
@Sexo varchar(50)
AS
DECLARE @Activo bit
SET @Activo = 1
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		--IF EXISTS (SELECT Cedula FROM Clientes WHERE Cedula = @Cedula)
			--RAISERROR('YA EXISTE UN REGISTRO CON ESE DOCUMENTO, INSERTE UNO NUEVO',16,1)
		--ELSE
			INSERT INTO Mascotas VALUES(
								@Nombre,
								@Edad,
								@Id_Cliente,
								@Foto,
								@Id_Tipo,
								@Activo,
								@Raza,
								@Sexo)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH
END

CREATE PROCEDURE MOSTRAR_MASCOTAS_CLIENTE
@Id_Cliente int
AS
BEGIN
	SELECT Id_Mascota, Nombre FROM Mascotas WHERE Activo = 1 and Id_Cliente = @Id_Cliente
	ORDER BY Nombre
END

ALTER PROCEDURE MOSTRAR_MASCOTAS
AS
BEGIN
	SELECT M.Id_Mascota, M.Nombre, M.Edad, C.Cedula as 'Cedula Dueño', M.Foto, T.Descripcion as 'Tipo', M.Raza, M.Sexo
	FROM Mascotas M 
	INNER JOIN Clientes C ON M.Id_Cliente=C.Id_Cliente
	INNER JOIN Tipos T ON T.Id_Tipo=M.Id_Tipo
	WHERE M.Activo = 1
	ORDER BY NombreCompleto
END

CREATE PROCEDURE BUSCAR_MASCOTA
@Buscador varchar(50)
AS
BEGIN
	SELECT * FROM Mascotas WHERE (Nombre like '%' + @Buscador + '%') AND Activo=1
END

ALTER PROCEDURE BUSCAR_MASCOTA_ID
@Id_Mascota int
AS
BEGIN
	SELECT M.Nombre,M.Edad,M.Foto,M.Id_Tipo,C.Cedula, M.Raza, M.Sexo, T.Descripcion
	FROM Mascotas M 
	INNER JOIN Clientes C ON C.Id_Cliente=M.Id_Cliente
	INNER JOIN Tipos T ON T.Id_Tipo = M.Id_Tipo
	WHERE Id_Mascota = @Id_Mascota AND M.Activo=1
END

ALTER PROCEDURE ACTUALIZAR_MASCOTA
@Id_Mascota int,
@Nombre varchar(50),
@Edad varchar(50),
@Id_Cliente int,
@Id_Tipo int
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		--IF EXISTS (SELECT * FROM Clientes WHERE Cedula=@Cedula AND Id_Cliente<>@Id_Cliente)
			--RAISERROR('ERROR, HAY OTRO REGISTRO QUE COINCIDE CON EL DOCUMENTO',16,1)
		--ELSE
			UPDATE Mascotas SET
			Nombre = @Nombre,
			Edad = @Edad,
			Id_Cliente = @Id_Cliente,
			Id_Tipo = @Id_Tipo
			WHERE Id_Mascota = @Id_Mascota
			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH	
END

CREATE PROCEDURE ACTUALIZAR_MASCOTA_FOTO
@Id_Mascota int,
@Foto image
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		--IF EXISTS (SELECT * FROM Empleados WHERE Cedula=@Cedula AND Id_Empleado<>@Id_Empleado)
			--RAISERROR('ERROR, HAY OTRO REGISTRO QUE COINCIDE CON EL DOCUMENTO',16,1)
		--ELSE
			UPDATE Mascotas SET
			Foto = @Foto
			WHERE Id_Mascota = @Id_Mascota
			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH	
END

CREATE PROCEDURE ELIMINAR_MASCOTA
@Id_Mascota int
AS
BEGIN
	BEGIN TRY
		UPDATE Mascotas SET
		Activo = 0
		WHERE Id_Mascota = @Id_Mascota
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END

---------------------------------------------------------
-- PROCEDIMIENTO TABLA USUARIOS
---------------------------------------------------------
ALTER PROCEDURE INSERTAR_USUARIO
@Username varchar(50),
@Password varchar(50),
@Cedula varchar(50),
@Empleados bit,
@Clientes bit,
@Mascotas bit,
@Citas bit,
@Productos bit,
@Ventas bit,
@Usuarios bit
AS
DECLARE @Id_Usuario int
DECLARE @Activo bit
DECLARE @Id_Empleado int
SET @Activo = 1
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT * FROM Usuarios WHERE Username = @Username)
			RAISERROR('NOMBRE DE USUARIO YA EXISTENTE, INSERTE UNO NUEVO',16,1)
		ELSE
			SELECT @Id_Empleado = Id_Empleado FROM Empleados WHERE Cedula = @Cedula
			INSERT INTO Usuarios VALUES(
								@Username,
								@Password,
								@Id_Empleado,
								@Activo)
			SET @Id_Usuario = @@IDENTITY
			INSERT INTO Permisos VALUES(
								@Id_Usuario,
								@Empleados,
								@Clientes,
								@Mascotas,
								@Citas,
								@Productos,
								@Ventas,
								@Usuarios)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH
END

ALTER PROCEDURE MOSTRAR_USUARIOS
@Username varchar(50)
AS
BEGIN
	SELECT P.* FROM Usuarios U
	INNER JOIN Permisos P
	ON P.Id_Usuario = U.Id_Usuario
	WHERE U.Username = @Username
END
exec MOSTRAR_USUARIOS 'Admin'

CREATE PROCEDURE BUSCAR_USUARIO
@Buscador varchar(50)
AS
BEGIN
	SELECT * FROM Usuarios WHERE (Username like '%' + @Buscador + '%') AND Activo=1
END

CREATE PROCEDURE COMPROBAR_USUARIO
@Username varchar(50),
@Password varchar(50)
AS
BEGIN
	SELECT * FROM Usuarios WHERE (Username = @Username) and (Password = @Password)
END

CREATE PROCEDURE ACTUALIZAR_USUARIO
@Id_Usuario int,
@Username varchar(50),
@Password varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT * FROM Usuarios WHERE Username=@Username AND Id_Usuario<>@Id_Usuario)
			RAISERROR('ERROR, HAY OTRO REGISTRO QUE COINCIDE CON EL USUARIO',16,1)
		ELSE
			UPDATE Usuarios SET
			Username = @Username,
			Password = @Password
			WHERE Id_Usuario = @Id_Usuario
			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH	
END

CREATE PROCEDURE ELIMINAR_USUARIO
@Id_Usuario int
AS
BEGIN
	BEGIN TRY
		UPDATE Usuarios SET
		Activo = 0
		WHERE Id_Usuario = @Id_Usuario
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END

---------------------------------------------------------
-- PROCEDIMIENTO TABLA HISTORIAS CLINICAS
---------------------------------------------------------
ALTER PROCEDURE INSERTAR_HISTORIA
@Id_Mascota int,
@Motivo varchar(50),
@Observacion varchar(max),
@Descripcion varchar(max),
@Peso varchar(20),
@Edad varchar(10)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		--IF EXISTS (SELECT * FROM Usuarios WHERE Username = @Username)
			--RAISERROR('NOMBRE DE USUARIO YA EXISTENTE, INSERTE UNO NUEVO',16,1)
		--ELSE
			INSERT INTO HistoriasClinicas VALUES(
								@Id_Mascota,
								GETDATE(),
								@Motivo,
								@Observacion,
								@Descripcion,
								@Peso,
								@Edad)
								
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH
END

CREATE PROCEDURE MOSTRAR_HISTORIAS
AS
BEGIN
	SELECT * FROM HistoriasClinicas
	ORDER BY Id_Mascota
END

CREATE PROCEDURE BUSCAR_HISTORIA
@Buscador varchar(50)
AS
BEGIN
	SELECT * FROM HistoriasClinicas WHERE (Id_Historia like '%' + @Buscador + '%')
END


CREATE PROCEDURE ELIMINAR_HISTORIA
@Id_Historia int
AS
BEGIN
	BEGIN TRY
		DELETE FROM HistoriasClinicas 
		WHERE Id_Historia = @Id_Historia
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END

---------------------------------------------------------
-- PROCEDIMIENTO TABLA CITAS
---------------------------------------------------------

ALTER PROCEDURE INSERTAR_CITA
@Fecha datetime,
@Hora varchar(10),
@Id_Cliente int,
@Id_Empleado int
AS
DECLARE @Estado varchar(10)
SET @Estado = 'DISPONIBLE'
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT * FROM Citas WHERE Fecha = @Fecha and Hora = @Hora and Id_Empleado = @Id_Empleado)
			RAISERROR('CITA YA EXISTENTE, INSERTE UNA NUEVA',16,1)
		ELSE
			INSERT INTO Citas VALUES(
								@Fecha,
								@Hora,
								@Id_Cliente,
								@Id_Empleado,
								@Estado)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH
END

ALTER PROCEDURE MOSTRAR_CITAS
@Id_Empleado int,
@fecha datetime
AS
BEGIN
	SELECT * FROM Citas WHERE Estado = 'DISPONIBLE' and Id_Empleado = @Id_Empleado and Fecha = @fecha
	ORDER BY Id_Cita
END

ALTER PROCEDURE MOSTRAR_CITAS_AGENDADAS
@Id_Empleado int,
@fecha datetime
AS
BEGIN
	SELECT Citas.*, Clientes.NombreCompleto as 'Cliente' 
	FROM Citas INNER JOIN Clientes
	ON Citas.Id_Cliente = Clientes.Id_Cliente
	WHERE Citas.Estado = 'AGENDADO' and Citas.Id_Empleado = @Id_Empleado and Citas.Fecha = @fecha
	ORDER BY Id_Cita
END

ALTER PROCEDURE AGENDAR_CITA
@Id_Cita int,
@Documento varchar(50)
AS
BEGIN
	BEGIN TRY
		UPDATE Citas 
		SET Citas.Estado = 'AGENDADO', 
		Citas.Id_Cliente = (SELECT Clientes.Id_Cliente FROM Clientes WHERE Cedula = @Documento)
		WHERE Citas.Id_Cita = @Id_Cita
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END

CREATE PROCEDURE CANCELAR_CITA
@Id_Cita int
AS
BEGIN
	BEGIN TRY
		UPDATE Citas 
		SET Estado = 'DISPONIBLE'
		WHERE Id_Cita = @Id_Cita
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END

ALTER PROCEDURE BUSCAR_CITA
@Buscador varchar(50)
AS
BEGIN
	SELECT Citas.*, Clientes.NombreCompleto as 'Cliente' FROM Citas INNER JOIN Clientes
	ON Clientes.Id_Cliente = Citas.Id_Cliente
	WHERE (Clientes.Cedula like '%' + @Buscador + '%') AND Citas.Estado = 'AGENDADO'
END

/*
CREATE PROCEDURE BUSCAR_USUARIO
@Buscador varchar(50)
AS
BEGIN
	SELECT * FROM Usuarios WHERE (Username like '%' + @Buscador + '%') AND Activo=1
END

CREATE PROCEDURE ACTUALIZAR_USUARIO
@Id_Usuario int,
@Username varchar(50),
@Password varchar(50)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT * FROM Usuarios WHERE Username=@Username AND Id_Usuario<>@Id_Usuario)
			RAISERROR('ERROR, HAY OTRO REGISTRO QUE COINCIDE CON EL USUARIO',16,1)
		ELSE
			UPDATE Usuarios SET
			Username = @Username,
			Password = @Password
			WHERE Id_Usuario = @Id_Usuario
			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH	
END

CREATE PROCEDURE ELIMINAR_USUARIO
@Id_Usuario int
AS
BEGIN
	BEGIN TRY
		UPDATE Usuarios SET
		Activo = 0
		WHERE Id_Usuario = @Id_Usuario
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END
*/
 delete from Citas

 ---------------------------------------------------------
-- PROCEDIMIENTO TABLA PRESCRIPCION
---------------------------------------------------------
ALTER PROCEDURE INSERTAR_PRESCRIPCION
@Id_Cliente int,
@ListaDetalle DETALLE_PRESCRIPCION READONLY
AS
BEGIN
	DECLARE @Id_Prescripcion int
	INSERT INTO Prescripcion VALUES(
									@Id_Cliente,
									GETDATE())
	SET @Id_Prescripcion = @@IDENTITY

	INSERT INTO PrescripcionDetalle (Id_Prescripcion, Nombre, Cantidad, Presentacion, Indicaciones)
	SELECT @Id_Prescripcion, Nombre, Cantidad, Presentacion, Indicaciones FROM @ListaDetalle

	SELECT @Id_Prescripcion
END

CREATE TYPE DETALLE_PRESCRIPCION AS TABLE(
	Id_PrescripcionD int,
	Nombre varchar(50),
	Cantidad varchar(50),
	Presentacion varchar(50),
	Indicaciones varchar(50)
	PRIMARY KEY(Id_PrescripcionD)
)

CREATE PROCEDURE MOSTRAR_PRESCRIPCION
@Id_Prescripcion int
AS
BEGIN
	SELECT PD.*
	FROM Prescripcion P INNER JOIN PrescripcionDetalle PD
	ON P.Id_Prescripcion = PD.Id_Prescripcion
	WHERE PD.Id_Prescripcion = @Id_Prescripcion AND P.Id_Prescripcion = @Id_Prescripcion
END

CREATE PROCEDURE MOSTRAR_PRESCRIPCION_ENCABEZADO
@Id_Prescripcion int
AS
BEGIN
	SELECT * FROM Prescripcion
	WHERE Id_Prescripcion = @Id_Prescripcion
END

 ---------------------------------------------------------
-- PROCEDIMIENTO TABLA PRODUCTOS
---------------------------------------------------------

CREATE PROCEDURE INSERTAR_PRODUCTO
@Codigo bigint,
@Nombre varchar(50),
@Presentacion varchar(50),
@Precio decimal(18,2)
AS
DECLARE @Activo bit
SET @Activo = 1
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT Codigo FROM Productos WHERE Codigo = @Codigo)
			RAISERROR('YA EXISTE UN REGISTRO CON ESE CODIGO, INSERTE UNO NUEVO',16,1)
		ELSE
			INSERT INTO Productos VALUES(
								@Codigo,
								@Nombre,
								@Presentacion,
								@Precio,
								@Activo)
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH
END

CREATE PROCEDURE MOSTRAR_PRODUCTOS
AS
BEGIN
	SELECT * FROM Productos WHERE Activo = 1
	ORDER BY Codigo
END

CREATE PROCEDURE BUSCAR_PRODUCTO
@Buscador varchar(50)
AS
BEGIN
	SELECT * FROM Productos WHERE (Nombre like '%' + @Buscador + '%') AND Activo=1
END

CREATE PROCEDURE BUSCAR_PRODUCTO_ID
@Id_Producto int
AS
BEGIN
	SELECT * FROM Productos WHERE Id_Producto = @Id_Producto AND Activo=1
END

--CREATE PROCEDURE BUSCAR_CLIENTE_CEDULA
--@Cedula int
--AS
--BEGIN
--	SELECT Id_Cliente FROM Clientes WHERE Cedula = @Cedula AND Activo=1
--END

CREATE PROCEDURE ACTUALIZAR_PRODUCTO
@Id_Producto int,
@Codigo bigint,
@Nombre varchar(50),
@Presentacion varchar(50),
@Precio decimal(18,2)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
		IF EXISTS (SELECT * FROM Productos WHERE Codigo=@Codigo AND Id_Producto<>@Id_Producto)
			RAISERROR('ERROR, HAY OTRO REGISTRO QUE COINCIDE CON EL CODIGO',16,1)
		ELSE
			UPDATE Productos SET
			Codigo = @Codigo,
			Nombre = @Nombre,
			Presentacion = @Presentacion,
			Precio = @Precio
			WHERE Id_Producto = @Id_Producto
			COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE() AS ErrorMessage
		RETURN
	END CATCH	
END

CREATE PROCEDURE ELIMINAR_PRODUCTO
@Id_Producto int
AS
BEGIN
	BEGIN TRY
		UPDATE Productos SET
		Activo = 0
		WHERE Id_Producto = @Id_Producto
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END

 ---------------------------------------------------------
-- PROCEDIMIENTO TABLA FACTURAR
---------------------------------------------------------

ALTER PROCEDURE INSERTAR_FACTURA
@Documento varchar(50),
@Total_Compra decimal(18,2),
@ListaDetalle DETALLE_FACTURA2 READONLY
AS
BEGIN
	
	DECLARE @Id_Factura int
	INSERT INTO Factura VALUES(
									@Documento,
									GETDATE(),
									@Total_Compra)
	SET @Id_Factura = @@IDENTITY

	INSERT INTO FacturaDetalle (Id_Factura, Id_Producto,Codigo, Nombre, Presentacion, Precio_Unitario, Cantidad, Total)
	SELECT @Id_Factura, Id_Producto,Codigo, Nombre, Presentacion, Precio_Unitario, Cantidad, Total FROM @ListaDetalle

	SELECT @Id_Factura
END

CREATE TYPE DETALLE_FACTURA2 AS TABLE(
	Id_Detalle int,
	Id_Producto int,
	Codigo int,
	Nombre varchar(50),
	Presentacion varchar(50),
	Precio_Unitario decimal(18,2),
	Cantidad int,
	Total decimal(18,2)
	PRIMARY KEY(Id_Detalle)
)

ALTER PROCEDURE MOSTRAR_FACTURA
@Id_Factura int
AS
BEGIN
	SELECT FD.*
	FROM Factura F INNER JOIN FacturaDetalle FD
	ON F.Id_Factura = FD.Id_Factura
	WHERE FD.Id_Factura = @Id_Factura AND F.Id_Factura = @Id_Factura
END

CREATE PROCEDURE MOSTRAR_FACTURA_ENCABEZADO
@Id_Factura int
AS
BEGIN
	SELECT * FROM Factura
	WHERE Id_Factura = @Id_Factura
END

EXEC MOSTRAR_FACTURA_ENCABEZADO 7

SELECT E.Id_Empleado, E.NombreCompleto from Empleados E
INNER JOIN Usuarios U ON E.Id_Empleado = U.Id_Empleado
WHERE U.Username = @User
