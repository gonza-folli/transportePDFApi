using Microsoft.AspNetCore.Mvc;
using System.IO;
using iText.Kernel.Pdf;
using iText.Forms;
using iText.Forms.Fields;
using System.Linq;
using transportePDFApi.Helpers;
using transportePDFApi.Model;
using transportePDFApi.Services;

namespace transportePDFApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly IDictionary<string, Action<PdfFormField, string, VehiculoMunicipalModel>> _fieldKeyActionBinding;
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService   ) {

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

            _reportService = reportService;

        }






        [HttpGet("vehiculomunicipal",   Name = "GetReportVehiculoMunicipal")]
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




            byte[] bytes = _reportService.generateReportVehiculoMunicipal(_fieldKeyActionBinding, vehiculoMunicipalModel);

            return File(bytes, "application/pdf", "nombreDePrueba");

        }


    }
}
