using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using advent_of_code_2023.Models.DayThree;
using Microsoft.AspNetCore.Mvc;

namespace advent_of_code_2023.Controllers
{
    public class DayThreeController: ControllerBase
    {
        private readonly IDayThreeService dayThreeService;

        public DayThreeController(IDayThreeService daythreeService)
        {
            this.dayThreeService = daythreeService;
        }

        [HttpGet]
        [Route("/inputDaythree")]
        public ActionResult<Part> ReadFile()
        {
            return Ok(dayThreeService.FindPart());
        }

        [HttpGet]
        [Route("/PartTotal")]
        public ActionResult<int> TotalPartNumbre()
        {
            return Ok(dayThreeService.PartTotal());
        }
    }
}