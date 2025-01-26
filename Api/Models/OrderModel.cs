using value_analysis_server.Api.Database;

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
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}