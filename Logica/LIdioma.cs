using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Datos;
using System.Data;
using System.Collections;

namespace Logica
{
    public class LIdioma
    {

        public UIdioma idiomaInicio(Int32 FORMULARIO , int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["L_MInicio"].ToString();
            com.B= compIdioma["L_PPopulares"].ToString();
            com.C = compIdioma["L_Opciones"].ToString();

            com.D = compIdioma["L_Plato1"].ToString();
            com.E = compIdioma["L_Detalle1"].ToString();
            com.F = compIdioma["L_Precio1"].ToString();

            com.G = compIdioma["L_Plato2"].ToString();
            com.H = compIdioma["L_Detalle2"].ToString();
            com.I = compIdioma["L_Precio2"].ToString();
            com.J = compIdioma["L_Plato3"].ToString();
            com.K = compIdioma["L_Detalle3"].ToString();
            com.L = compIdioma["L_Precio3"].ToString();

            return com;
        }
        public UIdioma idiomaInicio1(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["L_MInicio"].ToString();
            com.B = compIdioma["L_PPopulares"].ToString();
            com.C = compIdioma["L_Opciones"].ToString();

            com.D = compIdioma["L_Plato1"].ToString();
            com.E = compIdioma["L_Detalle1"].ToString();
            com.F = compIdioma["L_Precio1"].ToString();

            com.G = compIdioma["L_Plato2"].ToString();
            com.H = compIdioma["L_Detalle2"].ToString();
            com.I = compIdioma["L_Precio2"].ToString();
            com.J = compIdioma["L_Plato3"].ToString();
            com.K = compIdioma["L_Detalle3"].ToString();
            com.L = compIdioma["L_Precio3"].ToString();

            return com;
        }

        public UIdioma idiomaCanje(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["L_PuntoR"].ToString();
            com.B = compIdioma["L_cantPuntos"].ToString();
            com.C = compIdioma["L_puntosInsu"].ToString();

            com.D = compIdioma["LB_puntos"].ToString();
            com.E = compIdioma["L_Historial"].ToString();
            com.F = compIdioma["GV_Historial"].ToString();

            com.G = compIdioma["BT_Canje"].ToString();
            com.H = compIdioma["BT_Regresar"].ToString();
            com.I = compIdioma["JS_canje"].ToString();
            //com.J = compIdioma["L_Plato3"].ToString();
            //com.K = compIdioma["L_Detalle3"].ToString();
            //com.L = compIdioma["L_Precio3"].ToString();

            return com;
        }
        public UIdioma idiomaContacto(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["L_title"].ToString();
            com.B = compIdioma["LB_Nombre"].ToString();
            com.C = compIdioma["LB_Email"].ToString();

            com.D = compIdioma["LB_Telefono"].ToString();
            com.E = compIdioma["LB_Detalle"].ToString();
            com.F = compIdioma["BT_Enviar"].ToString();
            com.G = compIdioma["JS_contacto"].ToString();

            return com;
        }
        public UIdioma idiomaCreamenu(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["L_insertmenu"].ToString();
            com.B = compIdioma["LB_nompla"].ToString();
            com.C = compIdioma["LB_desc"].ToString();

            com.D = compIdioma["LB_precio"].ToString();
            com.E = compIdioma["LB_seleccionar"].ToString();
            com.F = compIdioma["B_guardar"].ToString();
            com.G = compIdioma["JS_crearP"].ToString();

            return com;
        }

        public UIdioma idiomaComentarios(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["lb_listComen"].ToString();
            com.B = compIdioma["LB_buscar"].ToString();
            com.C = compIdioma["BT_Buscar"].ToString();

            com.D = compIdioma["validator_username"].ToString();
            com.E = compIdioma["RFV_alerta"].ToString();
            com.F = compIdioma["LB_Detalle"].ToString();
            com.G = compIdioma["LB_Usuario"].ToString();


            return com;
        }
        public UIdioma idiomaListaplatos(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_listPlato"].ToString();
            com.B = compIdioma["BT_Nuevo"].ToString();
            com.C = compIdioma["B_modificar"].ToString();

            com.D = compIdioma["BT_Eliminar"].ToString();
            com.E = compIdioma["LB_buscar"].ToString();
            com.F = compIdioma["BT_Buscar"].ToString();
            com.G = compIdioma["RFV_alerta"].ToString();
            com.H = compIdioma["validator_username"].ToString();
            com.I = compIdioma["B_Seleccionar"].ToString();
            com.J = compIdioma["LB_Nombre"].ToString();
            com.K = compIdioma["LB_Descrip"].ToString();
            com.L = compIdioma["LB_Precio"].ToString();
            com.M = compIdioma["LB_Imagen"].ToString();
            com.N = compIdioma["JS_elimin"].ToString();

            return com;
        }

