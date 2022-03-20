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
    public partial class FrmMatenimientoEmpleado : Form
    {
        public FrmMatenimientoEmpleado()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMatenimientoEmpleado_Load(object sender, EventArgs e)
        {
            spMostrarGrilla.LeerGrilla("sp_MostrarEmpleado", dgvEmpleado);
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
            txtPuesto.Text = dgvEmpleado.CurrentRow.Cells[5].Value.ToString(); 
            txtCodigo.Clear();
            ValidarCampo();
        }
        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtNombre.Text) &&
                !string.IsNullOrEmpty(txtApellido.Text) &&
                !string.IsNullOrEmpty(txtCedula.Text) &&
                !string.IsNullOrEmpty(txtTelefono.Text) &&
                !string.IsNullOrEmpty(txtPuesto.Text);
           btnActualizar.Enabled = vr;
            btnEliminar.Enabled = vr;
        }

        private void Filtrar(object sender, EventArgs e)
        {
            spFiltrar.FiltradoDatos("sp_FiltrarEmpleado", "@Randon", txtCodigo.Text, dgvEmpleado);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            empleado.iD = Convert.ToInt32(txtId.Text);             
            empleado.Nombre = txtNombre.Text;
            empleado.Apellido = txtApellido.Text;
            empleado.Cedula = txtCedula.Text;
            empleado.Cargo = txtPuesto.Text;
            empleado.Telefono = txtTelefono.Text;

            int num = spActualizar.Actualizar("sp_ActualizarEmpleado", empleado);

            if (num > 0)
            {
                Limpiar.Limpia(gbControles);
                FrmMatenimientoEmpleado_Load(null, null);
                MessageBox.Show("Proceso realizado satisfactoriamente");
            }
            else
            {
                MessageBox.Show("Hubo en error en proceso");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.iD = Convert.ToInt32(txtId.Text);


            int num = spEliminar.Eliminar("sp_EliminarEmpleado", empleado);

            if (num > 0)
            {
                Limpiar.Limpia(gbControles);
                FrmMatenimientoEmpleado_Load(null, null);
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
            FrmMatenimientoEmpleado_Load(null, null);
        }
    }
}
