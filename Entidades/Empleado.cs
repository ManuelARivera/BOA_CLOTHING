using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOA_CLOTHING.Entidades
{
    class Empleado : Persona
    {
        private string _cargo;
        private string _usuario;
        private string _passwords;

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
