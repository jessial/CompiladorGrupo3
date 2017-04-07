using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilador.AnalisisLexico
{
    class TablaSimbolos
    {
        private static TablaSimbolos INSTANCIA = new TablaSimbolos();
        private Dictionary<string, List<ComponenteLexico>> mapaSimbolos = new Dictionary<string, List<ComponenteLexico>>();
        private TablaSimbolos() { }

        public static TablaSimbolos obtenerTablaSimbolos()
        {
            return INSTANCIA;
        }

        public void AgregarSimbolo(ComponenteLexico componente)
        {
            if (mapaSimbolos.ContainsKey(componente.Lexema)) mapaSimbolos[componente.Lexema].Add(componente);
            else
            {
                List<ComponenteLexico> lista = new List<ComponenteLexico>();
                lista.Add(componente);
                mapaSimbolos.Add(componente.Lexema, lista);
            }
        }
        public List<ComponenteLexico> obtenerTablaDeSimbolos1()
        {
            List<ComponenteLexico> ArrayList = mapaSimbolos.Values.ToList().SelectMany(componenteLexico => componenteLexico).ToList();
            return ArrayList;
        }
    }
}
