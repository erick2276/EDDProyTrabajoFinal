using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDato.Text) || !int.TryParse(txtDato.Text, out int dato))
            {
                MessageBox.Show("Introduce un número válido.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            miRaiz = miArbol.RegresaRaiz();
            miArbol.strArbol = "";

            miArbol.InsertaNodo(dato, ref miRaiz);

            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            stopwatch.Stop();

            MessageBox.Show($"El dato {dato} fue insertado en el árbol.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");

            txtDato.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            miArbol = new ArbolBusqueda();
            miRaiz = null;
            txtArbol.Text = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";

            stopwatch.Stop();

            MessageBox.Show($"El árbol fue limpiado.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();


            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }
            stopwatch.Start();
            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");

            Bitmap bm = FileDotEngine.Run(b.ToString());

            stopwatch.Stop();

            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();

            MessageBox.Show($"La gráfica fue generada.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();


            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El árbol está vacío";
                return;
            }
            stopwatch.Start();
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);
            lblRecorridoPreOrden.Text = miArbol.strRecorrido;

            miArbol.strRecorrido = "";
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;

            miArbol.strRecorrido = "";
            lblRecorridoPostOrden.Text = "";
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;

            stopwatch.Stop();

            MessageBox.Show($"Los recorridos fueron completados.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();


            miArbol = new ArbolBusqueda();
            miRaiz = null;
            txtArbol.Text = "";
            txtDato.Text = "";
            stopwatch.Start();
            Random rnd = new Random();
            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                miRaiz = miArbol.RegresaRaiz();
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            stopwatch.Stop();

            MessageBox.Show($"El arbol fue creado con {txtNodos.Value} nodos.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDato.Text) || !int.TryParse(txtDato.Text, out int valor))
            {
                MessageBox.Show("Introduce un número válido para buscar.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();


            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }
            stopwatch.Start();
            bool encontrado = miArbol.BuscaNodo(valor, miRaiz);

            stopwatch.Stop();

            if (encontrado)
            {
                MessageBox.Show($"El valor {valor} fue encontrado en el arbol.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
            }
            else
            {
                MessageBox.Show($"El valor {valor} no fue encontrado en el arbol.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
            }

            txtDato.Text = "";
        }

        private void btnAlturaArbol_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();


            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }
            stopwatch.Start();
            int altura = miArbol.altura(miRaiz);

            stopwatch.Stop();

            MessageBox.Show($"La altura del arbol es: {altura}.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        private void btnCantidadHojas_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();


            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }
            stopwatch.Start();
            int cantidadHojas = miArbol.cantidadHojas(miRaiz);

            stopwatch.Stop();

            MessageBox.Show($"La cantidad de hojas es de: {cantidadHojas}.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        private void btnCantidadNodos_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();


            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }
            stopwatch.Start();
            int cantidadNodos = miArbol.cantidadNodos(miRaiz);

            stopwatch.Stop();

            MessageBox.Show($"La cantidad de nodos es de: {cantidadNodos}.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
        }

        private void btnEliminarPredecesor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDato.Text) || !int.TryParse(txtDato.Text, out int dato))
            {
                MessageBox.Show("coloque un numero  para eliminar el predecesor.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();


            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }
            stopwatch.Start();
            bool eliminado = miArbol.eliminarPre(dato, ref miRaiz);

            stopwatch.Stop();

            if (eliminado)
            {
                MessageBox.Show($"El predecesor del nodo con dato el {dato} fue eliminado.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
            }
            else
            {
                MessageBox.Show($"No se encontro el dato {dato} en el arbol.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
            }

            txtDato.Text = "";
        }

        private void btnEliminarSucesor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDato.Text) || !int.TryParse(txtDato.Text, out int Dato))
            {
                MessageBox.Show("coloque un número para eliminar el sucesor.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();


            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }
            stopwatch.Start();
            bool eliminado = miArbol.eliminarSucesor(Dato, ref miRaiz);

            stopwatch.Stop();

            if (eliminado)
            {
                MessageBox.Show($"El sucesor del nodo con el valor {Dato} fue eliminado.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
            }
            else
            {
                MessageBox.Show($"No se encontro el valor {Dato} en el árbol.\nTiempo transcurrido: {stopwatch.Elapsed.TotalMilliseconds} ms");
            }

            txtDato.Text = "";
        }
    }
}

 