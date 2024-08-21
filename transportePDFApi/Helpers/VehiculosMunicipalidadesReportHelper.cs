using iText.Forms.Fields;
using transportePDFApi.Model;

namespace transportePDFApi.Helpers
{
    public class ReporteCAUHelper
    {
        public static void SetExpedienteField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.EXPEDIENTE.ToString());
        }
        public static void SetLocalidadField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.LOCALIDAD.ToString());
        }
        public static void SetNroCauField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.NROCAU.ToString());
        }
        public static void SetModalidadField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.MODALIDAD.ToString());
        }
        public static void SetCuitField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.CUIT.ToString());
        }
        public static void SetDominioField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.DOMINIO.ToString());
        }
        public static void SetInscripcionDNRPAField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.INSCRIPCION_DNRPA.ToString());
        }
        public static void SetCodigoDGTField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.CODIGO_DGT.ToString());
        }
        public static void SetMunicipalidadField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.MUNICIPALIDAD.ToString());
        }
        public static void SetLocacionField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.LOCACION.ToString());
        }
        public static void SetVencimientoField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.VENCIMIENTO.ToString());
        }
        public static void SetMarca1Field(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.MARCA_1.ToString());
        }
        public static void SetModelo1Field(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.MODELO_1.ToString());
        }
        public static void SetNro1Field(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.NRO_1.ToString());
        }
        public static void SetMarca2Field(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.MARCA_2.ToString());
        }
        public static void SetNro2Field(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.NRO_2.ToString());
        }
        public static void SetMarca3Field(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.MARCA_3.ToString());
        }
        public static void SetModelo3Field(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.MODELO_3.ToString());
        }
        public static void SetAsientosField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.ASIENTOS.ToString());
        }
        public static void SetMarca4Field(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.MARCA_4.ToString());
        }
        public static void SetNro4Field(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.NRO_4.ToString());
        }
        public static void SetFechaEmisionField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.FECHA_EMISION.ToString());
        }
        public static void SetFechaVigenciaField(PdfFormField form, string fieldKey, ReporteCAUModel ReporteCAUModel)
        {
            form.SetValue(ReporteCAUModel.FECHA_VIGENCIA.ToString());
        }


    }

}
