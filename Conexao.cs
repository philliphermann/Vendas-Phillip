﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();
        
            public Conexao()
        {
            con.ConnectionString = "Data Source=SAN0636460W10-1\\SQLEXPRESS;Initial Catalog=Vendas;Integrated Security=True";
        }
            public SqlConnection conectar()
        {
            con.Open();
            return con;
        }
        public SqlConnection desconectar()
        {
            con.Close();
            return con;
        }


    }
}
