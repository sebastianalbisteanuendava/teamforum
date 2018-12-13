using System.ComponentModel.DataAnnotations;

namespace TeamForum.Models.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int Age { get; set; }

    }
}