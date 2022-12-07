using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ordenamiento_Mezcla_Natural
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaraciones
        Operacion_Mezcla mezcla = new Operacion_Mezcla();
        int[] vector;

        public int[] Cargar(int n)
        {
            Random r = new Random();
            int valor;

            //Dar n elementos
            vector = new int[n];

            //Guardar datos en el arreglo
            for (int i = 0; i < n; i++)
            {
                valor = 0;
                valor = r.Next(1, 100);
                vector[i] = valor;
            }
            return vector;
        }
        

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int elementos = int.Parse(txtElementos.Text);
            Cargar(elementos);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lvwMostar.Clear();
            mezcla.Mostrar(lvwMostar, vector);
        }

        
        private void btnRecAsc_Click(object sender, EventArgs e)
        {
            var timer = new Stopwatch();
            timer.Start();
            lvwOrdenado.Clear();
            int[] a= mezcla.MezclaNatural(vector);
            mezcla.Mostrar(lvwOrdenado, a);
            lblEstadisticaNombre.Text = mezcla.DatosEstadisticos();

            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Tiempo: " + timeTaken.ToString(@"m\:ss\.fff");
            lblStadistica.Text = foo;
        }

        //Boton Recorrido MezclaNatural Descendente
        private void button3_Click(object sender, EventArgs e)
        {
            var timer = new Stopwatch();
            timer.Start();
            lvwOrdenado.Clear();
            int[] a = mezcla.MergeSortDes(vector);
            lblEstadisticaNombre.Text = mezcla.DatosEstadisticos();

            mezcla.Mostrar(lvwOrdenado, a);

            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Tiempo: " + timeTaken.ToString(@"m\:ss\.fff");
            lblStadistica.Text = foo;
        }

        private void btnRAscendenteDirecta_Click(object sender, EventArgs e)
        {
            var timer = new Stopwatch();
            timer.Start();
            lvwOrdenado.Clear();
            int[] a = mezcla.MezclaDirecta(vector);
            lblEstadisticaNombre.Text = mezcla.DatosEstadisticos();

            mezcla.Mostrar(lvwOrdenado, a);

            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Tiempo: " + timeTaken.ToString(@"m\:ss\.fff");
            lblStadistica.Text = foo;
        }

        private void btnRDescendenteDirecta_Click(object sender, EventArgs e)
        {
            var timer = new Stopwatch();
            timer.Start();
            lvwOrdenado.Clear();
            int[] a = mezcla.MergeSortDes(vector);
            lblEstadisticaNombre.Text = mezcla.DatosEstadisticos();

            mezcla.Mostrar(lvwOrdenado, a);

            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Tiempo: " + timeTaken.ToString(@"m\:ss\.fff");
            lblStadistica.Text = foo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvwOrdenado.Clear();
            lblEstadisticaNombre.Text = "--";
            lblStadistica.Text = "--";
        }
    }
}
