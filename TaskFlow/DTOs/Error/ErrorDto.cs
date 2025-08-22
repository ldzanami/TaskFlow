namespace TaskFlow.DTOs.Error
{
    public class ErrorDto
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public List<ErrorDetailDto> Details { get; set; }
        public string Uuid { get; set; } = Guid.NewGuid().ToString();
    }
}
