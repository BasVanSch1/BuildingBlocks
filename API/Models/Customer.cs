using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    [PrimaryKey(nameof(Username))]
    public class Customer
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
