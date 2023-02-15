using System;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Programa07_01_Expresiones_regulares_I_y_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Expresiones Regulares II
            // Metodo 1

            // Busqueda de expresion en un texto
            string texto = "La casa del casamentero";
            string exp = "casa";

            MatchCollection encontrado = Regex.Matches(texto, exp);

            foreach(Match e in encontrado)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("-------------------------");

            // Metodo 2

            texto = "El estudiante es un casanova en la escuela";
            exp = " casa ";

            Regex expReg = new Regex(exp);
            encontrado = expReg.Matches(texto);

            foreach(Match e in encontrado)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("-------------------------");

            // Uso de . significa que le puede seguir cualquier caractér
            // cabal, campeon, academico

            texto = "Saludos al mas cabal";
            exp = " ca.";

            MatchesExp(texto, exp);

            // Uso de clases de caracteres, se usa [] para contener los caracteres posibles.
            // Nico, Necio, Naco
            texto = "Hola Nico";
            exp = "N[ie]c";

            MatchesExp(texto, exp);

            //----------------------------------------------------------------------------------------------------

            // Expresiones Regulares II

            // Rango
            // Un rango "[a-u]" determina los caracteres que se buscaran en una palabra. En este
            // caso se buscará según el abecedario (siempre), todas las letras entre A y U.
            // Nico, Neco, Noco, Ndco, Nzco
            texto = "Hola Ndco";
            exp = "N[a-u]c";

            MatchesExp(texto, exp);

            // Uso de Complemento
            // Cuando usamos complemento, determinamos con el simbolo ^ que las letras siguientes
            // no deben estar en la palabra a buscar. Po ejemplo; Si decimos "N[^ie]c" decimos
            // que la palabara debe empezar con n, no le debe seguir i ni e, y debe seguirle la c.
            // El simbolo ^ actúa como si fuera una negacion.
            // Noco, Nico
            texto = "Hola Noco";
            exp = "N[^ie]c";

            MatchesExp(texto, exp);

            // Verificamos si tiene la expresion despues de x caracter
            texto = "En youtube hay millones de videos";
            exp = "m[io]l";

            expReg = new Regex(exp);
            if (expReg.IsMatch(texto, 5))
                Console.WriteLine("Si tiene");
            else
                Console.WriteLine("No tiene");
            Console.WriteLine("-------------------");

            // Para saber si una cadena finaliza con una expresion
            // EL signo $ indica que se buscará lo que se necesite, al final de la cadena
            texto = "En youtube hay videos de a mil";
            exp = "m[io]l$";

            MatchesExp(texto, exp);

            // Elemento opcional
            // El signo ? indica que en este caso, haya un caracter "c" o no haya nada, luego
            // tiene que haber una o.
            // Nico, Nilo, Nio
            texto = "Hola Nico";
            exp = "N[ie]c?o";

            MatchesExp(texto, exp);

            // Cuantificador
            // Indica que, en este caso, se busquen los numeros del 0 al 9 ("[0-9]"),
            // y que aparezcan dos de ellos en ese rango ("{2}"). Tambien sirve con letras.
            // Busca que existan x de esos elementos
            texto = "Holaa 25 Nico";
            exp = "[0-9]{2}";
            // exp = "[a]{2}";

            MatchesExp(texto, exp);

            // Alternaciones
            // Busca la palabra especifica completa
            texto = "Yo se programar en c";
            exp = "(c|java|python)";

            MatchesExp(texto, exp);

            // Split
            // Saca el elemento que cumpla con la expresion regular, y divide la cadena
            // sin ese elemento.
            texto = "Este es un tes de separacion, division";
            exp = ",";

            string[] cadenas = Regex.Split(texto, exp);

            foreach(string c in cadenas)
            {
                Console.WriteLine(c);

                Console.WriteLine("---------------------");
            }

            // Reemplazar / Replace
            // Quita una palabra o letra de la cadena y la reemplaza por otra especificada.
            texto = "Yo hablo ingles y no soy ingles";
            expReg = new Regex("ingles");

            string reemplazo = "Español";

            string resultado = expReg.Replace(texto, reemplazo);

            Console.WriteLine(resultado);
        }

        public static void MatchesExp(string pTexto, string pExp)
        {
            MatchCollection encontrado = Regex.Matches(pTexto, pExp);

            foreach (Match e in encontrado)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("-------------------------");
        }
    }
}
