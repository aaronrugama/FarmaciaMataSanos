using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaMataSanos
{
    internal class MedicamentoDAO
    {
        public bool InsertarMedicamento(string nombre, byte[] imagen, int cantidad, decimal precio)
        {
            ConexionBD conexion = new ConexionBD();

            try
            {
                conexion.leerXML();
                conexion.conectar();

                using (var cmd = new NpgsqlCommand("CALL pa_insertar_medicamento(@p_nombre_med, @p_imagen_med, @p_cant_med, @p_precio_med)",
                                                    conexion.getMiConexion()))
                {
                    cmd.Parameters.AddWithValue("@p_nombre_med", nombre);
                    cmd.Parameters.AddWithValue("@p_imagen_med", imagen ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@p_cant_med", cantidad);
                    cmd.Parameters.AddWithValue("@p_precio_med", precio);

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR BD: " + ex.Message);
                return false;
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
