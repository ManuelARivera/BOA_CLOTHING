using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioNo5.Entidades
{
    class Limpiar
    {
        public static void Limpia(GroupBox gb)
        {
            foreach(var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear(); 
                }
            }
        }
        public static void Limpia2(GroupBox gb)
        {
            foreach (var combo in gb.Controls)
            {
                if (combo is TextBox)
                {
                    ((TextBox)combo).Clear();
                }
                if (combo is Label)
                {
                    ((Label)combo).Text = "...";
                }
            }
        }
    }
}
