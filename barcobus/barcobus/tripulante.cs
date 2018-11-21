using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barcobus
{
    public class tripulante
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
        private int rol;

        public int Rol
        {
            get { return rol; }
            set { rol = value; }
        }
        private DateTime fechaIngreso;

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        public tripulante() {
            fechaIngreso = DateTime.UtcNow;
        }

        public override String ToString() { return nombre; }

    }
}