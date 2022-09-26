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
    public partial class Form1 : Form
    {
        Cliente A;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome1 = nomeBox.Text;
            string cpf1 = cpfBox.Text;
            string telefone1 = telBox.Text;
            string email1 = emailBox.Text;
            


           
            A = new Cliente(' ', nome1, cpf1, telefone1, email1);
            A.inserirCliente();
            




        


        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id1 = Int32.Parse(idBox.Text);
            A = new Cliente(0," ", " ", " ", " ");
            A.excluirCliente(id1);

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id1 = Int32.Parse(idBox.Text);
            A = new Cliente(0, " ", " ", " ", " ");
            A.procurarCliente(id1);
            nomeBox.Text = A.GetNome();
            cpfBox.Text = A.GetCpf();
            telBox.Text = A.GetTel();
            emailBox.Text = A.GetEmail();

        }

        private void atualizarBNT_Click(object sender, EventArgs e)
        {
            int id1 = Int32.Parse(idBox.Text);
            string nome1 = nomeBox.Text;
            string cpf1 = cpfBox.Text;
            string telefone1 = telBox.Text;
            string email1 = emailBox.Text;




            A = new Cliente(' ', nome1, cpf1, telefone1, email1);
            A.attCliente(id1);


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Menu t1 = new Menu();
            t1.Show();
            Hide();
        }

        private void nomeBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
