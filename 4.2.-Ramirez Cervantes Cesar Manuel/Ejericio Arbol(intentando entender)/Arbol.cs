using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Arbol
    {
        private Nodo raiz;
        private Nodo trabajo;
        private int count = 0;
        public Arbol()
        {
            raiz = new Nodo();
        }
        public Nodo Agregar(string dato, Nodo nodo)//metodo para agregar nodos al arbol
        {
            if(nodo == null)// si no hay nodo donde se va a insertar, entonces se toma como la raiz 
            {
                raiz = new Nodo();
                raiz.Dato = dato;
                raiz.Hijo = null;//por lo tanto no tiene nodos hijos 
                raiz.Hermano = null;//tampoco nodos hermanos
                return raiz;
            }
            if(nodo.Hijo == null)//verifica si no tiene nodo hijo y se inserta el dato como hijo
            {
                Nodo temp = new Nodo();
                temp.Dato = dato;
                nodo.Hijo = temp;// se agrega el nuevo nodo como nodo hijo
                return temp;
            }
            else // se ya se tiene un hijo, el dto se inserta como hermano 
            {
                trabajo = nodo.Hijo;
                while(trabajo.Hermano != null)//recorrido hasta el ultimo nodo hermano
                {
                    trabajo = trabajo.Hermano;
                }
                Nodo temp = new Nodo();// se crea un nodo temporal 
                temp.Dato = dato;
                trabajo.Hermano = temp;// para agregarlo al ultimo nodo hermano 
                return temp;
            }
        }
        public void Imprimir(Nodo nodo)//metodo para mostrar el arbol
        {
            if (nodo == null)
                return;

            for (int i = 0; i < count; i++)
            {
                Console.Write("----");
            }
            Console.WriteLine("[{0}]",nodo.Dato);
            if(nodo.Hijo != null)// si existe un hijo llamara a si mismo el metodo imprimir mandando como parametro el nodo hijo
            {
                count++;
                Imprimir(nodo.Hijo);
                count--;
            }
            if(nodo.Hermano != null)
            {
                Imprimir(nodo.Hermano);// si existe un hermano llamara a si mismo el metodo imprimir como parametro el nodo hermano
            }
        }
        public void Arbol1()
        {
            Arbol arbol = new Arbol();
            Nodo raiz = arbol.Agregar("E", null);//se agrega el nodo raiz 
            arbol.Agregar("F", raiz);//se agrega el nodo F como hijo del nodo raiz 

            Nodo subRaizA = arbol.Agregar("A", raiz);//se agrega el nodo A como hijo del nodo raiz, pero tambien como un raiz de un subarbol
            arbol.Agregar("B", subRaizA);//se le agrega a la subraiz A los 3 nodos hijos B, C, D
            arbol.Agregar("C", subRaizA);
            arbol.Agregar("D", subRaizA);

            arbol.Imprimir(raiz);
        }
        public void Arbol2()
        {
            Arbol arbol = new Arbol();
            Nodo raiz = arbol.Agregar("C", null);//se agrega el nodo raiz C
            arbol.Agregar("D", raiz);// se agregan los nodos D y F como hijos de la raiz
            arbol.Agregar("F", raiz);

            Nodo subRaizA = arbol.Agregar("A", raiz);// se agrega el nodo A como hijo de la raiz, pero tambien como raiz de un subarbol
            Nodo subRaizB = arbol.Agregar("B", subRaizA);// a su vez el nodo hijo de la subraiz A se agrega como otra subraiz 
            arbol.Agregar("E", subRaizB);//se agrega el nodo hijo a la subraiz B 
            arbol.Agregar("G", raiz);// se agrega el ultimo nodo hijo de la raiz 

            arbol.Imprimir(raiz);
        }
        public void Arbol3()
        {
            Arbol arbol = new Arbol();
            Nodo raiz = arbol.Agregar("K", null);// se agrega el nodo raiz K
            arbol.Agregar("B", raiz);//se agregan B, A y C como nodos hijos de la raiz 
            arbol.Agregar("A", raiz);
            arbol.Agregar("C", raiz);

            Nodo subRaizD = arbol.Agregar("D", raiz);// se agrega D como hijo de la raiz, pero tambien como raiz de un subarbol
            Nodo subRaizI = arbol.Agregar("I", subRaizD);// se agrega I como hijo de la subraiz D, pero tambien como raiz de un subarbol
            arbol.Agregar("J", subRaizI);// se agrega J como hijo del nodo I
            Nodo subRaizE = arbol.Agregar("E", subRaizD);// se agrega E como hijo del nodo D, pero tambien como raiz de un subarbol 
            arbol.Agregar("F", subRaizE);// se agrega F como hijo del nodo subraiz E 
            Nodo subRaizG = arbol.Agregar("G", subRaizE);// se agrega G como hijo del nodo E, pero tambien como raiz de un subarbol
            arbol.Agregar("H", subRaizG);// se agrega H como hijo del nodo G 

            arbol.Imprimir(raiz);
        }
    }
}
