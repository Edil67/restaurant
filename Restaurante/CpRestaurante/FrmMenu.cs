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

            if (lista.Count > 0) dgvLista.CurrentCell = dgvLista.Rows[0].Cells["nombre"];
            btnEditar.Enabled = lista.Count > 0;
            btnEliminar.Enabled = lista.Count > 0;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            listar();
        }
    }
}
