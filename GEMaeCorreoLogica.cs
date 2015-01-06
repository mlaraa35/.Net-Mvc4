

using System;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using PPBMS.SGR.Entidades;
using PPBMS.SGR.AccesoDatos;
using System.Net.Mail;

namespace PPBMS.SGR.LogicaNegocio
{
 

	public class GEMaeCorreoLogica
	{
 
		
		string MENSAJE_ERROR = ConfigurationManager.AppSettings["MENSAJE_ERROR"].ToString();
		string MENSAJE_ERROR_DETALLE = ConfigurationManager.AppSettings["MENSAJE_ERROR_DETALLE"].ToString();
        string MENSAJE_SUCCESS = ConfigurationManager.AppSettings["MENSAJE_SUCCESS"].ToString();
		string MENSAJE_SUCCESS_DETALLE = ConfigurationManager.AppSettings["MENSAJE_SUCCESS_DETALLE"].ToString();
        
        static String strUserName = ConfigurationManager.AppSettings["UserName_Imp"].ToString();
        static String strPass = ConfigurationManager.AppSettings["Pass_Imp"].ToString();
        static String strDominio = ConfigurationManager.AppSettings["Dominio_Imp"].ToString();
        static String impersonar = ConfigurationManager.AppSettings["impersonar"].ToString();
		
		public GEMaeCorreoLogica() {}

		GEMaeCorreoData oDGEMaeCorreo = new GEMaeCorreoData();		

	 
		public GEMaeCorreoEntidad Consultar(GEMaeCorreoEntidad oGEMaeCorreo)
		{
			PPBMS.SGR.Entidades.Util.MensajeResultado oResultado = new PPBMS.SGR.Entidades.Util.MensajeResultado();
			try 
			{
				
			
				oResultado.MENSAJE = MENSAJE_SUCCESS;
				oResultado.DETALLE = MENSAJE_SUCCESS_DETALLE;
				oResultado.ESTADO = 1;
				oResultado.ID_RETURN = "1";
				return oDGEMaeCorreo.Consultar(oGEMaeCorreo);
				
            }
            catch (Exception ex)
            {
				oResultado.ESTADO = 0;
				oResultado.MENSAJE = MENSAJE_ERROR;
				oResultado.DETALLE = MENSAJE_ERROR_DETALLE;
				oResultado.ID_RETURN = "-1";
				oResultado.DETALLE = ex.Message.ToString();
				return oDGEMaeCorreo.Consultar(oGEMaeCorreo);
            }
            
        }

		public GEMaeCorreoEntidadWS ConsultarWS(GEMaeCorreoEntidad oGEMaeCorreo)
		{
			PPBMS.SGR.Entidades.Util.MensajeResultado oResultado = new PPBMS.SGR.Entidades.Util.MensajeResultado();
			try 
			{
				
			
				oResultado.MENSAJE = MENSAJE_SUCCESS;
				oResultado.DETALLE = MENSAJE_SUCCESS_DETALLE;
				oResultado.ESTADO = 1;
				oResultado.ID_RETURN = "1";
				return oDGEMaeCorreo.ConsultarWS(oGEMaeCorreo);
				
            }
            catch (Exception ex)
            {
				oResultado.ESTADO = 0;
				oResultado.MENSAJE = MENSAJE_ERROR;
				oResultado.DETALLE = MENSAJE_ERROR_DETALLE;
				oResultado.ID_RETURN = "-1";
				oResultado.DETALLE = ex.Message.ToString();
				return oDGEMaeCorreo.ConsultarWS(oGEMaeCorreo);
            }
            
        }
        /// <summary>
        /// Autor : Alejandra Chávez Panez
        /// Fecha : 26/12/2014
        /// Descripción : Método para llamar al método Enviar Correo de la Capa De Datos.
        /// </summary>
        /// <param name="oGEMaeCorreo"></param>
        /// <returns></returns>
        public MailMessage EnviarCorreo(GEMaeCorreoEntidad oGEMaeCorreo, GRMaeRequerimientoEntidad objGRMaeRequerimiento)
        {
            GEMaeCorreoData objGEMaeCorreoData = new GEMaeCorreoData();
            //MailMessage resultado;

            //resultado = objGEMaeCorreoData.EnviarCorreo(oGEMaeCorreo);

            return objGEMaeCorreoData.EnviarCorreo(oGEMaeCorreo, objGRMaeRequerimiento); ;
        }









































