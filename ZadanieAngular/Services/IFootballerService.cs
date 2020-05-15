using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZadanieAngular.Models;

namespace ZadanieAngular.Services
{
    public interface IFootballerService
    {
        public Task<Footballer> updateFootballer(Footballer footballer);
        public Task<Footballer> deleteByFootballerId(Guid footballerId);
    }
}
