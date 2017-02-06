using System.Threading.Tasks;
using Bristlecone.DataLayer.Entities;
using BristleCone.ServiceLayer.Common;
using Bristlecone.ViewModels.DTO;
using Bristlecone.ServiceLayer.Common;

namespace Bristlecone.Service.Interfaces
{

    public interface IApplicationService : IEntityService<Application>
    {
        Task<ApplicationDTO> GetApplicationAsync(long id);

        Task<ResponseDTO> CreateApplicationAsync(ApplicationDTO applicationDto);

        Task<ResponseDTO> UpdateApplicationAsync(ApplicationDTO applicationDto);
    }

}