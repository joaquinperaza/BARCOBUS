using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace barcobus
{

    [XmlInclude(typeof(barcoLento))]
    [XmlInclude(typeof(barcoRapido))]
    public class barco
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int capacidadPasajeros;

        public int CapacidadPasajeros
        {
            get { return capacidadPasajeros; }
            set { capacidadPasajeros = value; }
        }
        private int capacidadTripulantes;

        public int CapacidadTripulantes
        {
            get { return capacidadTripulantes; }
            set { capacidadTripulantes = value; }
        }
        private List<registroMantenimiento> logMantenimientos= new List<registroMantenimiento>();

        public List<registroMantenimiento> LogMantenimientos
        {
             get { return logMantenimientos; }
        }
        private List<registroReparacion> logReparaciones = new List<registroReparacion>();

        public List<registroReparacion> LogReparaciones
        {
         get { return logReparaciones; }
        }
        private List<tripulante> tripulacion= new List<tripulante>();

        public List<tripulante> Tripulacion
        {
            get { return tripulacion; }
        }
    }
}