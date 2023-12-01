using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Mvc;

namespace advent_of_code_2023.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DayOneController : ControllerBase
    {
        private readonly IDayOneService dayOneService;

        public DayOneController(IDayOneService dayOneService)
        {
            this.dayOneService = dayOneService;
        }
        //TODO add a way to post a file
       /* [HttpPost]
        [Route("/PostInput")]
        public ActionResult<string[]> PostEntry(string entry){
            return Ok(dayOneService.PostEntry(entry));
        }
        */
        [HttpGet]
        [Route("/sum")]
        public ActionResult<string[]> SumValues(){
            return Ok(dayOneService.SumValues());
        }

        [HttpGet]
        [Route("/input")]
        public ActionResult<string[]> ReadFile(){
            return Ok(dayOneService.ReadFile());
        }
        
    }
}