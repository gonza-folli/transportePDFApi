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
        private readonly IDictionary<string, Action<PdfFormField, string, ReporteCAUModel>> _fieldKeyActionBinding;
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService   ) {

            _fieldKeyActionBinding = new Dictionary<string, Action<PdfFormField, string, ReporteCAUModel>>
                {
                    {"EXPEDIENTE", VehiculosMunicipalidadesReportHelper.SetExpedienteField},
                    {"LOCALIDAD", VehiculosMunicipalidadesReportHelper.SetLocalidadField},
                    {"NROCAU", VehiculosMunicipalidadesReportHelper.SetNroCauField},
                    {"NRO_CAU", VehiculosMunicipalidadesReportHelper.SetNroCauField},
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

            _reportService = reportService;

        }


        [HttpGet("ReportCAU",   Name = "GetReportCAU")]
        public IActionResult GetReporteVehículosMunicipalidades ()
        {

            //Obtengo de la DB el modelo
            ReporteCAUModel reporteCAUModel = new ReporteCAUModel()
            {
                EXPEDIENTE = "EXP-2024-12345",
                LOCALIDAD = "Buenos Aires",
                NROCAU = "CAU-67890",
                NRO_CAU = "CAU-22222",
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




            //byte[] bytes = _reportService.generateReportVehiculoMunicipal(_fieldKeyActionBinding, reporteCAUModel);
            byte[] bytes = _reportService.generateReportCauA1(_fieldKeyActionBinding, reporteCAUModel);
            //byte[] bytes = _reportService.generateReportVehiculoMunicipal(_fieldKeyActionBinding, reporteCAUModel);
            //byte[] bytes = _reportService.generateReportVehiculoMunicipal(_fieldKeyActionBinding, reporteCAUModel);

            return File(bytes, "application/pdf", "nombreDePrueba");

        }


    }
}
