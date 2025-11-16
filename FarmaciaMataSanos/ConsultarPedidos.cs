using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace FarmaciaMataSanos
{
    internal class ConsultarPedidos
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=@Kfrl0550;Database=FarmaciaMataSano;";

        public DataTable ObtenerPedidos()
        {
            DataTable tabla = new DataTable();

            using (NpgsqlConnection conexion = new NpgsqlConnection(connectionString))
            {
                conexion.Open();

                using (NpgsqlCommand comando = new NpgsqlCommand("SELECT * FROM fn_obtener_pedidos()", conexion))
                {
                    using (NpgsqlDataReader lector = comando.ExecuteReader())
                    {
                        tabla.Load(lector);
                    }
                }
            }

            return tabla;
        }
    }
}
