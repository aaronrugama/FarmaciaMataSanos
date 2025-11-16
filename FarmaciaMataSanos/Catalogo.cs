using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FarmaciaMataSanos
{
    internal class Catalogo
    {
        internal class Medicamento
        {
            public string CodMed { get; set; }
            public string Nombre { get; set; }
            public byte[] Imagen { get; set; }
            public int Cantidad { get; set; }
            public decimal Precio { get; set; }
        }

        internal class PedidoItem
        {
            public Medicamento Medicamento { get; set; }
            public int Cantidad { get; set; }
            public decimal Subtotal { get; set; }
        }

        internal static class ImagenHelper
        {
            public static Image ByteArrayToImage(byte[] bytes)
            {
                if (bytes == null || bytes.Length == 0)
                    return null;

                try
                {
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        return Image.FromStream(ms);
                    }
                }
                catch
                {
                    return null;
                }
            }
        }

        public static class MedicamentoC
        {
            public static List<Medicamento> obtenerMedicamentos(NpgsqlConnection con)
            {
                List<Medicamento> lista = new List<Medicamento>();

                try
                {
                    using (var tran = con.BeginTransaction())
                    {
                        using (var cmd = new NpgsqlCommand("CALL pa_obtener_medicamentos(ref => NULL)", con, tran))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        using (var cmdFetch = new NpgsqlCommand("FETCH ALL IN \"mi_cursor\"", con, tran))
                        using (var reader = cmdFetch.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new Medicamento
                                {
                                    CodMed = reader.GetString(0),
                                    Nombre = reader.GetString(1),
                                    Imagen = reader.IsDBNull(2) ? null : (byte[])reader["imagen_med"],
                                    Cantidad = reader.GetInt32(3),
                                    Precio = reader.GetDecimal(4)
                                });
                            }
                        }

                        tran.Commit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener medicamentos: " + ex.Message);
                }

                return lista;
            }
        }


        internal static class PedidoDAO
        {
            public static string insertarOrden(NpgsqlConnection con, decimal total, string codCliente)
            {
                string sql = @"INSERT INTO orden (cod_orden, total_orden, cod_cliente) 
                               VALUES ('OR' || lpad(nextval('seq_orden')::text,4,'0'), @total, @cli) 
                               RETURNING cod_orden";

                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@cli", codCliente);

                    return (string)cmd.ExecuteScalar();
                }
            }

            public static void insertarDetalle(NpgsqlConnection con, string codOrden, PedidoItem item)
            {
                string sql = @"
                    INSERT INTO detalle_orden 
                    (cod_detalle, cant_detalle, subtotal_detalle, cod_orden, cod_med)
                    VALUES ('DT' || lpad(nextval('seq_detalle')::text,4,'0'), @cant, @sub, @orden, @med)";

                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@cant", item.Cantidad);
                    cmd.Parameters.AddWithValue("@sub", item.Subtotal);
                    cmd.Parameters.AddWithValue("@orden", codOrden);
                    cmd.Parameters.AddWithValue("@med", item.Medicamento.CodMed);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
