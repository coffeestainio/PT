
using System;
using System.Xml.Linq;

namespace FacElec.helpers
{
    public static class RestHelper
    {

        public static GTICargaFacturaSoapClient.EndpointConfiguration Ambiente;

        public static XDocument SendFacturaElectronica(XDocument docXml)
        {
            string respuesta = "";

            try
            {
                var servicio = new GTICargaFacturaSoapClient(Ambiente);
                var response = servicio.InsertarDocumentosAsync(docXml.ToString(), Program.env.email, Program.env.password);
                response.Wait();
                respuesta = response.Result;
            }
            catch (Exception ex)
            {
               Program.log.Error(ex.Message);
            }

            XDocument resXml = XDocument.Parse(respuesta);
            return resXml;
        }


    }
}
