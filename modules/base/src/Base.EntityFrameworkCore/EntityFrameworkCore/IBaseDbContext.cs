﻿using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Base.EntityFrameworkCore
{
    [ConnectionStringName("Base")]
    public interface IBaseDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}