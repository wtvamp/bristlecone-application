using Bristlecone.DataAccessLayer.Common;
using Microsoft.EntityFrameworkCore;

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
