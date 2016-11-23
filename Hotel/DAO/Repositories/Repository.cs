using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
	public abstract class Repository<TEntity> where TEntity : class
	{
		private readonly DbContext context;

		#region Properties
		private DbSet<TEntity> Entities { get; set; }

		protected HotelContext HotelContext
		{
			get
			{
				return context as HotelContext;
			}
		} 
		#endregion

		public Repository(DbContext context)
		{
			this.context = context;
			Entities = this.context.Set<TEntity>();
		}

		public TEntity Find(string id)
		{
			return Entities.Find(id);
		}

		public List<TEntity> ToList()
		{
			return Entities.ToList();
		}

		public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
		{
			return Entities.Where(predicate);
		}

		public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
		{
			return Entities.SingleOrDefault(predicate);
		}

		public void Add(TEntity entity)
		{
			Entities.Add(entity);
		}

		public void AddRange(IEnumerable<TEntity> entities)
		{
			Entities.AddRange(entities);
		}

		public void Remove(TEntity entity)
		{
			Entities.Remove(entity);
		}

		public void RemoveRange(IEnumerable<TEntity> entities)
		{
			Entities.RemoveRange(entities);
		}

		public IEnumerable<TEntity> OrderBy(Expression<Func<TEntity, string>> keySelector)
		{
			return Entities.OrderBy(keySelector);
		}

		public IEnumerable<TEntity> OrderByDescending(Expression<Func<TEntity, string>> keySelector)
		{
			return Entities.OrderByDescending(keySelector);
		}

		public bool Any(Expression<Func<TEntity, bool>> predicate)
		{
			return Entities.Any(predicate);
		}
		public int Count()
		{
			return Entities.Count();
		}
	}
}
