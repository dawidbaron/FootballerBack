using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZadanieAngular.DTO;
using ZadanieAngular.Models;

namespace ZadanieAngular.Repository
{
    public interface IFootballerRepository
    {
        Task<IEnumerable<Footballer>> getAllFootballers();

        Task<Guid> addFootballer(FootballerPostDto footballerPostDto);
        Task<Footballer> getFootballerById(Guid FootballerId);

        Task<Boolean> saveAll();

        Task<Boolean> deleteFootballer(Footballer footballer);
    }
}
