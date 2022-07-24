namespace DesignPatterns.CreationPatterns.Builder
{
    internal abstract class ReportBuilder
    {
        protected Report Report { get; set; }

        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            Report = new Report();
        }
        public Report GetReport()
        {
            return Report;
        }
    }
}
