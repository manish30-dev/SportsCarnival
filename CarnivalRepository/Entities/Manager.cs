using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnivalRepository.Entities
{
    public class Manager
    {
        
        public int EventManagerId { get; set; }
        
        public string? EventManagerName { get; set; }
  
        public bool IsEventManager { get; set; }

        public string? EventManagerEmail { get; set; }
        public string? Role { get; set; }
    }
}
