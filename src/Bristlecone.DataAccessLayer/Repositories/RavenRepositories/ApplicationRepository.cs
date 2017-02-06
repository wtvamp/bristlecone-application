using Bristlecone.DataAccessLayer.Repositories.Interfaces;
using Bristlecone.DataLayer.Common;
using Bristlecone.DataLayer.Entities;
using Bristlecone.DataLayer.Interfaces;
using Raven.Client;

namespace Bristlecone.DataLayer.RavenRepositories
{
    /// <summary>
    /// Derivative repository for interacting with Bristlecone Application Entities using RavenDb
    /// </summary>
    public class ApplicationRavenRepository : RavenDbRepository<Application>, IApplicationRepository
    {
        /// <summary>
        /// Creates a new Raven Repository for Applications
        /// </summary>
        /// <param name="session"></param>
        public ApplicationRavenRepository(IDocumentSession session) : base(session)
        {

        }
    }
}