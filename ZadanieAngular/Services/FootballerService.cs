using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZadanieAngular.Models;
using ZadanieAngular.Repository;

namespace ZadanieAngular.Services
{
    public class FootballerService : IFootballerService
    {
        private readonly IFootballerRepository footballerRepository;

        public FootballerService(IFootballerRepository _footballerRepository)
        {
            footballerRepository = _footballerRepository;
        }

        public async Task<Footballer> deleteByFootballerId(Guid footballerId)
        {
            var footballer = await footballerRepository.getFootballerById(footballerId);

            await footballerRepository.deleteFootballer(footballer);

            return footballer;
        }

        public async Task<Footballer> updateFootballer(Footballer footballer)
        {

            var footballerr = await footballerRepository.getFootballerById(footballer.FootballerID);

            footballerr.LastName = footballer.LastName;
            footballerr.FirstName = footballer.FirstName;


            await footballerRepository.saveAll();


            return footballerr;
        }
    }
}
