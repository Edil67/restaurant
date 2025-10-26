using CadRestaurante;
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
    public partial class FrmTipoMenu : Form
    {
        private bool esNuevo = false;
        public FrmTipoMenu()
        {
            InitializeComponent();
        }

        public void listar()
        {
            var lista = TipoMenuCln.listarPa(txtParametroCategoria.Text);
            dgvListaCategoria.DataSource = lista;
            dgvListaCategoria.Columns["id"].Visible = false;
            dgvListaCategoria.Columns["estado"].Visible = false;  // Ocultar columna estado
            dgvListaCategoria.Columns["descripcion"].HeaderText = "Descripción";
            dgvListaCategoria.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvListaCategoria.Columns["fechaRegistro"].HeaderText = "Fecha Registro";

            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;

            if (lista.Count>0) dgvListaCategoria.CurrentCell = dgvListaCategoria.Rows[0].Cells["descripcion"];
        }

        private void limpiar()
        {
            txtDescripcionCategoria.Text=string.Empty;
        }
        private bool validar()
        {
            bool esValido = true;
            erpDescripcionTipoMenu.SetError(txtDescripcionCategoria, "");

            if (string.IsNullOrEmpty(txtDescripcionCategoria.Text))
            {
                esValido = false;
                Size = new Size(718, 510);
                erpDescripcionTipoMenu.SetError(txtDescripcionCategoria, "Debe ingresar una descripción de categoría.");

            }
            return esValido;
        }
        private void FrmTipoMenu_Load(object sender, EventArgs e)
        {
            Size = new Size(718, 510);
            listar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Size = new Size(718, 510);
            if (validar())
            {
                if (Util.usuario == null)
                {
                    MessageBox.Show("No se ha establecido un usuario. Inicie sesión primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var categoria = new TipoMenu();
                categoria.descripcion = txtDescripcionCategoria.Text.Trim();
                categoria.usuarioRegistro = Util.usuario.usuario; // Asignar el usuario actual

                if (esNuevo)
                {
                    categoria.fechaRegistro = DateTime.Now;
                    categoria.estado = 1;
                    TipoMenuCln.insertar(categoria);
                }
                else
                {
                    int index = dgvListaCategoria.CurrentCell.RowIndex;
                    categoria.id = Convert.ToInt32(dgvListaCategoria.Rows[index].Cells["id"].Value);
                    TipoMenuCln.actualizar(categoria);
                }

                listar();
                MessageBox.Show("Categoría guardada correctamente", "::: Restaurante - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo= true;
            Size = new Size(915, 527);
            txtDescripcionCategoria.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(718, 510);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvListaCategoria.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaCategoria.Rows[index].Cells["id"].Value);
            string descripcion = dgvListaCategoria.Rows[index].Cells["Descripcion"].Value.ToString();
            DialogResult dialog =
                MessageBox.Show($"¿Está seguro que desea dar de baja la Categoria con descripción {descripcion}?",
                "::: Restaurante - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                TipoMenuCln.eliminar(id, Util.usuario.usuario);
                listar();
                MessageBox.Show("Categoria dado de baja correctamente", "::: Restaurante - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
            listar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(915, 527);
            esNuevo = false;
            int index = dgvListaCategoria.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaCategoria.Rows[index].Cells["id"].Value);
            var categoria = TipoMenuCln.obtener(id);
            txtDescripcionCategoria.Text = categoria.descripcion;
            txtDescripcionCategoria.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
