using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryPattern.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? DeptNo { get; set; }
        [Display(Name = "Department Name")]
        [Required]
        public string DeptName { get; set; }
        [DataType(DataType.MultilineText)]
        public string DeptLocation { get; set; }
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Employee { get; set; }
    }
}
