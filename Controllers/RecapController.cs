using FileManagerAPI.Models;
using FileManagerAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecapController : ControllerBase
    {
        private readonly IRecapRepository _recapRepository;

        public RecapController(IRecapRepository recapRepository)
        {
            _recapRepository = recapRepository;
        }


        [HttpGet]
        public async Task<ActionResult<List<HVI>>> HviRaw()
        {
            try
            {
                var list = await _recapRepository.GetHVI();

                return Ok(list);

            }
            catch (Exception e)
            {

                throw new Exception(e.Message.ToString());
            }
        }
    }
}
