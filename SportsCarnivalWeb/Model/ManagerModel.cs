using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SportsCarnivalWeb.Model
{
    public class ManagerModel
    {
        [Key]
        public int EventManagerId { get; set; }
        [Required]
        public string? EventManagerName { get; set; }
        [Required]
        public bool IsEventManager { get; set; }
        [Required]
        public string? EventManagerEmail { get; set; }
        public string? Role { get; set; }

    }
}
