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

            _reportService = reportService;

        }


        [HttpGet("ReportCAU",   Name = "GetReportCAU")]
        public IActionResult GetReporteVehículosMunicipalidades ()
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




            //byte[] bytes = _reportService.generateReportVehiculoMunicipal(_fieldKeyActionBinding, reporteCAUModel);
            byte[] bytes = _reportService.generateReportCauA1(_fieldKeyActionBinding, reporteCAUModel);
            //byte[] bytes = _reportService.generateReportVehiculoMunicipal(_fieldKeyActionBinding, reporteCAUModel);
            //byte[] bytes = _reportService.generateReportVehiculoMunicipal(_fieldKeyActionBinding, reporteCAUModel);

            return File(bytes, "application/pdf", "nombreDePrueba");

        }


    }
}
