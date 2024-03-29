﻿using Application.Interfaces;
using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Persistence_.Context
{
    public class ApplicationDBContext : DbContext
    {

        private readonly IDateTimeService _dateTime;

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options, IDateTimeService dateTime) :base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            _dateTime = dateTime;
        }
        public DbSet<Cliente> Clientes { get; set; }


       public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                   case EntityState.Added:
                        entry.Entity.Created = _dateTime.NowUtc;

                        break;

                    case EntityState.Modified:
                        entry.Entity.LastModified = _dateTime.NowUtc;

                        break;


                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    } 
}
