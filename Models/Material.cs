
using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class Material
    {
        [Key]
         public int Mat_id { get; set; }
        public string Mat_type { get; set; } 
        public string Mat_Name { get; set; } 
    }
}