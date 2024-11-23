using System.ComponentModel.DataAnnotations;

namespace SeverGame106.Models
{
    public class Region
    {
        public int RegionId {  get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
