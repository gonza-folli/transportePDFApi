
using iText.Forms.Fields;
using iText.Forms;
using iText.Kernel.Pdf;
using transportePDFApi.Model;
using transportePDFApi.Helpers;

namespace transportePDFApi.Services
{
    public class ReportServiceImplementation : IReportService
    {

        private readonly IDictionary<string, Action<PdfFormField, string, ReporteCAUModel>> _fieldKeyActionBinding;

        public ReportServiceImplementation()
        {
            _fieldKeyActionBinding = new Dictionary<string, Action<PdfFormField, string, ReporteCAUModel>>
                {
                    {"EXPEDIENTE", ReporteCAUHelper.SetExpedienteField},
                    {"LOCALIDAD", ReporteCAUHelper.SetLocalidadField},
                    {"NROCAU", ReporteCAUHelper.SetNroCauField},
                    {"NRO_CAU", ReporteCAUHelper.SetNroCauField},
                    {"MODALIDAD", ReporteCAUHelper.SetModalidadField},
                    {"CUIT", ReporteCAUHelper.SetCuitField},
                    {"DOMINIO", ReporteCAUHelper.SetDominioField},
                    {"INSCRIPCION_DNRPA", ReporteCAUHelper.SetInscripcionDNRPAField},
                    {"CODIGO_DGT", ReporteCAUHelper.SetCodigoDGTField},
                    {"MUNICIPALIDAD", ReporteCAUHelper.SetMunicipalidadField},
                    {"LOCACION", ReporteCAUHelper.SetLocacionField},
                    {"VENCIMIENTO", ReporteCAUHelper.SetVencimientoField},
                    {"MARCA_1", ReporteCAUHelper.SetMarca1Field},
                    {"MODELO_1", ReporteCAUHelper.SetModelo1Field},
                    {"NRO_1", ReporteCAUHelper.SetNro1Field},
                    {"MARCA_2", ReporteCAUHelper.SetMarca2Field},
                    {"NRO_2", ReporteCAUHelper.SetNro2Field},
                    {"MARCA_3", ReporteCAUHelper.SetMarca3Field},
                    {"MODELO_3", ReporteCAUHelper.SetModelo3Field},
                    {"ASIENTOS", ReporteCAUHelper.SetAsientosField},
                    {"MARCA_4", ReporteCAUHelper.SetMarca4Field},
                    {"NRO_4", ReporteCAUHelper.SetNro4Field},
                    {"FECHA_EMISION", ReporteCAUHelper.SetFechaEmisionField},
                    {"FECHA_VIGENCIA", ReporteCAUHelper.SetFechaVigenciaField}
                };
        }
        public byte[] generateReport(ReporteCAUModel formularioModel, string filename)
        {
            var pdfStream = new MemoryStream();

            string pdfPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Reportes", filename);

            // Abre el PDF
            PdfReader pdfReader = new PdfReader(pdfPath);
            pdfReader.SetUnethicalReading(true);

            PdfDocument pdfDoc = new PdfDocument(pdfReader, new PdfWriter(pdfStream));

            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, false);
            // Obtiene los campos del formulario
            IDictionary<string, PdfFormField> fields = form.GetAllFormFields();
            // Itera sobre los campos del formulario


            foreach (KeyValuePair<string, PdfFormField> field in fields)
            {
                string fieldName = field.Key;
                PdfFormField fieldValue = field.Value;
                if (_fieldKeyActionBinding.TryGetValue(fieldName, out var action))
                {
                    action.Invoke(fieldValue, fieldName, formularioModel);
                }
                //PdfFormField fieldValue = field.Value;
                Console.WriteLine($"Nombre del Campo: {fieldName}, Valor del Campo: {fieldValue.GetValueAsString()}");
            }


            pdfDoc.Close();

            byte[] bytes = pdfStream.ToArray();

            return bytes;

        }
    }
}
