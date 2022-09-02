using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Gestor_casos.Utilidades
{
    public class EnviarCorreo
    {
        #region Conrreo confirmacion
        public void Enviar_confirmacion_Correo(String Direccion_DCorreo, String NumeroCaso, String Servicio)
        {
            try
            {
                Smtp Ec = new Smtp();
                MailMessage mensaje = new MailMessage();

                var numeroCaso = NumeroCaso;
                var servicio = Servicio;

                var asunto = "Caso " + numeroCaso + " Creado";
                var remitente = "soporte.it.umg2022@gmail.com";
                var nombre = "Gestion de Casos";
                var cuerpo = "  Buen dia, su caso numero " + numeroCaso +
                " \n\n Fue creado satisfactoriamente  \n\n El equipo de " + servicio + " \n\n Lo estara contactando";

                mensaje.Subject = asunto;
                var Direccion_Correo = Direccion_DCorreo;

                mensaje.To.Add(new MailAddress(Direccion_Correo));
                mensaje.CC.Add(new MailAddress("juniorh2911@gmail.com"));

                mensaje.From = new MailAddress(remitente, nombre);

                mensaje.Body = cuerpo;

                /* Enviar */
                Ec.MandarCorreo(mensaje);

                //Logs log = new Logs();
                //log.Log("El Mail se ha Enviado Correctamente");
                /*MessageBox.Show("El Mail se ha Enviado Correctamente", "Correo Enviado " +
                "...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);*/

                mensaje.Dispose();//********Mata el evento y el objeto********************
            }
            catch (Exception ex)
            {
                //Logs log = new Logs();
                //log.Log(ex.ToString());
                //MessageBox.Show(ex.ToString());
            }
        }
        #endregion
        #region Conrreo de prueba
        /*public void Correo_Prueba(String Direccion_DCorreo)
        {
            try
            {
                ServidorCorreo Ec = new ServidorCorreo();
                MailMessage mensaje = new MailMessage();

                var asunto = ConfigGet.MailAsunto();
                var remitente = ConfigGet.MailRemitente();
                var nombre = ConfigGet.MailNombreRemi();
                var cuerpo = "  Este es un correo de Pruebas de Xerox Billing Counter ";

                mensaje.Subject = asunto;
                var Direccion_Correo = Direccion_DCorreo;

                mensaje.To.Add(new MailAddress(Direccion_Correo));

                mensaje.From = new MailAddress(remitente, nombre);
                              
                mensaje.Body = cuerpo;

                /* Enviar *//*
                Ec.MandarCorreo(mensaje);
                Logs log = new Logs();
                log.Log("Correo de Prueba ha sido enviado correctamente...");
                MessageBox.Show("El Mail se ha Enviado Correctamente", "Correo Enviado " +
                "...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                mensaje.Dispose();//********Mata el evento y el objeto********************
            }
            catch (Exception ex)
            {
                Logs log = new Logs();
                log.Log("Correo de Prueba no enviado ..." + ex.ToString());
                MessageBox.Show("Correo no enviado ..." + ex.ToString());                
                
            }
        }*/
        #endregion
    }
}
