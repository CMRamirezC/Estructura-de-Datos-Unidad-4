using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Arbol_2
{
    class Arbol
    {
        class Nodo
        {
            public int info;
            public Nodo izq, der;
        }
        Nodo raiz;
        public Arbol()
        {
            raiz = null;
        } 
        public void Insertar(char caracter)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            int info = Convert.ToInt32(caracter);
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, reco;            
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.info)
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }
        private void ImprimirPre(Nodo reco)
        {
            if (reco != null)
            {
                Console.Write(Convert.ToChar(reco.info) + " ");
                ImprimirPre(reco.izq);
                ImprimirPre(reco.der);
            }
        }
        public void ImprimirPre()//manda a llamar el metodo recursivo
        {
            ImprimirPre(raiz);//imprime el elemento raiz
            Console.WriteLine();
        }
        private void ImprimirPost(Nodo reco)//metodo recursivo que se usa para imprimir en pos-orden
        {
            if (reco != null)
            {
                ImprimirPost(reco.izq);
                ImprimirPost(reco.der);
                Console.Write(Convert.ToChar(reco.info) + " ");
            }
        }
        public void ImprimirPost()//metodo que llama el metodo recursivo ImprimirPost
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }
    }
}
