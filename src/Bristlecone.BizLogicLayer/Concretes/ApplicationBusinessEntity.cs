using System;
using System.Linq;
using System.Threading.Tasks;
using Bristlecone.BusinessLayer.Common;
using Bristlecone.BusinessLayer.Interfaces;
using Bristlecone.DataLayer.Entities;
using Bristlecone.DataAccessLayer.Repositories.Interfaces;

namespace Bristlecone.BusinessLayer.Concretes
{
    /// <summary>
    /// Create an Application Business Entity to handle Application Business Logic before saving to the database
    /// </summary>
    public class ApplicationBusinessEntity : BusinessEntity<Application>, IApplicationBusinessEntity
    {
        private IApplicationRepository _applicationRepository;

        /// <summary>
        /// Constructor for injection Application repository
        /// </summary>
        /// <param name="applicationRepository"></param>
        public ApplicationBusinessEntity(IApplicationRepository applicationRepository) : base(applicationRepository)
        {
            _applicationRepository = applicationRepository;

        }

        /// <summary>
        /// Get an Application from the repository and apply business rules before returning it
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Application> GetApplicationAsync(long id)
        {
            // Fetch our Application
            var application = _applicationRepository.FindBy(p => p.ApplicationID == id).FirstOrDefault();

            // Apply Business Rules

            // Return object after rules have been applied
            return await Task.FromResult(application);
        }

        /// <summary>
        /// Applying business rules to an Application object before creating it.
        /// </summary>
        /// <param name="Application"></param>
        /// <returns></returns>
        public async Task<Application> CreateApplicationAsync(Application Application)
        {
            try
            {
                // Check if app already exists
                var existingApplication = GetApplicationAsync(Application.ApplicationID).Result;
                if (existingApplication != null)
                    // This Application already exists, we're not adding it again.
                    return await Task.FromResult(Application);

                // Apply business logic
                // existingApplication.ApplicationName == 3 characters or more, etc...

                // Call the base EntityService Create
                Create(Application);

                // Fetch the newly created object so we can pass it back with the ResponseDTO
                var applicationCreated = await GetApplicationAsync(Application.ApplicationID);

                return await Task.FromResult(applicationCreated);
            }
            catch (Exception)
            {
                // TODO: Log exceptions AND catch more generic exceptions first
                return await Task.FromResult(Application);
            }
        }

        /// <summary>
        /// Applying business rules to an Application object before updating it.
        /// </summary>
        /// <param name="Application"></param>
        /// <returns></returns>
        public async Task<Application> UpdateApplicationAsync(Application Application)
        {
            try
            {
                // Fetch our Application
                var existingApplication =
                    _applicationRepository.FindBy(e => e.ApplicationID == Application.ApplicationID)
                        .FirstOrDefault();

                if (existingApplication == null)
                    // Application wasn't found, so we won't attempt to update
                    return await Task.FromResult(Application);

                // Apply business logic
                // existingApplication.ApplicationName == 3 characters or more, etc...
                
                // Call the base EntityService Update
                Update(Application);

                // Fetch the newly created object so we can pass it back with the ResponseDTO
                var ApplicationUpdated = await GetApplicationAsync(Application.ApplicationID);

                return await Task.FromResult(ApplicationUpdated);
            }
            catch (Exception)
            {
                // TODO: Log exceptions
                return await Task.FromResult(Application);
            }
        }
    }
}