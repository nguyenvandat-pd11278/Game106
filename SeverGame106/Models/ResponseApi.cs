namespace SeverGame106.Models
{
    public class ResponseApi
    {
        public bool IsSuccess {  get; set; } =true;
        public string Notification {  get; set; }
        public object data {  get; set; }
    }
}
