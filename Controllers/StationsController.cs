using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Tube.Data;
using Tube.Dtos;
using Tube.Models;

namespace Tube.Controllers
{
    [Route("api/stations")]
    [ApiController]
    public class StationsController : ControllerBase
    {
        private readonly ITubeRepo _repository;
        private readonly IMapper _mapper;

        public StationsController(ITubeRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/stations
        [HttpGet]
        public ActionResult<IEnumerable<StationReadDto>> GetAllStations()
        {
            var stations = _repository.GetAllStations();
            return Ok(_mapper.Map<IEnumerable<StationReadDto>>(stations));
        }

        // GET api/stations/{id}
        [HttpGet("{id}")]
        public ActionResult<StationReadDto> GetStationById(int id)
        {
            var station = _repository.GetStationById(id);
            if (station != null)
            {
                return Ok(_mapper.Map<StationReadDto>(station));
            }
            return NotFound();
        }
    }
}