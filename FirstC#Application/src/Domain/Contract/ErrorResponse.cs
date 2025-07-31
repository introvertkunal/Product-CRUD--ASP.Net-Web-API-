namespace FirstC_Application.src.Domain.Contract
{
    public class ErrorResponse
    {
        public string? Title { get; set; }
        public int Status { get; set; }

        public string? Message { get; set; }
    }
}
