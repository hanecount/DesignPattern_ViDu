// xay dung doi tuong phuc tap dua tren nhung doi tuong don gian bang phuong phap tiep can tung buoc

namespace BuilderDesignPattern
{
    public class Report
    {
        public string ReportType {  get; set; }
        public string ReportHeader {  get; set; }      
        public string ReportContent {  get; set; }
        public string ReportFooter { get; set; }
        public void DisplayReport()
        {
            Console.WriteLine("ReportType: {0}", ReportType);
            Console.WriteLine("Header: {0}", ReportHeader);
            Console.WriteLine("Content: {0}", ReportContent);
            Console.WriteLine("Footer: {0}", ReportFooter);
        }
    }

    public abstract class ReportBuilder
    {
        protected Report reportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();

        public void CreateNewReport()
        {
            reportObject = new Report();
        }

        public Report GetReport()
        {
            return reportObject;
        }
    }

    public class ExcelReport: ReportBuilder
    {
        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }

        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }
    }

    public class PDFReport : ReportBuilder
    {
        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }

        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }

        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Content";
        }

        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
        }
    }

    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();
            return reportBuilder.GetReport();
        }
    }

    public class exec
    {
        static void Main(string[] args)
        {
            Report report;
            ReportDirector director = new ReportDirector();
            PDFReport pDFReport = new PDFReport();
            report = director.MakeReport(pDFReport);
            report.DisplayReport();

            ExcelReport excelReport = new ExcelReport();
            report = director.MakeReport(excelReport);
            report.DisplayReport();
            Console.ReadKey();
        }
    }
}
