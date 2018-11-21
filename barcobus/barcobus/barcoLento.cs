using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barcobus
{
    public class barcoLento:barco
    {
        private int capacidadBodega;

        public int CapacidadBodega
        {
            get { return capacidadBodega; }
            set { capacidadBodega = value; }
        }
        private int adicional;

        public int Adicional
        {
            get { return adicional; }
            set { adicional = value; }
        }
    }
}