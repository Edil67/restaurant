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
    public partial class FrmListaCliente : Form
    {
        private FrmPedido frmPedido;

        public FrmListaCliente(FrmPedido pedido)
        {
            InitializeComponent();
            frmPedido = pedido;
        }

        public void listar()
        {
            var lista = ClienteCln.listarPa(txtParametroCliente.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombreCliente"].HeaderText = "Nombre";
            dgvLista.Columns["primerApellido"].HeaderText = "Primer Apellido";
            dgvLista.Columns["segundoApellido"].HeaderText = "Segundo Apellido";
            dgvLista.Columns["cedulaIdentidad"].HeaderText = "Cédula Identidad";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";

            if (lista.Count > 0) 
                dgvLista.CurrentCell = dgvLista.Rows[0].Cells["nombreCliente"];
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametroCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void FrmListaCliente_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentRow != null)
            {
                string cedulaIdentidad = dgvLista.CurrentRow.Cells["cedulaIdentidad"].Value.ToString();
                string nombreCompleto = string.Format("{0} {1} {2}",
                    dgvLista.CurrentRow.Cells["nombreCliente"].Value.ToString(),
                    dgvLista.CurrentRow.Cells["primerApellido"].Value.ToString(),
                    dgvLista.CurrentRow.Cells["segundoApellido"].Value.ToString());

                // Llama al método del formulario de venta para establecer el cliente
                frmPedido.SetListaCliente(cedulaIdentidad, nombreCompleto);
                this.Close(); // Cierra el formulario de selección
            }
        }
    }
}
