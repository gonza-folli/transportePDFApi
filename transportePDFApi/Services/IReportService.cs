using iText.Forms.Fields;
using transportePDFApi.Model;

namespace transportePDFApi.Services
{
    public interface IReportService
    {
        byte[] generateReportVehiculoMunicipal(IDictionary<string, Action<PdfFormField, string, VehiculoMunicipalModel>> fieldKeyActionBinding, VehiculoMunicipalModel formularioModel);
    }
}
