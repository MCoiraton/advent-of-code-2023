using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Mvc;

using advent_of_code_2023.Models.DayFour;


namespace advent_of_code_2023.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DayFourController : ControllerBase
    {
        private readonly IDayFourService dayFourService;

        public DayFourController(IDayFourService dayFourService)
        {
            this.dayFourService = dayFourService;
        }

        [HttpGet]
        [Route("/ReadCard")]
        public ActionResult<List<ScratchCard>> ReadCard()
        {
            return Ok(dayFourService.ReadCards());
        }

        [HttpGet]
        [Route("/TotalPoint")]
        public ActionResult<string[]> GetTotalPoint()
        {
            return Ok(dayFourService.GetTotalPoint());
        }

        [HttpGet]
        [Route("/PartTwo")]
        public ActionResult<int> getPartTwo()
        {
            return Ok(dayFourService.PartTwo());
        }
    }
}