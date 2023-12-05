using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using advent_of_code_2023.Models.DayTwo;
using Microsoft.AspNetCore.Mvc;

namespace advent_of_code_2023.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DayTwoController : ControllerBase
    {
        private readonly IDayTwoService dayTwoService;

        public DayTwoController(IDayTwoService dayTwoService)
        {
            this.dayTwoService = dayTwoService;
        }

        [HttpGet]
        [Route("/inputDayTwo")]
        public ActionResult<List<Game>> ReadFile()
        {
            return Ok(dayTwoService.ReadFile());
        }

        [HttpGet]
        [Route("/totalId")]
        public ActionResult<int> GetTotalId()
        {
            return Ok(dayTwoService.SumPossibleGame());
        }

        [HttpGet]
        [Route("/partTwoDaytwo")]
        public ActionResult<int> GetPartTwo()
        {
            return Ok(dayTwoService.SumPower());
        }
    }
}