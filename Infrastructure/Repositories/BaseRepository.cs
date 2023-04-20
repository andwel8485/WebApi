using System;
using Infrastructure.Data;
using ApplicationCore.Contracts.Repositories;
namespace Infrastructure.Repositories
{
	public class BaseRepository<T>:IBaseRepository<T> where T:class
	{

		private readonly WebAppDbContext _dbContext;
		public BaseRepository(WebAppDbContext webAppDbContext)
		{
            _dbContext = webAppDbContext;
		}
		public IEnumerable<T> GetAll()
		{
			return _dbContext.Set<T>();
		}

		public T? GetById(int ?id)
		{
			return _dbContext.Set<T>().Find(id);
		}

		public int Update(T entity)
		{
            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();
			return 1;
		}

        public int Delete(int id)
        {

			var entity = GetById(id);
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
            return 1;
        }

        public int Insert(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
			return 1;
        }
    }
}

