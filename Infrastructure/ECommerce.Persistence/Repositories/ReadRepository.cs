using ECommerce.Persistence.Contexts;
using ECommerceAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {

        private readonly ECommerceAPIDbContext _context;










        // implementing interface

        public Microsoft.EntityFrameworkCore.DbSet<T> Table => throw new NotImplementedException();

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetSingleAsync(System.Linq.Expressions.Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetWhere(System.Linq.Expressions.Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }
    }
}
