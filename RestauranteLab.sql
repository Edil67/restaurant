
CREATE DATABASE LabRestaurante;
GO

USE master;
GO

CREATE LOGIN usrrestaurante WITH PASSWORD = N'123456',
    DEFAULT_DATABASE = LabRestaurante,
    CHECK_EXPIRATION = OFF,
    CHECK_POLICY = ON;
GO

USE LabRestaurante;
GO

CREATE USER usrrestaurante FOR LOGIN usrrestaurante;
GO
ALTER ROLE db_owner ADD MEMBER usrrestaurante;
GO


-- ELIMINAR TABLAS EXISTENTES (si las hay)

DROP TABLE IF EXISTS PedidoDetalle;
DROP TABLE IF EXISTS Pedidos;
DROP TABLE IF EXISTS Usuarios;
DROP TABLE IF EXISTS Empleado;
DROP TABLE IF EXISTS Cliente;
DROP TABLE IF EXISTS Menu;
DROP TABLE IF EXISTS TipoMenu;
GO


-- TABLA: TipoMenu

CREATE TABLE TipoMenu (
    id INT PRIMARY KEY IDENTITY(1,1),
    descripcion VARCHAR(30) NOT NULL UNIQUE,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1 -- -1: Eliminado, 0: Inactivo, 1: Activo
);
GO


-- TABLA: Menu

CREATE TABLE Menu (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL,
    descripcion VARCHAR(100),
    idTipoMenu INT NOT NULL,
    precio DECIMAL(10,2) NOT NULL CHECK (precio > 0),
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT fk_Menu_TipoMenu FOREIGN KEY (idTipoMenu) REFERENCES TipoMenu(id)
);
GO


-- TABLA: Cliente

CREATE TABLE Cliente (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL,
    primerApellido VARCHAR(30) NOT NULL,
    segundoApellido VARCHAR(30) NOT NULL,
    cedulaIdentidad VARCHAR(15) NOT NULL UNIQUE,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1
);
GO


-- TABLA: Empleado

CREATE TABLE Empleado (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(30) NOT NULL,
    primerApellido VARCHAR(30) NOT NULL,
    segundoApellido VARCHAR(30) NOT NULL,
    telefono VARCHAR(8) NOT NULL,
    direccion VARCHAR(50) NOT NULL,
    cargo VARCHAR(30) NOT NULL,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1
);
GO


-- TABLA: Usuarios

CREATE TABLE Usuarios (
    id INT PRIMARY KEY IDENTITY(1,1),
    usuario VARCHAR(30) NOT NULL,
    clave VARCHAR(100) NOT NULL,
    idEmpleado INT NOT NULL,
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT fk_Usuarios_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
);
GO


-- TABLA: Pedidos

CREATE TABLE Pedidos (
    id INT PRIMARY KEY IDENTITY(1,1),
    idCliente INT NOT NULL,
    idEmpleado INT NOT NULL,
    fechaPedido DATETIME NOT NULL DEFAULT GETDATE(),
    total DECIMAL(10,2) DEFAULT 0 CHECK (total >= 0),
    usuarioRegistro VARCHAR(50) NOT NULL DEFAULT SUSER_NAME(),
    fechaRegistro DATETIME NOT NULL DEFAULT GETDATE(),
    estado SMALLINT NOT NULL DEFAULT 1,
    CONSTRAINT fk_Pedido_Cliente FOREIGN KEY(idCliente) REFERENCES Cliente(id),
    CONSTRAINT fk_Pedido_Empleado FOREIGN KEY(idEmpleado) REFERENCES Empleado(id)
);
GO


-- TABLA: PedidoDetalle

CREATE TABLE PedidoDetalle (
    id INT PRIMARY KEY IDENTITY(1,1),
    idPedido INT NOT NULL,
    idMenu INT NOT NULL,
    cantidad INT NOT NULL CHECK (cantidad > 0),
    subtotal DECIMAL(10,2) NULL,
    CONSTRAINT fk_PedidoDetalle_Pedido FOREIGN KEY(idPedido) REFERENCES Pedidos(id),
    CONSTRAINT fk_PedidoDetalle_Menu FOREIGN KEY(idMenu) REFERENCES Menu(id)
);
GO


-- TRIGGER: Calcular Subtotal

CREATE TRIGGER trg_CalcularSubtotal
ON PedidoDetalle
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE pd
    SET pd.subtotal = pd.cantidad * m.precio
    FROM PedidoDetalle pd
    INNER JOIN Menu m ON pd.idMenu = m.id
    WHERE pd.id IN (SELECT id FROM inserted);
END;
GO


-- DATOS DE PRUEBA

INSERT INTO TipoMenu(descripcion) VALUES
('Entrada'),
('Plato Fuerte'),
('Sopa'),
('Postre'),
('Bebida');

