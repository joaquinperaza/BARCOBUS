using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barcobus
{
    public class registroMantenimiento
    {
        private DateTime timestamp;

        public DateTime Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
        private mantenimiento mantenimiento;
        public mantenimiento Mantenimiento
        {
            get { return mantenimiento; }
            set { mantenimiento = value; }
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