        public UIdioma idiomaDespachos(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_pedidos"].ToString();
            com.B = compIdioma["LB_Reservas"].ToString();
            com.C = compIdioma["LB_ordenes"].ToString();
            com.D = compIdioma["LB_Pedido"].ToString();
            com.E = compIdioma["LB_mesa"].ToString();
            com.F = compIdioma["LB_Plato"].ToString();
            com.G = compIdioma["LB_Cant"].ToString();
            com.H = compIdioma["LB_despachar"].ToString();

            return com;
        }

        public UIdioma idiomaGenerartoken(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_recuperar"].ToString();
            com.B = compIdioma["LB_nombre"].ToString();
            com.C = compIdioma["L_Mensaje"].ToString();
            com.D = compIdioma["JS_tokenR"].ToString();
            com.E = compIdioma["JS_tokenR1"].ToString();
            com.F = compIdioma["JS_tokenR2"].ToString();

            return com;
        }

        public UIdioma idiomaListaclientes(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_listClien"].ToString();
            com.B = compIdioma["LB_Buscar"].ToString();
            com.C = compIdioma["BT_Buscar"].ToString();
            com.D = compIdioma["REV_Username"].ToString();
            com.E = compIdioma["RFV_alerta"].ToString();
            com.F = compIdioma["LB_User"].ToString();
            com.G = compIdioma["LB_Nombre"].ToString();
            com.H = compIdioma["LB_Apellido"].ToString();
            com.I = compIdioma["LB_Email"].ToString();
            com.J = compIdioma["LB_Telefono"].ToString();
            com.K = compIdioma["LB_Puntos"].ToString();

            return com;
        }

        public UIdioma idiomaListaempleados(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_listEmple"].ToString();
            com.B = compIdioma["BT_Nuevo"].ToString();
            com.C = compIdioma["BT_Modificar"].ToString();
            com.D = compIdioma["BT_Eliminar"].ToString();
            com.E = compIdioma["LB_buscar"].ToString();
            com.F = compIdioma["BT_Buscar"].ToString();
            com.G = compIdioma["validator_username"].ToString();
            com.H = compIdioma["RFV_alerta"].ToString();
            com.I = compIdioma["LB_Nom"].ToString();
            com.J = compIdioma["LB_Ape"].ToString();
            com.K = compIdioma["LB_email"].ToString();
            com.L = compIdioma["LB_Tele"].ToString();
            com.M = compIdioma["LB_Cedu"].ToString();
            com.N = compIdioma["LB_Usua"].ToString();
            com.O = compIdioma["LB_Ro"].ToString();
            com.P = compIdioma["LB_Con"].ToString();
            com.Q = compIdioma["JS_eliminarE"].ToString();
            com.R = compIdioma["JS_modificarE"].ToString();
            com.S = compIdioma["JS_RegisE"].ToString();

            return com;
        }

        public UIdioma idiomaListaReservas(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_listReser"].ToString();
            com.B = compIdioma["LB_buscar"].ToString();
            com.C = compIdioma["BT_Buscar"].ToString();
            com.D = compIdioma["validator_username"].ToString();
            com.E = compIdioma["RFV_alerta"].ToString();
            com.F = compIdioma["LB_Nombre"].ToString();
            com.G = compIdioma["LB_Cantidad"].ToString();
            com.H = compIdioma["LB_Fechain"].ToString();
            com.I = compIdioma["LB_Fechade"].ToString();


            return com;
        }


