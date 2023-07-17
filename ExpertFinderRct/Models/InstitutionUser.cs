using System;
namespace ExpertFinderRct.Models
{
	public class InstitutionUser
	{
        private Guid Id { get; set; }

        public int BaseUserId { get; set; }

        public bool Suspended { get; set; } = false;

        public bool IsVerfied { get; set; } = false;

        public bool IsBlocked { get; set; } = false;
    }
}