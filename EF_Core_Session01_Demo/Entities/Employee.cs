using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Session01_Demo.Entities
{
    // EF core --> 4 ways for mapping classes in the database : [Table , view , function]
    // 1. By convention [Default behaviour] // any class is truned into table 
    // if you want to change that you have to manaully change it 

    // 2. Data annotation [Set of attributes used for data valedations]

    // 3. Fluent APIs

    // 4. Class Configuration

    // Entity 
    // POCO: 
    // Plain old clr object
    //internal class Employee
    //{
    //    public int Id { get; set; } 
    //    // Column int primarykey --> public numeric property that has name "Id" or "EmployeeID"
    //    // and adds a Identity (1 , 1) Required
    //    public string Name { get; set; } 
    //    // String reference type : required coz its not string?
    //    // before .Net 6 string? wasnt there 
    //    // Has type NVARCHAR(max)
    //    public int? Age { get; set; }
    //    // Value type : int[Age] - Required doesnt allow null "(int? allow null)"
    //    public double Salary{ get; set; }
    //    // Float value type Required
    //    public string? Email { get; set; } // NVARCHAR(max) optional
    //    public DateTime DateOfCreation { get; set; }
    //    // Datetime2 - Required
    //}


    // 2. Data annotation [Set of attributes used for data valedations] 
    //[Table("Employees", Schema = "dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }
    //    // if key is used alone it means it's primary and has identitiy
    //    // what if you dont want the identity

    //    [Required]
    //    [Column("EmpName", TypeName = "varchar")]
    //    [MaxLength(50)]
    //    [StringLength(50, MinimumLength = 10)]
    //    public string? Name { get; set; }
    //    [Range(20, 60, ErrorMessage = "Incorrect Validation")]
    //    public int? Age { get; set; }
    //    [Column(TypeName = "money")]
    //    [DataType(DataType.Currency)]
    //    public double Salary { get; set; }
    //    [EmailAddress]
    //    public string? Email { get; set; }
    //    // Same regex as email 
    //    [Phone]
    //    [DataType(DataType.PhoneNumber)]
    //    public string? PhoneNumber { get; set; }
    //    public DateTime DateOfCreation { get; set; }
    //    [NotMapped]
    //    public double TotalSalary { get; set; }
    //    // drived attribue
    //    public string Password { get; set; }

    //}

    class Employee
    {
        public string EmpId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
