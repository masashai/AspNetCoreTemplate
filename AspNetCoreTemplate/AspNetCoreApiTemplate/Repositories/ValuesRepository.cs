using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreApiTemplate.Data;

namespace AspNetCoreApiTemplate.Repositories
{
    public interface IValuesRepository
    {
        // Value Find(int id);
    }
    
    public class ValuesRepository : IValuesRepository
    {
        private readonly ApplicationDbContext _context;

        public ValuesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //public Value Find(int id)
        //{
        //    return _context.Values.Find(id);
        //}
    }
}
