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
    public partial class FrmEmpleado : Form
    {
        private bool esNuevo = false;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void listar()
        {
            var lista = EmpleadoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = lista;
            dgvLista.Columns["id"].Visible = false;
            dgvLista.Columns["estado"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "Nombre";
            dgvLista.Columns["primerApellido"].HeaderText = "Primer Apellido";
            dgvLista.Columns["segundoApellido"].HeaderText = "Segundo Apellido";
            dgvLista.Columns["telefono"].HeaderText = "Teléfono";
            dgvLista.Columns["direccion"].HeaderText = "Dirección";
            dgvLista.Columns["cargo"].HeaderText = "Cargo";
            dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";
            dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha Registro";

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["Nombre"];
            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;

        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            Size = new Size(816, 345);
            listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            Size = new Size(816, 489);
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            pnlAcciones.Enabled = false;
            Size = new Size(816, 489);

            var id = (int)dgvLista.CurrentRow.Cells["id"].Value;
            var empleado = EmpleadoCln.obtener(id);
            txtNombre.Text = empleado.nombre;
            txtPrimerApellido.Text = empleado.primerApellido;
            txtSegundoApellido.Text = empleado.segundoApellido;
            txtTelefono.Text = empleado.telefono;
            txtDirección.Text = empleado.direccion;
            cbxCargo.Text = empleado.cargo;

            txtNombre.Focus();
        }
        private void limpiar()
        {
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtTelefono.Clear();
            txtDirección.Clear();
            cbxCargo.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAcciones.Enabled = true;
            Size = new Size(816, 345);
            limpiar();
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
            erpSegundoApellido.Clear();
            erpPrimerApellido.Clear();
            erpTelefono.Clear();
            erpDireccion.Clear();
            erpCargo.Clear();

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                erpNombre.SetError(txtNombre, "El nombre es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                erpPrimerApellido.SetError(txtPrimerApellido, "El primer apellido es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtSegundoApellido.Text)) 
            {
                erpSegundoApellido.SetError(txtSegundoApellido, "El segundo apellido es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                erpTelefono.SetError(txtTelefono, "El teléfono es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtDirección.Text))
            {
                erpDireccion.SetError(txtDirección, "La dirección es obligatoria");
                esValido = false;
            }
            if (string.IsNullOrEmpty(cbxCargo.Text))
            {
                erpCargo.SetError(cbxCargo, "El cargo es obligatorio");
                esValido = false;
            }

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var empleado = new Empleado();
                empleado.nombre = txtNombre.Text.Trim();
                empleado.primerApellido = txtPrimerApellido.Text.Trim();
                empleado.segundoApellido = txtSegundoApellido.Text.Trim();
                empleado.telefono = txtTelefono.Text.Trim();
                empleado.direccion = txtDirección.Text.Trim();
                empleado.cargo = cbxCargo.Text.Trim();
                empleado.usuarioRegistro = "admin";

                if (esNuevo)
                {
                    empleado.fechaRegistro = DateTime.Now;
                    empleado.estado = 1;
                    EmpleadoCln.insertar(empleado);
                }
                else
                {
                    empleado.id = (int)dgvLista.CurrentRow.Cells["id"].Value;
                    EmpleadoCln.actualizar(empleado);
                }
                listar();
                MessageBox.Show("Los datos se guardaron correctamente", "::: Mensaje - Restaurante :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
