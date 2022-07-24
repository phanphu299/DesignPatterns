namespace DesignPatterns.CreationPatterns.Builder
{
    internal class PdfReportBuilder : ReportBuilder
    {
        public override void SetReportContent()
        {
            Report.Content = "Pdf content ne";
        }

        public override void SetReportFooter()
        {
            Report.Footer = "Pdf footer ne";
        }

        public override void SetReportHeader()
        {
            Report.Header = "Pdf header ne";
        }

        public override void SetReportType()
        {
            Report.ReportType = "PDF";
        }
    }
}
