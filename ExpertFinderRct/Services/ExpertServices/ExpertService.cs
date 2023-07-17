namespace ExpertFinderRct.Services.ExpertServices
{
    public class ExpertService : IExpertService
    {
        //private readonly DataContext _context;

        //public ExpertService(DataContext context)
        //{
        //    _context = context;
        //}

        private static List<Expert> AllExperts = new List<Expert>
        {
            new Expert
            {
                Id = 123,
                FirstName = "Emmanuel",
                LastName = "Asiedu",
                OtherNames = "Kwame Junior",
                Phone = "0245087211",
                AltPhone = "0591861293",
                Email = "2skonty2@gmail.com",
                Password = "12345678",
                DateCreated = DateTime.Now,
                CreatedBy = "Admin",
            }
        };
        
        
        public async Task<Expert>? GetExperts()
        {
            throw new NotImplementedException();
        }

        public async Task<Expert> GetSingleExpert(int id)
        {
            throw new NotImplementedException();
        }
    
        public async Task<Expert> AddExpert(Expert expert)
        {
            throw new NotImplementedException();
        }

        public async Task<Expert>? UpdateExpert(int id, Expert request)
        {
            throw new NotImplementedException();
        }

        public async Task<Expert>? DeleteExpert(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Expert>? ExpertAvailable(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Expert>? ExpertUnavailable(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Expert>? DisableExpert(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Expert>? SuspendExpert(int id)
        {
            throw new NotImplementedException();
        }
    }
}
