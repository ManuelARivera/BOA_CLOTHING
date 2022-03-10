using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOA_CLOTHING.Entidades.SP;
using LaboratorioNo5.Entidades;

namespace BOA_CLOTHING.Formularios
{
    public partial class FrmNuevaVenta : Form
    {
        public FrmNuevaVenta()
        {
            InitializeComponent();
            
        }
        string[,] ListaVenta = new string[200, 100];
        int Fila = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int idM = Convert.ToInt32(txtidMercancia.Text);
                if (spValidar.Existe("sp_ValidarMercancia", idM).Equals(true))
                {
                    DataTable table = spBuscarMercancia.OptenerDatos(idM);

                    lblTipo.Text = table.Rows[0][0].ToString();
                    lblPrecio.Text = table.Rows[0][1].ToString();
                    btnCargarLista.Enabled = true;
                }
                else
                {
                    MessageBox.Show("idMercancia no encontrado.\nfavor validar idMercancia");
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCantidad.Text != "") 
                {
             
                    ListaVenta[Fila, 0] = txtidMercancia.Text;
                    ListaVenta[Fila, 1] = lblTipo.Text;
                    ListaVenta[Fila, 2] = lblPrecio.Text;
                    ListaVenta[Fila, 3] = txtCantidad.Text;
                    ListaVenta[Fila, 4] = (float.Parse(lblPrecio.Text)*int.Parse(txtCantidad.Text)).ToString();

                    dgvLista.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2], ListaVenta[Fila, 3], ListaVenta[Fila, 4]);
                    Fila++;
                    CostoPagar();
                    Limpiar.Limpia(gbControles);
                }
                else
                {
                    MessageBox.Show("La cadena de entrada no tiene el formato correcto");
                }

            }
            catch
            {

            }

           
        }

        private void CostoPagar()
        {
            float CostoTotal = 0;
            int conteo = 0;

            conteo = dgvLista.RowCount;

            for(int i = 0; i < conteo; i++ )
            {
                CostoTotal += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());
            }
            lblCostoApagar.Text = CostoTotal.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDevolucion.Text = (float.Parse(txtEfectivo.Text)- float.Parse(lblCostoApagar.Text)).ToString();
            }
            catch 
            {
                lblDevolucion.Text = "$ 0.00";
            }
        }
    }
}
