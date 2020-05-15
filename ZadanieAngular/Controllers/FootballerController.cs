using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZadanieAngular.DTO;
using ZadanieAngular.Models;
using ZadanieAngular.Repository;
using ZadanieAngular.Services;

namespace ZadanieAngular.Controllers
{
    [Route("footballer")]
    [ApiController]
    public class FootballerController : ControllerBase
    {

        private readonly IFootballerRepository footballerRepository;
        private readonly IFootballerService footballerService;
        public FootballerController(IFootballerRepository _footballerRepository, IFootballerService _footballerService)
        {
            footballerRepository = _footballerRepository;
            footballerService = _footballerService;
        }
        [HttpPost]
        public async Task<IActionResult> CreateFootballer(FootballerPostDto footballerToAdd)
        {
            try
            {
                var guid = await footballerRepository.addFootballer(footballerToAdd);
                return guid == Guid.Empty ? (IActionResult)StatusCode(500) : Ok(guid);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("all")]

        public async Task<IActionResult> getAllFootballer()
        {
            var footballers = await footballerRepository.getAllFootballers();
            return Ok(footballers.ToList());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> getFootballerById(Guid id)
        {
            var footballer = await footballerRepository.getFootballerById(id);
            return Ok(footballer);
        }



        [HttpPut]
        public async Task<IActionResult> updateFootballer(Footballer footballer)
        {

            var _footballer = await footballerService.updateFootballer(footballer);
            return Ok(_footballer);

        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteFootballer(Guid id)
        {
            var footballer= footballerService.deleteByFootballerId(id);
            return Ok(footballer);
        }
    }
}
