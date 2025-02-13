using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Entities
{

    //internal class Department
    //{
    //    public int ID { get; set; } 
    //    public string Name { get; set; }
    //    public int Ins_ID { get; set; }
    //    public DateTime HiringDate { get; set; }
    //}


    //[Table("Department", Schema = "dbo")]
    //internal class Department
    //{

    //    [Key]
    //    public int ID { get; set; }
    //    [Column("Name", TypeName = "varchar")]
    //    [StringLength(maximumLength: 120, MinimumLength = 12, ErrorMessage = "Invalid length")]
    //    public string Name { get; set; }
    //    [NotNull]
    //    public int Ins_ID { get; set; }
    //    [Range(typeof(DateTime), "2000-01-01", "2025-12-31")]
    //    public DateTime HiringDate { get; set; }
    //}

    // using Fluent API's
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime? HiringDate { get; set; }
    }

}
