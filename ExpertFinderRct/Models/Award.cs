using System;
namespace ExpertFinderRct.Models
{
	public class Award
	{
        private Guid Id { get; set; }

        public string ExpertId { get; set; } = string.Empty;

        public string AwardName { get; set; } = string.Empty;

        public DateTime MonthYear { get; set; } = DateTime.Now;

        public bool IsVerified { get; set; } = false;

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}