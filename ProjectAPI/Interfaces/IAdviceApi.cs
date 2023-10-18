using ProjectAPI.Dtos;
using ProjectAPI.Model;

namespace ProjectAPI.Interfaces
{
    public interface IAdviceApi
    {
        Task<ResponseGenerico<AdviceModel>> AdviseSearch();
        Task<ResponseGenerico<AdviceModel>> AdviseSearchId(string id);
    }
}