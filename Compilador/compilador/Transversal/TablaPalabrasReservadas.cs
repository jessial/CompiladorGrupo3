using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using compilador.AnalisisLexico;

namespace compilador.Transversal
{
    class TablaPalabrasReservadas
    {
        private static TablaPalabrasReservadas INSTANCIA = new TablaPalabrasReservadas();
        private Dictionary<string, ComponenteLexico> mapaPalabrasReservadas = new Dictionary<string, ComponenteLexico>();

        private TablaPalabrasReservadas() { Inicializar(); }
        public static TablaPalabrasReservadas obtenerTablaPalabrasReservadas()
        {
            return INSTANCIA;
        }

        private void Inicializar()
        {
            mapaPalabrasReservadas.Add("PARA", ComponenteLexico.CREATE(0, 0, "PARA", "PALABRA RESERVADA PARA"));
            mapaPalabrasReservadas.Add("DESDE", ComponenteLexico.CREATE(0, 0, "DESDE", "PALABRA RESERVADA DESDE"));
            mapaPalabrasReservadas.Add("HASTA", ComponenteLexico.CREATE(0, 0, "HASTA", "PALABRA RESERVADA HASTA"));
            mapaPalabrasReservadas.Add("EN", ComponenteLexico.CREATE(0, 0, "EN", "PALABRA RESERVADA EN"));
            mapaPalabrasReservadas.Add("INCREMENTOS", ComponenteLexico.CREATE(0, 0, "INCREMENTOS", "PALABRA RESERVADA INCREMENTOS"));
            mapaPalabrasReservadas.Add("DE", ComponenteLexico.CREATE(0, 0, "DE", "PALABRA RESERVADA DE"));
            mapaPalabrasReservadas.Add("CADA", ComponenteLexico.CREATE(0, 0, "CADA", "PALABRA RESERVADA CADA"));
            mapaPalabrasReservadas.Add("PASO", ComponenteLexico.CREATE(0, 0, "PASO", "PALABRA RESERVADA PASO"));
            mapaPalabrasReservadas.Add("HACER", ComponenteLexico.CREATE(0, 0, "HACER", "PALABRA RESERVADA HACER"));
            mapaPalabrasReservadas.Add("FIN", ComponenteLexico.CREATE(0, 0, "FIN", "PALABRA RESERVADA FIN"));
            mapaPalabrasReservadas.Add("DECREMENTOS", ComponenteLexico.CREATE(0, 0, "DECREMENTOS", "PALABRA RESERVADA DECREMENTOS"));

        }
        public Boolean EsPalabraReservada(string lexema)
        {
            return mapaPalabrasReservadas.ContainsKey(lexema);
        }
        public ComponenteLexico ObtenerPalabraReservada(String Lexema)
        {

            return mapaPalabrasReservadas[Lexema];
        }

    }
}
