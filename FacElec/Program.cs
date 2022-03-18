using FacElec.sync;
using Microsoft.Extensions.Configuration;
using System.IO;
using FacElec.helpers;
using FacElec.model;
using log4net;
using log4net.Config;
using System.Reflection;
using ServiceReference;

namespace FacElec
{
    public class Program
    {
        public static int numCuenta;
        public static Env env;
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static IConfiguration Configuration { get; set; }
        static void Main(string[] args)
        {

            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            log.Info("Leyendo configuracion");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();

            var prod = Configuration["Env"] == "Prod";
            GTICargaFacturaSoapClient.Produccion = prod;

            log.Info($"Ambiente de produccion?: {prod}");

            if (prod)
            {
                env = new Env(int.Parse(Configuration["Ambientes:Prod:Account"]),
                          Configuration["Ambientes:Prod:User"],
                              Configuration["Ambientes:Prod:Password"]);
                SqlHelper.sqlConnection = Configuration.GetConnectionString("Production");
            }
            else
            {
                env = new Env(int.Parse(Configuration["Ambientes:Dev:Account"]),
                          Configuration["Ambientes:Dev:User"],
                              Configuration["Ambientes:Dev:Password"]);
                SqlHelper.sqlConnection = Configuration.GetConnectionString("Development");
            }

            log.Info("Iniciando el proceso");

            Sincronizador.SincronizarFacturas(!prod);

            log.Info("Proceso completado");

        }
    }
}
