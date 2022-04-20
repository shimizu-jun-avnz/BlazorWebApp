using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebApp.Shared.Models
{
    public class Job_code_master
    {
        [Key]
        public int Job_id { get; set; } = -1;
        public string Job_name { get; set; } = "";
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
    }
}
