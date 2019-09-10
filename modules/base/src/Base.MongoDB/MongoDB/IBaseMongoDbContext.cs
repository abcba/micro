﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Base.MongoDB
{
    [ConnectionStringName("Base")]
    public interface IBaseMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
