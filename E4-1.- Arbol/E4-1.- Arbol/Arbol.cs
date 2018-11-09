using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1.__Arbol
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

        public void Insertar(int info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
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
                Console.Write(reco.info + " ");
                ImprimirPre(reco.izq);
                ImprimirPre(reco.der);
            }
        }

        public void ImprimirPre()//manda a llamar el metodo recursivo
        {
            ImprimirPre(raiz);//imprime el elemento raiz
            Console.WriteLine();
        }

        private void ImprimirEntre(Nodo reco)//se imprime todos los elementos 
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.info + " ");
                ImprimirEntre(reco.der);
            }
        }

        public void ImprimirEntre()//manda a llamar el metodo recursivo
        {
            ImprimirEntre(raiz);//metodo que imprime el elemento en la parte inferior izquierda
            Console.WriteLine();
        }


        private void ImprimirPost(Nodo reco)//metodo recursivo que se usa para imprimir en pos-orden
        {
            if (reco != null)
            {
                ImprimirPost(reco.izq);
                ImprimirPost(reco.der);
                Console.Write(reco.info + " ");
            }
        }


        public void ImprimirPost()//metodo que llama el metodo recursivo ImprimirPost
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }
    }
}
