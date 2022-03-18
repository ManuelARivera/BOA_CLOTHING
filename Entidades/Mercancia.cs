using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOA_CLOTHING.Entidades
{
    class Mercancia
    {
        private string _codigo;
        private string _tipo;
        private string _marca;
        private decimal _precio;
        private string _descripcion;
        private int _stock;
        private int _ventas;

        public Mercancia()
        {
            _ventas = 0;
        }

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public int Ventas
        {
            get { return _ventas; }
            set { _ventas = value; }
        }
    }
}
