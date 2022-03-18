using LaboratorioNo5.Entidades;
using System;
using BOA_CLOTHING.Entidades.SP;
using BOA_CLOTHING.Entidades;
using BOA_CLOTHING.BaseDatos;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BOA_CLOTHING.Formularios
{
    public partial class FrmMercancia : Form
    {
        public FrmMercancia()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            btnCrear.Enabled = false;
        }

        private void ValidarCampo()
        {
            var vr = !string.IsNullOrEmpty(txtTipo.Text) &&
                !string.IsNullOrEmpty(txtMarca.Text) &&
                !string.IsNullOrEmpty(txtPrecio.Text) &&
                !string.IsNullOrEmpty(txtStock.Text);
            btnCrear.Enabled = vr;

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Mercancia mr = new Mercancia();

            try
            {
                if (spValidar.Existe("sp_ValidarColaborador", txtidMercancia.Text).Equals(false))
                {
                    mr.Codigo = txtidMercancia.Text;
                    mr.Tipo = txtTipo.Text;
                    mr.Marca = txtMarca.Text;
                    mr.Precio = Convert.ToDecimal(txtPrecio.Text);
                    mr.Descripcion = txtDescripcion.Text;
                    mr.Stock = Convert.ToInt32(txtStock.Text);

                    int num =  spInsertar.Insertar("sp_InsertarMercancia", mr); 

                    if(num > 0)
                    {
                        MessageBox.Show("Los datos fueron insertado satisfactoriamente");
                        Limpiar.Limpia(gbControles);
                    }
                }
                else
                {
                    MessageBox.Show("El código introducido se encuentra registrada en nuestra base de datos");
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
