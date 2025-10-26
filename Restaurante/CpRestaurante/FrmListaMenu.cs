using ClnRestaurante;
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
    public partial class FrmListaMenu : Form
    {
        private FrmPedido frmPedido;
        public FrmListaMenu(FrmPedido pedido)
        {
            InitializeComponent();
            frmPedido = pedido;

        }
        public void listar()
        {
            var lista = MenuCln.listarPa(txtParametroProducto.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idTipoMenu"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "Nombre";
            dgvLista.Columns["tipoMenu"].HeaderText = "Tipo de Menú";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["precio"].HeaderText = "Precio";
            dgvLista.Columns["stock"].HeaderText = "Stock";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["nombre"];
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }
        private void txtParametroProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void FrmListaMenu_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow != null)
            {
                // Obtén los datos del producto seleccionado
                string cedulaIdentidad = "";
                string nombre = dgvLista.CurrentRow.Cells["nombre"].Value.ToString();
                string descripcion = dgvLista.CurrentRow.Cells["descripcion"].Value.ToString();
                string stock = dgvLista.CurrentRow.Cells["stock"].Value.ToString();
                string precio = dgvLista.CurrentRow.Cells["precio"].Value.ToString();

                // Llama al método del formulario de venta
                frmPedido.SetListaProducto(cedulaIdentidad, nombre, descripcion, stock, precio);
                this.Close(); // Cierra el formulario de selección
            }
        }

    }
}
