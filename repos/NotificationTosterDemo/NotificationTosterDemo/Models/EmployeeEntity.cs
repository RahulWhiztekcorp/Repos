using System.ComponentModel.DataAnnotations;

namespace NotificationTosterDemo.Models
{
    public class EmployeeEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
