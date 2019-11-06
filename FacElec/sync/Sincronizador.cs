using System;
using System.Collections.Generic;
using FacElec.model;
using FacElec.helpers;
using System.Xml.Linq;

namespace FacElec.sync
{
    public static class Sincronizador
    {

        public static void SincronizarFacturas(bool pruebas)
        {
            
            var facturas = new List<Factura>();
            var resultados = new List<GTIResponse>();
            facturas = SqlHelper.GetFacturas();
            if (facturas != null && facturas.Count > 0)
            {
                foreach (Factura fac in facturas)
                {
                    var xmlFac = XmlHelper.generateXML(fac);

                    XmlHelper.storeXml(xmlFac, fac.id_factura, fac.notaCredito);

                    var resultado = RestHelper.SendFacturaElectronica(xmlFac);
                    if (resultado != null)
                        resultados.Add(XmlHelper.validateResponse(fac.id_factura, resultado, fac.notaCredito));
                    else
                        Program.log.Error("Hubo un error al sincronizar la factura con GTI");
                }
                if (!pruebas) SqlHelper.GuardarEstado(resultados);
            }
            else{
                Program.log.Warn("No hay facturas pendientes");
            }

        }
    }
}
