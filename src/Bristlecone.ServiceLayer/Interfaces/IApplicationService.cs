using System.Threading.Tasks;
using Bristlecone.DataAccessLayer.Entities;
using Bristlecone.ServiceLayer.Common;
using Bristlecone.ViewModels.DTO;
using BristleCone.ServiceLayer.Common;
using System.Collections.Generic;

namespace Bristlecone.ServiceLayer.Interfaces
{

    public interface IApplicationService : IEntityService<Application>
    {
        Task<ApplicationDTO> GetApplicationAsync(string id);

        Task<List<ApplicationDTO>> GetApplicationsAsync(List<string> ids);

        Task<ResponseDTO> CreateApplicationAsync(ApplicationDTO applicationDto);

        Task<ResponseDTO> UpdateApplicationAsync(ApplicationDTO applicationDto);
    }

}