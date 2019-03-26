using OnHelp.Api.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Contracts.Repositories.Base
{
    public interface IRepository<T> where T : EntityBase
    {
        void AddOrUpdate(T item);
        void AddOrUpdateBatch(IEnumerable<T> items);
        void Delete(T item);
        void DeleteBatch(IEnumerable<T> items);
        void Dispose();
        IEnumerable<T> GetByCriteria(Expression<Func<T, bool>> expression);
        T GetById(int id);
        void Save();
    }
}
