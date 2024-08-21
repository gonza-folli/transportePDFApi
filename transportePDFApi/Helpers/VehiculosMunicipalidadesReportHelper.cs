using iText.Forms.Fields;
using transportePDFApi.Model;

namespace transportePDFApi.Helpers
{
    public class VehiculosMunicipalidadesReportHelper
    {
        public static void SetExpedienteField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.EXPEDIENTE.ToString());
        }

        public static void SetLocalidadField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.LOCALIDAD.ToString());
        }
        public static void SetNroCauField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.NROCAU.ToString());
        }
        public static void SetModalidadField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.MODALIDAD.ToString());
        }
        public static void SetCuitField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.CUIT.ToString());
        }
        public static void SetDominioField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.DOMINIO.ToString());
        }




    }

}
