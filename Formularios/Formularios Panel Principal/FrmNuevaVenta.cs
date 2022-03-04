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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idM = Convert.ToInt32(txtidMercancia.Text);
            if (spValidar.Existe("sp_ValidarMercancia", idM).Equals(true))
            {   
                DataTable table = spBuscarMercancia.OptenerDatos(idM);

                lblTipo.Text = table.Rows[0][0].ToString();
                lblPrecio.Text = table.Rows[0][1].ToString(); 
            }
            else
            {
                MessageBox.Show("idMercancia no encontrado.\nfavor validar idMercancia");
            }
        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            Limpiar.Limpia(gbControles);
        }
    }
}
