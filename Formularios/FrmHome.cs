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

        private void btnOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Metodo para abrir los formularios Hijas en el panelContenedor
        //Primero verifica si tiene algun controls y en caso de que lo tenga, procede a eliminar
        //Se crea la instancia del formulario hija pasada por parametro la cual llamaremos fh y terminando mostandola
        private void AbrirFrmHija(object frmhija)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.RemoveAt(0);


            Form fh = frmhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(fh);
            panelContenedor.Tag = fh;
            fh.Show();
           

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FrmNuevaVenta());
        }

        private void btnMercancias_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FrmMercancia());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FrmCompra());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FrmEmpleado());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FrmCliente());
        }

        private void btnMatenimiento_Click(object sender, EventArgs e)
        {
            AbrirFrmHija(new FrmMantenimiento());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
           
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
