using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FarmaciaMataSanos
{
    internal class ConexionBD
    {
        private string servidor;
        private string baseDatos;
        private string usuario;
        private string contra;
        private string puerto;
        private NpgsqlConnection miConexion;

        public NpgsqlConnection getMiConexion()
        {
            return miConexion;
        }

        public void conectar()
        {
            string cadenaConexion = $"Host={servidor};Port={puerto};Database={baseDatos};Username={usuario};Password={contra}";
            miConexion = new NpgsqlConnection(cadenaConexion);
            miConexion.Open();
        }

        public void leerXML()
        {
            string rutaXML = "../../Config/userconfig.xml";
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement raiz;
            try
            {
                xmlDocument.Load(rutaXML);
                raiz = xmlDocument.DocumentElement;

                servidor = decode64(raiz.SelectSingleNode("host").InnerText);
                puerto = decode64(raiz.SelectSingleNode("puerto").InnerText);
                baseDatos = decode64(raiz.SelectSingleNode("dbname").InnerText);
                usuario = decode64(raiz.SelectSingleNode("usuario").InnerText);
                contra = decode64(raiz.SelectSingleNode("password").InnerText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string decode64(string cadena)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(cadena));
        }

        public void Dispose()
        {
            cerrarConexion();
        }

        public void cerrarConexion()
        {
            if (miConexion != null && miConexion.State != ConnectionState.Closed)
            {
                miConexion.Close();
            }
        }
    }
}
