public interface IReport { string Generate(); }
public class PdfReport:IReport{ public string Generate()=>"PDF"; }
public class CsvReport:IReport{ public string Generate()=>"CSV"; }