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
                if(spValidar.Existe("sp_ValidarColaborador", txtNombre.Text, txtApellido.Text).Equals(false))
                {
                    emplado.Nombre = txtNombre.Text;
                    emplado.Apellido = txtApellido.Text;
                    emplado.Telefono = txtTelefono.Text;
                    emplado.Cargo = txtCargo.Text;
                    emplado.Usuario = txtUsuario.Text;
                    emplado.Passwords = txtPassword.Text;

                    spInsertar.Insertar("sp_InsertarEmpleado", emplado);
                    SQLConnection.CerrarConexion();
                    Limpiar.Limpia(gbControles);
                }
                else
                {
                    MessageBox.Show("Empleado introducio ya existe en nuestra base de datos");
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }
    }
}
