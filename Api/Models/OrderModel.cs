namespace value_analysis_server.Api.Models
{
    public partial class Order
    {
        public Guid id { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string justification { get; set; }
        public string status { get; set; }
    }
}