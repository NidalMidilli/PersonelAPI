using DataAccessLayer.Abstract;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> obj;

         public Repository()
        {
            obj = c.Set<T>();
        }
        public int Add(T ent)
        {
            obj.Add(ent);
            return c.SaveChanges();
        }

      
        public int Delete(T ent)
        {
            obj.Remove(ent);
            return c.SaveChanges();
        }

        public T GetById(int id)
        {
            return obj.Find(id);
        }

        public List<T> ListAll()
        {
            return obj.ToList();
        }


        public int Update(T ent)
        {
            obj.Update(ent);
            return c.SaveChanges();
        }
    }
}