        //public GEMaeCorreoEntidadWS ConsultarGridWS(GEMaeCorreoEntidad oGEMaeCorreo)
        //{
        //    PPBMS.SGR.Entidades.Util.MensajeResultado oResultado = new PPBMS.SGR.Entidades.Util.MensajeResultado();
        //    try
        //    {


        //        oResultado.MENSAJE = MENSAJE_SUCCESS;
        //        oResultado.DETALLE = MENSAJE_SUCCESS_DETALLE;
        //        oResultado.ESTADO = 1;
        //        oResultado.ID_RETURN = "1";
        //        return oDGEMaeCorreo.ConsultarGridWS(oGEMaeCorreo);

        //    }
        //    catch (Exception ex)
        //    {
        //        oResultado.ESTADO = 0;
        //        oResultado.MENSAJE = MENSAJE_ERROR;
        //        oResultado.DETALLE = MENSAJE_ERROR_DETALLE;
        //        oResultado.ID_RETURN = "-1";
        //        oResultado.DETALLE = ex.Message.ToString();
        //        return oDGEMaeCorreo.ConsultarGridWS(oGEMaeCorreo);
        //    }

        //}

        //public PPBMS.SGR.Entidades.Util.MensajeResultado Agregar(GEMaeCorreoEntidad oGEMaeCorreo)
        //{
        //    PPBMS.SGR.Entidades.Util.MensajeResultado oResultado = new PPBMS.SGR.Entidades.Util.MensajeResultado();

        //    try
        //    {
        //        oResultado = oDGEMaeCorreo.Agregar(oGEMaeCorreo);

        //        oResultado.MENSAJE = MENSAJE_SUCCESS;
        //        oResultado.DETALLE = MENSAJE_SUCCESS_DETALLE;
        //        oResultado.ESTADO = 1;
        //        oResultado.ID_RETURN = "1";
        //        return oResultado;

        //    }
        //    catch (Exception ex)
        //    {
        //        oResultado.ESTADO = 0;
        //        oResultado.MENSAJE = MENSAJE_ERROR;
        //        oResultado.DETALLE = MENSAJE_ERROR_DETALLE;
        //        oResultado.ID_RETURN = "-1";
        //        oResultado.DETALLE = ex.Message.ToString();
        //        return oResultado;
        //    }

        //}

        //public PPBMS.SGR.Entidades.Util.MensajeResultado Actualizar(GEMaeCorreoEntidad oGEMaeCorreo)
        //{
        //    PPBMS.SGR.Entidades.Util.MensajeResultado oResultado = new PPBMS.SGR.Entidades.Util.MensajeResultado();
        //    try
        //    {
        //        oResultado = oDGEMaeCorreo.Actualizar(oGEMaeCorreo);
        //        oResultado.MENSAJE = MENSAJE_SUCCESS;
        //        oResultado.DETALLE = MENSAJE_SUCCESS_DETALLE;
        //        oResultado.ESTADO = 1;
        //        oResultado.ID_RETURN = "1";
        //        return oResultado;

        //    }
        //    catch (Exception ex)
        //    {
        //        oResultado.ESTADO = 0;
        //        oResultado.MENSAJE = MENSAJE_ERROR;
        //        oResultado.DETALLE = MENSAJE_ERROR_DETALLE;
        //        oResultado.ID_RETURN = "-1";
        //        oResultado.DETALLE = ex.Message.ToString();
        //        return oResultado;
        //    }
        //}


        //public PPBMS.SGR.Entidades.Util.MensajeResultado Eliminar(GEMaeCorreoEntidad oGEMaeCorreo)
        //{
        //    PPBMS.SGR.Entidades.Util.MensajeResultado oResultado = new PPBMS.SGR.Entidades.Util.MensajeResultado();
        //    try
        //    {
        //        oResultado = oDGEMaeCorreo.Eliminar(oGEMaeCorreo);
        //        oResultado.MENSAJE = MENSAJE_SUCCESS;
        //        oResultado.DETALLE = MENSAJE_SUCCESS_DETALLE;
        //        oResultado.ESTADO = 1;
        //        oResultado.ID_RETURN = "1";
        //        return oResultado;

        //    }
        //    catch (Exception ex)
        //    {
        //        oResultado.ESTADO = 0;
        //        oResultado.MENSAJE = MENSAJE_ERROR;
        //        oResultado.DETALLE = MENSAJE_ERROR_DETALLE;
        //        oResultado.ID_RETURN = "-1";
        //        oResultado.DETALLE = ex.Message.ToString();
        //        return oResultado;
        //    }

        //}




	}
}
