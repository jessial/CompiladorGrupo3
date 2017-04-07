using compilador.AnalisisLexico;
using compilador.Transversal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compilador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void btnCompilarCod_Click(object sender, EventArgs e)
        {
            CacheArchivo.getInstance().limpiarLista();
            string[] linea = { };
            List<string> listaLineas = new List<string>();
            List<Linea> listaLineaOb = new List<Linea>();

            linea = codigo.Lines;
            for (int i = 0; i < linea.Length; i++)
            {
                string lineaCompleta = (i + 1).ToString() + "-> " + linea[i];
                listaLineas.Add(lineaCompleta);
                CacheArchivo.getInstance().adicionar(new Linea((i + 1), linea[i]));
                
            }

            resultado.Text = String.Join(Environment.NewLine, listaLineas);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CacheArchivo.getInstance().limpiarLista();
            openFileDialog1.Filter = "Archivos txt| *.txt";
            openFileDialog1.FileName = "Seleccione un archivo de Texto";
            openFileDialog1.Title = "Lector De Archivo De Texto";
            openFileDialog1.InitialDirectory = "C:/";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textArchivo.Text = openFileDialog1.FileName;
            }

            try
            {
                StreamReader sr = new StreamReader(@textArchivo.Text, System.Text.Encoding.Default);
                string linea = "";
                List<string> listaLineas = new List<string>();
                int cantidadLineas = 1;

                while (linea != null)
                {
                    linea = sr.ReadLine();
                    if (linea != null)
                    {
                        string lineaCompleta = cantidadLineas.ToString() + "-> " + linea;
                        listaLineas.Add(lineaCompleta);
                        CacheArchivo.getInstance().adicionar(new Linea(cantidadLineas, linea));
                        cantidadLineas++;
                    }
                }

                sr.Close();
                resultado.Text = String.Join(Environment.NewLine, listaLineas);
            }
            catch (Exception)
            {
                Console.WriteLine("El archivo no se puede leer");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnalizadorLexico anaLex = new AnalizadorLexico();
            ComponenteLexico componente = anaLex.Analizar();
            //MessageBox.Show(componente.Lexema + "->" + componente.Categoria);
            while (!componente.Lexema.Equals("@EOF@"))
            {
                //MessageBox.Show(componente.Lexema + "->" + componente.Categoria);
                anaLex.Puntero = componente.PosicionFinalLinea + 1;
                anaLex.estadoActual = 0;
                componente = anaLex.Analizar();
            }
            int fila = 0;
            foreach (ComponenteLexico element in TablaSimbolos.obtenerTablaSimbolos().obtenerTablaDeSimbolos1())
            {
                int renglon = dataGridView2.Rows.Add();
                dataGridView2.Rows[fila].Cells["Lexema"].Value = TablaSimbolos.obtenerTablaSimbolos().obtenerTablaDeSimbolos1()[fila].Lexema;
                dataGridView2.Rows[fila].Cells["NumeroLinea"].Value = TablaSimbolos.obtenerTablaSimbolos().obtenerTablaDeSimbolos1()[fila].NumeroLinea;
                dataGridView2.Rows[fila].Cells["Categoria"].Value = TablaSimbolos.obtenerTablaSimbolos().obtenerTablaDeSimbolos1()[fila].Categoria;
                dataGridView2.Rows[fila].Cells["PosicionInicial"].Value = TablaSimbolos.obtenerTablaSimbolos().obtenerTablaDeSimbolos1()[fila].PosicionInicialLinea;
                dataGridView2.Rows[fila].Cells["PosicionFinal"].Value = TablaSimbolos.obtenerTablaSimbolos().obtenerTablaDeSimbolos1()[fila].PosicionFinalLinea;
                fila++;
            }

            int fila1 = 0;
            foreach (Error element in ManejadorErrores.ObtenerManejadorErrores().ObtenerErroresCompletos())
            {
                int renglon2 = dataGridView1.Rows.Add();
                dataGridView1.Rows[fila1].Cells["ValorRecibido"].Value = ManejadorErrores.ObtenerManejadorErrores().ObtenerErroresCompletos()[fila1].lexema;
                dataGridView1.Rows[fila1].Cells["Descripcion"].Value = ManejadorErrores.ObtenerManejadorErrores().ObtenerErroresCompletos()[fila1].MensajeError;
                dataGridView1.Rows[fila1].Cells["NumeroDeLinea"].Value = ManejadorErrores.ObtenerManejadorErrores().ObtenerErroresCompletos()[fila1].numerolinea;
                dataGridView1.Rows[fila1].Cells["PosicionInicialError"].Value = ManejadorErrores.ObtenerManejadorErrores().ObtenerErroresCompletos()[fila1].posicionInicialLinea;
                dataGridView1.Rows[fila1].Cells["PosicionFinalError"].Value = ManejadorErrores.ObtenerManejadorErrores().ObtenerErroresCompletos()[fila1].posicionFinalLinea;
                dataGridView1.Rows[fila1].Cells["TipoError"].Value = ManejadorErrores.ObtenerManejadorErrores().ObtenerErroresCompletos()[fila1].TipoError;
                fila1++;
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
