using System.ComponentModel.DataAnnotations;

namespace Login.Models
{
    public class Authentication
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } 
        public string Password { get; set; } 
        public string Role { get; set; } 
        public string Department { get; set; } 
        public string Name { get; set; } 
        public string Surname { get; set; } 
        public string Phone { get; set; } 
        public string Flg_status { get; set; } 
        public DateTime Date_create { get; set; } 
        public DateTime Last_login { get; set; } 
    }
}