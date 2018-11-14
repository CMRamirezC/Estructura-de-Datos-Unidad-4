using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Nodo
    {
        private string dato;
        private Nodo hijo;
        private Nodo hermano;
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Hijo
        {
            get { return hijo; }
            set { hijo = value; }
        }
        public Nodo Hermano
        {
            get { return hermano; }
            set { hermano = value; }
        }
        public Nodo()
        {
            dato = "";
            hijo = null;
            hermano = null;
        }
    }
}
