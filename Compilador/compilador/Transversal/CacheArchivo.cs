using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compilador.Transversal
{
   public class CacheArchivo
    {
        private static CacheArchivo cacheArchivo = new CacheArchivo();
        private List<Linea> listaLineas = new List<Linea>();

        private CacheArchivo() { }

        public static CacheArchivo getInstance()
        {
            return cacheArchivo;
        }

        public void adicionar (Linea linea)
        {
            listaLineas.Add(linea);
        }
        public Linea obtenerLinea(int numeroLinea )
        {
            Linea lineaRespuesta = null;
            if (listaLineas.Count > 0 && listaLineas.Count > numeroLinea)
                lineaRespuesta = listaLineas.ElementAt(numeroLinea);
            else
                lineaRespuesta = new Linea(numeroLinea + 1, "@EOF@");

            return lineaRespuesta;
        }
        public void limpiarLista()
        {
            listaLineas.Clear();
        }
    }
}
