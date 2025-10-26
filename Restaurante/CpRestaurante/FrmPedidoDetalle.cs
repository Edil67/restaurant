using CadRestaurante;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpRestaurante
{
    public partial class FrmPedidoDetalle : Form
    {
        private List<Pedidos> pedidos;
        public FrmPedidoDetalle(FrmPedido frmPedido)
        {
            InitializeComponent();
        }

        private List<Pedidos> obtenerVentasPorCliente(string cedulaIdentidad)
        {
            using (var context = new LabRestauranteEntities())
            {
                return context.Pedidos
                    .Include("Cliente")
                    .Include("PedidoDetalle")
                    .Include("PedidoDetalle.Menu")
                    .Include("PedidoDetalle.Menu.TipoMenu")
                    .Where(v => v.Cliente.cedulaIdentidad == cedulaIdentidad && v.estado == 1)
                    .ToList();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtParametroCedulaIdentidadVentaDetalle.Text))
            {
                MessageBox.Show("Por favor, ingrese la cédula de identidad del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cedulaIdentidad = txtParametroCedulaIdentidadVentaDetalle.Text.Trim();
            pedidos = obtenerVentasPorCliente(cedulaIdentidad);

            if (pedidos == null || !pedidos.Any())
            {
                MessageBox.Show("No se encontró ningún pedido con la cédula proporcionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var primerPedido = pedidos.First();
            txtInfNombreCliente.Text = primerPedido.Cliente.nombreCliente;
            txtInfVentaCedulaIdentidad.Text = primerPedido.Cliente.cedulaIdentidad;
            txtInfVentaUsuario.Text = primerPedido.usuarioRegistro;

            // Mostrar todos los productos de todos los pedidos del cliente
            var detalles = pedidos
                .SelectMany(p => p.PedidoDetalle.Select(d => new
                {
                    p.fechaRegistro,
                    Menu = d.Menu.nombre,
                    TipoMenu = d.Menu.TipoMenu.descripcion,
                    d.Menu.descripcion,
                    Cantidad = d.cantidad,
                    PrecioUnitario = d.Menu.precio,
                    Subtotal = d.subtotal,
                    p.usuarioRegistro,
                    CedulaIdentidad = p.Cliente.cedulaIdentidad
                }))
                .ToList();

            dgvDetalleVenta.DataSource = detalles; 
            dgvDetalleVenta.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            dgvDetalleVenta.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
        }


        private void FrmPedidoDetalle_Load(object sender, EventArgs e)
        {
            txtParametroCedulaIdentidadVentaDetalle.Select();
        }

        private void btnNuevoRegistroVenta_Click(object sender, EventArgs e)
        {
            var frmPedido = new FrmPedido();
            frmPedido.ShowDialog();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtParametroCedulaIdentidadVentaDetalle.Text = "";
            txtInfVentaCedulaIdentidad.Text = "";
            txtInfVentaUsuario.Text = "";
            txtInfNombreCliente.Text = "";
        }
    }
}
