using System;
namespace FacElec.model
{
    public class GTIResponse
    {
        public string NumDocumento;
        public string IdCarga;
        public string NumFacturaInterno;
        public string ClaveNumerica;
        public string NumConsecutivoCompr;
        public string CodigoError;
        public string DescripcionError;

        public GTIResponse(string numDocumento, string idCarga, string numFacturaInterno, string claveNumerica, string numConsecutivoCompr, string codigoError, string descripcionError)
        {
            NumDocumento = numDocumento;
            IdCarga = idCarga;
            NumFacturaInterno = numFacturaInterno;
            ClaveNumerica = claveNumerica;
            NumConsecutivoCompr = numConsecutivoCompr;
            CodigoError = codigoError;
            DescripcionError = descripcionError;
        }

        public GTIResponse() { }
    }
}
