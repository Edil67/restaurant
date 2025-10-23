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
    public partial class FrmAutenticacion : Form
    {
        public FrmAutenticacion()
        {
            InitializeComponent();
            //string claveEncriptada = CpRestaurante.Util.Encrypt("hola123");
            //Clipboard.SetText(claveEncriptada);
            //MessageBox.Show("claveEncriptada: " + claveEncriptada);
        }
        private bool validar()
        {
            bool esValido = true;
            erpUsuario.SetError(txtUsuario, "");
            erpClave.SetError(txtClave, "");
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpUsuario.SetError(txtUsuario, "El campo Usuario es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                erpClave.SetError(txtClave, "El campo Contraseña es obligatorio");
                esValido = false;
            }
            return esValido;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var usuario = UsuarioCln.validar(txtUsuario.Text, Util.Encrypt(txtClave.Text));
                if (usuario != null)
                {
                    Util.usuario = usuario;
                    txtClave.Clear();
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                    Hide();
                    new FrmPrincipal(this).ShowDialog();
                }
                else MessageBox.Show("Usuario y/o contraseña incorrecto", "::: Restaurante - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnIngresar.PerformClick();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
