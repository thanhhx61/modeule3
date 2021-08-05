
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DBContexts;
using WebApplication1.Models;

namespace BookStore.Services
{
    public class ClasssService : IClasssService
    {
        public Task<List<Classs>> GetClasses()
        {
            throw new System.NotImplementedException();
        }

        public List<Classs> GetClasss()
        {
            throw new System.NotImplementedException();
        }

        public Task<Classs> GetClasssById(int classsId)
        {
            throw new System.NotImplementedException();
        }
    }
}
