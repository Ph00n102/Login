using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
        public class Person
        {
            [Key]
            public int Id { get; set; }
            public int Cid { get; set; } 
            public string Hn { get; set; } 
            public string Name { get; set; } 
            public string Surname { get; set; } 
            
        }
}