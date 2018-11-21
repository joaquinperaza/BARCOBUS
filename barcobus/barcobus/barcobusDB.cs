using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using System.ComponentModel;

namespace barcobus
{
    public class barcobusDB
    {
        private barcobus db=new barcobus();
        public static String rutaArchivo = HttpRuntime.AppDomainAppPath + "db.xml";
        private void guardardb()
        {

            
            System.Xml.Serialization.XmlSerializer writer =
            new System.Xml.Serialization.XmlSerializer(typeof(barcobus));
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

            logItem e = new logItem();
            e.Barco = barco;
            e.Encargado = encargado;
            e.Operacion = "Creacion de barco";
            if (encargado.Permisos > 1)
            {db.Barcos.Add(barco);
            db.Log.Add(e);
            guardardb();
            }
            else
            {
                EmailException ee = new EmailException(e);
            }
        }
        /// <summary>
        /// Crear nuevo tipo de mantenimeinto.
        /// </summary>
        /// <param name="mantenimiento">Mantenimiento a guardar.</param>
        /// <param name="encargado">Encargado creador del mantenimeinto.</param>
        public void createMantenimiento(mantenimiento mantenimiento, encargado encargado)
        {
            logItem e = new logItem();
            e.Mantenimiento = mantenimiento;
            e.Encargado = encargado;
            e.Operacion = "Creacion de mantenimiento";
            if (encargado.Permisos > 1)
            {
                db.Mantenimientos.Add(mantenimiento);
                db.Log.Add(e);
                guardardb();
            }
            else
            {
                EmailException ee = new EmailException(e);
            }

        }
        /// <summary>
        /// Crear nuevo tripulante
        /// </summary>
        /// <param name="tripulante">Tripulante a ser ingresado.</param>
        /// <param name="encargado">Encargado responsable de la edicion.</param>
        public void createTripulante(tripulante tripulante, encargado encargado)
        {
            logItem e = new logItem();
            e.Tripulante = tripulante;
            e.Encargado = encargado;
            e.Operacion = "Creacion de tripulante";
            if (encargado.Permisos > 1)
            {
                db.Log.Add(e);
                db.Tripulantes.Add(tripulante);
                guardardb();
            }
            else
            {
                EmailException ee = new EmailException(e);
            }
        }
        /// <summary>
        /// Crear nuevo encargado
        /// </summary>
        /// <param name="newEncargado">Nuevo encargado a ingresar.</param>
        /// <param name="encargado">encargado que ingresa nuevo encargado.</param>
        public void createEncargado(encargado newEncargado, encargado encargado)
        {
            logItem e = new logItem();
            e.Encargado = encargado;
            e.Operacion = "Creacion de encargado: " + newEncargado.Nombre;

            if (encargado.Permisos > 2)
            {
                db.Encargados.Add(newEncargado);
                db.Log.Add(e);
                guardardb();
            }
            else
            {
                EmailException ee = new EmailException(e);
            }
        }
        public void initEncargado(encargado e) {
            logItem ee = new logItem();
            ee.Encargado = e;
            ee.Operacion = "Inicializacion de encargado: " + e.Nombre;
            if (db.Encargados.Count == 0)
            {
                db.Log.Add(ee);
                db.Encargados.Add(e);
                guardardb();
            }
            else {
                EmailException eee = new EmailException(ee);
            }
        }
        public bool boot() {
            bool b = false;
            if (db.Encargados.Count == 0) {
                b = true;
            }
            return b;
        }
        /// <summary>
        /// Registrar un nuevo mantenimiento a barco
        /// </summary>
        /// <param name="rmantenimiento">Solicitud de manetenimiento</param>
        /// <param name="barco">Barco a realizar el mantenimiento</param>
        /// <param name="encargado">Encargado que ingresa la solicitud.</param>
        public void registrarMantenimeinto(registroMantenimiento rmantenimiento,barco barco,  encargado encargado) {
            logItem e = new logItem();
            e.Encargado = encargado;
            e.Barco = barco;
            e.registroMantenimiento = rmantenimiento;
            e.Operacion = "Asignacion de mantenimiento";
            if (encargado.Permisos > 0)
            {
                db.Barcos.Find(b2 => b2.Nombre == barco.Nombre).LogMantenimientos.Add(rmantenimiento);
                db.Log.Add(e);
                guardardb();
            }
            else
            {
                EmailException ee = new EmailException(e);
            }
        }
        /// <summary>
        /// Registrar reparacion
        /// </summary>
        /// <param name="rreparacion">Registro de reparacion</param>
        /// <param name="b">Barco reparado</param>
        /// <param name="encargado">Encargado del reporte</param>
        public void registrarReparacion(registroReparacion rreparacion, string b, encargado encargado)
        {
            barco barco = db.Barcos.Find(b2 => b2.Nombre == b);
            logItem e = new logItem();
            e.Encargado = encargado;
            e.Barco = barco;
            e.registroReparacion = rreparacion;
            e.Operacion = "Alta de reparacion";
            if (encargado.Permisos > 0)
            {
                db.Barcos.Find(b2 => b2.Nombre == barco.Nombre).LogReparaciones.Add(rreparacion);
                db.Log.Add(e);
                guardardb();
            }
            else
            {
                EmailException ee = new EmailException(e);
            }
        }
        /// <summary>
        /// Asigna tripulante a un barco
        /// </summary>
        /// <param name="barco">Barco a asignarle tripulacion</param>
        /// <param name="encargado">Encargado de la asignacion</param>
        /// <param name="tripulante">Tripulante a asignar</param>
        public int asignarTripulante(string b, encargado encargado, string t) {
            barco barco = db.Barcos.Find(b2 => b2.Nombre == b);
            tripulante tripulante = db.Tripulantes.Find(t2 => t2.Nombre == t);
            logItem e = new logItem();
            e.Encargado = encargado;
            e.Barco = barco;
            e.Tripulante = tripulante;
            e.Operacion = "Asignacion de tripulante";
            bool chequeo=true;
            if (encargado.Permisos > 0)
            { 
            if (db.Barcos.Find(b2 => b2.Nombre == barco.Nombre).Tripulacion.Count >= db.Barcos.Find(b2 => b2.Nombre == barco.Nombre).CapacidadTripulantes) { chequeo = false;
            return 2;
            }
            if (db.Barcos.Find(b2 => b2.Nombre == barco.Nombre).Tripulacion.Find(t3=>t3.Nombre==tripulante.Nombre)!=null) { chequeo = false;
            return 3;
            }
            if(db.Barcos.Find(b2 => b2.Nombre == barco.Nombre).Tripulacion.FindAll(e2 => e2.Rol == 1).Count>1){
            chequeo=false;
            return 4;
            }
            
                foreach (barco b22 in db.Barcos)
                {
                    if (b22.Tripulacion.Find(t2 => t2.Nombre == tripulante.Nombre) != null)
                    {
                        b22.Tripulacion.Remove(b22.Tripulacion.Find(t2 => t2.Nombre == tripulante.Nombre));
                    }
                }
            

            if (chequeo == true)
            {
                db.Barcos.Find(b2 => b2.Nombre == barco.Nombre).Tripulacion.Add(tripulante);
                db.Log.Add(e);
                guardardb();
                return 1;
            }
            else {
                return 5;
            }
                
            }
            else
            {
                EmailException ee = new EmailException(e);
                return 0;
            }
        }

