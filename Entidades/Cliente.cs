using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOA_CLOTHING.Entidades
{
    class Cliente : Persona
    {
        private string _direccion;
        private string _rnc;
    

        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public string RNC
        {
            get { return _rnc; }
            set { _rnc = value; }
        }
 
    }

}
