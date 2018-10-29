using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Configuration;
using Utilitarios;
using System.Data.SqlClient;
using System.Reflection;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace Datos
{
     public class DAuditoria
    {

        public static void add(UAuditoria eAuditoria)
        {
            using (var dbc = new Mapeo("auditoria"))
            {
                dbc.Entry(eAuditoria).State = EntityState.Added;
                dbc.SaveChanges();
            }
        }

        //public static UAuditoria get(int id)
        //{
        //    using (var dbc = new Mapeo("auditoria"))
        //    {
        //        UAuditoria eAuditoria = dbc.auditoria.Find(id);
        //        return eAuditoria != null ? eAuditoria : UAuditoria.newEmpty();
        //    }
        //}

        public static List<UAuditoria> getAll(int id)
        {
            using (var dbc = new Mapeo("auditoria"))
            {
                return dbc.auditoria.ToList();
            }
        }

        public static List<UAuditoria> getAuditoriaTabla(string nombreTabla)
        {
            using (var dbc = new Mapeo("auditoria"))
            {
                return (from x in dbc.auditoria where x.Tabla == nombreTabla select x).ToList();
            }
        }

        public void insert(Object obj, UAuditoria data, string esquema, string tabla)
        {
            UAuditoria eAuditoria = new UAuditoria();
            eAuditoria.Fecha = DateTime.Now;
            eAuditoria.Accion = "INSERT";
            eAuditoria.User_bd = "SQL";
            eAuditoria.Schema = esquema;
            eAuditoria.Session = data.Session;
            eAuditoria.Tabla = tabla;
            eAuditoria.Pk = data.Pk.ToString();

            //JObject jObject = new JObject();

            //foreach (PropertyInfo propertyInfo in obj.GetType().GetProperties())
            //{
            //    if (propertyInfo.PropertyType == typeof(string) || propertyInfo.PropertyType == typeof(int) || propertyInfo.PropertyType == typeof(Boolean))
            //    {
            //        jObject[propertyInfo.Name] = propertyInfo.GetValue(obj).ToString();
            //    }
            //}

            eAuditoria.Data = JsonConvert.SerializeObject(obj);
            DAuditoria.add(eAuditoria);
        }

        public void update(Object newObj, Object oldObj, UAuditoria data, string esquema, string tabla)
        {
            UAuditoria eAuditoria = new UAuditoria();
            eAuditoria.Fecha = DateTime.Now;
            eAuditoria.Accion = "UPDATE";
            eAuditoria.User_bd = "SQL";
            eAuditoria.Schema = esquema;
            eAuditoria.Tabla = tabla;
            eAuditoria.Pk = data.Pk;
            eAuditoria.Session = data.Session;

            JObject jObject = new JObject();

            Boolean sinCambios = true;

            foreach (PropertyInfo propertyInfo in newObj.GetType().GetProperties())
            {
                if (propertyInfo.PropertyType == typeof(string) || propertyInfo.PropertyType == typeof(int) || propertyInfo.PropertyType == typeof(Boolean))
                {
                    if (propertyInfo.Name.Equals("Id"))
                    {
                        jObject[propertyInfo.Name] = propertyInfo.GetValue(newObj).ToString();
                    }
                    if (!propertyInfo.GetValue(newObj).ToString().Equals(propertyInfo.GetValue(oldObj).ToString()) && !propertyInfo.Name.Equals("pk"))
                    {
                        jObject["new_" + propertyInfo.Name] = propertyInfo.GetValue(newObj).ToString();
                        jObject["old_" + propertyInfo.Name] = propertyInfo.GetValue(oldObj).ToString();
                        sinCambios = false;
                    }
                }
                else if (propertyInfo.PropertyType == typeof(List<int>) && !JsonConvert.SerializeObject(propertyInfo.GetValue(newObj)).Equals(JsonConvert.SerializeObject(propertyInfo.GetValue(oldObj))))
                {
                    jObject["new_" + propertyInfo.Name] = JsonConvert.SerializeObject(propertyInfo.GetValue(newObj));
                    jObject["old_" + propertyInfo.Name] = JsonConvert.SerializeObject(propertyInfo.GetValue(oldObj));
                    sinCambios = false;
                }
            }

            if (sinCambios)
            {
                return;
            }

            eAuditoria.Data = JsonConvert.SerializeObject(jObject);
            DAuditoria.add(eAuditoria);
        }

        public void delete(Object obj, UAuditoria datos, string esquema, string tabla)
        {
            UAuditoria eAuditoria = new UAuditoria();
            eAuditoria.Fecha = DateTime.Now;
            eAuditoria.Accion = "DELETE";
            eAuditoria.User_bd = "SQL";
            eAuditoria.Schema = esquema;
            eAuditoria.Tabla = tabla;
            eAuditoria.Pk = datos.Pk;
            eAuditoria.Session = data.Session;

            JObject jObject = new JObject();

            foreach (PropertyInfo propertyInfo in obj.GetType().GetProperties())
            {
                if (propertyInfo.PropertyType == typeof(string) || propertyInfo.PropertyType == typeof(int) || propertyInfo.PropertyType == typeof(Boolean))
                {
                    jObject[propertyInfo.Name] = propertyInfo.GetValue(obj).ToString();
                }
            }

            eAuditoria.Data = JsonConvert.SerializeObject(obj);
            DAuditoria.add(eAuditoria);
        }
    }
}
