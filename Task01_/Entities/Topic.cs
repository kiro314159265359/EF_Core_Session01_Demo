using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01.Entities
{

    //internal class Topic
    //{
    //   
    //    public int ID { get; set; }
    //  
    //    public string Name { get; set; }
    //}

    //[Table("Topic", Schema = "dbo")]
    //internal class Topic
    //{
    //    [Key]
    //    public int ID { get; set; }
    //    [Required]
    //    public string Name { get; set; }
    //}

    // using Fluent API's
    internal class Topic
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

}