        public UIdioma idiomaListarmesas(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_listmesas"].ToString();
            com.B = compIdioma["BT_Nuevo"].ToString();
            com.C = compIdioma["BT_Modificar"].ToString();
            com.D = compIdioma["BT_Eliminar"].ToString();
            com.E = compIdioma["LB_buscar"].ToString();
            com.F = compIdioma["BT_Buscar"].ToString();
            com.G = compIdioma["LB_Codigo"].ToString();
            com.H = compIdioma["LB_Cant"].ToString();
            com.I = compIdioma["LB_Ubi"].ToString();

            return com;
        }

        public UIdioma idiomaListaventas(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_listventas"].ToString();
            com.B = compIdioma["LB_buscar"].ToString();
            com.C = compIdioma["BT_Buscar"].ToString();
            com.D = compIdioma["validator_username"].ToString();
            com.E = compIdioma["RFV_alerta"].ToString();
            com.F = compIdioma["nombre"].ToString();
            com.G = compIdioma["cantidad"].ToString();
            com.H = compIdioma["fecha"].ToString();
            com.I = compIdioma["fecha_despacho"].ToString();

            return com;
        }

        public UIdioma idiomaLoggin(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_Login"].ToString();
            com.B = compIdioma["LB_username"].ToString();
            com.C = compIdioma["validator_username"].ToString();
            com.D = compIdioma["LB_pass"].ToString();
            com.E = compIdioma["LB_Recuperar"].ToString();
            com.F = compIdioma["B_Login"].ToString();
            com.G = compIdioma["B_Registrarse"].ToString();
            com.H = compIdioma["JS_loguear"].ToString();
            com.I = compIdioma["JS_loguear1"].ToString();
            com.J = compIdioma["JS_loguear2"].ToString();
            com.K = compIdioma["JS_loguear3"].ToString();

            return com;
        }
        public UIdioma idiomaMasteradmin(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_menunave"].ToString();
            com.B = compIdioma["LB_cerrar"].ToString();
            com.C = compIdioma["LB_users"].ToString();
            com.D = compIdioma["LB_comen"].ToString();
            com.E = compIdioma["LB_menu"].ToString();
            com.F = compIdioma["LB_Mesas"].ToString();
            com.G = compIdioma["LB_ventas"].ToString();
            com.H = compIdioma["LB_Reportes"].ToString();
            com.I = compIdioma["LB_clientes"].ToString();
            com.J = compIdioma["LB_Emple"].ToString();
            com.K = compIdioma["LB_Coment"].ToString();
            com.L = compIdioma["LB_menu1"].ToString();
            com.M = compIdioma["LB_mesas1"].ToString();
            com.N = compIdioma["LB_pedidos"].ToString();
            com.O = compIdioma["LB_Rerservas"].ToString();
            com.P = compIdioma["LB_repo1"].ToString();
            com.Q = compIdioma["LB_repo2"].ToString();
            com.R = compIdioma["LB_repo3"].ToString();
            com.S = compIdioma["LB_Idioma"].ToString();


            return com;
        }
        public UIdioma idiomaMastercocinero(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_Pedidos"].ToString();
            com.B = compIdioma["LB_cerrar"].ToString();


            return com;
        }

        public UIdioma idiomaMastermesero(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_pedidos"].ToString();
            com.B = compIdioma["LB_Reser"].ToString();
            com.C = compIdioma["LB_cerrar"].ToString();


            return com;
        }

        public UIdioma idiomaMasterprincipal(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_inicio"].ToString();
            com.B = compIdioma["LB_contacto"].ToString();
            com.C = compIdioma["LB_Menu"].ToString();
            com.D = compIdioma["LB_Reservas"].ToString();
            //com.E = compIdioma["BT_login"].ToString();
            //com.F = compIdioma["BT_Cerrar"].ToString();
            com.G = compIdioma["LB_login"].ToString();
            com.H = compIdioma["LB_cerrar"].ToString();
            com.I = compIdioma["L_Comentario"].ToString();
            com.J = compIdioma["REV_tex"].ToString();
            com.K = compIdioma["BT_Enviar"].ToString();
            //com.L = compIdioma["JS_comen"].ToString();


            return com;
        }
        public UIdioma idiomaMasterprincipal1(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_inicio"].ToString();
            com.B = compIdioma["LB_contacto"].ToString();
            com.C = compIdioma["LB_Menu"].ToString();
            com.D = compIdioma["LB_Reservas"].ToString();
            //com.E = compIdioma["BT_login"].ToString();
            //com.F = compIdioma["BT_Cerrar"].ToString();
            com.G = compIdioma["LB_login"].ToString();
            com.H = compIdioma["LB_cerrar"].ToString();
            com.I = compIdioma["L_Comentario"].ToString();
            com.J = compIdioma["REV_tex"].ToString();
            com.K = compIdioma["BT_Enviar"].ToString();
            //com.L = compIdioma["JS_comen"].ToString();


            return com;
        }
        public UIdioma idiomaMenureserva(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
          //  com.A = compIdioma["L_Usuario"].ToString();
            com.B = compIdioma["LB_nombre"].ToString();
            com.C = compIdioma["LB_desc"].ToString();
            com.D = compIdioma["LB_precio"].ToString();
            com.E = compIdioma["LB_ingreCant"].ToString();
            com.F = compIdioma["B_guardar"].ToString();


            return com;
        }

