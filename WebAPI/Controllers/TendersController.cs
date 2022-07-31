using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TendersController : ControllerBase
    {
        ITenderService _tenderService;

        public TendersController(ITenderService tenderService)
        {
            _tenderService = tenderService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {           
            var result = _tenderService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbytenderid")]
        public IActionResult GetByTenderID(int TenderID)
        {
            var result = _tenderService.GetByTenderID(TenderID);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Tender tender)
        { 
            var result = _tenderService.Add(tender);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
