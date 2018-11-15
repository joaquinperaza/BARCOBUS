using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace barcobus
{
    public class logItem
    {
        private int timestamp;

        public int Timestamp
        {
            get { return timestamp; }
        }
        private encargado e;

        public encargado Encargado
        {
            get { return e; }
            set { e = value; }
        }
        private tripulante t;

        internal tripulante Tripulante
        {
            get { return t; }
            set { t = value; }
        }
        private mantenimiento m;

        public mantenimiento Mantenimiento
        {
            get { return m; }
            set { m = value; }
        }
        private barco b;

        public barco Barco
        {
            get { return b; }
            set { b = value; }
        }
        private registroMantenimiento rm;

        public registroMantenimiento registroMantenimiento
        {
            get { return rm; }
            set { rm = value; }
        }
        private registroReparacion rr;

        public registroReparacion registroReparacion
        {
            get { return rr; }
            set { rr = value; }
        }
        private String operacion;

        public String Operacion
        {
            get { return operacion; }
            set { operacion = value; }
        }
        public override String ToString() {
            String s = "Excepcion de acceso no autorizado: \n Usuario: "+Encargado.Nombre+" sobre los elementos \n Barco: "+Barco.Nombre+"\n Tripulante: "+Tripulante.Nombre+"\n Mantenimiento: "+Mantenimiento.Descripcion+" \n RegistroReparacion: "+registroReparacion.Descripcion+"\n RegistroMantenimeinto: "+registroMantenimiento.Mantenimiento.Descripcion+"\n OPERACION DENEGADA: "+operacion;
            return s;
        }
        public logItem() {
            timestamp = (int)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds;
        }


    }
}