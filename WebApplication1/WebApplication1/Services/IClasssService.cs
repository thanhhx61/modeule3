
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace BookStore.Services
{
    public interface IClasssService
    {
        Task<List<Classs>> GetClasses();
        Task<Classs> GetClasssById(int classsId);

        List<Classs> GetClasss();
    }
}
