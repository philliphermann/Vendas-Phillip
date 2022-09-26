using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormVenda t1 = new FormVenda();
            t1.Show();
            Hide();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Form1 t2 = new Form1();
            t2.Show();
            Hide();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormsProduto t1 = new FormsProduto();
            t1.Show();
            Hide();
        }
    }
}
