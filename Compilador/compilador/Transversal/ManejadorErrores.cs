using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compilador.Transversal
{
    class ManejadorErrores
    {
        private Dictionary<string, List<Error>> mapaErrores = new Dictionary<string, List<Error>>();
        private static ManejadorErrores INSTANCIA = new ManejadorErrores();
        private ManejadorErrores()
        {
            mapaErrores.Add("LEXICO", new List<Error>());
            mapaErrores.Add("SINTACTICO", new List<Error>());
            mapaErrores.Add("SEMANTICO", new List<Error>());
        }

        public static ManejadorErrores ObtenerManejadorErrores()
        {
            return INSTANCIA;
        }
        public void AgregarError(Error error)
        {
            if (error != null && mapaErrores.ContainsKey(error.TipoError)) mapaErrores[error.TipoError].Add(error);

        }

        public Boolean HayErrores(string TipoError)
        {
            return (mapaErrores.ContainsKey(TipoError) && mapaErrores[TipoError].Count > 0);
        }
        public List<Error> ObtenerErroresCompletos()
        {
            return mapaErrores.Values.SelectMany(e => e).ToList();
        }
    }
}
