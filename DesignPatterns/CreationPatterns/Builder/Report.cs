namespace DesignPatterns.CreationPatterns.Builder
{
    internal class Report
    {
        public string ReportType { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
        public string Footer { get; set; }

        public void ShowReport()
        {
            Console.WriteLine($"Report type: {ReportType}");
            Console.WriteLine($"Report header: {Header}");
            Console.WriteLine($"Report content: {Content}");
            Console.WriteLine($"Report footer: {Footer}");
        }
    }
}
