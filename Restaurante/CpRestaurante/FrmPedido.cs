using CadRestaurante;
using ClnRestaurante;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CpRestaurante
{
    public partial class FrmPedido : Form
    {
        private const int STOCK_MINIMO = 5;

        public FrmPedido()
        {
            InitializeComponent();
            ConfigurarFormularioInicial();
        }

        // Métodos de inicialización y configuración
        private void ConfigurarFormularioInicial()
        {
            nudCantidadProductoVenta.ValueChanged += nudCantidadProductoVenta_ValueChanged;
            ConfigurarGrilla();
            ConfigurarValoresIniciales();
        }

        private void ConfigurarValoresIniciales()
        {
            dtpFechaVenta.Value = DateTime.Now;
            txtMontoTotalVentaDetalle.Text = "0.00";
            nudCantidadProductoVenta.Value = 1;
        }

        private void ConfigurarGrilla()
        {
            dgvListaVentas.AutoGenerateColumns = false;
            dgvListaVentas.Columns.Clear();
            AgregarColumnasGrilla();
        }

        private void AgregarColumnasGrilla()
        {
            dgvListaVentas.Columns.Add("Cedula", "Cédula");
            dgvListaVentas.Columns.Add("Cliente", "Cliente");
            dgvListaVentas.Columns.Add("Nombre", "Menú");
            dgvListaVentas.Columns.Add("Precio", "Precio");
            dgvListaVentas.Columns.Add("Cantidad", "Cantidad");
            dgvListaVentas.Columns.Add("UsuarioRegistro", "Usuario");
            dgvListaVentas.Columns.Add("FechaRegistro", "Fecha");
            dgvListaVentas.Columns.Add("MontoTotal", "Subtotal");

            ConfigurarFormatoColumnas();
        }

        private void ConfigurarFormatoColumnas()
        {
            dgvListaVentas.Columns["Cedula"].Visible = false;
            dgvListaVentas.Columns["Cliente"].Visible = false;
            dgvListaVentas.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dgvListaVentas.Columns["MontoTotal"].DefaultCellStyle.Format = "N2";
            dgvListaVentas.Columns["Cantidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Métodos de manipulación de datos
        private void limpiar()
        {
            txtNombreProductoVenta.Clear();
            txtStockProductoVenta.Clear();
            txtPrecioProductoVenta.Clear();
            nudCantidadProductoVenta.Value = 1;
        }

        private void ActualizarMontoTotal()
        {
            decimal totalVenta = dgvListaVentas.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Sum(r => decimal.TryParse(r.Cells["MontoTotal"].Value?.ToString(), out decimal mt) ? mt : 0m);

            txtMontoTotalVentaDetalle.Text = totalVenta.ToString("N2");
        }

        // Métodos de validación
        private bool validar(bool RegistroPedido = false)
        {
            LimpiarErrores();
            bool esValido = true;

            if (RegistroPedido)
            {
                esValido &= ValidarCamposCliente();
            }

            esValido &= ValidarCamposProducto();
            return esValido;
        }

        private void LimpiarErrores()
        {
            erpNombreCliente.Clear();
            erpCedulaIdentidad.Clear();
            erpNombre.Clear();
            erpCantidad.Clear();
            erpPrecioVenta.Clear();
            erpMontoTotal.Clear();
        }

        private bool ValidarCamposCliente()
        {
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(txtCedulaIdentidadVenta.Text))
            {
                esValido = false;
                erpCedulaIdentidad.SetError(txtCedulaIdentidadVenta, "Este campo no debe estar vacío.");
            }
            if (string.IsNullOrWhiteSpace(txtNombreClienteVenta.Text))
            {
                esValido = false;
                erpNombreCliente.SetError(txtNombreClienteVenta, "Este campo no debe estar vacío.");
            }

            return esValido;
        }

        private bool ValidarCamposProducto()
        {
            bool esValido = true;

            if (string.IsNullOrEmpty(txtNombreProductoVenta.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombreProductoVenta, "El campo Nombre es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtPrecioProductoVenta.Text) || !decimal.TryParse(txtPrecioProductoVenta.Text, out _))
            {
                esValido = false;
                erpPrecioVenta.SetError(txtPrecioProductoVenta, "El campo Precio de Venta es obligatorio y debe ser un número válido.");
            }
            if (nudCantidadProductoVenta.Value <= 0)
            {
                esValido = false;
                erpCantidad.SetError(nudCantidadProductoVenta, "La cantidad debe ser mayor a cero.");
            }

            return esValido;
        }

        // Métodos públicos para interacción con otros formularios
        public void SetListaCliente(string cedulaIdentidad, string nombre)
        {
            txtCedulaIdentidadVenta.Text = cedulaIdentidad;
            txtNombreClienteVenta.Text = nombre;
            ActualizarClienteEnGrilla(cedulaIdentidad, nombre);
        }

        public void SetListaProducto(string cedulIdentidad, string nombre, string descripcion, string stock, string precio)
        {
            txtNombreProductoVenta.Text = nombre;
            txtStockProductoVenta.Text = stock;
            txtPrecioProductoVenta.Text = precio;
            ConfigurarStockMaximo(stock);
        }

        // Métodos auxiliares
        private void ConfigurarStockMaximo(string stock)
        {
            nudCantidadProductoVenta.Maximum = int.TryParse(stock, out int stockDisponible) && stockDisponible > 0 
                ? stockDisponible 
                : 1;
        }

        private void ActualizarClienteEnGrilla(string cedulaIdentidad, string nombre)
        {
            foreach (DataGridViewRow row in dgvListaVentas.Rows)
            {
                if (row.IsNewRow) continue;
                row.Cells["Cedula"].Value = cedulaIdentidad;
                row.Cells["Cliente"].Value = nombre;
            }
        }

        // Añadir este evento para actualizar el subtotal al cambiar la cantidad
        private void nudCantidadProductoVenta_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrecioProductoVenta.Text) &&
                decimal.TryParse(txtPrecioProductoVenta.Text, out decimal precio))
            {
                decimal subtotal = precio * (decimal)nudCantidadProductoVenta.Value;
                // Puedes mostrar este subtotal en algún campo si lo deseas
            }
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmListaMenu productoFrm = new FrmListaMenu(this);
            productoFrm.ShowDialog();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {

            ConfigurarGrilla();
            dtpFechaVenta.Value = DateTime.Now;
            txtMontoTotalVentaDetalle.Text = "0.00";
            nudCantidadProductoVenta.Value = 1;
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!validar(false)) // Asegurarse de que no valide los campos del cliente
            {
                MessageBox.Show("Por favor, corrija los errores antes de agregar el producto.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreProductoVenta.Text))
            {
                MessageBox.Show("Por favor, selecciona un producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = txtNombreProductoVenta.Text;
            int cantidadVenta = (int)nudCantidadProductoVenta.Value;

            using (var context = new LabRestauranteEntities())
            {
                var producto = context.Menu
                    .FirstOrDefault(p => p.nombre.Trim() == codigo.Trim()&&p.estado==1);
                if (producto == null)
                {
                    MessageBox.Show("Menu no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ALERTA DE STOCK IGUAL A CERO
                if (producto.stock == 0)
                {
                    MessageBox.Show("El producto seleccionado no tiene stock disponible.", "Stock agotado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int stock = producto.stock;
                if (stock < 0)
                {
                    MessageBox.Show("El producto tiene stock negativo, verifique el inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Validar cantidad solicitada
                if (cantidadVenta > stock)
                {
                    MessageBox.Show("La cantidad solicitada excede el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar si el producto ya existe en el DataGridView
                foreach (DataGridViewRow row in dgvListaVentas.Rows)
                {
                    if (row.IsNewRow) continue;
                    var cellNombre = row.Cells["Nombre"].Value;
                    if (cellNombre != null && cellNombre.ToString() == codigo)
                    {
                        if (!int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out int cantidadActual))
                            cantidadActual = 0;

                        int nuevaCantidad = cantidadActual + cantidadVenta;

                        if (nuevaCantidad > stock)
                        {
                            MessageBox.Show("La cantidad total excede el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Actualizar la cantidad y el subtotal
                        row.Cells["Cantidad"].Value = nuevaCantidad;
                        row.Cells["MontoTotal"].Value = nuevaCantidad * producto.precio;

                        limpiar();
                        return;
                    }
                }

                // Si no existe en el DataGridView, agregarlo como un nuevo registro
                var nombre = producto.nombre;
                var precioVenta = producto.precio;

                int id = Util.usuario.id;
                if (id <= 0)
                {
                    MessageBox.Show("No se pudo identificar al empleado asociado al usuario actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var usuarioRegistro = Util.usuario.usuario;
                var fechaRegistro = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                var montoTotal = precioVenta * cantidadVenta;

                dgvListaVentas.Rows.Add(
                    txtCedulaIdentidadVenta.Text, // Usar el valor actual del cliente
                    txtNombreClienteVenta.Text,   // Usar el valor actual del cliente
                    nombre,
                    precioVenta,
                    cantidadVenta,
                    usuarioRegistro,
                    fechaRegistro,
                    montoTotal
                );
                ActualizarMontoTotal();
                limpiar();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvListaVentas.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListaVentas.SelectedRows)
                {
                    if (!row.IsNewRow)
                        dgvListaVentas.Rows.RemoveAt(row.Index);
                }
                ActualizarMontoTotal(); // Actualizar el total después de quitar productos
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto para quitar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegistrarVentaDetalle_Click(object sender, EventArgs e)
        {
            if (dgvListaVentas.Rows.Cast<DataGridViewRow>().All(r => r.IsNewRow))
            {
                MessageBox.Show("Por favor, agregue al menos un producto antes de continuar.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Si no hay cliente seleccionado, mostrar diálogo para buscar/agregar cliente
            if (string.IsNullOrEmpty(txtCedulaIdentidadVenta.Text) ||
                string.IsNullOrEmpty(txtNombreClienteVenta.Text))
            {
                var result = MessageBox.Show("Debe seleccionar un cliente para continuar. ¿Desea buscar un cliente ahora?",
                    "Cliente Requerido", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    // Mostrar formulario de búsqueda de cliente
                    var frmListaCliente = new FrmListaCliente(this);
                    frmListaCliente.ShowDialog();

                    // Si después de cerrar el formulario aún no hay cliente, salir
                    if (string.IsNullOrEmpty(txtCedulaIdentidadVenta.Text) ||
                        string.IsNullOrEmpty(txtNombreClienteVenta.Text))
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }

            // Verificar usuario/empleado
            int idEmpleado = Util.usuario.id;
            if (idEmpleado <= 0)
            {
                MessageBox.Show("No se pudo identificar al empleado asociado al usuario actual.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Actualizar la información del cliente en el DataGridView
            foreach (DataGridViewRow row in dgvListaVentas.Rows)
            {
                if (row.IsNewRow) continue;
                row.Cells["Cedula"].Value = txtCedulaIdentidadVenta.Text;
                row.Cells["Cliente"].Value = txtNombreClienteVenta.Text;
            }

            // Continuar con el proceso de registro...
            using (var context = new LabRestauranteEntities())
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    // Buscar el cliente por cédula de identidad
                    var cliente = context.Cliente.FirstOrDefault(c => c.cedulaIdentidad == txtCedulaIdentidadVenta.Text.Trim());
                    if (cliente == null)
                    {
                        MessageBox.Show("El cliente no existe. Debe registrar el cliente antes de realizar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Calcular total desde la grilla
                    decimal totalVenta = 0m;
                    foreach (DataGridViewRow row in dgvListaVentas.Rows)
                    {
                        if (row.IsNewRow) continue;
                        if (row.Cells["MontoTotal"].Value != null && decimal.TryParse(row.Cells["MontoTotal"].Value.ToString(), out decimal mt))
                            totalVenta += mt;
                    }

                    var venta = new Pedidos
                    {
                        idCliente = cliente.id,
                        idEmpleado = idEmpleado,
                        usuarioRegistro = Util.usuario.usuario,
                        fechaRegistro = DateTime.Now,
                        fechaPedido = dtpFechaVenta.Value,
                        total = totalVenta,
                        estado = 1
                    };

                    context.Pedidos.Add(venta);
                    context.SaveChanges(); // Se guarda la venta y se genera el IdVenta

                    int idVenta = venta.id;

                    // Procesar detalles
                    foreach (DataGridViewRow row in dgvListaVentas.Rows)
                    {
                        if (row.IsNewRow) continue;

                        var nombreCell = row.Cells["Nombre"].Value;
                        var cantidadCell = row.Cells["Cantidad"].Value;

                        if (nombreCell == null || cantidadCell == null) continue;

                        string nombre = nombreCell.ToString();
                        if (!int.TryParse(cantidadCell.ToString(), out int cantidad)) continue;

                        // Importante: Buscar el producto con tracking
                        var producto = context.Menu.FirstOrDefault(p => p.nombre == nombre);
                        if (producto == null)
                        {
                            throw new Exception($"Producto {nombre} no encontrado.");
                        }

                        // Validar stock antes de actualizar
                        int nuevoStock = producto.stock - cantidad;
                        if (nuevoStock < 0)
                        {
                            throw new Exception($"Stock insuficiente para {nombre}. Stock actual: {producto.stock}");
                        }

                        producto.stock = nuevoStock;

                        // Cambiado el aviso de stock bajo a cuando queden 5 o menos unidades
                        if (nuevoStock <= STOCK_MINIMO)
                        {
                            MessageBox.Show($"El stock del producto {producto.nombre} está bajo (restan {nuevoStock} unidades).",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        // Crear el detalle de venta
                        var detalle = new PedidoDetalle
                        {
                            idPedido = idVenta,
                            idMenu = producto.id,
                            cantidad = cantidad
                            // subtotal lo calcula el trigger en la BD
                        };

                        context.PedidoDetalle.Add(detalle);
                    }

                    // Guardar los detalles y los cambios de stock
                    context.SaveChanges();
                    transaction.Commit();

                    MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvListaVentas.Rows.Clear();
                    txtMontoTotalVentaDetalle.Text = "0.00";
                    limpiar();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error al registrar la venta: {ex.Message}", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}   
