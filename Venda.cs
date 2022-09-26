using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    class Venda
    {
        private int idVendas;
        private string cupomVendas;
        private int codPVendas;
        private int codCVendas;
        private DateTime dataVendas;
        private int quantidadeVendas;
        private double TotalVendas;
        private double ValorVendas;
        public Venda(int idVendas, string cupomVendas, int codPVendas, int codCVendas, DateTime dataVendas, int quantidadeVendas, double ValorVenda, double TotalVenda)
        {
            this.idVendas = idVendas;
            this.cupomVendas = cupomVendas;
            this.codPVendas = codPVendas;
            this.codCVendas = codCVendas;
            this.dataVendas = dataVendas;
            this.quantidadeVendas = quantidadeVendas;
            this.ValorVendas = ValorVenda;
            this.TotalVendas = TotalVenda;
        }
        public void Setid(int idVendas)
        {
            this.idVendas = idVendas;
        }
        public void SetTotalVenda(double TotalVenda)
        {
            this.TotalVendas = TotalVenda;
        }
        public void SetValorVenda(double ValorVenda)
        {
            this.ValorVendas = ValorVenda;
        }
        public void SetcupomVendas(string cupomVendas)
        {
            this.cupomVendas = cupomVendas;
        }
        public void SetcodPVendas(int codPVendas)
        {
            this.codPVendas = codPVendas;
        }
        public void SetcodCVendas(int codCVendas)
        {
            this.codCVendas = codCVendas;
        }
        public void SetdataVendas(DateTime dataVendas)
        {
            this.dataVendas = dataVendas;
        }
        public void SetquantidadeVendas(int quantidadeVendas)
        {
            this.quantidadeVendas = quantidadeVendas;
        }
        
        public int getidVendas()
        {
            return this.idVendas;
        }
        public double getValorVenda()
        {
            return this.ValorVendas;
        }
        public double getTotalVenda()
        {
            return this.TotalVendas;
        }
        public string getcupomVendas()
        {
            return this.cupomVendas;
        }
        public int getcodPVendas()
        {
            return this.codPVendas;
        }
        public int getcodCVendas()
        {
            return this.codCVendas;
        }
        public DateTime getdataVendas()
        {
            return this.dataVendas;
        }
        public int getquantidadeVendas()
        {
            return this.quantidadeVendas;
        }

        public void inserirVenda()
        {
            SqlCommand cmd = new SqlCommand();
            Conexao connect = new Conexao();

            cmd.CommandText = "Insert into Venda (cupomVenda, codProduto, codCliente, dataVenda, quantidadeVenda, ValorVenda, TotalVenda) values (@cupomVenda, @codProduto, @codCliente, @data, @quantidadeVenda, @ValorVenda, @TotalVenda)";
            cmd.Parameters.AddWithValue("@cupomVenda", this.cupomVendas);
            cmd.Parameters.AddWithValue("@codProduto", this.codPVendas);
            cmd.Parameters.AddWithValue("@codCliente", this.codCVendas);
            cmd.Parameters.AddWithValue("@data", this.dataVendas);
            cmd.Parameters.AddWithValue("@quantidadeVenda", this.quantidadeVendas);
            cmd.Parameters.AddWithValue("@valorVenda", this.ValorVendas);
            cmd.Parameters.AddWithValue("@totalVenda", this.TotalVendas);

            try
            {
                cmd.Connection = connect.conectar();
                cmd.ExecuteNonQuery();
                connect.desconectar();
              //  MessageBox.Show("Produto Cadastrado");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Produto Não Cadastrado");
            }

            
        }

    }
}
