
using iText.Forms.Fields;
using iText.Forms;
using iText.Kernel.Pdf;
using transportePDFApi.Model;

namespace transportePDFApi.Services
{
    public class ReportServiceImplementation : IReportService
    {
        public byte[] generateReportCauA1(IDictionary<string, Action<PdfFormField, string, ReporteCAUModel>> fieldKeyActionBinding, ReporteCAUModel formularioModel)
        {

            var pdfStream = new MemoryStream();

            string pdfPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Reportes", "CAU Regulares - Titular (a1).pdf");

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
        public byte[] generateReportCauA2(IDictionary<string, Action<PdfFormField, string, ReporteCAUModel>> fieldKeyActionBinding, ReporteCAUModel formularioModel)
        {

            var pdfStream = new MemoryStream();

            string pdfPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Reportes", "CAU Regulares - Contrato (a2).pdf");

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
        public byte[] generateReportCauB1(IDictionary<string, Action<PdfFormField, string, ReporteCAUModel>> fieldKeyActionBinding, ReporteCAUModel formularioModel)
        {

            var pdfStream = new MemoryStream();

            string pdfPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Reportes", "CAU Especiales - Titular (b1).pdf");

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
        public byte[] generateReportCauB2(IDictionary<string, Action<PdfFormField, string, ReporteCAUModel>> fieldKeyActionBinding, ReporteCAUModel formularioModel)
        {

            var pdfStream = new MemoryStream();

            string pdfPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Reportes", "CAU Especiales - Contrato (b2).pdf");

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

        public byte[] generateReportVehiculoMunicipal(IDictionary<string, Action<PdfFormField, string, ReporteCAUModel>> fieldKeyActionBinding, ReporteCAUModel formularioModel)
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
