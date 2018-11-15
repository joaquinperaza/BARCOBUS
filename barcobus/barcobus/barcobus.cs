using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace barcobus
{
    public class barcobus
    {
        private List<barco> barcos = new List<barco>();
        public List<barco> Barcos
        {
            get { return barcos; }
        }
        private List<tripulante> tripulantes = new List<tripulante>();
        public List<tripulante> Tripulantes
        {
            get { return tripulantes; }
        }
        private List<encargado> encargados = new List<encargado>();
        public List<encargado> Encargados
        {
            get { return encargados; }
        }
        private List<mantenimiento> mantenimientos = new List<mantenimiento>();
        public List<mantenimiento> Mantenimientos
        {
            get { return mantenimientos; }
           
        }
        private List<logItem> log = new List<logItem>();
        public List<logItem> Log
        {
            get { return log; }
            
        }
        



      
    }
}