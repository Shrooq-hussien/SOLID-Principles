public class ReportGenerator {
    public string Generate(string type){
        if(type=="pdf") return "PDF Report";
        if(type=="csv") return "CSV Report";
        return "Unknown";
    }
}