        public UIdioma idiomaModificarempleado(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_modiemp"].ToString();
            com.B = compIdioma["LB_nombre"].ToString();
            com.C = compIdioma["LB_apellido"].ToString();
            com.D = compIdioma["LB_usuario"].ToString();
            com.E = compIdioma["LB_email"].ToString();
            com.F = compIdioma["LB_contra"].ToString();
            com.G = compIdioma["LB_cedula"].ToString();
            com.H = compIdioma["LB_concon"].ToString();
            com.I = compIdioma["LB_celu"].ToString();
            com.J = compIdioma["LB_rol"].ToString();
            com.K = compIdioma["RFV_Nombre"].ToString();
            //com.L = compIdioma["RFV_Apellido"].ToString();
            com.M = compIdioma["REV_Apellido"].ToString();
            ////com.N = compIdioma["RFV_Usuario"].ToString();
            //com.O = compIdioma["RFV_Email"].ToString();
            com.P = compIdioma["CV_CContrasena"].ToString();
            //com.Q = compIdioma["RFV_Cedula"].ToString();
            com.R = compIdioma["REV_Nombre1"].ToString();
            com.T = compIdioma["REV_Nombre2"].ToString();
            com.S = compIdioma["0"].ToString();
            com.U = compIdioma["1"].ToString();
            com.V = compIdioma["2"].ToString();
            com.W = compIdioma["RV_Rol"].ToString();
            com.X = compIdioma["B_Modificar"].ToString();
            return com;
        }

        public UIdioma idiomaModificarmenu(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_modimeni"].ToString();
            com.B = compIdioma["LB_nompla"].ToString();
            com.C = compIdioma["REV_nombre"].ToString();
            com.D = compIdioma["LB_desc"].ToString();
            com.E = compIdioma["REV_desc"].ToString();
            com.F = compIdioma["LB_preciopla"].ToString();
            com.G = compIdioma["validator_precio"].ToString();
            com.H = compIdioma["LB_imagen"].ToString();
            com.I = compIdioma["FU_imagen"].ToString();
            com.J = compIdioma["B_Modificar"].ToString();
            com.K = compIdioma["JS_ModificarPla"].ToString();
            com.L = compIdioma["JS_carga"].ToString();
            com.M = compIdioma["JS_carga1"].ToString();


            return com;
        }

        public UIdioma idiomaModificarmesa(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_modimesa"].ToString();
            com.B = compIdioma["LB_codimesa"].ToString();
            com.C = compIdioma["LB_cantper"].ToString();
            com.D = compIdioma["LB_ubi"].ToString();
            com.E = compIdioma["BT_Modificar"].ToString();
            com.F = compIdioma["JS_ModifiMesa"].ToString();


            return com;
        }
        public UIdioma idiomaNuevamesa(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_nuevamesa"].ToString();
            com.B = compIdioma["LB_cantper"].ToString();
            com.C = compIdioma["RFV_numeros"].ToString();
            com.D = compIdioma["LB_ubi"].ToString();
            com.E = compIdioma["RFV_ubi"].ToString();
            com.F = compIdioma["BT_Nuevo"].ToString();
            com.G = compIdioma["JS_Nmesa"].ToString();


            return com;
        }

