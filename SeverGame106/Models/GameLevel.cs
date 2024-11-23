using System.ComponentModel.DataAnnotations;

namespace SeverGame106.Models
{
    public class GameLevel
    {
        [Key]
        public int LevelId {  get; set; }
        public string? title { get; set; }
        public string? description { get; set; }
    }
}
