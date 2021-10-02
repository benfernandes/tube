using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tube.Data;
using Tube.Models;

namespace Tube.Controllers
{
    [Route("api/stations")]
    [ApiController]
    public class StationsController : ControllerBase
    {
        private readonly MockTubeRepo _repository = new MockTubeRepo();

        // GET api/stations
        [HttpGet]
        public ActionResult<IEnumerable<Station>> GetAllStations()
        {
            var stations = _repository.GetAllStations();
            return Ok(stations);
        }

        // GET api/stations/{id}
        [HttpGet("{id}")]
        public ActionResult<Station> GetStationById(int id)
        {
            var station = _repository.GetStationById(id);
            return Ok(station);
        }
    }
}