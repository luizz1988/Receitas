using OnHelp.Api.Domain.Contracts.Repositories.Base;
using OnHelp.Api.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Repository.Base
{
    public abstract class DataAccessBase<T> : IDisposable, IRepository<T> where T : EntityBase
    {

        #region "Attributes"
        public bool ChainExecute { get; set; }
        #endregion

        #region "Constructor"

        protected DataAccessBase()
        {
            Context = new DataContextBase();
            DbSet = Context.Set<T>();
        }

        #endregion

        #region "Properties"

        protected DataContextBase Context { get; private set; }

        protected DbSet<T> DbSet { get; private set; }

        #endregion

        #region "Methods"

        public T GetById(int id)
        {
            return this.DbSet.FirstOrDefault(e => e.Id == id);
        }

        public List<T> GetAll()
        {
            return this.DbSet.ToList();
        }

        public IEnumerable<T> GetByCriteria(Expression<Func<T, bool>> expression)
        {
            if (expression == null)
                return this.DbSet;

            return this.DbSet.Where(expression);
        }

        public void AddOrUpdate(T item)
        {
            this.Context.Entry(item).State = (item.Id == 0 ? EntityState.Added : EntityState.Modified);
        }

        public void AddOrUpdateBatch(IEnumerable<T> items)
        {
            this.DbSet.AddRange(items);
        }

        public void Delete(T item)
        {
            this.DbSet.Remove(item);
        }

        public void DeleteBatch(IEnumerable<T> items)
        {
            this.DbSet.RemoveRange(items);
        }

        public void Save()
        {
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
                Context = null;
            }
        }

        #endregion

    }
}
