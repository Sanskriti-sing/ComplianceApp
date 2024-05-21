using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ComplianceApp.Models
{
    public class ComplianceItem
    {
        
        public int EpisodeId { get; set; }

        [JsonConverter(typeof(TimeSpanToStringConverter))]
        public TimeSpan StartTime { get; set; }

        [JsonConverter(typeof(TimeSpanToStringConverter))]
        public TimeSpan EndTime { get; set; }
        public string Description { get; set; }
    }
}
