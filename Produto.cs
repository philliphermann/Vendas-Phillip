using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    class Produto
    {
        private int id;
        private string descricaoProduto;
        private double valorProduto;
        private int quantidadeProduto;



        public Produto(int id, string descricaoProduto, double ValorProduto, int quantidadeProduto)
        {
            this.id = id;
            this.descricaoProduto = descricaoProduto;
            this.valorProduto = ValorProduto;
            this.quantidadeProduto = quantidadeProduto;
        }
        public void SetIdProduto(int ids)
        {
            this.id = ids;
        }
        public void SetdescricaoProduto(string descricaoProdutos)
        {
            this.descricaoProduto = descricaoProdutos;
        }
        public void SetValorProdutos(double ValorProdutos)
        {
            this.valorProduto = ValorProdutos;
        }
        public void SetquantidadeProduto(int quantidadeProdutos)
        {
            this.quantidadeProduto = quantidadeProdutos;
        }
        public int GetIdProduto()
        {
            return this.id = id;
        }
        public string GetdescricaoProduto()
        {
            return this.descricaoProduto;
        }
        public double GetValorProduto()
        {
            return this.valorProduto;
        }
        public int GetquantidadeProduto()
        {
            return this.quantidadeProduto;
        }

        public void inserirProduto()
        {
            SqlCommand cmd = new SqlCommand();
            Conexao connect = new Conexao();

            cmd.CommandText = "Insert into Produto (descricaoProduto, valorProduto, quantidadeProduto) values (@descricaoProduto, @valorProduto,@quantidadeProduto)";
            cmd.Parameters.AddWithValue("@descricaoProduto", this.descricaoProduto);
            cmd.Parameters.AddWithValue("@valorProduto", this.valorProduto);
            cmd.Parameters.AddWithValue("@quantidadeProduto", this.quantidadeProduto);

            try
            {
                cmd.Connection = connect.conectar();
                cmd.ExecuteNonQuery();
                connect.desconectar();
                MessageBox.Show("Produto Cadastrado");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Produto não cadastrado");
            }
        }


        public void excluirProduto(int id)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao connect = new Conexao();
            cmd.CommandText = "delete from produto where idProduto = @id";
            cmd.Parameters.AddWithValue("@id", id);


            try
            {
                cmd.Connection = connect.conectar();
                cmd.ExecuteNonQuery();
                connect.desconectar();
                MessageBox.Show("Produtio excluido");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Produto não excluído");
            }
        }
        public void procurarProduto(int id)
        {

            SqlCommand cmd = new SqlCommand();
            Conexao connect = new Conexao();
            cmd.CommandText = "Select * from Produto where idProduto =  @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader;

            try
            {
                cmd.Connection = connect.conectar();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.descricaoProduto = reader[1].ToString();
                    this.valorProduto = reader.GetDouble(2);
                    this.quantidadeProduto = reader[3].GetHashCode();

                }

                MessageBox.Show("Produto encontrado");
            }
            catch (SqlException e)
            {
                MessageBox.Show("Produto não encontrado");

            }
        }
        public void attProduto(int id)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao connect = new Conexao();
            cmd.CommandText = "update Produto set valorProduto = @valorProduto, descricaoProduto = @descricaoProduto, quantidadeProduto = @quantidadeProduto where idProduto = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@descricaoProduto", this.descricaoProduto);
            cmd.Parameters.AddWithValue("@valorProduto", this.valorProduto);
            cmd.Parameters.AddWithValue("@quantidadeProduto", this.quantidadeProduto);
            try
            {
                cmd.Connection = connect.conectar();
                cmd.ExecuteNonQuery();
                connect.desconectar();
                MessageBox.Show("DADOS ENVIADOS");
            }
            catch (SqlException e)
            {
                MessageBox.Show("DADOS NÃO ENVIADOS");
            }
             void updateEstoque(int idProduto)
            {
                cmd.CommandText = "update Produto set QuantidadeProduto = quantidadeProduto - @quantidadeProduto where IdProduto = @id";




                cmd.Parameters.AddWithValue("@QuantidadeProduto", this.quantidadeProduto);
                cmd.Parameters.AddWithValue("@id", idProduto);



                try
                {
                    cmd.Connection = connect.conectar();
                    cmd.ExecuteNonQuery();
                    connect.desconectar();
                    MessageBox.Show("Dados atualizados com excito");
                }



                catch (SqlException e)
                {
                    MessageBox.Show("Dados não atualizados");
                }
            }
        }
    }
}
