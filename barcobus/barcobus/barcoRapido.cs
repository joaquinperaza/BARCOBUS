﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barcobus
{
    public class barcoRapido : barco
    {
        private int velocidadMax;

        public int VelocidadMax
        {
            get { return velocidadMax; }
            set { velocidadMax = value; }
        }
        
     
    }
}