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
    public partial class FrmMenu : Form
    {
        private bool esNuevo;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var lista = MenuCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["idTipoMenu"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "Nombre";
            dgvLista.Columns["tipoMenu"].HeaderText = "Tipo Menú";
            dgvLista.Columns["descripcion"].HeaderText = "Descripción";
            dgvLista.Columns["precio"].HeaderText = "Precio";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["nombre"];
            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;
        }
        private void cargarTipoMenu()
        {
            var lista = TipoMenuCln.listar();
            cbxTipoMenu.DataSource = lista;
            cbxTipoMenu.ValueMember = "id";
            cbxTipoMenu.DisplayMember = "descripcion";
            cbxTipoMenu.SelectedIndex = -1;
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            listar();
            cargarTipoMenu();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            pnlAcciones.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlAcciones.Enabled = false;

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var menu = MenuCln.obtener(id);
            txtNombre.Text = menu.nombre;
            txtDescripcion.Text = menu.descripcion;
            cbxTipoMenu.SelectedValue = menu.idTipoMenu;
            nudPrecioVenta.Value = menu.precio;

            txtNombre.Focus();
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            cbxTipoMenu.SelectedIndex = -1;
            nudPrecioVenta.Value = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAcciones.Enabled = true;
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
