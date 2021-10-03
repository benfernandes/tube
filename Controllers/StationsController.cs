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
        [HttpGet("{id}", Name = "GetStationById")]
        public ActionResult<StationReadDto> GetStationById(int id)
        {
            var station = _repository.GetStationById(id);
            if (station != null)
            {
                return Ok(_mapper.Map<StationReadDto>(station));
            }
            return NotFound();
        }

        // POST api/stations
        [HttpPost]
        public ActionResult<StationReadDto> CreateStation(StationCreateDto stationCreateDto)
        {
            var stationModel = _mapper.Map<Station>(stationCreateDto);
            _repository.CreateStation(stationModel);
            _repository.SaveChanges();

            var stationReadDto = _mapper.Map<StationReadDto>(stationModel);

            return CreatedAtRoute(nameof(GetStationById), new { Id = stationReadDto.Id }, stationReadDto);
        }
    }
}