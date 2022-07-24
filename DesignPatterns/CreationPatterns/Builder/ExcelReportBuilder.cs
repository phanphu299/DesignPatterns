namespace DesignPatterns.CreationPatterns.Builder
{
    internal class ExcelReportBuilder : ReportBuilder
    {
        public override void SetReportContent()
        {
            Report.Content = "Excel content ne";
        }

        public override void SetReportFooter()
        {
            Report.Footer = "Excel footer ne";
        }

        public override void SetReportHeader()
        {
            Report.Header = "Excel header ne";
        }

        public override void SetReportType()
        {
            Report.ReportType = "EXCEL";
        }
    }
}