        public UIdioma idiomaPago(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_pago"].ToString();
            com.B = compIdioma["LB_preciore"].ToString();
            com.C = compIdioma["LB_valor"].ToString();
            com.D = compIdioma["BT_pagar"].ToString();
            com.E = compIdioma["JS_pago"].ToString();


            return com;
        }

        public UIdioma idiomaRecuperar_contraseña(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_recucontra"].ToString();
            com.B = compIdioma["LB_newpas"].ToString();
            com.C = compIdioma["LB_Rnewpas"].ToString();
            com.D = compIdioma["CV_veri"].ToString();
            com.E = compIdioma["Guardar_new_pass"].ToString();
            com.F = compIdioma["JS_Ncontra"].ToString();


            return com;
        }

        public UIdioma idiomaRegistro(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_regis"].ToString();
            com.B = compIdioma["LB_nombre"].ToString();
            com.C = compIdioma["LB_user"].ToString();
            com.D = compIdioma["LB_pass"].ToString();
            com.E = compIdioma["LB_rpass"].ToString();
            com.F = compIdioma["REV_Nombre"].ToString();
            com.G = compIdioma["validator_username"].ToString();
            com.H = compIdioma["CV_CContrasena"].ToString();
            com.I = compIdioma["LB_apellido"].ToString();
            com.J = compIdioma["LB_email"].ToString();
            com.K = compIdioma["LB_cedula"].ToString();
            com.L = compIdioma["LB_celu"].ToString();
            com.M = compIdioma["REV_Nombre0"].ToString();
            com.N = compIdioma["REV_Nombre1"].ToString();
            com.O = compIdioma["REV_Nombre2"].ToString();
            com.P = compIdioma["B_Crear"].ToString();
            com.Q = compIdioma["JS_registro"].ToString();
            com.R = compIdioma["JS_registro1"].ToString();
            return com;
        }

        public UIdioma idiomaRegistrarempleado(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_regisemp"].ToString();
            com.B = compIdioma["LB_nombre"].ToString();
            com.C = compIdioma["LB_user"].ToString();
            com.D = compIdioma["LB_pas"].ToString();
            com.E = compIdioma["LB_rpas"].ToString();
            com.F = compIdioma["LB_apellido"].ToString();
            com.G = compIdioma["LB_email"].ToString();
            com.H = compIdioma["LB_cedula"].ToString();
            com.I = compIdioma["LB_celu"].ToString();
            com.J = compIdioma["CV_CContrasena"].ToString();
            com.K = compIdioma["LB_rol"].ToString();
            //com.L = compIdioma["DDL_Rol"].ToString();
            //com.M = compIdioma["DDL_Rol"].ToString();
            com.O = compIdioma["B_Crear"].ToString();
            return com;
        }

        public UIdioma idiomaResrvas(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();

            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }

            com.A = compIdioma["L_Reservas"].ToString();
            com.B = compIdioma["L_Fecha"].ToString();
            com.C = compIdioma["L_Hora"].ToString();
            com.D = compIdioma["L_Cantidad"].ToString();
            com.E = compIdioma["B_Reservar"].ToString();
            com.F = compIdioma["BT_MReservas"].ToString();
            com.G = compIdioma["REV_Fecha"].ToString();
            com.H = compIdioma["RV_Hora"].ToString();
            com.I = compIdioma["RV_Cantidad"].ToString();
            com.J = compIdioma["JS_Reserva"].ToString();
            com.K = compIdioma["JS_reservaRe"].ToString();
            com.L= compIdioma["JS_ReservaToken"].ToString();
            com.M = compIdioma["JS_ReservaE"].ToString();
            return com;
        }
        public UIdioma idiomaReserva(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();
            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.E = compIdioma["LB_reserT"].ToString();
            com.C = compIdioma["BT_Platos"].ToString();
            return com;

        }
        public UIdioma idiomaPedido(Int32 FORMULARIO, int DDL)
        {
            Idioma idioma = new Idioma();
            UIdioma com = new UIdioma();
            DataTable info = idioma.obtenerIdioma(FORMULARIO, DDL);
            Hashtable compIdioma = new Hashtable();
            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            com.A = compIdioma["LB_pedidoT"].ToString();
            com.B = compIdioma["LB_seleccion"].ToString();
            com.C = compIdioma["BT_Mesa"].ToString();
            com.D = compIdioma["LB_menuT"].ToString();
            return com;
        }

