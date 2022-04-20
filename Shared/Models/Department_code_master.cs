using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebApp.Shared.Models
{
    public class Department_code_master
    {
        [Key]
        public int Department_id { get; set; } = -1;
        public string Department_name { get; set; } = "";
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
    }
}
