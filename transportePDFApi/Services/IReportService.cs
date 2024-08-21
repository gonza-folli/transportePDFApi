using iText.Forms.Fields;
using transportePDFApi.Model;

namespace transportePDFApi.Services
{
    public interface IReportService
    {
        byte[] generateReportVehiculoMunicipal(IDictionary<string, Action<PdfFormField, string, ReporteCAUModel>> fieldKeyActionBinding, ReporteCAUModel formularioModel);
        byte[] generateReportCauA1(IDictionary<string, Action<PdfFormField, string, ReporteCAUModel>> fieldKeyActionBinding, ReporteCAUModel formularioModel);
        byte[] generateReportCauA2(IDictionary<string, Action<PdfFormField, string, ReporteCAUModel>> fieldKeyActionBinding, ReporteCAUModel formularioModel);
        byte[] generateReportCauB1(IDictionary<string, Action<PdfFormField, string, ReporteCAUModel>> fieldKeyActionBinding, ReporteCAUModel formularioModel);
        byte[] generateReportCauB2(IDictionary<string, Action<PdfFormField, string, ReporteCAUModel>> fieldKeyActionBinding, ReporteCAUModel formularioModel);
        byte[] generateReport(ReporteCAUModel formularioModel, string filename);
    }
}
