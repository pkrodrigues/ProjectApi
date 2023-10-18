using ProjectAPI.Dtos;

namespace ProjectAPI.Interfaces{
    public interface IAdviceService
    {
         Task<ResponseGenerico<AdviceResponse>> AdviseSearch();
        Task<ResponseGenerico<AdviceResponse>> AdviseSearchId(int id);
    }
}