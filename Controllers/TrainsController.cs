using trains.DB;
using trains.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using gregsharp.Services;
using System;

namespace gregsharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TrainsController : ControllerBase
    {
        private readonly TrainsService _service;
        //Dependency Injection
        public TrainsController(TrainsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Train>> GetAll()
        {
            try
            {
                return Ok(FakeDB.Trains);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Train> GetById(string id)
        {
            try
            {
                Train found = _service.GetById(id);
                return Ok(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }

        [HttpPost]
        public ActionResult<Train> Create([FromBody] Train newTrain)
        {
            try
            {
                Train train = _service.Create(newTrain);
                return Ok(train);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}