        /// <summary>
        /// Lista la tripulacion
        /// </summary>
        /// <param name="barco">Barco a listar la tripulacion</param>
        /// <param name="encargado">Encargado que realiza la consulta</param>
        /// <returns>Lista de tripulantes del barco.</returns>
        public List<tripulante> listarTripulacion(barco barco, encargado encargado)
        {
            logItem e = new logItem();
            e.Encargado = encargado;
            e.Barco = barco;
            e.Operacion = "Consulta de tripulacion";
            if (encargado.Permisos > 0)
            {
                List<tripulante> t=db.Barcos.Find(b2 => b2.Nombre == barco.Nombre).Tripulacion;
                db.Log.Add(e);
                guardardb();
                return t;
            }
            else
            { 
                EmailException ee = new EmailException(e);
                return new List<tripulante>();
            }
        }
        public class resultado {
            public int capitanes;
            public int oficialesCubierta;
            public int pilotos;
            public int comisarios;
            public int jefesDeMaquina;
            public int servicios;
        }
       /// <summary>
       /// Listado de los tripulantes por tipo
       /// </summary>
       /// <returns>Tripulantes categorizados.</returns>
        public resultado tripulantes() {
            resultado r = new resultado();
            r.capitanes = db.Tripulantes.FindAll(e2 => e2.Rol == 1).Count;
            r.oficialesCubierta = db.Tripulantes.FindAll(e2 => e2.Rol == 2).Count;
            r.pilotos = db.Tripulantes.FindAll(e2 => e2.Rol == 3).Count;
            r.comisarios = db.Tripulantes.FindAll(e2 => e2.Rol == 4).Count;
            r.jefesDeMaquina = db.Tripulantes.FindAll(e2 => e2.Rol == 5).Count;
            r.servicios = db.Tripulantes.FindAll(e2 => e2.Rol == 6).Count;
            return r;
        }
        /// <summary>
        /// Editar permisos de un encargado
        /// </summary>
        /// <param name="encargado">Encargado responsable</param>
        /// <param name="encargadoAEditar">Encargado a editar</param>
        /// <param name="permisoNuevo">Nuevo codigo de permiso</param>
        public void editarPermiso(encargado encargado, encargado encargadoAEditar, int permisoNuevo) {
            logItem e = new logItem();
            e.Encargado = encargado;
            e.Operacion = "Edicion de permisos del encargado: " + encargadoAEditar.Nombre;
            if (encargado.Permisos > 2)
            {
                db.Encargados.Find(e2 => e2.Nombre == encargadoAEditar.Nombre).Permisos = permisoNuevo;
                db.Log.Add(e);
                guardardb();
            }
            else
            {
                EmailException ee = new EmailException(e);
            }
        }
        public encargado login(Int32 ci, String clave) {
            logItem ee = new logItem();
            
            encargado e = db.Encargados.Find(e2 => e2.Ci == ci);
            ee.Encargado = e;
           
            if(e!=null){
            if (e.Password == clave)
            {
                ee.Operacion = "Ingreso.";
                db.Log.Add(ee);
                return e;
            }
            else {
                ee.Operacion = "Ingreso fallido: Clave incorrecta";
                db.Log.Add(ee);
                EmailException e2 = new EmailException(ee);
                return null; }
            }
            else { return null; }
        }

