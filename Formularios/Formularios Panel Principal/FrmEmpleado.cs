using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOA_CLOTHING.Entidades.SP;
using BOA_CLOTHING.Entidades;
using BOA_CLOTHING.BaseDatos;
using System.Windows.Forms;
using LaboratorioNo5.Entidades;

namespace BOA_CLOTHING.Formularios
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emplado = new Empleado();
            try
            {
                if(spValidar.Existe("sp_ValidarColaborador", txtidEmpleado.Text).Equals(false))
                {

                    emplado.iDEmpleado = txtidEmpleado.Text;
                    emplado.Nombre = txtNombre.Text;
                    emplado.Apellido = txtApellido.Text;
                    emplado.Telefono = txtTelefono.Text;
                    emplado.Cargo = txtCargo.Text;
                    emplado.Usuario = txtUsuario.Text;
                    emplado.Passwords = txtPassword.Text;

                    int num = spInsertar.Insertar("sp_InsertarEmpleado", emplado);

                    if (num > 0)
                    {
                        MessageBox.Show("Los datos fueron insertado satisfactoriamente");
                        Limpiar.Limpia(gbControles);
                    }
                }
                else
                {
                    MessageBox.Show("La cedula se encuentra registrada en nuestra base de datos");
                }
                SQLConnection.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            btnCrear.Enabled = false;
        }

        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtidEmpleado.Text) &&
                !string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtApellido.Text) &&
                !string.IsNullOrEmpty(txtTelefono.Text) &&
                !string.IsNullOrEmpty(txtCargo.Text) &&
                !string.IsNullOrEmpty(txtUsuario.Text) &&
                !string.IsNullOrEmpty(txtPassword.Text);
            btnCrear.Enabled = vr;

        }

        private void txtidEmpleado_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.Limpia(gbControles);
        }
    }
}
