using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BOA_CLOTHING.Formularios.Formularios_Resportes;

namespace BOA_CLOTHING.Formularios
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnOff_Click(object sender, EventArgs e) { Application.Exit(); }

        private void AbrirFrmHija(object frmhija)
        {
            Form fh = frmhija as Form;        
            fh.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e) { AbrirFrmHija(new FrmNuevaVenta()); }

        private void btnMercancias_Click(object sender, EventArgs e) { AbrirFrmHija(new FrmMercancia()); }

        private void btnCompras_Click(object sender, EventArgs e) { AbrirFrmHija(new FrmCompra()); }

        private void btnEmpleados_Click(object sender, EventArgs e) { AbrirFrmHija(new FrmEmpleado()); }

        private void btnClientes_Click(object sender, EventArgs e) { AbrirFrmHija(new FrmCliente()); }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void panelContenedorColor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMatenimiento_Click(object sender, EventArgs e)
        {
            panelSubmenuManteimiento.Visible = true;
        }

        private void btnM_Empleado_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FrmMatenimientoEmpleado());
        }

        private void btnM_Cliente_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FrmMantenimientoCliente());
        }

        private void btnM_Mercancia_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FrmMantenimientoMercancia());
        }

        private void btnM_Facturas_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FrmMantenimientoFactura());
        } 

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panelSubmenuManteimiento.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            panelSubmenuReportes.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            panelSubmenuReportes.Visible = true;
        }

        private void btnR_Ventas_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FrmReportesVentas());
        }

        private void btnR_StockProducto_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FrmReportesStockMercancia());
        }

    }
}
