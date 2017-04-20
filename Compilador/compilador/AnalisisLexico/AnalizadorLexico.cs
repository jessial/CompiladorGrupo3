using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using compilador.Transversal;
using System.Windows.Forms;

namespace compilador.AnalisisLexico
{
    class AnalizadorLexico
    {
        private int Numero;
        public int Puntero = 0;
        private string lexema = null;
        private string caracterActual = null;
        public int estadoActual;
        private Linea lineaActual = null;
        private Form1 Form = Form1.getInstance();

        public AnalizadorLexico()
        {
            CargarLinea();
        }

        private void CargarLinea()
        {
            int numeroLinea = 0;
            if (lineaActual != null)
            {
                numeroLinea = lineaActual.Numero;
            }
            //si la linea no existe retornara una line @EOF@
            lineaActual = CacheArchivo.getInstance().obtenerLinea(numeroLinea);
            //reset al puntero 
            Puntero = 1;
        }

        private void LeerSiguienteCaracter()
        {
            if (lineaActual.Contenido.Equals("@EOF@"))
            {

                caracterActual = "@EOF@";
            }
            else if (lineaActual.Contenido.Length >= Puntero)
            {
                caracterActual = lineaActual.Contenido.Substring((Puntero - 1), 1);
            }
            else
            {
                caracterActual = "@FL@";
            }
            Puntero = Puntero + 1;

        }
        private void DevolverPuntero()
        {
            Puntero -= 1;
        }

