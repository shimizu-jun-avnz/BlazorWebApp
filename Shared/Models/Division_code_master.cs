using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebApp.Shared.Models
{
    public class Division_code_master
    {
        [Key]
        public int Division_id { get; set; } = -1;
        public string Division_name { get; set; } = "";
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
    }
}
