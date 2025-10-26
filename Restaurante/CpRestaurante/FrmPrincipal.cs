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
    public partial class FrmPrincipal : Form
    {
        private FrmAutenticacion frmAutenticacion;
        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.frmAutenticacion = frmAutenticacion;
        }
        public FrmPrincipal()
        {
            InitializeComponent();
            
        }

        private void btnCaTipoMenu_Click(object sender, EventArgs e)
        {
            var frmTipoMenu = new FrmTipoMenu();
            frmTipoMenu.ShowDialog();
        }

        private void btnCaMenu_Click(object sender, EventArgs e)
        {
            var frmMenu = new FrmPedido();
            new FrmMenu(frmMenu).ShowDialog();
        }

        private void btnCaCliente_Click(object sender, EventArgs e)
        {
            var frmPedido = new FrmPedido();
            new FrmCliente(frmPedido).ShowDialog();
        }

        private void btnCaPedidos_Click(object sender, EventArgs e)
        {
            var frmPedidos = new FrmPedido();
            frmPedidos.ShowDialog();
        }

        private void btnCaPedidosDetalle_Click(object sender, EventArgs e)
        {
            var frmPedido = new FrmPedido();
            // Corregido: Se pasa frmPedido como argumento al constructor de FrmPedidoDetalle
            var frmPedidoDetalle = new FrmPedidoDetalle(frmPedido);
            frmPedidoDetalle.ShowDialog();
        }
    }
}
