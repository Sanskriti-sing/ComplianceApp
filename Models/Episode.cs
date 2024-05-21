using System.ComponentModel.DataAnnotations;

namespace ComplianceApp.Models
{
    public class Episode
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public List<ComplianceItem> ComplianceItems { get; set;}

    }
}
