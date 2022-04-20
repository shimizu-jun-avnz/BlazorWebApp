using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebApp.Shared.Models
{
    public class Employee
    {

        [Key]
        public String Emp_no { get; set; } = "";
        public String? Name { get; set; }
        public String? Picture_file_name { get; set; }
        public int? Gender { get; set; }
        public DateTime? Birth_day { get; set; }
        public DateTime? Enter_day { get; set; }
        public DateTime? Retirement_day { get; set; }
        public int? Job_rank { get; set; }
        public int? Belongs_department { get; set; }
        public int? Belongs_division { get; set; }
        public DateTime? Created_at { get; set; }
        public DateTime? Updated_at { get; set; }

        /// <summary>
        /// 役職名（ナビゲーションプロパティ）
        /// </summary>
        [ForeignKey("Job_rank")]
        public Job_code_master? JobName { get; set; }

        /// <summary>
        /// 部署名称（ナビゲーションプロパティ）
        /// </summary>
        [ForeignKey("Belongs_department")]
        public Department_code_master? DepartmentName { get; set; }

        /// <summary>
        /// 課名称（ナビゲーションプロパティ）
        /// </summary>
        [ForeignKey("Belongs_division")]
        public Division_code_master? DivisionName { get; set; }

    }
}
