using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GBApp.Models;

namespace GBApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {

        private readonly IMyService _myService;

        public HomeController(IMyService myService)
        {
            _myService = myServicee;
        }

        [HttpGet("GetWelcome")]
        public async Task<IActionResult> GetWelcomeOnDate(DateTime? date)
        {
            try
            {
                if(date ==null)
                    return BadRequest("указано неверное значение параметра даты");
               
                var exProcList = _myService.GetWelcome(date);
                if (exProcList == null)
                {
                    return NotFound("Ошибка исполнения");
                }
                return Ok(exProcList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetCurrentDate")]
        public async Task<IActionResult> GetCurrentDate()
        {
            try
            {

                return Ok(DateTime.Now.ToShortDateString());
                       
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
