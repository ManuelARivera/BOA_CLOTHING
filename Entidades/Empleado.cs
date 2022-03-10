using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOA_CLOTHING.Entidades
{
    class Empleado
    {
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _cargo;
        private string _usuario;
        private string _passwords;

        public string Nombre
        {
            get { return _nombre;  }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string Passwords
        {
            get { return _passwords; }
            set { _passwords = value; }
        }

    }
}
