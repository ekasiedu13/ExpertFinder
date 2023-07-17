namespace ExpertFinderRct.Services.ExpertServices
{
    public interface IExpertService
    {
        Task<Expert>? GetExperts();        
        
        Task<Expert>? GetSingleExpert(int id);

        Task<Expert> AddExpert(Expert expert);

        Task<Expert>? UpdateExpert(int id, Expert request);

        Task<Expert>? ExpertAvailable(int id);

        Task<Expert>? ExpertUnavailable(int id);

        Task<Expert>? DisableExpert(int id);

        Task<Expert>? SuspendExpert(int id);

        Task<Expert>? DeleteExpert(int id);
    }
}