        public ComponenteLexico Analizar()
        {
            ComponenteLexico componente = null;
            lexema = "";
            int estadoActual = 0;
            bool continuarEvaluacion = true;

            while (continuarEvaluacion)
            {

                switch (estadoActual)
                {
                    case 0:
                        LeerSiguienteCaracter();

                        while (" ".Equals(caracterActual))
                        {
                            LeerSiguienteCaracter();
                        }

                        if ((char.IsLetter(caracterActual.ToCharArray()[0]) || "$".Equals(caracterActual) || "_".Equals(caracterActual)) && (!"O".Equals(caracterActual) && !"Y".Equals(caracterActual)))
                        {
                            estadoActual = 4;
                            lexema += caracterActual;

                        }
                        else if ("Y".Equals(caracterActual))
                        {
                            estadoActual = 34;
                            lexema += caracterActual;
                        }
                        else if ("O".Equals(caracterActual))
                        {
                            estadoActual = 35;
                            lexema += caracterActual;
                        }
                        else if (";".Equals(caracterActual))
                        {
                            estadoActual = 13;
                           // lexema += caracterActual;
                        }
                        else if ("+".Equals(caracterActual))
                        {
                            estadoActual = 5;
                            lexema += caracterActual;
                        }

                        else if (char.IsDigit(caracterActual.ToCharArray()[0]))
                        {
                            estadoActual = 1;
                            lexema += caracterActual;
                        }

                        else if ("-".Equals(caracterActual))
                        {
                            estadoActual = 6;
                            lexema += caracterActual;
                        }
                        else if ("*".Equals(caracterActual))
                        {
                            estadoActual = 7;
                            lexema += caracterActual;
                        }

                        else if ("/".Equals(caracterActual))
                        {
                            estadoActual = 8;
                            lexema += caracterActual;
                        }

                        else if ("%".Equals(caracterActual))
                        {
                            estadoActual = 9;
                            lexema += caracterActual;
                        }

                        else if ("(".Equals(caracterActual))
                        {
                            estadoActual = 10;
                            lexema += caracterActual;
                        }

                        else if (")".Equals(caracterActual))
                        {
                            estadoActual = 11;
                            lexema += caracterActual;
                        }

                        else if ("@EOF@".Equals(caracterActual))
                        {
                            estadoActual = 12;
                            lexema += caracterActual;
                        }

                        else if ("=".Equals(caracterActual))
                        {
                            estadoActual = 19;
                            lexema += caracterActual;
                        }


                        else if ("<".Equals(caracterActual))
                        {
                            estadoActual = 20;
                            lexema += caracterActual;
                        }


                        else if (">".Equals(caracterActual))
                        {
                            estadoActual = 21;
                            lexema += caracterActual;
                        }


                        else if (":".Equals(caracterActual))
                        {
                            estadoActual = 22;
                            lexema += caracterActual;
                        }


                        else if ("!".Equals(caracterActual))
                        {
                            estadoActual = 30;
                            lexema += caracterActual;
                        }

                        else if ("@FL@".Equals(caracterActual))
                        {
                            estadoActual = 13;
                            lexema += "";
                        }
                        else if("[".Equals(caracterActual))
                        {
                            estadoActual = 32;
                            lexema += caracterActual;
                        }
                        else if ("]".Equals(caracterActual))
                        {
                            estadoActual = 33;
                            lexema += caracterActual;
                        }


                        else
                        {
                            estadoActual = 18;

                        }
                        break;
                    case 1:
                        LeerSiguienteCaracter();
                        if (char.IsDigit(caracterActual.ToCharArray()[0]))
                        {
                            estadoActual = 1;
                            lexema += caracterActual;
                        }
                        else if (",".Equals(caracterActual))
                        {
                            estadoActual = 2;
                            lexema = lexema + caracterActual;
                        }
                        else estadoActual = 14;

                        break;
                    case 2:
                        LeerSiguienteCaracter();
                        if (char.IsDigit(caracterActual.ToCharArray()[0]))
                        {
                            estadoActual = 3;
                            lexema += caracterActual;
                        }
                        else estadoActual = 17;
                        break;
                    case 3:
                        LeerSiguienteCaracter();
                        if (char.IsDigit(caracterActual.ToCharArray()[0]))
                        {
                            estadoActual = 3;
                            lexema += caracterActual;
                        }
                        else estadoActual = 15;
                        break;
                    case 4:
                        LeerSiguienteCaracter();
                        if (char.IsLetter(caracterActual.ToCharArray()[0]) || "$".Equals(caracterActual) || "_".Equals(caracterActual))
                        {
                            estadoActual = 4;
                            lexema += caracterActual;
                        }
                        else estadoActual = 16;
                        break;
                    case 5:
                        int posicionInicial = (Puntero - 1) - lexema.Length;
                        int numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "SUMA");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;
  
                        break;
                    case 6:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "RESTA");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 7:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "MULTIPLICACIÓN");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 8:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "DIVISIÓN");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 9:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "MODULO");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 10:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "PARENTESIS ABRE");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 11:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "PARENTESIS CIERRA");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 12:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "FIN DE ARCHIVO");
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 13:
                        /*posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "SALTO DE LINEA");
                        Form.datos(componente);*/
                        estadoActual = 0;
                        lexema = "";
                        CargarLinea();

                        break;
                    case 14:
                        DevolverPuntero();
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "NUMERO ENTERO");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 15:
                        DevolverPuntero();
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "NUMERO DECIMAL");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 16:
                        DevolverPuntero();
                        string categoria = null;
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        if (TablaPalabrasReservadas.obtenerTablaPalabrasReservadas().EsPalabraReservada(lexema))
                        {
                            ComponenteLexico palabraReservada = TablaPalabrasReservadas.obtenerTablaPalabrasReservadas().ObtenerPalabraReservada(lexema);
                            componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, palabraReservada.Categoria);
                        }
                        else
                        {
                            categoria = "IDENTIFICADOR";
                            componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, categoria);
                        }
                        
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;
                        break;
                    case 17:
                        DevolverPuntero();
                        String MensajeError17 = "Numero decimal no valido";
                        Error ErrorNumeroDecimal = Error.CREATE(lineaActual.Numero, (Puntero - 1) - lexema.Length, caracterActual, MensajeError17, "LEXICO");
                        ManejadorErrores.ObtenerManejadorErrores().AgregarError(ErrorNumeroDecimal);
                        lexema += "0";
                        componente = ComponenteLexico.CREATE(lineaActual.Numero, (Puntero - 1) - lexema.Length, lexema, "NUMERO DECIMAL DUMMY");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        Form.errores(ErrorNumeroDecimal);
                        continuarEvaluacion = false;

                        break;
                    case 18:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        string MensajeError18 = "Símbolo no válido";
                        Error ErrorSimboloInvalido = Error.CREATE(lineaActual.Numero, (Puntero - 1) - lexema.Length, caracterActual, MensajeError18, "LEXICO");
                        ManejadorErrores.ObtenerManejadorErrores().AgregarError(ErrorSimboloInvalido);
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, caracterActual, "SIMBOLO NO VALIDO");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.errores(ErrorSimboloInvalido);
                        continuarEvaluacion = false;

                        break;

                    case 19:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "IGUAL QUE");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 20:
                        LeerSiguienteCaracter();
                        if (">".Equals(caracterActual))
                        {
                            estadoActual = 23;
                            lexema += caracterActual;
                        }
                        else if ("=".Equals(caracterActual))
                        {
                            estadoActual = 24;
                            lexema += caracterActual;
                        }
                        else
                        {
                            estadoActual = 25;
                            lexema += caracterActual;
                        }
                        break;
                    case 21:
                        LeerSiguienteCaracter();
                        if ("=".Equals(caracterActual))
                        {
                            estadoActual = 26;
                            lexema += caracterActual;
                        }
                        else
                        {
                            estadoActual = 27;
                            lexema += caracterActual;
                        }
                        break;
                    case 22:
                        LeerSiguienteCaracter();
                        if ("=".Equals(caracterActual))
                        {
                            estadoActual = 28;
                            lexema += caracterActual;
                        }
                        else
                        {
                            estadoActual = 29;
                            lexema += caracterActual;
                        }
                        break;
                    case 23:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "DIFERENTE QUE");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 24:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "MENOR O IGUAL QUE");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 25:
                        DevolverPuntero();
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "MENOR QUE");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 26:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "MAYOR O IGUAL QUE");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 27:
                        DevolverPuntero();
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "MAYOR QUE");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 28:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "ASIGNACION");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 29:
                        DevolverPuntero();
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        string MensajeError29 = "Símbolo no válido";
                        Error ErrorAsignacionInvalido = Error.CREATE(lineaActual.Numero, (Puntero - 1) - lexema.Length, caracterActual, MensajeError29, "LEXICO");
                        ManejadorErrores.ObtenerManejadorErrores().AgregarError(ErrorAsignacionInvalido);
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, caracterActual, "ASIGNACION NO VALIDA");
                        Form.errores(ErrorAsignacionInvalido);
                        continuarEvaluacion = false;

                        break;
                    case 30:
                        LeerSiguienteCaracter();
                        if ("=".Equals(caracterActual))
                        {
                            estadoActual = 31;
                            lexema += caracterActual;
                        }
                        break;
                    case 31:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "DIFERENTE QUE");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 32:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "CORCHETE ABRE");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 33:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "CORCHETE CIERRA");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 34:
                        LeerSiguienteCaracter();
                        if (char.IsLetter(caracterActual.ToCharArray()[0]) || "$".Equals(caracterActual) || "_".Equals(caracterActual))
                        {
                            estadoActual = 4;
                            lexema += caracterActual;
                        }
                        else estadoActual = 36;

                        break;
                    case 35:
                        LeerSiguienteCaracter();
                        if (char.IsLetter(caracterActual.ToCharArray()[0]) || "$".Equals(caracterActual) || "_".Equals(caracterActual))
                        {
                            estadoActual = 4;
                            lexema += caracterActual;
                        }
                        else estadoActual = 37;

                        break;
                    case 36:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "OPERADOR Y");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;
                    case 37:
                        posicionInicial = (Puntero - 1) - lexema.Length;
                        numeroLinea = lineaActual.Numero;
                        componente = ComponenteLexico.CREATE(numeroLinea, posicionInicial, lexema, "OPERADOR O");
                        TablaSimbolos.obtenerTablaSimbolos().AgregarSimbolo(componente);
                        Form.datos(componente);
                        continuarEvaluacion = false;

                        break;

                }

            }
            return componente;

        }

    }
}
