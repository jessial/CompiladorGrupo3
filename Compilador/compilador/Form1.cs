using compilador.AnalisisLexico;
using System.Threading;
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
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace compilador
{
    public partial class Form1 : Form
    {
        private static Form1 Form;

        public static Form1 getInstance()
        {
            if (Form == null || Form.IsDisposed)
            {
                Form = new Form1();
        
            }
            return Form;
        }
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
            while (!componente.Lexema.Equals("@EOF@"))
            {
                anaLex.Puntero = componente.PosicionFinalLinea + 1;
                anaLex.estadoActual = 0;
                componente = anaLex.Analizar();
            }

        }
        public void errores(Error error)
        {
            dataGridView1.Rows.Add(error.lexema,error.MensajeError,error.numerolinea,error.posicionInicialLinea,error.posicionFinalLinea,error.TipoError);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void datos(ComponenteLexico data)
        {
            dataGridView2.Rows.Add(data.Lexema, data.NumeroLinea, data.Categoria, data.PosicionInicialLinea, data.PosicionFinalLinea);
        }

        private void codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo.ResetText();
            resultado.ResetText();
            dataGridView2.Rows.Clear();
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }
    }
}
