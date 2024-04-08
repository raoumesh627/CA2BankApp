namespace BankingSystemMVC_Umesh_yadav_25327.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string ErrorMessage { get; set; }
        public string Path { get; set; }
        public string StackTrace { get; set; }
    }
}