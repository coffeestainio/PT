using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FacElec.model;
using Newtonsoft.Json;

namespace FacElec.helpers
{
    public static class SqlHelper
    {
        private const string sqlConnection = "Server=tcp:pt2.database.windows.net,1433;Initial Catalog = pt2_test; Persist Security Info=False;User ID = PTSQL; Password=SQLPT12345!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;";

        public static List<Factura> GetFacturas()
        {
            List<Factura> factura = new List<Factura>();
            try
            {
                var sqlQuery = "SELECT *, " +
                    "factura_Detalle = ( " +
                                       "select top 1 *, " +
                                       "producto = (select id_producto, nombre, costo from producto p where p.id_producto = fd.id_producto for JSON PATH) " +
                                       "from Factura_Detalle fd where f.id_factura = fd.id_factura " +
                    "FOR JSON PATH ) ,    " +
                    " cliente = ( " +
                    "select * from cliente where cliente.id_cliente = f.id_cliente " +
                    "FOR JSON AUTO " +
                    ") " +
                    " from Factura f where sincronizada = 0 " +
                                            "For JSON PATH  ";

                using (var connection = new SqlConnection(sqlConnection))
                {
                    var command = new SqlCommand(sqlQuery, connection);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            factura = JsonConvert.DeserializeObject<List<Factura>>(reader[0].ToString());

                        }
                    }
                }
            }
            catch (Exception ex ){
                return null;
            }

            return factura;

        }

        public static void GuardarEstado(List<Factura> facturasListas){
            
        }
    }
}
