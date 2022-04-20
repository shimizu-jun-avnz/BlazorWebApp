using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebApp.Shared.Models
{
    public class General_code_master
    {
        [Key]
        [Column(Order = 1)]
        public int Code_type { get; set; } = -1;
        [Key]
        [Column(Order = 2)]
        public int Code_id { get; set; } = -1;
        public string Name { get; set; } = "";
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
    }
}
