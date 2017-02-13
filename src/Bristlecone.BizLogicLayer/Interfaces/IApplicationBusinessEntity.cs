using System.Threading.Tasks;
using Bristlecone.BizLogicLayer.Common;
using Bristlecone.DataAccessLayer.Entities;

namespace Bristlecone.BizLogicLayer.Interfaces
{

    public interface IApplicationBusinessEntity : IBusinessEntity<Application>
    {
        Task<Application> GetApplicationAsync(long id);

        Task<Application> CreateApplicationAsync(Application Application);

        Task<Application> UpdateApplicationAsync(Application Application);
    }

}