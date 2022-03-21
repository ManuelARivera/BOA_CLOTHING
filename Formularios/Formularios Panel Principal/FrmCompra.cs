using BOA_CLOTHING.Entidades;
using BOA_CLOTHING.Entidades.SP;
using System;
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
    public partial class FrmCompra : Form
    {
        private int _stock;
        private int _resultado;
        private int _cantidad;
        public FrmCompra()
        {
            InitializeComponent();
            _stock = 0;
            _resultado = 0;
            _cantidad = 0;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            btnAplicar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string Id = txtCodigo.Text;
                if (spValidar.Existe("sp_ValidarMercancia", Id).Equals(true))
                {
                    DataTable table = spBuscarMercancia.OptenerDatosCompra(Id);
                     
                    lblTipo.Text = table.Rows[0][0].ToString();
                    lblStock.Text = table.Rows[0][1].ToString();
                    _stock = Convert.ToInt32( table.Rows[0][1]);
                    btnAplicar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Código no encontrado.\nfavor validar idMercancia");
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            _cantidad = Convert.ToInt32(txtCantidad.Text);
            lblStock.Text = (_resultado = _stock + _cantidad).ToString();

            Mercancia mercancia = new Mercancia();
            mercancia.Codigo = txtCodigo.Text;
            mercancia.Stock = _resultado;
       
            int num = spActualizar.ActualizarCompra("sp_ActualizarMercanciaCompra", mercancia);

            if (num > 0)
            {
                MessageBox.Show("Proceso realizado satisfactoriamente");
            }
            else
            {
                MessageBox.Show("Hubo en error en proceso");
            }

        }
    }
}
