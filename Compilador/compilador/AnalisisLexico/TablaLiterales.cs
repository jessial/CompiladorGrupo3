using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilador.AnalisisLexico
{
    class TablaLiterales
    {
        private static TablaLiterales INSTANCIA = new TablaLiterales();
        private Dictionary<string, List<ComponenteLexico>> mapaLiterales = new Dictionary<string, List<ComponenteLexico>>();
        private TablaLiterales() { }

        public static TablaLiterales obtenerTablaLiterales()
        {
            return INSTANCIA;
        }

        public void AgregarLiteral(ComponenteLexico componente)
        {
            if (mapaLiterales.ContainsKey(componente.Lexema)) mapaLiterales[componente.Lexema].Add(componente);
            else
            {
                List<ComponenteLexico> lista = new List<ComponenteLexico>();
                lista.Add(componente);
                mapaLiterales.Add(componente.Lexema, lista);
            }
        }
        public List<ComponenteLexico> obtenerTablaLiterales1()
        {
            List<ComponenteLexico> ArrayList = mapaLiterales.Values.ToList().SelectMany(componenteLexico => componenteLexico).ToList();
            return ArrayList;
        }
    }
}

