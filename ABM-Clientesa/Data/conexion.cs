using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entities;


namespace Data
{
    public class Conexion
    {
        SqlConnection conex; // a Donde (representa una sesión única para un origen de datos de SQL Server.)
        SqlCommand cmd; // Que Envio (consultas)
                        //SqlDataReader read como lo recibo

        public Conexion()
        {
            conex = new SqlConnection("Data Source=LAPTOP-T13SKOOM\\SQLEXPRESS2019;Initial Catalog=ABMClientes;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conex;

        }
        public void Open() {
            conex.Open();
        }
        public void Close()
        {
            conex.Close();
        }

        public void Execute(string sentence)
        {
            Open();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sentence;
            cmd.ExecuteNonQuery();
            Close();
        }
        public SqlDataReader ExecuteQuery(string sentence)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sentence;
            return cmd.ExecuteReader(); // como lo recibo

        }

        public Cliente listaDeClientes(List<Cliente> listaClientes)
        {
            string sql = $"select * from clientes";
            Open();

            Cliente client = new Cliente();
            SqlDataReader reader = ExecuteQuery(sql);
            for (int ind = 0; ind <= listaClientes.Count(); ind++)
            {
                client.Nombre = reader["nombre"].ToString();
                client.Apellido = reader["apellido"].ToString();
                client.DNI = reader["DNI"].ToString();
                client.Cuil = reader["CUIL"].ToString();
            }
            Close();
            return client;
        }
        
        public Cliente GetClientByDNI(string dni)
        {
            string sql = $"select nombre from clientes where dni = '{dni}'";
            Open();
            SqlDataReader reader = ExecuteQuery(sql);
            reader.Read();
            Cliente cl = new Cliente();
            cl.Nombre = reader["nombre"].ToString();
            Close();
            return cl;
        }

    }

}
