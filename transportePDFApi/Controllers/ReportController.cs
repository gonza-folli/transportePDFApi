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
        private readonly IReportService _reportService;

        public ReportController(IReportService reportService) {
            _reportService = reportService;
        }


        [HttpGet("ReportCAUVehiculosMunicipales",   Name = "GetReportCAUVehiculosMunicipales")]
        public IActionResult GetReporteVehiculosMunicipalidades ()
        {
             /*
             TODO:
            -a. Crear un endpoint de GET generico que reciba "nombre de reporte" a generar
            -b. Este endpoint tambien tiene que recibir los datos necesarios para llenar el PDF, probablemente un ID para ir a buscar a una fuente de datos externa
            -.Si vamos a tener que procesar datos externos, vamos a necesitar crear un HttpClient para consultar esa fuente de datos, Y generar una interfaz o servicio para 
            -que el procesamiento de estos datos vaya por otro lado
            -c. En la imple de ReportService, refactorizar el uso de la libreria IText para no repetir codigo. Prestar atencion que la utilidad PdfAcroForm.GetAcroForm obtiene el formulario proveniente de la metadata del PDF
            -d. Con el IReportService, tambien se podria refactorizar el hecho de tener varios metodos con los mismos parametros y que termine siendo uno solo, dentro del cual se llama al metodo propio de la implementacion apropiado

             * */

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

            byte[] bytes = _reportService.generateReport(reporteCAUModel, "CAU Vehiculos de Municipalidades (c).pdf");

            return File(bytes, "application/pdf", "CAUVehiculosMunicipales");

        }

        [HttpGet("ReportCAUA1", Name = "GetReportCAUA1")]
        public IActionResult GetReporteCauA1()
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

            byte[] bytes = _reportService.generateReport(reporteCAUModel, "CAU Regulares - Titular (a1).pdf");

            return File(bytes, "application/pdf", "CAUA1");

        }

        [HttpGet("ReportCAUA2", Name = "GetReportCAUA2")]
        public IActionResult GetReporteCauA2()
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

            byte[] bytes = _reportService.generateReport(reporteCAUModel, "CAU Regulares - Contrato (a2).pdf");

            return File(bytes, "application/pdf", "CAUA2");

        }

        [HttpGet("ReportCAUB1", Name = "GetReportCAUB1")]
        public IActionResult GetReporteCauAB1()
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

            byte[] bytes = _reportService.generateReport(reporteCAUModel, "CAU Especiales - Titular (b1).pdf");

            return File(bytes, "application/pdf", "CAUB1");

        }

        [HttpGet("ReportCAUB2", Name = "GetReportCAUB2")]
        public IActionResult GetReporteCauAB2()
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

            byte[] bytes = _reportService.generateReport(reporteCAUModel, "CAU Especiales - Contrato (b2).pdf");

            return File(bytes, "application/pdf", "CAUB2");

        }

    }
}
