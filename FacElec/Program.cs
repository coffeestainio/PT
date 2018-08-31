using FacElec.sync;
using Microsoft.Extensions.Configuration;
using System.IO;
using FacElec.helpers;

namespace FacElec
{
    class Program
    {

        public static IConfiguration Configuration { get; set; }
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
            SqlHelper.sqlConnection = Configuration.GetConnectionString("Production");

            GTICargaFacturaSoapClient.Pruebas = Configuration.GetSection("GTIPruebas").Value == "true";
           
            Sincronizador.SincronizarFacturas();

        }
    }
}
