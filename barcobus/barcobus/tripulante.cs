﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barcobus
{
    class tripulante
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

    }
}