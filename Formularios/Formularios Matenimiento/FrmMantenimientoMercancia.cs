using System;
using BOA_CLOTHING.Entidades.SP;
using BOA_CLOTHING.Entidades;
using BOA_CLOTHING.BaseDatos;
using LaboratorioNo5.Entidades;
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
    public partial class FrmMantenimientoMercancia : Form
    {
        public FrmMantenimientoMercancia()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMantenimientoMercancia_Load(object sender, EventArgs e)
        {
            spMostrarGrilla.LeerGrilla("sp_MostrarMercancia", dgvMercancia);
            SQLConnection.CerrarConexion();
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            txtidMercancia.Text = dgvMercancia.CurrentRow.Cells[0].Value.ToString();
            txtTipo.Text = dgvMercancia.CurrentRow.Cells[1].Value.ToString();
            txtMarca.Text = dgvMercancia.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dgvMercancia.CurrentRow.Cells[3].Value.ToString();
            txtDescripcion.Text = dgvMercancia.CurrentRow.Cells[4].Value.ToString();
            txtCodigo.Clear();
            ValidarCampo();
        }
        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtidMercancia.Text) &&
                !string.IsNullOrEmpty(txtTipo.Text) &&
                !string.IsNullOrEmpty(txtMarca.Text) &&
                !string.IsNullOrEmpty(txtPrecio.Text);
            btnActualizar.Enabled = vr;
            btnEliminar.Enabled = vr;

        }

        private void Filtrar(object sender, EventArgs e)
        {
         
            spFiltrar.FiltradoDatos("sp_FiltrarMercancia", "@idMercancia", txtCodigo.Text, dgvMercancia);
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Mercancia mercancia = new Mercancia();
            mercancia.Codigo = txtidMercancia.Text;
            mercancia.Tipo = txtTipo.Text;
            mercancia.Marca = txtMarca.Text;
            mercancia.Precio = Convert.ToDecimal(txtPrecio.Text);
            mercancia.Descripcion = txtDescripcion.Text;

            int num = spActualizar.Actualizar("sp_ActualizarMercancia", mercancia);

            if (num > 0)
            {
                Limpiar.Limpia(gbControles);
                FrmMantenimientoMercancia_Load(null, null);
                MessageBox.Show("Proceso realizado satisfactoriamente");
            }
            else 
            {
                MessageBox.Show("Hubo en error en proceso");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Mercancia mercancia = new Mercancia();
            mercancia.Codigo = txtidMercancia.Text;


            int num = spEliminar.Eliminar("sp_EliminarMercancia", mercancia);

            if (num > 0)
            {
                Limpiar.Limpia(gbControles);
                FrmMantenimientoMercancia_Load(null, null);
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
            FrmMantenimientoMercancia_Load(null, null);
        }
    }
}
