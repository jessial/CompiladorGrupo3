using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilador.AnalisisLexico
{
    public class ComponenteLexico
    {
        public int NumeroLinea { get; }
        public int PosicionInicialLinea { get; }
        public int PosicionFinalLinea { get; }
        public string Lexema { get; }
        public string Categoria { get; }

        private ComponenteLexico(int numeroLinea, int posicionInicialLinea, int posicionFinanlLinea, string lexema, string categoria )
        {
            NumeroLinea= numeroLinea;
            PosicionInicialLinea= posicionInicialLinea;
            PosicionFinalLinea = posicionFinanlLinea;
            Lexema = lexema;
            Categoria = categoria;
        }
        public static ComponenteLexico CREATE(int numeroLinea, int posicionInicialLinea, string lexema, string categoria)
        {
            return new ComponenteLexico(numeroLinea, posicionInicialLinea, (posicionInicialLinea + lexema.Length), lexema, categoria);
        }
    }

    }
//}

