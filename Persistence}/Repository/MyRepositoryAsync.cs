using Application.Interfaces;
using Ardalis.Specification.EntityFrameworkCore;
using Persistence_.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence_.Repository
{
    public class MyRepositoryAsync<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDBContext dbContext;

        public MyRepositoryAsync(ApplicationDBContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
 
    }

