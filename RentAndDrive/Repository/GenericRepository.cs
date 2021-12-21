using Microsoft.EntityFrameworkCore;
using RentAndDrive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RentAndDrive.Repository
{
    public class GenericRepository<T> where T : class, new()
    {
        Context c = new Context();
        public T TGet(int id)
        {
            return c.Set<T>().Find(id);
        }
        public void TAdd(T p)
        {
            c.Set<T>().Add(p);
            c.SaveChanges();
        }
        public List<T> TList()
        {
            return c.Set<T>().ToList();
        }
        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }
    }
}
