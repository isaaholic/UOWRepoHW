using UOWRepoHW.Contexts;
using UOWRepoHW.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWRepoHW.Repositories;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly LibraryDbContext _libraryDbContext;
    private readonly DbSet<T> _dbSet;

    public Repository(LibraryDbContext libraryDbContext)
    {
        ArgumentNullException.ThrowIfNull(libraryDbContext, nameof(libraryDbContext));

        _dbSet = libraryDbContext.Set<T>();
        _libraryDbContext = libraryDbContext;
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
    }

    public T? GetById(int Id)
    {
        return _dbSet.Find(Id);
    }

    public IEnumerable<T>? GetList(Func<T, bool>? predicate = null)
    {
        return predicate is null ? _dbSet.ToList() : _dbSet.Where(predicate).ToList();
    }

    public void Remove(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }
}