using System.ComponentModel.DataAnnotations;

namespace OscarTask.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }

        public string Phone { get; set; }

        public string Position { get; set; }
    }
}
