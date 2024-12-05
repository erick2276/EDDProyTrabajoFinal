using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//nota 3
namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";

        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (BuscaNodo(Dato, Raiz))
            {
                MessageBox.Show($"El valor {Dato} ya existe en el arbol.");
                return;
            }
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);


                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }
                      
        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }
        public bool BuscaNodo(int valor, NodoBinario nodo)
        {
            if (nodo == null) return false;
            if (valor == nodo.Dato) return true;
            if (valor < nodo.Dato) return BuscaNodo(valor, nodo.Izq);
            return BuscaNodo(valor, nodo.Der);
        }

        public int altura(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }

            int alturaIzq = altura(nodo.Izq);
            int alturaDer = altura(nodo.Der);

            return Math.Max(alturaIzq, alturaDer) + 1;
        }
        public int cantidadHojas(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            if (nodo.Izq == null && nodo.Der == null)
            {
                return 1;
            }

            return cantidadHojas(nodo.Izq) + cantidadHojas(nodo.Der);
        }

        public int cantidadNodos(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            return 1+cantidadNodos(nodo.Izq) + cantidadNodos(nodo.Der);
        }

        public bool eliminarPre(int Dato, ref NodoBinario nodo)
        {
            if (nodo == null) return false;

            if (Dato < nodo.Dato)
            {
                return eliminarPre(Dato, ref nodo.Izq);
            }
            else if (Dato > nodo.Dato)
            {
                return eliminarPre(Dato, ref nodo.Der);
            }
            else
            {
                if (nodo.Izq != null)
                {
                    NodoBinario predecesor = nodo.Izq;
                    NodoBinario padrePredecesor = nodo; 

                    while (predecesor.Der != null)
                    {
                        padrePredecesor = predecesor;
                        predecesor = predecesor.Der;
                    }

                    nodo.Dato = predecesor.Dato;

                    if (padrePredecesor.Izq == predecesor)
                        padrePredecesor.Izq = predecesor.Izq;
                    else
                        padrePredecesor.Der = predecesor.Izq;

                    return true;
                }
                else
                {
                    nodo = (nodo.Der != null) ? nodo.Der : null;
                    return true;
                }
            }

        }

        public bool eliminarSucesor(int Dato, ref NodoBinario nodo)
        {
            if (nodo == null) return false;

            if (Dato < nodo.Dato)
            {
                return eliminarSucesor(Dato, ref nodo.Izq);
            }
            else if (Dato > nodo.Dato)
            {
                return eliminarSucesor(Dato, ref nodo.Der);
            }
            else
            {
                if (nodo.Der != null)
                {
                    NodoBinario sucesor = nodo.Der;
                    NodoBinario padreSucesor = nodo;

                    while (sucesor.Izq != null)
                    {
                        padreSucesor = sucesor;
                        sucesor = sucesor.Izq;
                    }

                    nodo.Dato = sucesor.Dato;

                    if (padreSucesor.Der == sucesor)
                        padreSucesor.Der = sucesor.Der;
                    else
                        padreSucesor.Izq = sucesor.Der;

                    return true;
                }
                else
                {
                    nodo = (nodo.Izq != null) ? nodo.Izq : null;
                    return true;
                }
            }
        }
    }

}


