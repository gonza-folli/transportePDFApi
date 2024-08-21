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
                    {"INSCRIPCION_DNRPA", VehiculosMunicipalidadesReportHelper.SetInscripcionDNRPAField},
                    {"CODIGO_DGT", VehiculosMunicipalidadesReportHelper.SetCodigoDGTField},
                    {"MUNICIPALIDAD", VehiculosMunicipalidadesReportHelper.SetMunicipalidadField},
                    {"LOCACION", VehiculosMunicipalidadesReportHelper.SetLocacionField},
                    {"VENCIMIENTO", VehiculosMunicipalidadesReportHelper.SetVencimientoField},
                    {"MARCA_1", VehiculosMunicipalidadesReportHelper.SetMarca1Field},
                    {"MODELO_1", VehiculosMunicipalidadesReportHelper.SetModelo1Field},
                    {"NRO_1", VehiculosMunicipalidadesReportHelper.SetNro1Field},
                    {"MARCA_2", VehiculosMunicipalidadesReportHelper.SetMarca2Field},
                    {"NRO_2", VehiculosMunicipalidadesReportHelper.SetNro2Field},
                    {"MARCA_3", VehiculosMunicipalidadesReportHelper.SetMarca3Field},
                    {"MODELO_3", VehiculosMunicipalidadesReportHelper.SetModelo3Field},
                    {"ASIENTOS", VehiculosMunicipalidadesReportHelper.SetAsientosField},
                    {"MARCA_4", VehiculosMunicipalidadesReportHelper.SetMarca4Field},
                    {"NRO_4", VehiculosMunicipalidadesReportHelper.SetNro4Field},
                    {"FECHA_EMISION", VehiculosMunicipalidadesReportHelper.SetFechaEmisionField},
                    {"FECHA_VIGENCIA", VehiculosMunicipalidadesReportHelper.SetFechaVigenciaField}
                };
        }



        [HttpGet(Name = "GetReport")]
        public IActionResult GetReporteVehículosMunicipalidades ()
        {

            //Obtengo de la DB el modelo
            VehiculoMunicipalModel vehiculoMunicipalModel = new VehiculoMunicipalModel()
            {
                EXPEDIENTE = "EXP-2024-12345",
                LOCALIDAD = "Buenos Aires",
                NROCAU = "CAU-67890",
                MODALIDAD = "Arrendamiento",
                CUIT = "20304050607",
                DOMINIO = "ABC123",
                INSCRIPCION_DNRPA = "123456789",
                CODIGO_DGT = "DGT987654",
                MUNICIPALIDAD = "La Plata",
                LOCACION = "Avenida Siempreviva 742",
                VENCIMIENTO = new DateTime(2025, 12, 31),
                MARCA_1 = "Ford",
                MODELO_1 = "Fiesta",
                NRO_1 = "NRO001",
                MARCA_2 = "Chevrolet",
                NRO_2 = "NRO002",
                MARCA_3 = "Toyota",
                MODELO_3 = "Corolla",
                ASIENTOS = "5",
                MARCA_4 = "Volkswagen",
                NRO_4 = "NRO004",
                FECHA_EMISION = DateTime.Now,
                FECHA_VIGENCIA = new DateTime(2025, 12, 31)
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
            foreach (KeyValuePair<string, PdfFormField> field in fields)
            {
                string fieldName = field.Key;
                PdfFormField fieldValue = field.Value;
                if (_fieldKeyActionBinding.TryGetValue(fieldName, out var action ))
                {
                    action.Invoke(fieldValue, fieldName, vehiculoMunicipalModel);
                }

                Console.WriteLine($"Nombre del Campo: {fieldName}, Valor del Campo: {fieldValue.GetValueAsString()}");
            }

            pdfDoc.Close();

            byte[] bytes = pdfStream.ToArray();

            return File(bytes, "application/pdf", "nombreDePrueba");

        }


    }
}
