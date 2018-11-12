using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barcobus
{
    public class encargado
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int ci;

        public int Ci
        {
            get { return ci; }
            set { ci = value; }
        }
        private int personasACargo;

        public int PersonasACargo
        {
            get { return personasACargo; }
            set { personasACargo = value; }
        }
        private int permisos;

        public int Permisos
        {
            get { return permisos; }
            set { permisos = value; }
        }
    }
}