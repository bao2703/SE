using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Core
{
	public interface IRepository<TEntity> where TEntity : class
	{
		TEntity Find(string id);

		IEnumerable<TEntity> ToList();

		IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

		TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

		void Add(TEntity entity);

		void AddRange(IEnumerable<TEntity> entities);

		void Remove(TEntity entity);

		void RemoveRange(IEnumerable<TEntity> entities);
	}
}
