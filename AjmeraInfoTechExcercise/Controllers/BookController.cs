using AITExcercise.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjmeraInfoTechExcercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly ILogger<BookController> _logger;
        private readonly IBookService _Service;

        public BookController( IBookService Service, ILogger<BookController> logger = null)
        {
            _logger = logger;
            _Service = Service;
        }


        [AllowAnonymous]
        [HttpGet("GetBookById")]
        public async Task<IActionResult> GetBookById(string id)
        {
            try
            {
                if (id != null && id != string.Empty)
                {
                    var result = await _Service.GetBookById(id);
                    if (result.Id != null)
                    {
                        return Ok(result);
                    }
                    else
                    {
                        return Ok("No record found");
                    }

                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
        [AllowAnonymous]
        [HttpGet("GetAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            try
            {
                var records = await _Service.GetAllBooks();
                return Ok(records);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500);
            }
        }
    }
}
