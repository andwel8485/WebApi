using System;
namespace ApplicationCore.Contracts.Repositories
{
	public interface IBaseRepository<T> where T:class
	{
		IEnumerable<T> GetAll();
		T? GetById(int ?id);
		int Update(T entity);
		int Insert(T entity);
		int Delete(int id);

	}
}

