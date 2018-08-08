using System.Diagnostics.Contracts;
using System.Xml.Linq;
using FacElec.model;
namespace FacElec.helpers
{
    public static class XmlHelper
    {
        public static XDocument generateXML(Factura factura){

            var numCuenta = 1234;
            var periodo = 0;
            if (System.DateTime.Today.Month < 10)
                periodo = System.DateTime.Today.Year;
            else
                periodo = System.DateTime.Today.Year + 1;

            var xmlDoc = new XDocument(
                             new XDeclaration("1.0", "utf-8",""),
                             new XElement("root",
                             new XElement("FacturaElectronicaXML",
                                   new XElement("Encabezado",
                                               new XElement("NumeroFactura", factura.id_factura),
                                                new XElement("FechaFactura", factura.fecha.ToString("yyyy-MM-dd")),
                                                new XElement("Emisor", new XElement("numCuenta", numCuenta)),
                                                new XElement("TipoCambio", "1.00"),
                                                new XElement("TipoDoc", 4),
                                                new XElement("CondicionVenta", 1),
                                                new XElement("NumOrdenCompra", factura.ordenCompra),
                                                new XElement("Moneda", 1),
                                                new XElement("idMedioPago", 1),
                                                new XElement("DiasCredito", factura.plazo),
                                                new XElement("Sucursal", 1),
                                                new XElement("Terminal", 1),
                                                new XElement("FechaVencimiento", ""),
                                                new XElement("SituacionEnvio", 1),
                                                new XElement("Periodo", periodo),
                                                new XElement("Receptor",
                                                             new XElement("TipoIdentificacion", 1)
                                                            )
                                               )
                                        )
                            ));
            return xmlDoc;
        } 

        public static void storeXml(XDocument xmlDoc, string facId){
            var fileName = $"facturasEnviadas/facturaElectronica_{facId}.xml";
            System.IO.FileInfo file = new System.IO.FileInfo(fileName);
            file.Directory.Create();
            xmlDoc.Save(fileName);
        }

    }
}
