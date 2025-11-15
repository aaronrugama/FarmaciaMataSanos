using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaMataSanos
{
    public partial class FrmLogIn : Form
    {
        private ConexionBD conexion = new ConexionBD();
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer credenciales del formulario
                string correo = txtCorreo.Text.Trim();
                string contrasena = txtContra.Text.Trim();
                

                if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
                {
                    MessageBox.Show("Por favor, ingrese su correo y contraseña.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convertir la contraseña a Base64 (como la tienes almacenada)
                string contrasenaBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(contrasena));

                // Conectar a la base de datos
                conexion.leerXML(); // Lee los datos de conexión del XML
                conexion.conectar(); // Abre la conexión

                // Crear el comando para la función
                using (var cmd = new NpgsqlCommand("SELECT * FROM fn_login_usuario(@correo, @contrasena)", conexion.getMiConexion()))
                {
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@contrasena", contrasenaBase64);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Leer los datos del usuario
                            string codUser = reader["cod_user"].ToString();
                            string nombre = reader["nombre_user"].ToString();
                            string apellido = reader["apellido_user"].ToString();
                            string rol = reader["rol_user"].ToString();

                            // Mostrar mensaje de bienvenida
                            MessageBox.Show($"¡Bienvenido/a {nombre} {apellido}!",
                                "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Abrir el formulario principal
                            this.Hide();
                            FrmInicio frm = new FrmInicio();
                            frm.Text = $"Farmacia MataSanos - Sesión de {rol}";
                            frm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.",
                                "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar iniciar sesión: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No espacios
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
                return;
            }

            // Caracteres válidos para un correo
            string validos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.@_-";

            if (!char.IsControl(e.KeyChar) && !validos.Contains(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string correo = txtCorreo.Text.Trim();

            if (string.IsNullOrWhiteSpace(correo))
            {
                errValidar.SetError(txtCorreo, "El correo es obligatorio.");
                e.Cancel = true;
                return;
            }

            // Validación básica de correo
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                errValidar.SetError(txtCorreo, "Formato de correo inválido.");
                e.Cancel = true;
                return;
            }

            errValidar.SetError(txtCorreo, "");
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtContra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContra.Text))
            {
                errValidar.SetError(txtContra, "La contraseña es obligatoria.");
                e.Cancel = true;
                return;
            }

            // Mínimo 4 caracteres por ejemplo
            if (txtContra.Text.Length < 4)
            {
                errValidar.SetError(txtContra, "La contraseña es muy corta.");
                e.Cancel = true;
                return;
            }

            errValidar.SetError(txtContra, "");
        }
    }
}
