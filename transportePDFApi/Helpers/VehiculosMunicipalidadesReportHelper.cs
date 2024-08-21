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
        public static void SetInscripcionDNRPAField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.INSCRIPCION_DNRPA.ToString());
        }
        public static void SetCodigoDGTField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.CODIGO_DGT.ToString());
        }
        public static void SetMunicipalidadField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.MUNICIPALIDAD.ToString());
        }
        public static void SetLocacionField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.LOCACION.ToString());
        }
        public static void SetVencimientoField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.VENCIMIENTO.ToString());
        }
        public static void SetMarca1Field(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.MARCA_1.ToString());
        }
        public static void SetModelo1Field(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.MODELO_1.ToString());
        }
        public static void SetNro1Field(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.NRO_1.ToString());
        }
        public static void SetMarca2Field(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.MARCA_2.ToString());
        }
        public static void SetNro2Field(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.NRO_2.ToString());
        }
        public static void SetMarca3Field(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.MARCA_3.ToString());
        }
        public static void SetModelo3Field(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.MODELO_3.ToString());
        }
        public static void SetAsientosField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.ASIENTOS.ToString());
        }
        public static void SetMarca4Field(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.MARCA_4.ToString());
        }
        public static void SetNro4Field(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.NRO_4.ToString());
        }
        public static void SetFechaEmisionField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.FECHA_EMISION.ToString());
        }
        public static void SetFechaVigenciaField(PdfFormField form, string fieldKey, VehiculoMunicipalModel vehiculoMunicipalModel)
        {
            form.SetValue(vehiculoMunicipalModel.FECHA_VIGENCIA.ToString());
        }


    }

}
