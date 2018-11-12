using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barcobus
{
    public class registroReparacion
    {
        private int timestamp;

        public int Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
        private String r;
        public String Reparacion
        {
            get { return r; }
            set { r = value; }
        }
        private String descripcion;
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private encargado e;
        public encargado Encargado
        {
            get { return e; }
            set { e = value; }
        }
    }
}