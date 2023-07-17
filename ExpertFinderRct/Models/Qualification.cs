using System;
namespace ExpertFinderRct.Models
{
	public class Qualification
	{
        private Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string CountryId { get; set; } = string.Empty;

        public string CertificateType { get; set; } = string.Empty;

        public DateTime StartMonth { get; set; } = DateTime.Now;

        public DateTime EndMonth { get; set; } = DateTime.Now;

        public bool IsVerified { get; set; } = false;

        public string CreatedBy { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}