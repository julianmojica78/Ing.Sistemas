using Datos;
using Logica;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using Utilitarios;

/// <summary>
/// Descripción breve de Servicios
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class Servicios : System.Web.Services.WebService
{
    public ClientScriptManager ClientScript { get; private set; }
    public object Page { get; private set; }

    public Servicios()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    public Seguridad SoapHeader;

    [WebMethod]
    [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
    public string AutenticationUsuario()
    {
        try
        {
            if (SoapHeader == null) return "-1";
            if (!SoapHeader.blCredencialesValidas(SoapHeader.stToken)) return "-1";

            string stToken = Guid.NewGuid().ToString();

            HttpRuntime.Cache.Add(stToken,
                SoapHeader.stToken,
                null,
                System.Web.Caching.Cache.NoAbsoluteExpiration,
                TimeSpan.FromDays(2),
                System.Web.Caching.CacheItemPriority.NotRemovable,
                null);
            return stToken;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [WebMethod]
    [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
    public string AutenticationUsuari()
    {
        try
        {
            if (SoapHeader == null) return "-1";
            if (!SoapHeader.blCredencialesValidas(SoapHeader.stToken)) return "-1";

            string stToken = Guid.NewGuid().ToString();

            HttpRuntime.Cache.Add(stToken,
                SoapHeader.stToken,
                null,
                System.Web.Caching.Cache.NoAbsoluteExpiration,
                TimeSpan.FromDays(2),
                System.Web.Caching.CacheItemPriority.NotRemovable,
                null);
            return stToken;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [WebMethod]
    [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
    public String LMenu()
    {
        try
        {
            if (SoapHeader == null) throw new Exception("Requiere validacion");

            if (!SoapHeader.blCredencialesValidas(SoapHeader)) throw new Exception("Requiere validacion");

            L_Persistencia datos = new L_Persistencia();
            Menu m = new Menu();
            UUser dato = new UUser();
            DataTable data = datos.ToDataTable(datos.obtenerMenu());
            DataTable d = new DataTable();
            d.Columns.Add("id");
            d.Columns.Add("nombre");
            d.Columns.Add("descripcion");
            d.Columns.Add("precio");
            d.Columns.Add("imagen");
            d.AcceptChanges();

            int i = 0;
            foreach (DataRow dat in data.Rows)
            {

                m.Id_plato = int.Parse(data.Rows[i]["id_plato"].ToString());
                m.Nombre = data.Rows[i]["nombre"].ToString();
                m.Descripcion = data.Rows[i]["descripcion"].ToString();
                m.Precio = data.Rows[i]["precio"].ToString();
                String img = data.Rows[i]["imagen"].ToString();


                //m.Id_plato = int.Parse(data.Rows[1]["id_plato"].ToString());
                //m.Nombre = data.Rows[1]["nombre"].ToString();
                //m.Descripcion = data.Rows[1]["descripcion"].ToString();
                //m.Precio = data.Rows[1]["precio"].ToString();
                //String img = data.Rows[1]["imagen"].ToString();

                String a = img.Replace("~", "");
                //Image _imagen = Image.FromFile(HttpContext.Current.Server.MapPath(img));
                //byte[] _bytes = ImgToByteArray(_imagen);
                //String _strBase64 = Convert.ToBase64String(_bytes);
                m.Imagen = "http://localhost:53180" + a;

                d.Rows.Add(m.Id_plato, m.Nombre, m.Descripcion, m.Precio, m.Imagen);
                i++;
            }

            String datas = JsonConvert.SerializeObject(d);
            return datas;
        }
        catch (Exception ex) { throw ex; }

    }

    [WebMethod]
    [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
    public String Filtro(String nombre)
    {
        try
        {
            if (SoapHeader == null) throw new Exception("Requiere validacion");

            if (!SoapHeader.blCredencialesValidas(SoapHeader)) throw new Exception("Requiere validacion");
            L_Persistencia dato = new L_Persistencia();
            UUser datos = new UUser();
            Menu m = new Menu();
            ClientScriptManager cm = this.ClientScript;
            DataTable data = dato.ToDataTable(dato.buscarPlatos(nombre));
            DataTable d = new DataTable();
            d.Columns.Add("id");
            d.Columns.Add("nombre");
            d.Columns.Add("descripcion");
            d.Columns.Add("precio");
            d.Columns.Add("imagen");
            d.AcceptChanges();

            int i = 0;
            foreach (DataRow dat in data.Rows)
            {

                m.Id_plato = int.Parse(data.Rows[i]["id_plato"].ToString());
                m.Nombre = data.Rows[i]["nombre"].ToString();
                m.Descripcion = data.Rows[i]["descripcion"].ToString();
                m.Precio = data.Rows[i]["precio"].ToString();
                String img = data.Rows[i]["imagen"].ToString();


                //m.Id_plato = int.Parse(data.Rows[1]["id_plato"].ToString());
                //m.Nombre = data.Rows[1]["nombre"].ToString();
                //m.Descripcion = data.Rows[1]["descripcion"].ToString();
                //m.Precio = data.Rows[1]["precio"].ToString();
                //String img = data.Rows[1]["imagen"].ToString();

                String a = img.Replace("~", "");
                //Image _imagen = Image.FromFile(HttpContext.Current.Server.MapPath(img));
                //byte[] _bytes = ImgToByteArray(_imagen);
                //String _strBase64 = Convert.ToBase64String(_bytes);
                m.Imagen = "http://localhost:53180" + a;

                d.Rows.Add(m.Id_plato, m.Nombre, m.Descripcion, m.Precio, m.Imagen);
                i++;
            }

            String datas = JsonConvert.SerializeObject(d);
            return datas;
        }
        catch (Exception ex) { throw ex; }
    }

    private void RegisterStartupScript(string v1, string v2)
    {
        throw new NotImplementedException();
    }

    private byte[] ImgToByteArray(Image _img)
    {
        MemoryStream ms = new MemoryStream();
        _img.Save(ms, ImageFormat.Jpeg);
        return ms.ToArray();
    }

    private string encriptar(string input)
    {
        SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hashedBytes = provider.ComputeHash(inputBytes);

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < hashedBytes.Length; i++)
            output.Append(hashedBytes[i].ToString("x2").ToLower());

        return output.ToString();
    }

    [WebMethod]
    [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
    public UReserva Reserva(String fecha, String hora, Int32 cantidad, String data)
    {
        try
        {
            if (SoapHeader == null) throw new Exception("Requiere validacion");

            if (!SoapHeader.blCredencialesValidas(SoapHeader)) throw new Exception("Requiere validacion");

            UReserva datos = new UReserva();
            UReservation dato = new UReservation();
            LUser user = new LUser();
            UEmpleados usuario = new UEmpleados();
            UUsuario usu = new UUsuario();
            LUsuario regi = new LUsuario();
            ClientScriptManager cm = this.ClientScript;

            String json = data;

            Object jobject = JsonConvert.DeserializeObject<Object>(json);
            DataTable regis = new DataTable();
            usuario = JsonConvert.DeserializeObject<UEmpleados>(json);
            //DataTable regis = user.ToDataTable(reg);

            usuario.Telefono = "1234";
            usuario.Cedula = "1234";
            usuario.Puntos = 0;
            usuario.Id_Rol = 4;
            usuario.Sesiones = 0;
            usuario.Intentos = 0;
            usuario.Session = "a";

            String dia = fecha + ' ' + hora + ":00";
            dato.Dia = dia;
            dato.Id_mesa = cantidad;
            datos.A = "Para Confirmar su reseva,por favor pague el valor de la reserva";
            datos.B = "No puede reservas si no esta Logueado";
            datos.C = "Ya existe un token, por favor verifique su correo.";
            datos.D = "La Reserva no existe";
            try
            {
                DataTable dat = user.verificarRes(usuario.User_Name1);
                if (int.Parse(dat.Rows.Count.ToString()) > 0)
                {
                    dato.Id_usuario = int.Parse(dat.Rows[0]["user_id"].ToString());
                    datos.Nombre = dat.Rows[0]["user_name1"].ToString();

                    datos = user.Rserva(datos, dato);
                }
                else
                {
                    usu.Mensaje = "";
                    usu.Extension = "";
                    usu = regi.insertUsuario(usuario, usu);

                    DataTable rese = user.verificarRes(usuario.User_Name1);
                    dato.Id_usuario = int.Parse(rese.Rows[0]["user_id"].ToString());
                    datos.Nombre = rese.Rows[0]["user_name1"].ToString();
                    datos = user.Rserva(datos, dato);
                    //cm.RegisterClientScriptBlock(this.GetType(), "", datos.Mensaje);

                }

            }
            catch
            {
                datos = user.Rserva(datos, dato);
                //this.RegisterStartupScript("mensaje", datos.Mensaje);
            }

            return datos;
        }
        catch (Exception ex) { throw ex; }
    }

    [WebMethod]
    [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
    public DataTable Login(String user, String clave)
    {
        try
        {
            if (SoapHeader == null) throw new Exception("Requiere validacion");

            if (!SoapHeader.blCredencialesValidas(SoapHeader)) throw new Exception("Requiere validacion");
            UUser datos = new UUser();
            LUser data = new LUser();

            datos.User_name = user;
            datos.Clave = clave;


            DataTable dato = data.login(datos);
            DataSet dat = new DataSet();
            dat.Tables.Add(dato);
            return dato;
        }
        catch (Exception ex) { throw ex; }
    }
    [WebMethod]
    [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
    public UUser Contactenos(String nombre, String email, String telefono, String detalle)
    {
        try
        {
            if (SoapHeader == null) throw new Exception("Requiere validacion");

            if (!SoapHeader.blCredencialesValidas(SoapHeader)) throw new Exception("Requiere validacion");

            UUser dato = new UUser();
            UContacto datos = new UContacto();
            L_Persistencia data = new L_Persistencia();

            datos.Nombre = nombre;
            datos.Email = email;
            datos.Telefono = telefono;
            datos.Detalle = detalle;
            data.insertarcontacto(datos);
            return dato;
        }
        catch (Exception ex) { throw ex; }
    }

    [WebMethod]
    [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
    public String Ofertas()
    {
        try
        {
            if (SoapHeader == null) throw new Exception("Requiere validacion");

            if (!SoapHeader.blCredencialesValidas(SoapHeader)) throw new Exception("Requiere validacion");
            L_Persistencia datos = new L_Persistencia();
            Ofertas m = new Ofertas();
            UUser dato = new UUser();
            DataTable data = datos.ToDataTable(datos.obtenerOferta());
            DataTable d = new DataTable();
            d.Columns.Add("id");
            d.Columns.Add("nombre");
            d.Columns.Add("descripcion");
            d.Columns.Add("precio");
            d.Columns.Add("oferta");
            d.Columns.Add("imagen");
            d.AcceptChanges();

            int i = 0;
            foreach (DataRow dat in data.Rows)
            {

                m.Id_ofertas = int.Parse(data.Rows[i]["id_plato"].ToString());
                m.Nombre = data.Rows[i]["nombre"].ToString();
                m.Descripcion = data.Rows[i]["descripcion"].ToString();
                m.Precio = data.Rows[i]["precio"].ToString();
                m.Oferta = data.Rows[i]["oferta"].ToString();
                String img = data.Rows[i]["imagen"].ToString();

                String a = img.Replace("~", "");
                m.Imagen = "http://localhost:53180" + a;

                d.Rows.Add(m.Id_ofertas, m.Nombre, m.Descripcion, m.Precio, m.Oferta, m.Imagen);
                i++;
            }

            String datas = JsonConvert.SerializeObject(d);
            return datas;
        }
        catch (Exception ex) { throw ex; }
    }

    [WebMethod]
    [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
    public String TopPlatos()
    {

        try
        {
            if (SoapHeader == null) throw new Exception("Requiere validacion");

            if (!SoapHeader.blCredencialesValidas(SoapHeader)) throw new Exception("Requiere validacion");
            L_Persistencia datos = new L_Persistencia();
            TopPlatos m = new TopPlatos();
            UUser dato = new UUser();
            DataTable data = datos.ToDataTable(datos.obtenerTop());
            DataTable d = new DataTable();
            d.Columns.Add("id");
            d.Columns.Add("nombre");
            d.Columns.Add("descripcion");
            d.Columns.Add("precio");
            d.Columns.Add("imagen");
            d.AcceptChanges();

            int i = 0;
            foreach (DataRow dat in data.Rows)
            {

                m.Id_plato = int.Parse(data.Rows[i]["id_plato"].ToString());
                m.Nombre = data.Rows[i]["nombre"].ToString();
                m.Descripcion = data.Rows[i]["descripcion"].ToString();
                m.Precio = data.Rows[i]["precio"].ToString();
                String img = data.Rows[i]["imagen"].ToString();

                String a = img.Replace("~", "");
                m.Imagen = "http://localhost:53180" + a;

                d.Rows.Add(m.Id_plato, m.Nombre, m.Descripcion, m.Precio, m.Imagen);
                i++;
            }

            String datas = JsonConvert.SerializeObject(d);
            return datas;
        }
        catch (Exception ex) { throw ex; }
    }
    public DataTable obtenerPost(SRGamesCol.ServiceToken p)
    {
        SRGamesCol.Facebook_servideSoapClient eti = new SRGamesCol.Facebook_servideSoapClient();
        DataTable dato = new DataTable();
        dato = eti.noticias(p);
        return dato;
    }
}