using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly AppContext _context;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(AppContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }
    }
}