        public DataTable obtenerIdioma()
        {
            Idioma dato = new Idioma();
            DataTable data = dato.obtenerIdio();
            return data;
        }

        public DataTable obtenerFormulario()
        {
            Idioma dato = new Idioma();
            DataTable data = dato.obtenerFormulario();
            return data;
        }

        //public DataTable obtenerControles()
        //{
        //    Idioma dato = new Idioma();
        //    Int32 formulario = 
        //    DataTable data = dato.obtenerIdioma(int formulario , int idioma);
        //    return data;
        //}
        public DataTable obtenerControl(Int32 formulario, Int32 idioma)
        {
            Idioma dato= new Idioma();
            DataTable data = dato.obtenerIdioma(formulario, idioma);
            return data;
        }

        public Hashtable hastableIdioma(DataTable info, Hashtable compIdioma)
        {
            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            return compIdioma;
        }

        public Hashtable hastableIdioma1(DataTable info, Hashtable compIdioma)
        {
            for (int i = 0; i < info.Rows.Count; i++)
            {
                compIdioma.Add(info.Rows[i]["control"].ToString(), info.Rows[i]["valor"].ToString());
            }
            return compIdioma;
        }

        public Estado estado(UUser datos)
        {
            Estado desp = new Estado();


            if (datos.User_name == null)
            {
                desp.Esstado = true;
            }
            else
            {
                desp.Esstado = false;
                desp.Idioma = datos.A;
            }

            return desp;

        }
        public UIdioma modificarTexto(UIdioma user)
        {
            Idioma data = new Idioma();
            UIdioma dato = new UIdioma();
            data.modificarTexto(user);
            dato.Mensaje = "<script type='text/javascript'>alert('" + user.Mensaje.ToString() + "');window.location=\"Idioma.aspx\"</script>";

            return dato;
        }

        public UIdioma eliminarIdioma(UIdioma user)
        {
            Idioma data = new Idioma();
            UIdioma dato = new UIdioma();

            if (user.Id != 1)
            {
                data.eliminarIdioma(user);
                dato.Mensaje = "<script type='text/javascript'>alert('" + user.Mensaje.ToString() + "');window.location=\"Idioma.aspx\"</script>";

            }
            else
            {
                dato.Mensaje = "<script type='text/javascript'>alert('" + user.B.ToString() + "');window.location=\"Idioma.aspx\"</script>";

            }

            return dato;
        }

        //public UIdioma agregarIdioma(UIdioma datos)
        //{
        //    Idioma data = new Idioma();
        //    UIdioma user = new UIdioma();

        //    System.Data.DataTable validez = data.validarIdioma(datos);
        //    if (int.Parse(validez.Rows[0]["id"].ToString()) > 0)
        //    {
        //        data.agregarIdioma(datos);

        //        //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Creado Correctamente');</script>");
        //        user.Mensaje = "<script type='text/javascript'>alert('" + datos.Mensaje.ToString() + "');window.location=\"Idioma.aspx\"</script>";

        //    }
        //    else
        //    {
        //        user.Mensaje = "<script type='text/javascript'>alert('" + datos.A.ToString() + "');</script>";
        //    }


        //    return user;
        //}

        public UIdioma agregarControl(UIdioma datos)
        {
            Idioma data = new Idioma();
            UIdioma user = new UIdioma();

            System.Data.DataTable validez = data.validarControl(datos);
            if (int.Parse(validez.Rows[0]["id"].ToString()) == 0)
            {
                data.agregarControl(datos);
                //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Creado Correctamente');</script>");
                user.Mensaje = "<script type='text/javascript'>alert('" + datos.Mensaje.ToString() + "');window.location=\"Idioma.aspx\"</script>";

            }
            else
            {
                user.Mensaje = "<script type='text/javascript'>alert('" + datos.A.ToString() + "');</script>";
            }

            return user;
        }

        public DataTable obtenerControles(Int32 formulario, Int32 idioma)
        {
            Idioma dato = new Idioma();
            DataTable data = dato.obtenerControlador(formulario, idioma);
            return data;
        }


    }
}