INSERT INTO Empleado (nombre, primerApellido, segundoApellido, telefono, direccion, cargo)
VALUES 
('Paola', 'Duran', 'Rojas', '78963254', 'Avaroa 47', 'Gerente'),
('Micaela', 'Mamani', 'Perez', '78925478', 'Mendizabal 7', 'Cajera');

INSERT INTO Cliente (nombre, primerApellido, segundoApellido, cedulaIdentidad)
VALUES 
('Luis', 'Perez', 'Mendoza', '14181556'),
('Pablo', 'Padilla', 'Arandia', '14181236'),
('Mariana', 'Velazco', 'Gutierrez', '7895411');

INSERT INTO Menu (nombre, descripcion, idTipoMenu, precio)
VALUES 
('Lasaña', 'Pasta al horno con carne y queso', 2, 45.00),
('Sopa de Maní', 'Sopa tradicional boliviana con maní y papas fritas', 3, 25.00),
('Flan', 'Postre con caramelo', 4, 15.00);

INSERT INTO Pedidos (idCliente, idEmpleado, total)
VALUES 
(1, 1, 0),
(2, 2, 0);

INSERT INTO PedidoDetalle (idPedido, idMenu, cantidad)
VALUES 
(1, 1, 2),
(1, 3, 1),
(2, 2, 3);
GO


-- PROCEDIMIENTOS ALMACENADOS


DROP PROC IF EXISTS paClienteListar;
DROP PROC IF EXISTS paEmpleadoListar;
DROP PROC IF EXISTS paMenuListar;
DROP PROC IF EXISTS paUsuariosListar;
DROP PROC IF EXISTS paPedidosListar;
DROP PROC IF EXISTS paPedidoDetalleListar;
GO

CREATE PROC paClienteListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT id, nombre, primerApellido, segundoApellido, cedulaIdentidad, usuarioRegistro, fechaRegistro, estado
    FROM Cliente
    WHERE estado <> -1 AND nombre LIKE '%' + REPLACE(@parametro,' ','%') + '%';
END;
GO

CREATE PROC paEmpleadoListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT id, nombre, primerApellido, segundoApellido, telefono, direccion, cargo, usuarioRegistro, fechaRegistro, estado
    FROM Empleado
    WHERE estado <> -1 AND nombre LIKE '%' + REPLACE(@parametro,' ','%') + '%';
END;
GO

GO
DROP PROC IF EXISTS paMenuListar;
GO
CREATE PROC paMenuListar @parametro VARCHAR(50)
AS
SELECT 
    m.id, 
    m.idTipoMenu,
    m.nombre, 
    m.descripcion,
    t.descripcion AS tipoMenu,  
    m.precio, 
    m.usuarioRegistro, 
    m.fechaRegistro, 
    m.estado
FROM Menu m
INNER JOIN TipoMenu t ON t.id = m.idTipoMenu
WHERE m.estado > -1 
  AND (m.nombre + t.descripcion) LIKE '%' + REPLACE(@parametro, ' ', '%') + '%'
ORDER BY m.estado DESC, m.nombre ASC;
GO


CREATE PROC paUsuariosListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT us.id, em.nombre AS empleado, us.usuario, us.clave, us.usuarioRegistro, us.fechaRegistro, us.estado
    FROM Usuarios us
    INNER JOIN Empleado em ON us.idEmpleado = em.id
    WHERE us.estado <> -1 AND us.usuario LIKE '%' + REPLACE(@parametro,' ','%') + '%';
END;
GO

CREATE PROC paPedidosListar @parametro VARCHAR(50)
AS
BEGIN
    SELECT p.id, c.nombre AS cliente, e.nombre AS empleado, p.fechaPedido, p.total, p.estado
    FROM Pedidos p
    INNER JOIN Cliente c ON p.idCliente = c.id
    INNER JOIN Empleado e ON p.idEmpleado = e.id
    WHERE p.estado <> -1 AND c.nombre LIKE '%' + REPLACE(@parametro,' ','%') + '%';
END;
GO

CREATE PROC paPedidoDetalleListar @idPedido INT
AS
BEGIN
    SELECT 
        d.id, 
        d.idPedido, 
        m.nombre AS menu, 
        t.descripcion AS tipo, 
        d.cantidad, 
        d.subtotal
    FROM PedidoDetalle d
    INNER JOIN Menu m ON d.idMenu = m.id
    INNER JOIN TipoMenu t ON m.idTipoMenu = t.id
    WHERE d.idPedido = @idPedido;
END;
GO


-- ACTUALIZAR TOTALES DE PEDIDOS

UPDATE p
SET total = (SELECT SUM(subtotal) FROM PedidoDetalle WHERE idPedido = p.id)
FROM Pedidos p;
GO


-- CONSULTAS DE PRUEBA

SELECT * FROM TipoMenu;
SELECT * FROM Cliente;
SELECT * FROM Empleado;
SELECT * FROM Menu;
SELECT * FROM Pedidos;
SELECT * FROM PedidoDetalle;
GO
