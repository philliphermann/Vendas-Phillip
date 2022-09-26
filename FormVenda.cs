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
    public partial class FormVenda : Form
    {
        DateTime date = DateTime.Now;
        void Somar()
        {
            double totGeral = 0;
            for (int i = 0; i < gridVendas.Rows.Count; i++)
            {
                totGeral += Convert.ToDouble(gridVendas.Rows[i].Cells[3].Value);

            }
            totalCompralb.Text = totGeral.ToString();
        }

            public FormVenda()
        {
            InitializeComponent();
            

            var cupom = date.ToString("yyymmhhmmss");
            labelCupom.Text = date.ToString("yyymmhhmmss");
        }

        

        private void gridVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            int id1 = Int32.Parse(txtCliente.Text);
            Cliente A;
            A = new Cliente(0, " ", " ", " ", " ");
            A.procurarCliente(id1);
            labelCliente.Text = A.GetNome();
            

        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            int id1 = Int32.Parse(txtProduto.Text);
            
            Produto A;
            A = new Produto(0, " ", ' ', ' ');
            A.procurarProduto(id1);
            labelproduto.Text = A.GetdescricaoProduto();
            valorProdutoLab.Text = A.GetValorProduto().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu t1 = new Menu();
            t1.Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarQuantidade_Click(object sender, EventArgs e)
        {
            double tot = Double.Parse(valorProdutoLab.Text) * Double.Parse (qntProdutoTxt.Text);
            lbTotal.Text = tot.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            String[] linha = new string[] { txtProduto.Text, labelproduto.Text, valorProdutoLab.Text, lbTotal.Text, qntProdutoTxt.Text.ToString() };
            gridVendas.Rows.Add(linha);
            Somar();
        }

        private void totalCompralb_Click(object sender, EventArgs e)
        {
           
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            gridVendas.Rows.RemoveAt(gridVendas.CurrentRow.Index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venda A;
            int idClientes = Convert.ToInt32(txtCliente.Text);
            int idProdutos = Convert.ToInt32(txtProduto.Text);
            string cupom = labelCupom.Text;
            DateTime data = DateTime.Now;

            for (int i = 0; i < gridVendas.Rows.Count; i++)
            {



                int quantidades = Convert.ToInt32(gridVendas.Rows[i].Cells[4].Value);
                double valor = Convert.ToDouble(gridVendas.Rows[i].Cells[2].Value);
                double total = Convert.ToDouble(gridVendas.Rows[i].Cells[3].Value);



                A = new Venda(' ', cupom, idProdutos, idClientes, data, quantidades, valor, total);
                A.inserirVenda();
                MessageBox.Show("Dado enviados com sucesso!");
                txtCliente.Text = "";
                labelCliente.Text = "Nome Cliente:";
                txtProduto.Text = "";
                labelproduto.Text = "Nome Produto:";
                lbTotal.Text = "Valor Total:";
                valorProdutoLab.Text = "Valor Produto:";
                cupom = date.ToString("yyymmhhmmss");
                labelCupom.Text = date.ToString("yyymmhhmmss");
            



                /* Produto Z;
                 Z  = new Produto(0,);
                 Z.updateEstoque(idProdutos);*/

            }


        
            
        

    }

        private void labelproduto_Click(object sender, EventArgs e)
        {

        }

        private void qntProdutoTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCliente_Click(object sender, EventArgs e)
        {

        }

        private void labelCupom_Click(object sender, EventArgs e)
        {
           
        }
    }
}
