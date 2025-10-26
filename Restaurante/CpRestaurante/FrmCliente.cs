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
    public partial class FrmCliente : Form
    {
        private bool esNuevo = false;
        public FrmCliente(FrmPedido frmPedido)
        {
            InitializeComponent();
        }
        public void listar()
        {
            var lista = ClienteCln.listarPa(txtParametroCliente.Text);
            dgvListaCliente.DataSource = lista;
            dgvListaCliente.Columns["id"].Visible = false;
            dgvListaCliente.Columns["estado"].Visible = false;
            dgvListaCliente.Columns["cedulaIdentidad"].HeaderText = "Cedula Identidad";
            dgvListaCliente.Columns["nombreCliente"].HeaderText = "Nombres";
            dgvListaCliente.Columns["primerApellido"].HeaderText = "Primer Apellido";
            dgvListaCliente.Columns["segundoApellido"].HeaderText = "Segundo Apellido";
            dgvListaCliente.Columns["fechaRegistro"].HeaderText = "Fecha Registro";
            dgvListaCliente.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";


            btnEditar.Enabled = lista.Count() > 0;
            btnEliminar.Enabled = lista.Count() > 0;

            if (lista.Count > 0) dgvListaCliente.CurrentCell = dgvListaCliente.Rows[0].Cells["cedulaIdentidad"];
        }
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Size = new Size(732, 608);
            txtNombresCliente.KeyPress += Util.onlyLetters;
            listar();
        }
        private void limpiar()
        {
            txtCedulaIdentidadCliente.Text = string.Empty;
            txtNombresCliente.Text = string.Empty;
            txtPrimerApellidoCliente.Text = string.Empty;
            txtSegundoApellidoCliente.Text = string.Empty;
        }

        private bool validar()
        {
            bool esValido = true;

            erpCedulaIdentidadCliente.SetError(txtCedulaIdentidadCliente, "");
            erpNombresCliente.SetError(txtNombresCliente, "");
            erpPrimerApellidoCliente.SetError(txtPrimerApellidoCliente, "");


            if (string.IsNullOrEmpty(txtCedulaIdentidadCliente.Text))
            {
                esValido = false;
                erpCedulaIdentidadCliente.SetError(txtCedulaIdentidadCliente, "El campo Cedula Identidad es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtNombresCliente.Text))
            {
                esValido = false;
                erpNombresCliente.SetError(txtNombresCliente, "El campo Nombres es obligatorio.");
            }
            if (string.IsNullOrEmpty(txtPrimerApellidoCliente.Text))
            {
                esValido = false;
                erpPrimerApellidoCliente.SetError(txtPrimerApellidoCliente, "El campo Primer Apellido es obligatorio.");
            }
            
            return esValido;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Size = new Size(1013, 608);
            esNuevo = true;
            txtCedulaIdentidadCliente.Focus();
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                var cliente = new Cliente
                {
                    cedulaIdentidad = txtCedulaIdentidadCliente.Text.Trim(),
                    nombreCliente = txtNombresCliente.Text.Trim(),
                    primerApellido = txtPrimerApellidoCliente.Text.Trim(),
                    segundoApellido = txtSegundoApellidoCliente.Text.Trim(),
                    usuarioRegistro = Util.usuario.usuario
                };

                if (esNuevo)
                {
                    if (ClienteCln.existeDocumento(cliente.cedulaIdentidad))
                    {
                        MessageBox.Show("NO SE PUEDE AGREGAR, cedulaIdentidad ya existente.", ":::Restaurante - Mensaje :::",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cliente.fechaRegistro = DateTime.Now;
                    cliente.estado = 1;
                    ClienteCln.insertar(cliente);
                }
                else
                {
                    int index = dgvListaCliente.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dgvListaCliente.Rows[index].Cells["id"].Value);
                    var clienteExistente = ClienteCln.obtenerUno(id);

                    if (cliente.cedulaIdentidad != clienteExistente.cedulaIdentidad && ClienteCln.existeDocumento(cliente.cedulaIdentidad))
                    {
                        MessageBox.Show("NO SE PUEDE ACTUALIZAR, cedulaIdentidad ya existente.", ":::Restaurante - Mensaje :::",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cliente.id = id;
                    ClienteCln.actualizar(cliente);
                }

                MessageBox.Show("Cliente guardado correctamente", ":::Restaurante - Mensaje :::",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiar();
                Size = new Size(732, 608);
                listar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Size = new Size(1013, 608);
            esNuevo = false;
            int index = dgvListaCliente.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaCliente.Rows[index].Cells["id"].Value);
            var cliente = ClienteCln.obtenerUno(id);
            txtCedulaIdentidadCliente.Text = cliente.cedulaIdentidad;
            txtNombresCliente.Text = cliente.nombreCliente;
            txtPrimerApellidoCliente.Text = cliente.primerApellido;
            txtSegundoApellidoCliente.Text = cliente.segundoApellido;
            txtCedulaIdentidadCliente.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvListaCliente.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvListaCliente.Rows[index].Cells["id"].Value);
            string cedulaIdentidad = dgvListaCliente.Rows[index].Cells["cedulaIdentidad"].Value.ToString();
            DialogResult dialog =
                MessageBox.Show($"¿Está seguro que desea dar de baja al Cliente con N° de cedulaIdentidad {cedulaIdentidad}?",
                                ":::Restaurante - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ClienteCln.eliminar(id, Util.usuario.usuario);
                listar();
                MessageBox.Show("Cliente dado de baja correctamente", ":::Restaurante - Mensaje :::",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            listar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Size = new Size(732, 608);
        }
    }
}
