using BOA_CLOTHING.BaseDatos;
using BOA_CLOTHING.Entidades.SP;
using BOA_CLOTHING.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaboratorioNo5.Entidades;

namespace BOA_CLOTHING.Formularios
{
    public partial class FrmMantenimientoCliente : Form
    {
        public FrmMantenimientoCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMantenimientoCliente_Load(object sender, EventArgs e)
        {
            spMostrarGrilla.LeerGrilla("sp_MostrarCliente", dgvEmpleado);
            SQLConnection.CerrarConexion();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            txtId.Text = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleado.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvEmpleado.CurrentRow.Cells[2].Value.ToString();
            txtCedula.Text = dgvEmpleado.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvEmpleado.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvEmpleado.CurrentRow.Cells[5].Value.ToString();
            txtRnc.Text = dgvEmpleado.CurrentRow.Cells[6].Value.ToString();
            txtCodigo.Clear();
            ValidarCampo();
        }
        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtApellido.Text) &&
                !string.IsNullOrEmpty(txtCedula.Text) &&
                !string.IsNullOrEmpty(txtTelefono.Text) &&
                  !string.IsNullOrEmpty(txtDireccion.Text) &&
                !string.IsNullOrEmpty(txtRnc.Text);
            btnActualizar.Enabled = vr;
            btnEliminar.Enabled = vr;
        }

        private void Filrar(object sender, EventArgs e)
        {
            spFiltrar.FiltradoDatos("sp_FiltrarCliente", "@Randon", txtCodigo.Text, dgvEmpleado);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.iD = Convert.ToInt32(txtId.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.Cedula = txtCedula.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.RNC = txtRnc.Text;

            int num = spActualizar.Actualizar("sp_ActualizarCliente", cliente);

            if (num > 0)
            {
                Limpiar.Limpia(gbControles);
                FrmMantenimientoCliente_Load(null, null);
                MessageBox.Show("Proceso realizado satisfactoriamente");
            }
            else
            {
                MessageBox.Show("Hubo en error en proceso");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.iD = Convert.ToInt32(txtId.Text);


            int num = spEliminar.Eliminar("sp_EliminarCliente", cliente);

            if (num > 0)
            {
                Limpiar.Limpia(gbControles);
                FrmMantenimientoCliente_Load(null, null);
                MessageBox.Show("Proceso realizado satisfactoriamente");
            }
            else
            {
                MessageBox.Show("Hubo en error en proceso");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar.Limpia(gbControles);
            FrmMantenimientoCliente_Load(null, null);
        }
    }
}
