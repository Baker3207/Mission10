using APIFun.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace APIFun.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowlers> Get()
        {
            var bowlerData = (from bowler in _bowlerRepository.Bowlers
                              join team in _bowlerRepository.Teams on bowler.TeamID equals team.TeamID
                              where team.TeamName == "Marlins" || team.TeamName == "Sharks"
                              select bowler).ToArray();

            return bowlerData;
        }

    }
}

