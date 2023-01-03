using FileManagerAPI.Models;
using FileManagerAPI.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HVIController : ControllerBase
    {
        private readonly IHviRepository _hviRepository;

        public HVIController(IHviRepository hviRepository)
        {
            _hviRepository = hviRepository;
        }

        [HttpPost]
        [Route("hvi1")]
        public async Task<ActionResult<HVI>> FileUploadToDB(ListHVI model)
        {
            try
            {
                var response = await _hviRepository.UploadHVI(model.HVIList/*, model.Title*/);
                return Ok(response);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message.ToString());
            }
        }

        [HttpPost]
        [Route("hvi2")]
        public async Task<ActionResult<HVI>> FileUploadToDB2(ListHVI model)
        {
            try
            {
                var response = await _hviRepository.UploadHVI2(model.HVIList/*, model.Title*/);
                return Ok(response);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message.ToString());
            }
        }

        [HttpPost]
        [Route("hvi3")]
        public async Task<ActionResult<HVI>> FileUploadToDB3(ListHVI model)
        {
            try
            {
                var response = await _hviRepository.UploadHVI3(model.HVIList/*, model.Title*/);
                return Ok(response);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message.ToString());
            }
        }

        [HttpPost]
        [Route("hvi4")]
        public async Task<ActionResult<HVI>> FileUploadToDB4(ListHVI model)
        {
            try
            {
                var response = await _hviRepository.UploadHVI4(model.HVIList/*, model.Title*/);
                return Ok(response);
            }
            catch (Exception e)
            {

                throw new Exception(e.Message.ToString());
            }
        }
    }
}
