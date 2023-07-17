using System;
namespace ExpertFinderRct.Models
{
	public class Category
	{
		private Guid Id { get; set; }

		public string Name { get; set; }

        public bool IsVerified { get; set; } = false;

        public string CreatedBy { get; set; } = string.Empty;

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}