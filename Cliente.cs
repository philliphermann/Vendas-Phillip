using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendas
{
    class Cliente
    {
        private int id;
        private string Nome;
        private string Cpf;
        private string Telefone;
        private string Email;

        public Cliente(int id, string Nome, string Cpf, string Telefone, string Email)
        {
            this.id = id;
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Telefone = Telefone;
            this.Email = Email;
        }

        public void SetId(int ids)
        {
            this.id = ids;
        }
        public void SetNome(string Nom)
        {
            this.Nome = Nom;
        }
        public void SetCpf(string Cpfs)
        {
            this.Cpf = Cpfs;
        }
        public void SetTel(string Telefones)
        {
            this.Telefone = Telefones;
        }
        public void SetEmail(string Emails)
        {
            this.Email = Emails;
        }
        public int GetId()
        {
            return this.id = id;
        }
        public string GetNome()
        {
            return this.Nome;
        }
        public string GetCpf()
        {
            return this.Cpf;
        }
        public string GetTel()
        {
            return this.Telefone;
        }
        public string GetEmail()
        {
            return this.Email;
        }

        public void inserirCliente()
        {
            SqlCommand cmd = new SqlCommand();
            Conexao connect = new Conexao();

            cmd.CommandText = "Insert into Cliente (nomeCliente, cpfCliente, telefoneCliente, emailCliente) values (@nomeCliente, @cpfCliente, @telefoneCliente, @emailCliente)";
            cmd.Parameters.AddWithValue("@nomeCliente", this.Nome);
            cmd.Parameters.AddWithValue("@CpfCliente", this.Cpf);
            cmd.Parameters.AddWithValue("@TelefoneCliente", this.Telefone);
            cmd.Parameters.AddWithValue("@EmailCliente", this.Email);

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
        }

        public void excluirCliente(int id)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao connect = new Conexao();
            cmd.CommandText = "delete from cliente where idCliente = @id";
            cmd.Parameters.AddWithValue("@id", id);


            try
            {
                cmd.Connection = connect.conectar();
                cmd.ExecuteNonQuery();
                connect.desconectar();
                MessageBox.Show("CLIENTE EXCLUIDO");
            }
            catch (SqlException e)
            {
                MessageBox.Show("CLIENTE NÃO EXCLUIDO");
            }
        }

        public void procurarCliente(int id)
        {

            SqlCommand cmd = new SqlCommand();
            Conexao connect = new Conexao();
            cmd.CommandText = "Select * from cliente where idCliente =  @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader;

            try
            {
                cmd.Connection = connect.conectar();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    this.Nome = reader[1].ToString();
                    this.Cpf = reader[2].ToString();
                    this.Telefone = reader[3].ToString();
                    this.Email = reader[4].ToString();
                }

                MessageBox.Show("DADOS ENVIADOS");
            }
            catch (SqlException e)
            {
                MessageBox.Show("DADOS NÃO ENVIADOS");

            }
        }
            public void attCliente(int id)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao connect = new Conexao();
            cmd.CommandText = "update Cliente set nomeCliente = @nomeCliente , cpfCliente = @cpfCliente, telefoneCliente = @emailCliente where idCliente = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@nomeCliente", this.Nome);
            cmd.Parameters.AddWithValue("@CpfCliente", this.Cpf);
            cmd.Parameters.AddWithValue("@TelefoneCliente", this.Telefone);
            cmd.Parameters.AddWithValue("@EmailCliente", this.Email);
            try
            {
                cmd.Connection = connect.conectar();
                cmd.ExecuteNonQuery();
                connect.desconectar();
                MessageBox.Show("CLIENTE ATUALIZADO");
            }
            catch (SqlException e)
            {
                MessageBox.Show("CLIENTE NÃO ATUALIZADO");
            }
        }
    }
}
