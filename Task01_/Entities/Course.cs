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
    // convention way
    //internal class Course
    //{
    //    public int ID { get; set; }
    //    public int Duration { get; set; }
    //    public string Name { get; set; }
    //    public string? Description { get; set; }
    //    public string Top_ID { get; set; }
    //}

    //[Table("Course", Schema = "dbo")]
    //internal class Course
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    [Column("duration", TypeName = "int")]
    //    public int Duration { get; set; }
    //    [StringLength(maximumLength: 120 , MinimumLength = 12 , ErrorMessage = "Invalid Name")]
    //    [NotNull]
    //    [Column("Name", TypeName = "varchar")]
    //    public string Name { get; set; }
    //    [StringLength(maximumLength: 250, MinimumLength = 30, ErrorMessage = "Invalid Description")]
    //    [Column("Description", TypeName = "varchar")]
    //    public string? Description { get; set; }
    //    [NotNull]
    //    public int Top_ID { get; set; }
    //}

    // using Fluent API's
    internal class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Top_ID { get; set; }
    }

}
