using System;

namespace Teoria_Computacional {
    public class Transicion {
        public string Inicio;
        public string Valor;
        public string[] Siguiente;
    }

    public class Automata {
        public string Nombre;
        public string Estado_Inicial;
        public string[] Estados;
        public string[] Alfabeto;
        public string[] Estados_Aceptacion;
        public Transicion[] Trans;
    }

}
