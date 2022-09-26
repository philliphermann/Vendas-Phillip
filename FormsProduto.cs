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
    public partial class FormsProduto : Form
    {
        public FormsProduto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descricaoProduto1 = descBox.Text;
            Double valorproduto1 = Convert.ToDouble(valorBox.Text);
            int quantidadeProduto1 = Convert.ToInt32(quantBox.Text);
            
            Produto  A;
            A = new Produto(' ', descricaoProduto1, valorproduto1, quantidadeProduto1);
            A.inserirProduto();
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            int id1 = Int32.Parse(idProdutoBox.Text);
            Produto A;
            A = new Produto(0, " ", ' ', ' ');
            A.excluirProduto(id1);
        }

        private void atualizarBNT_Click(object sender, EventArgs e)
        {
            int id1 = Int32.Parse(idProdutoBox.Text);
            string descricaoProduto1 = descBox.Text;
            int valorproduto1 = Convert.ToInt32(valorBox.Text);
            int quantidadeProduto1 = Convert.ToInt32(quantBox.Text);

            Produto A;
            A = new Produto(' ', descricaoProduto1, valorproduto1, quantidadeProduto1);
            A.attProduto(id1);
        }

        private void procurarProduto_Click(object sender, EventArgs e)
        {
            int id1 = Int32.Parse(idProdutoBox.Text);
            Produto A;
            A = new Produto(0, " ", ' ', ' ' );
            A.procurarProduto(id1);
            descBox.Text = A.GetdescricaoProduto();
            valorBox.Text = A.GetValorProduto().ToString();
            quantBox.Text = A.GetquantidadeProduto().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu t1 = new Menu();
            t1.Show();
            Hide();
        }

        private void valorBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
