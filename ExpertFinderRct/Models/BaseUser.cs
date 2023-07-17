using System;
namespace ExpertFinderRct.Models
{
	public class BaseUser
	{
        private Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string OtherNames { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string AltPhone { get; set; } = string.Empty;

        public string CreatedBy { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}

