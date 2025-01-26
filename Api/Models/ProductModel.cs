using System.Diagnostics.CodeAnalysis;

namespace value_analysis_server.Api.Models
{
    public partial class Product
    {
        public Guid id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }
        [AllowNull]
        public int? provider1 { get; set; }
        [AllowNull]
        public int? provider2 { get; set; }
        [AllowNull]
        public int? provider3 { get; set; }
        [AllowNull]
        public int? provider4 { get; set; }
        [AllowNull]
        public string? selectedProvider { get; set; }

    }
}