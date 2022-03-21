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

namespace BOA_CLOTHING.Formularios.Formularios_Resportes
{
    public partial class FrmReportesStockMercancia : Form
    {
        public FrmReportesStockMercancia()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Filtrar(object sender, EventArgs e)
        {
            spFiltrar.FiltradoDatos("sp_FiltrarMercancia", "@idMercancia", txtCodigo.Text, dgvMercancia);
        }

        private void FrmReportesStockMercancia_Load(object sender, EventArgs e)
        {
            spMostrarGrilla.LeerGrilla("sp_MostrarMercanciaReporte", dgvMercancia);
        }
    }
}
