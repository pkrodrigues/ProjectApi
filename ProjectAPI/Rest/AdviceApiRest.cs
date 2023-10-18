using System.Dynamic;
using System.Text.Json;
using ProjectAPI.Dtos;
using ProjectAPI.Interfaces;
using ProjectAPI.Model;

namespace ProjectAPI.Rest
{
    public class AdviceApiRest : IAdviceApi
    {
        public async Task<ResponseGenerico<AdviceModel>> AdviseSearch()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.adviceslip.com/advice");

            var response = new ResponseGenerico<AdviceModel>();
            using (var client = new HttpClient())
            {
                var responseAdviceApi = await client.SendAsync(request);
                var contentResp = await responseAdviceApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<AdviceModel>(contentResp);

                if(responseAdviceApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseAdviceApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }else{
                    response.CodigoHttp = responseAdviceApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }

        public async Task<ResponseGenerico<AdviceModel>> AdviseSearchId(string id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.adviceslip.com/advice/{id}");

            var response = new ResponseGenerico<AdviceModel>();
            using (var client = new HttpClient())
            {
                var responseAdviceApi = await client.SendAsync(request);
                var contentResp = await responseAdviceApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<AdviceModel>(contentResp);

                if(responseAdviceApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseAdviceApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }else{
                    response.CodigoHttp = responseAdviceApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }
            return response;
        }
    }


}