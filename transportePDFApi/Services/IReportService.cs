using iText.Forms.Fields;
using transportePDFApi.Model;

namespace transportePDFApi.Services
{
    public interface IReportService
    {
        byte[] generateReport(ReporteCAUModel formularioModel, string filename);
    }
}
