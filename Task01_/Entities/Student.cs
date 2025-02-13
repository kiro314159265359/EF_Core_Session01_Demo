﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Entities
{
    //internal class Student
    //{
    //    // 1. By using the convention Default way
    //    public int ID { get; set; }
    //    public string FName { get; set; }
    //    public string LName { get; set; }
    //    public string Address { get; set; }
    //    public int? Age { get; set; }
    //    public int Dep_Id { get; set; }
    //}


    //[Table("Student", Schema = "dbo")]
    //internal class Student
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    [Column("FirstName", TypeName = "varchar")]
    //    [StringLength(maximumLength: 120)]
    //    public string FName { get; set; }
    //    [Column("LastName", TypeName = "varchar")]
    //    [StringLength(maximumLength: 120)]
    //    public string LName { get; set; }
    //    [Column("Address", TypeName = "nvarchar")]
    //    [StringLength(maximumLength: 120)]
    //    public string Address { get; set; }
    //    [Range(20, 50, ErrorMessage = "Incorrect Validation")]
    //    public int? Age { get; set; }
    //    [NotNull]
    //    public int Dep_Id { get; set; }
    //}

    // using Fluent API's
    internal class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }
        public int Dep_Id { get; set; }
    }

}
