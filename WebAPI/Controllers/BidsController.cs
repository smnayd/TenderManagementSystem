using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BidsController : ControllerBase
    {
        IBidService _bidService;

        public BidsController(IBidService bidService)
        {
            _bidService = bidService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bidService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbybidid")]
        public IActionResult GetByBidID(int BidID)
        {
            var result = _bidService.GetByBidID(BidID);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet]
        public IActionResult GetByTenderID(int TenderID)
        {
            var result = _bidService.GetTenderID(TenderID);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyuserid")]
        public IActionResult GetByUserID(int UserID)
        {
            var result = _bidService.GetUserID(UserID);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbiddetaildtos")]
        public IActionResult GetBidDetailDtos()
        {
            var result = _bidService.GetBidDetailDtos();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        /*gözden geçirilecek */
        //[HttpPost("delete")]
        //public IActionResult Delete(int BidID)
        //{
        //    var result = _bidService.Delete(BidID);
        //    if(result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        //[HttpPost("update")]
        //public IActionResult Update(Bid bid)
        //{
        //    var result = _bidService.Update(bid);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        [HttpPost("add")]
        public IActionResult Add(Bid bid)
        {
            var result = _bidService.Add(bid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
