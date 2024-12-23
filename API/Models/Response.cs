namespace API.Models
{
    public class Response
    {
        public bool Status { get; set; }
        public string Message { get; set; } = string.Empty;
        public dynamic Data { get; set; }

        public Response(Exception ex)
        {
            Status = false;
            Message = ex.Message;
            Data = ex.ToString();
        }

        public Response(object data)
        {
            Status = true;
            Message = "success";
            Data = data;
        }
    }
}
