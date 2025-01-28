using System.Diagnostics.CodeAnalysis;

using value_analysis_server.Api.Database;

namespace value_analysis_server.Api.Models
{
    public partial class Product
    {
        public Guid id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float quantity { get; set; }
        [AllowNull]
        public float? provider1 { get; set; }
        [AllowNull]
        public float? provider2 { get; set; }
        [AllowNull]
        public float? provider3 { get; set; }
        [AllowNull]
        public float? provider4 { get; set; }
        [AllowNull]
        public string? selectedProvider { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

    }
}