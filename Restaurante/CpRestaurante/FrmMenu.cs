using CadRestaurante;
using ClnRestaurante;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CpRestaurante
{
    public partial class FrmMenu : Form
    {
        private bool esNuevo=false;
        public FrmMenu(FrmPedido frmPedido)
        {
            InitializeComponent();
            nudStock.Minimum = 1; // Agregar esta línea
            nudStock.Value = 1;   // Agregar esta línea
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
            dgvLista.Columns["imagen"].HeaderText = "Imagen";
            dgvLista.Columns["stock"].HeaderText = "Stock";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";



            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["nombre"];
            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;
        }
        private void cargarTipoMenu()
        {
            var lista = TipoMenuCln.listar();
            cbxTipoPlato.DataSource = lista;
            cbxTipoPlato.ValueMember = "id";
            cbxTipoPlato.DisplayMember = "descripcion";
            cbxTipoPlato.SelectedIndex = -1;

        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            Size = new Size(812, 350);
            listar();
            cargarTipoMenu();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            pnlAcciones.Enabled = false;
            Size = new Size(812, 497);
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlAcciones.Enabled = false;
            Size = new Size(812, 497);

            int id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var menu = MenuCln.obtener(id);
            txtNombre.Text = menu.nombre;
            txtDescripcion.Text = menu.descripcion;
            cbxTipoPlato.SelectedValue = menu.idTipoMenu;
            nudPrecioVenta.Value = menu.precio;
            txtImagen.Text = menu.imagen;
            nudStock.Value = menu.stock;

            txtNombre.Focus();
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            cbxTipoPlato.SelectedIndex = -1;
            nudPrecioVenta.Value = 0;
            txtImagen.Clear();
            nudStock.Value = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(812, 350);
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

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }
        private bool validar()
        {
            bool esValido = true;
            erpNombre.Clear();
            erpDescripcion.Clear();
            erpTipoPlato.Clear();
            erpImagen.Clear();
            erpPrecioVenta.Clear();
            erpStock.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpNombre.SetError(txtNombre, "El nombre es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                erpDescripcion.SetError(txtDescripcion, "La descripción es obligatoria");
                esValido = false;
            }
            if (cbxTipoPlato.SelectedIndex == -1)
            {
                erpTipoPlato.SetError(cbxTipoPlato, "El tipo de menú es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtImagen.Text)){
                erpImagen.SetError(txtImagen, "La imagen es obligatoria");
            }
            if (nudPrecioVenta.Value <= 0)
            {
                erpPrecioVenta.SetError(nudPrecioVenta, "El precio de venta debe ser mayor a cero");
                esValido = false;
            }
            if (nudStock.Value <= 0) // Cambiar a <= 0
            {
                erpStock.SetError(nudStock, "El stock debe ser mayor a cero");
                esValido = false;
            }
            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var menu = new CadRestaurante.Menu();
                menu.nombre = txtNombre.Text.Trim();
                menu.descripcion = txtDescripcion.Text.Trim();
                menu.idTipoMenu = (int)cbxTipoPlato.SelectedValue;
                menu.precio = nudPrecioVenta.Value;
                menu.imagen = txtImagen.Text.Trim();
                menu.fechaRegistro = DateTime.Now;
                menu.estado = 1;
                menu.stock = (int)nudStock.Value;

                menu.usuarioRegistro = Util.usuario.usuario;

                if (esNuevo)
                {
                    menu.fechaRegistro = DateTime.Now;
                    menu.estado = 1;
                    MenuCln.insertar(menu);
                }
                else
                {
                    menu.id = (int)dgvLista.CurrentRow.Cells["id"].Value;
                    MenuCln.actualizar(menu);
                }
                listar();
                btnCancelar.PerformClick();
                MessageBox.Show(this, "Menu guardado correctamente", "::: Mensaje - Restaurante :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value); // Cambia "id" por "idProducto"
            string nombre = dgvLista.Rows[index].Cells["nombre"].Value.ToString();
            DialogResult dialog =
                MessageBox.Show($"¿Está seguro que desea dar de baja al producto con nombre {nombre}?",
                "::: TecnoCell - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                MenuCln.eliminar(id, Util.usuario.usuario);
                listar();
                MessageBox.Show("Producto dado de baja correctamente", "::: TecnoCell - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
