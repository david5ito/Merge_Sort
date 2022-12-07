using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordenamiento_Mezcla_Natural
{
    class Operacion_Mezcla
    {

        public Operacion_Mezcla()
        {

        }

        int comparaciones = 0, fusiones = 0;

        public void Mostrar(ListView lista, int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                lista.Items.Add(vector[i].ToString());
            }
        }


        public int[] MezclaNatural(int[] arreglo)
        {
            int izquierda = 0, izq = 0, derecha = arreglo.Length - 1, der = derecha;
            bool ordenado = false;

            do
            {
                ordenado = true;
                izquierda = 0;
                while (izquierda < derecha)
                {
                    izq = izquierda;
                    while (izq < derecha && arreglo[izq] <= arreglo[izq + 1])
                    {
                        izq++;
                    }
                    der = izq + 1;
                    while (der == derecha-1 ||der < derecha && arreglo[der] <= arreglo[der + 1])
                    {
                        der++;
                    }
                    if (der <= derecha)
                    {
                        MezclaDirecta(arreglo);
                        ordenado = false;
                    }
                    izquierda = izq;
                }
            } while (!ordenado);
            return arreglo;
        }

        public int[] MezclaDirecta(int[] arreglo)
        {
            //inicializar en ceros
            fusiones = 0;
            comparaciones = 0;

            int i, j, k;
            if (arreglo.Length > 1)
            {
                int nElementosIzq = arreglo.Length / 2;
                int nElementosDer = arreglo.Length - nElementosIzq;
                int[] arregloIzq = new int[nElementosIzq];
                int[] arregloDer = new int[nElementosDer];

                //copiado de elementos al arreglo izquierdo
                for (i = 0; i < nElementosIzq; i++)
                {
                    arregloIzq[i] = arreglo[i];
                }
                //copiado de elementos al arreglo derecho
                for (i = nElementosIzq; i < (nElementosIzq + nElementosDer); i++)
                {
                    arregloDer[i - nElementosIzq] = arreglo[i];
                }
                //Recursividad
                arregloIzq = MezclaDirecta(arregloIzq);
                arregloDer = MezclaDirecta(arregloDer);
                i = 0; j = 0; k = 0;

                while (arregloIzq.Length != j && arregloDer.Length != k)
                {
                    if (arregloIzq[j] < arregloDer[k])
                    {
                        arreglo[i] = arregloIzq[j];
                        i++; j++;
                        comparaciones++;
                    }
                    else
                    {
                        arreglo[i] = arregloDer[k];
                        i++; k++;
                        comparaciones++;
                    }
                }

                //Arreglo final
                while (arregloIzq.Length != j)
                {
                    arreglo[i] = arregloIzq[j];
                    i++; j ++;
                }
                while (arregloDer.Length != k)
                {
                    arreglo[i] = arregloDer[k];
                    i++; k++;
                }
            }
            fusiones++;
            //Fin del if
            return arreglo;
        }

        public int[] MergeSortDes(int[] arreglo)
        {
            fusiones = 0;
            comparaciones = 0;

            if (arreglo.Length > 1)
            {
                int i, j, k;
                int nElementosIzq = arreglo.Length / 2;
                int nElementosDer = arreglo.Length - nElementosIzq;
                int[] arregloIzq = new int[nElementosIzq];
                int[] arregloDer = new int[nElementosDer];

                //copiado de elementos al arreglo izquierdo
                for (i = 0; i < nElementosIzq; i++)
                {
                    arregloIzq[i] = arreglo[i];
                }
                //copiado de elementos al arreglo derecho
                for (i = nElementosIzq; i < (nElementosIzq + nElementosDer); i++)
                {
                    arregloDer[i - nElementosIzq] = arreglo[i];
                }
                //Recursividad
                arregloIzq = MergeSortDes(arregloIzq);
                arregloDer = MergeSortDes(arregloDer);
                i = 0; j = 0; k = 0;

                while (arregloIzq.Length != j && arregloDer.Length != k)
                {
                    if (arregloIzq[j] > arregloDer[k])
                    {
                        arreglo[i] = arregloIzq[j];
                        i++; j++;
                        comparaciones++;
                    }
                    else
                    {
                        arreglo[i] = arregloDer[k];
                        i++; k++;
                        comparaciones++;
                    }
                }

                //Arreglo final
                while (arregloIzq.Length != j)
                {
                    arreglo[i] = arregloIzq[j];
                    i++; j++;
                }
                while (arregloDer.Length != k)
                {
                    arreglo[i] = arregloDer[k];
                    i++; k++;
                }
                fusiones++;
            }
            return arreglo;
        }

        public string DatosEstadisticos()
        {
            string datos = ("Comparaciones: " + comparaciones + "\n" + "Fusiones: " + fusiones);
            return datos;
        }
    }
}
