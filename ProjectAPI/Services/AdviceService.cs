using AutoMapper;
using ProjectAPI.Dtos;
using ProjectAPI.Interfaces;
using ProjectAPI.Model;

namespace ProjectAPI.Services
{
    public class AdviceService : IAdviceService
    {
        private readonly IMapper _mapper;
        private readonly IAdviceApi _adviceApi;

        public AdviceService(IMapper mapper, IAdviceApi advice)
        {
            _mapper = mapper;
            _adviceApi = advice;
        }


        public async Task<ResponseGenerico<AdviceResponse>> AdviseSearch()
        {
            var advice = await _adviceApi.AdviseSearch();
            return _mapper.Map<ResponseGenerico<AdviceResponse>>(advice);
        }

        public async Task<ResponseGenerico<AdviceResponse>> AdviseSearchId(int id)
        {
            var advice = await _adviceApi.AdviseSearchId(id);
            return _mapper.Map<ResponseGenerico<AdviceResponse>>(advice);
        }
    }
}