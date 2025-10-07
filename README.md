Descripcion del negocio # Sis457_Restaurante
Bienvenido/a al Restaurante Gambito, un Retaurante especializada en la venta de platos tipicos. Este sistema esta diseñado para gestionar las operaciones comerciales de la tienda.

Modelo de Base de Datos
El sistema esta compuesto por las siguientes tablas principales:
Modelo de Base de Datos
Entidades Iniciales

1. Menu
id
nombre
precioVenta
stock
usuarioRegistro
fechaRegistro

2. Cliente
id
cedulaIdentidad
nombres
apellidos
direccion
celular
correoElectronico
usuarioRegistro
fechaRegistro

3. Empleado
id
nombres
primerApellido
segundoApellido
direccion
celular
cargo
usuarioRegistro
fechaRegistro

4. Usuario
id
idEmpleado
usuario
clave
usuarioRegistro
fechaRegistro


5. Pedido
id
idCliente
idUsuario
documentoCliente
montoPago
montoCambio
montoTotal
usuarioRegistro
fechaRegistro

6. PedidoDetalle
id
idPedido
idMenu
cantidad
precioUnitario
subtotal
usuarioRegistro
fechaRegistro
