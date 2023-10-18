using Microsoft.AspNetCore.Mvc;
using ProjectAPI.Interfaces;
using System.Net;

namespace ProjectAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[Controller]")]
    public class AdviceController:ControllerBase
    {
       public readonly IAdviceService _adviceService;

       public AdviceController(IAdviceService adviceService)
       {
        _adviceService = adviceService;
       }

       [HttpGet("busca/")]
       [ProducesResponseType(StatusCodes.Status200OK)]
       [ProducesResponseType(StatusCodes.Status400BadRequest)]
       [ProducesResponseType(StatusCodes.Status404NotFound)]
       [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> AdviseSearch()
       {
        var response = await _adviceService.AdviseSearch();

        if(response.CodigoHttp == HttpStatusCode.OK)
        {
            return Ok(response.DadosRetorno);
        }
        else 
        {
            return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
        }
       }

        [HttpGet("busca/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<ActionResult> AdviseSearchId([FromRoute] int id)
        {
            var response = await _adviceService.AdviseSearchId(id);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}
