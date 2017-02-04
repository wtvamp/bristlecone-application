using Bristlecone.DataLayer.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Bristlecone.DataAccessLayer
{

    public class BristleconeDbContext : BaseDbContext
    {
        public BristleconeDbContext(DbContextOptions<BristleconeDbContext> options) : base(options)
        {
            // Connection string inject in startup cs of calling application
        }

        // Bristlecone dbsets, etc. go here
    }
}
