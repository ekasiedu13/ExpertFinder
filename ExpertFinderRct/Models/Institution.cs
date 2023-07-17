using System;
namespace ExpertFinderRct.Models
{
	public class Institution
	{
        private Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string CountryId { get; set; } = string.Empty;

        public string GPS { get; set; } = string.Empty;

        public string Location  { get; set; } = string.Empty;

        public bool IsVerified { get; set; } = false;

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public string CreatedBy { get; set; } = string.Empty;
    }
}