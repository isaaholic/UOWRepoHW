﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UOWRepoHW.Repositories;

public interface IRepository<T> where T : class
{
    IEnumerable<T>? GetList(Func<T, bool>? predicate = null);
    T? GetById(int Id);
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);
}
