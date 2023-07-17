using System;
namespace ExpertFinderRct.Models
{
	public class Publication
	{
        private Guid Id { get; set; }

        public int ExpertId { get; set; } = 0;

        public string Title { get; set; } = string.Empty;

        public string Url { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public DateTime PublicationDate { get; set; } = DateTime.Now;

        public bool IsVerified { get; set; } = false;

        public string CreatedBy { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}