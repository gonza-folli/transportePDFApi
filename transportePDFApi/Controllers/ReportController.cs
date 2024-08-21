using Microsoft.AspNetCore.Mvc;
using System.IO;
using iText.Kernel.Pdf;
using iText.Forms;
using iText.Forms.Fields;
using System.Linq;
using transportePDFApi.Helpers;
using transportePDFApi.Model;

namespace transportePDFApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly IDictionary<string, Action<PdfFormField, string, VehiculoMunicipalModel>> _fieldKeyActionBinding;

        public ReportController() {

            _fieldKeyActionBinding = new Dictionary<string, Action<PdfFormField, string, VehiculoMunicipalModel>>
                {
                    {"EXPEDIENTE", VehiculosMunicipalidadesReportHelper.SetExpedienteField},
                    {"LOCALIDAD", VehiculosMunicipalidadesReportHelper.SetLocalidadField},
                    {"NROCAU", VehiculosMunicipalidadesReportHelper.SetNroCauField},
                    {"MODALIDAD", VehiculosMunicipalidadesReportHelper.SetModalidadField},
                    {"CUIT", VehiculosMunicipalidadesReportHelper.SetCuitField},
                    {"DOMINIO", VehiculosMunicipalidadesReportHelper.SetDominioField},


                    //{"CaeExpiration", InvoiceReportHelper.SetCaeExpirationField},
                    //{"Date", InvoiceReportHelper.SetDateField},
                    //{"City", InvoiceReportHelper.SetCityField},
                };
        }



        [HttpGet(Name = "GetReport")]
        public IActionResult GetReporteVehículosMunicipalidades ()
        {

            //Obtengo de la DB el modelo
            VehiculoMunicipalModel vehiculoMunicipalModel = new VehiculoMunicipalModel()
            {
                EXPEDIENTE = 12345,
                LOCALIDAD = "Buenos Aires",
                NROCAU = 67890,
                MODALIDAD = 1,
                CUIT = "20123456789",
                DOMINIO = "ABC123",
                INSCRIPCION_DNRPA = "DNRPA987654",
                CODIGO_DGT = "DGT123456",
                MUNICIPALIDAD = "La Plata",
                LOCACION = "Av. 123",
                VENCIMIENTO = new DateTime(2025, 12, 31),
                MARCA_1 = "Ford",
                MODELO_1 = "Fiesta",
                NRO_1 = "XY12345",
                MARCA_2 = "Chevrolet",
                MODELO_2 = "Corsa",
                NRO_2 = "YZ67890",
                MARCA_3 = "Volkswagen",
                MODELO_3 = "Golf",
                NRO_3 = "ZX09876",
                ASIENTOS = "5",
                MARCA_4 = "Renault",
                NRO_4 = "RN56789",
                FECHA_EMISION = new DateTime(2023, 08, 19),
                FECHA_VIGENCIA = new DateTime(2024, 08, 19)
            };



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
                if (_fieldKeyActionBinding.TryGetValue(fieldName, out var action ))
                {
                    action.Invoke(fieldValue, fieldName, vehiculoMunicipalModel);
                }
                //PdfFormField fieldValue = field.Value;
                Console.WriteLine($"Nombre del Campo: {fieldName}, Valor del Campo: {fieldValue.GetValueAsString()}");
            }


            pdfDoc.Close();

            byte[] bytes = pdfStream.ToArray();

            return File(bytes, "application/pdf", "nombreDePrueba");

        }


    }
}
