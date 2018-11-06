using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace barcobus
{
    public class barcobus
    {
        public static String rutaArchivo = "barcos.xml";
        private List<barco> barcos = new List<barco>();
        public List<barco> Barcos
        {
            get { return barcos; }
            set { barcos = value; }
        }
        public void guardarBarco(barco b) {
            Barcos.Add(b);
            guardarBarcos();
        }
        private void guardarBarcos()
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(List<barco>));

            System.IO.StreamWriter file = new System.IO.StreamWriter(rutaArchivo);
            writer.Serialize(file, barcos);
            file.Close();
        }
        public void leerBarcos()
        {
            List<barco>  barcos2 = new List<barco>();

            if (File.Exists(rutaArchivo))
            {
                System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(List<barco>));
                System.IO.StreamReader file = new System.IO.StreamReader(rutaArchivo);
                barcos2 = (List<barco>)reader.Deserialize(file);
                file.Close();
            }

            barcos = barcos2;
        }

  
      
    }
}