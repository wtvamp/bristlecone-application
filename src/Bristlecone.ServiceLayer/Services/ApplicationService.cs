using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using AutoMapper;
using Bristlecone.Service.Common;
using Bristlecone.DataLayer.Entities;
using Bristlecone.BusinessLayer.Interfaces;
using Bristlecone.ViewModels.DTO;
using Bristlecone.Service.Interfaces;
using Bristlecone.ServiceLayer.Common;

namespace IDX.Service.Services
{
    public class ApplicationService : EntityService<Application>, IApplicationService
    {
        private IApplicationBusinessEntity _applicationBusiness;
        IResponseUtilities<ApplicationDTO> _responseUtilities;


        /// <summary>
        /// Constuctor
        /// </summary>
        /// <param name="ApplicationBusiness">Required repository from DI Container</param>
        /// <param name="responseUtilities">Required object to create standard ResponseDTO objects</param>
        public ApplicationService(IApplicationBusinessEntity applicationBusiness, IResponseUtilities<ApplicationDTO> responseUtilities)
            : base(applicationBusiness)
        {
            _applicationBusiness = applicationBusiness;
            _responseUtilities = responseUtilities;
        }

        /// <summary>
        /// Fetches a Application record, constructs a ApplicationDTO and passes it back in the response
        /// </summary>
        /// <param name="id">The ApplicationId</param>
        /// <returns>ApplicationDTO</returns>
        public async Task<ApplicationDTO> GetApplicationAsync(long id)
        {
            // Fetch our Application
            var Application = await _applicationBusiness.GetApplicationAsync(id);

            // Map our db entity to our API model
            var ApplicationDto = Mapper.Map<Application, ApplicationDTO>(Application);

            return await Task.FromResult(ApplicationDto);
        }


        /// <summary>
        /// Takes the passed ApplicationDTO, constructs a new Application, and saves to the DB
        /// </summary>
        /// <param name="ApplicationDto">The ApplicationDTO</param>
        /// <returns>ResponseDTO</returns>
        public async Task<ResponseDTO> CreateApplicationAsync(ApplicationDTO ApplicationDto)
        {
            try
            {
                var existingApplication = GetApplicationAsync(ApplicationDto.ApplicationID).Result;
                if (existingApplication != null)
                    // This Application already exists, we're not adding it again.
                    return await Task.FromResult(_responseUtilities.GetDuplicateEntityResponseDto(ApplicationDto));

                // Map our API model to the related db entity
                var ApplicationToCreate = Mapper.Map<ApplicationDTO, Application>(ApplicationDto);

                // Call the base EntityService Create
                Create(ApplicationToCreate);

                // Fetch the newly created object so we can pass it back with the ResponseDTO
                var ApplicationCreated = await GetApplicationAsync(ApplicationToCreate.ApplicationID);

                return await Task.FromResult(_responseUtilities.GetCreatedResponseDto(ApplicationCreated, ApplicationCreated.ApplicationID));
            }
            catch (Exception ex)
            {
                // TODO: Log exceptions
                return await Task.FromResult(_responseUtilities.GetExceptionResponseDto(ex, ApplicationDto));
            }
        }

        /// <summary>
        /// Takes the passed ApplicationDTO, constructs a new Application, finds it and saves to the DB
        /// </summary>
        /// <param name="ApplicationDto">ApplicationDto</param>
        /// <returns>ResponseDTO</returns>
        public async Task<ResponseDTO> UpdateApplicationAsync(ApplicationDTO ApplicationDto)
        {
            try
            {
                // Fetch our Application
                var existingApplication = await _applicationBusiness.GetApplicationAsync(ApplicationDto.ApplicationID);

                if (existingApplication == null)
                    // Application wasn't found, so we won't attempt to update
                    return await Task.FromResult(_responseUtilities.GetEntityNotFoundResponseDto(ApplicationDto));

                // Map our API model to the related db entity
                var ApplicationToUpdate = Mapper.Map(ApplicationDto, existingApplication);

                // Call the base EntityService Update
                Update(ApplicationToUpdate);

                // Fetch the newly created object so we can pass it back with the ResponseDTO
                var ApplicationUpdated = await GetApplicationAsync(ApplicationToUpdate.ApplicationID);

                return await Task.FromResult(_responseUtilities.GetUpdatedResponseDto(ApplicationUpdated));
            }
            catch (Exception ex)
            {
                // TODO: Log exceptions
                return await Task.FromResult(_responseUtilities.GetExceptionResponseDto(ex, ApplicationDto));
            }
        }        
    }
}