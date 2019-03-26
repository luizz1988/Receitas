using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Repository.Base
{

    public class DataContextBase : DbContext
    {

        #region : Constructor

        public DataContextBase() : base("DataContextBase")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        #endregion

        #region DbSets

        public DbSet<Receita> Usuario { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.AddFromAssembly(typeof(DataContextBase).Assembly);
        }

    }
}
