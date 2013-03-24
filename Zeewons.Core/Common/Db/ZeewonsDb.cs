using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeewons.Core.Common.Db
{
   public class ZeewonsDb
    {
        public interface IZeewonsDb : IDisposable
        {
            IQueryable<T> Query<T>() where T : class;
            void Add<T>(T entity) where T : class;
            void Update<T>(T entity) where T : class;
            void Delete<T>(T entity) where T : class;
            void Deleted<T>(T entity) where T : class;
            void SaveChanges();
        }
        public class ZeewonsDB : DbContext, IZeewonsDb
        {
            public ZeewonsDB()
                : base("name=DefaultConnection")
            { }

            IQueryable<T> IZeewonsDb.Query<T>()
            {
                return Set<T>();
            }

            void IZeewonsDb.Add<T>(T entity)
            {
                Set<T>().Add(entity);
            }
            void IZeewonsDb.Update<T>(T entity)
            {
                Entry(entity).State = System.Data.EntityState.Modified;
            }

            void IZeewonsDb.Delete<T>(T entity)
            {
                Set<T>().Remove(entity);
            }
            void IZeewonsDb.SaveChanges()
            {
                SaveChanges();
            }
            void IZeewonsDb.Deleted<T>(T entity)
            {
                Entry(entity).State = System.Data.EntityState.Modified;
            }

        }
    }
}
