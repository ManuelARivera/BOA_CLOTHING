using System;
using LaboratorioNo5.Entidades;
using BOA_CLOTHING.Entidades;
using BOA_CLOTHING.Entidades.SP;
using BOA_CLOTHING.BaseDatos;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOA_CLOTHING.Formularios
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            btnCrear.Enabled = false;
        }

        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtCedula.Text) &&
                !string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtApellido.Text) &&
                !string.IsNullOrEmpty(txtTelefono.Text) &&
                !string.IsNullOrEmpty(txtRnc.Text);
            btnCrear.Enabled = vr;

        }

        private void txtidCliente_TextChanged(object sender, EventArgs e)
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

        private void txtRnc_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            try
            {
                if (spValidar.ExistePerson("sp_ValidarCliente", txtCedula.Text).Equals(false))
                {
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Cedula = txtCedula.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.RNC = txtRnc.Text;

                    int num = spInsertar.Insertar("sp_InsertarCliente", cliente);

                    if (num > 0)
                    {
                        MessageBox.Show("Los datos fueron insertado satisfactoriamente");
                        Limpiar.Limpia(gbControles);
                    }
                }
                else
                {
                    MessageBox.Show("La cédula introducido se encuentra registrada en nuestra base de datos");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            SQLConnection.CerrarConexion();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.Limpia(gbControles);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
