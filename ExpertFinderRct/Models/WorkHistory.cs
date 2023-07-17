using System;
namespace ExpertFinderRct.Models
{
	public class WorkHistory
	{
        private Guid Id { get; set; }

        public string Company { get; set; } = string.Empty;

        public int ExpertId { get; set; } = 0;

        public string Position { get; set; } = string.Empty;

        public DateTime StartMonth { get; set; } = DateTime.Now;

        public DateTime EndMonth { get; set; } = DateTime.Now;

        public bool IsVerified { get; set; } = false;

        public string CreatedBy { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}