        public  DataTable logDataTable(DateTime desde,DateTime hasta)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Fecha",typeof(DateTime));
            table.Columns.Add("Encargado", typeof(string));
            table.Columns.Add("Operacion", typeof(string));
            table.Columns.Add("URL", typeof(string));
            foreach (logItem item in db.Log)
            {   if(item.Timestamp>=desde && item.Timestamp<=hasta){
                DataRow row = table.NewRow();
                row["Fecha"] = item.Timestamp;
                row["Encargado"] = item.Encargado.Nombre;
                row["Operacion"] = item.Operacion;
                row["URL"] = "";
                table.Rows.Add(row);}
            }
            return table;
        }
        public DataTable barcoLog(string b3,DateTime d) {
            barco b = db.Barcos.Find(b2 => b2.Nombre == b3);
            int mes = d.Month;
            int anio = d.Year;
            DataTable table = new DataTable();
            table.Columns.Add("Fecha", typeof(DateTime));
            table.Columns.Add("Tipo", typeof(string));
            table.Columns.Add("Encargado", typeof(string));
            table.Columns.Add("Detalle", typeof(string));
            table.Columns.Add("Costo", typeof(int));
            
            foreach (registroMantenimiento item in b.LogMantenimientos)
            {
                if (item.Timestamp.Month == mes && item.Timestamp.Year == anio)
                {
                    DataRow row = table.NewRow();
                    row["Fecha"] = item.Timestamp;
                    row["Encargado"] = item.Encargado.Nombre;
                    row["Tipo"] = "Mantenimiento";
                    row["Detalle"] = item.Descripcion;
                    row["Costo"] = item.Costo;
                    table.Rows.Add(row);
                }
            }
            foreach (registroReparacion item in b.LogReparaciones)
            {
                if (item.Timestamp.Month == mes && item.Timestamp.Year == anio)
                {
                    DataRow row = table.NewRow();
                    row["Fecha"] = item.Timestamp;
                    row["Encargado"] = item.Encargado.Nombre;
                    row["Tipo"] = "Reparacion";
                    row["Detalle"] = item.Descripcion;
                    table.Rows.Add(row);
                }
            }
            return table;
        }
        public List<barco> barcoList() {
            return db.Barcos;
        }
        public List<tripulante> tripulanteList()
        {   List<tripulante> free= db.Tripulantes.ToList<tripulante>();
        
        return free;
        }
        public List<mantenimiento> listaMantenimiento() { return db.Mantenimientos.ToList<mantenimiento>(); }
        public string CalculateMD5Hash(string input)

        {
        if (input != null)
        {
            // step 1, calculate MD5 hash from input

            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {

                sb.Append(hash[i].ToString("X2"));

            }

            return sb.ToString();
         }
         else { return "NO TEXT"; }
    }


    }


}