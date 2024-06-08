using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess;

public class EfRepositoryBase<TEntity, TContext> : IRepository<TEntity>
    where TContext : DbContext
    where TEntity : Entity
{
    //TContext instance
    //Yalnızca constructor ile atanabilmesi ve ardından değiştirilememsi için readonly
    private readonly TContext Context;

    //TContext instance ataması için constructor
    public EfRepositoryBase(TContext context)
    {
        Context = context;
    }

    //IRepository'den implemente edilen metotlar
    public void Add(TEntity entity)
    {
        Context.Add(entity);
        Context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        Context.Update(entity);
        Context.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        Context.Remove(entity);
        Context.SaveChanges();
    }
    public List<TEntity> GetAll()
    {
        return Context.Set<TEntity>().ToList();  
    }

    public TEntity? GetById(int id)
    {
        return Context.Set<TEntity>().FirstOrDefault(x => x.Id == id);
    }
}

