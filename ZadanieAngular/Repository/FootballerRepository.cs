using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZadanieAngular.Data;
using ZadanieAngular.DTO;
using ZadanieAngular.Models;

namespace ZadanieAngular.Repository
{
    public class FootballerRepository : IFootballerRepository
    {
        private readonly FootballerContext footballerContext;

        public FootballerRepository(FootballerContext _context)
        {
            footballerContext = _context;
        }

        public async Task<Guid> addFootballer(FootballerPostDto FootballerPostDto)
        {
            Footballer footballer = new Footballer()
            {
                FootballerID = Guid.NewGuid(),
                FirstName = FootballerPostDto.FirstName,
                LastName = FootballerPostDto.LastName,
                ImgPath = FootballerPostDto.ImgPath
            };

            await footballerContext.Footballers.AddAsync(footballer);
            await saveAll();
            return footballer.FootballerID;

        }

        public async Task<bool> deleteFootballer(Footballer footballer)
        {

            footballerContext.Footballers.Remove(footballer);
            await saveAll();
            return true;

        }

        public async Task<IEnumerable<Footballer>> getAllFootballers()
        {
            return await footballerContext.Footballers.ToListAsync();
        }


        public async Task<Footballer> getFootballerById(Guid id)
        {

            var footballer = await footballerContext.Footballers.FirstOrDefaultAsync(x => x.FootballerID == id);
            return footballer;
        }
        public async Task<Boolean> saveAll()
        {
            return await footballerContext.SaveChangesAsync() > 0;
        }
    }
}
