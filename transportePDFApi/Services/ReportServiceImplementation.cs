
using iText.Forms.Fields;
using iText.Forms;
using iText.Kernel.Pdf;
using transportePDFApi.Model;

namespace transportePDFApi.Services
{
    public class ReportServiceImplementation : IReportService
    {
        public byte[] generateReportVehiculoMunicipal(IDictionary<string, Action<PdfFormField, string, VehiculoMunicipalModel>> fieldKeyActionBinding, VehiculoMunicipalModel formularioModel)
        {
          
            var pdfStream = new MemoryStream();

            string pdfPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Reportes", "CAU Vehiculos de Municipalidades (c).pdf");

            // Abre el PDF
            PdfReader pdfReader = new PdfReader(pdfPath);
            pdfReader.SetUnethicalReading(true);

            PdfDocument pdfDoc = new PdfDocument(pdfReader, new PdfWriter(pdfStream));

            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, false);
            // Obtiene los campos del formulario
            IDictionary<string, PdfFormField> fields = form.GetAllFormFields();
            // Itera sobre los campos del formulario

            //fields.TryGetValue("EXPEDIENTE", out PdfFormField fieldCuit);
            //fieldCuit.SetValue("20146221638");

            foreach (KeyValuePair<string, PdfFormField> field in fields)
            {
                string fieldName = field.Key;
                PdfFormField fieldValue = field.Value;
                if (fieldKeyActionBinding.TryGetValue(fieldName, out var action))
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
