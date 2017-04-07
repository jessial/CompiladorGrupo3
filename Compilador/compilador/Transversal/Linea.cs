using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilador.Transversal
{
    public class Linea
    {
        public int Numero { get; }
        public string Contenido { get; }

        public Linea(int numero, string contenido)
        {
            this.Numero = numero;
            this.Contenido = contenido;
        }
        public static Linea create(int numero, string contenido)
        {
            return new Linea(numero, contenido);
        }
        
    }
}
