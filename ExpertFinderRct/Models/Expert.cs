using System;
namespace ExpertFinderRct.Models
{
    public class Expert
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string OtherNames { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string AltPhone { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public string CreatedBy { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public bool IsVerfied { get; set; } = false;

        public bool IsBlocked { get; set; } = false;

        public string UserType { get; set; } = string.Empty;
    }
}

