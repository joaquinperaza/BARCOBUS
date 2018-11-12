using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace barcobus
{
    public class barcobusDB
    {
        private barcobus db=new barcobus();
        public static String rutaArchivo = "db.xml";
        private void guardardb()
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(List<barcobus>));

            System.IO.StreamWriter file = new System.IO.StreamWriter(rutaArchivo);
            writer.Serialize(file, db);
            file.Close();
        }
        private void leerBarcos()
        {
            barcobus dbr = new barcobus();

            if (File.Exists(rutaArchivo))
            {
                System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(barcobus));
                System.IO.StreamReader file = new System.IO.StreamReader(rutaArchivo);
                dbr = (barcobus)reader.Deserialize(file);
                file.Close();
            }

            db = dbr;
        }
        public barcobusDB()
        {
            leerBarcos();
        }



        ////////PUBLIC METHODS///////////////WRITE METHODS///////
      
        /// <summary>
        /// Guarda Nuevo Barco
        /// </summary>
        /// <param name="barco">Barco a guardar.</param>
        /// <param name="encargado">Encargado creador del mismo.</param>
        public void createBarco(barco barco, encargado encargado) {
            
            if (encargado.Permisos > 1)
            {db.Barcos.Add(barco);
            logItem e = new logItem();
            e.Barco = barco;
            e.Encargado = encargado;
            e.Operacion = "Creacion de barco";
            db.Log.Add(e);
            guardardb();
            }
            else
            {
                throw new System.UnauthorizedAccessException();
            }
        }
        /// <summary>
        /// Crear nuevo tipo de mantenimeinto.
        /// </summary>
        /// <param name="mantenimiento">Mantenimiento a guardar.</param>
        /// <param name="encargado">Encargado creador del mantenimeinto.</param>
        public void createMantenimiento(mantenimiento mantenimiento, encargado encargado)
        {
            if (encargado.Permisos > 1)
            {
                db.Mantenimientos.Add(mantenimiento);
                logItem e = new logItem();
                e.Mantenimiento = mantenimiento;
                e.Encargado = encargado;
                e.Operacion = "Creacion de mantenimiento";
                db.Log.Add(e);
                guardardb();
            }
            else
            {
                throw new System.UnauthorizedAccessException();
            }

        }
        /// <summary>
        /// Crear nuevo tripulante
        /// </summary>
        /// <param name="tripulante">Tripulante a ser ingresado.</param>
        /// <param name="encargado">Encargado responsable de la edicion.</param>
        public void createTripulante(tripulante tripulante, encargado encargado)
        {
            if (encargado.Permisos > 1)
            {
                logItem e = new logItem();
                e.Tripulante = tripulante;
                e.Encargado = encargado;
                e.Operacion = "Creacion de tripulante";
                db.Log.Add(e);
                db.Tripulantes.Add(tripulante);
                guardardb();
            }
            else
            {
                throw new System.UnauthorizedAccessException();
            }
        }
        /// <summary>
        /// Crear nuevo encargado
        /// </summary>
        /// <param name="newEncargado">Nuevo encargado a ingresar.</param>
        /// <param name="encargado">encargado que ingresa nuevo encargado.</param>
        public void createEncargado(encargado newEncargado, encargado encargado)
        {
            if (encargado.Permisos > 2)
            {
                db.Encargados.Add(newEncargado);
                logItem e = new logItem();
                e.Encargado = encargado;
                e.Operacion = "Creacion de encargado: "+encargado.Nombre;
                db.Log.Add(e);
                guardardb();
            }
            else
            {
                throw new System.UnauthorizedAccessException();
            }
        }
        /// <summary>
        /// Registrar un nuevo mantenimeitno a barco
        /// </summary>
        /// <param name="rmantenimiento">Solicitud de manetenimiento</param>
        /// <param name="barco">Barco a realizar el mantenimiento</param>
        /// <param name="encargado">Encargado que ingresa la solicitud.</param>
        public void registrarMantenimeinto(registroMantenimiento rmantenimiento,barco barco,  encargado encargado) {
            if (encargado.Permisos > 0)
            {
                db.Barcos.Find(b2 => b2.Nombre == barco.Nombre).LogMantenimientos.Add(rmantenimiento);
                logItem e = new logItem();
                e.Encargado = encargado;
                e.Barco = barco;
                e.registroMantenimiento = rmantenimiento;
                e.Operacion = "Asignacion de mantenimiento";
                db.Log.Add(e);
                guardardb();
            }
            else
            {
                throw new System.UnauthorizedAccessException();
            }
        }
        /// <summary>
        /// Registrar reparacion
        /// </summary>
        /// <param name="rreparacion">Registro de reparacion</param>
        /// <param name="barco">Barco reparado</param>
        /// <param name="encargado">Encargado del reporte</param>
        public void registrarReparacion(registroReparacion rreparacion, barco barco, encargado encargado)
        {
            if (encargado.Permisos > 0)
            {
                db.Barcos.Find(b2 => b2.Nombre == barco.Nombre).LogReparaciones.Add(rreparacion);
                logItem e = new logItem();
                e.Encargado = encargado;
                e.Barco = barco;
                e.registroReparacion = rreparacion;
                e.Operacion = "Alta de reparacion";
                db.Log.Add(e);
                guardardb();
            }
            else
            {
                throw new System.UnauthorizedAccessException();
            }
        }




    }


}