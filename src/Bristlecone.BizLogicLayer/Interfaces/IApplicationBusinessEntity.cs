using System.Threading.Tasks;
using Bristlecone.BusinessLayer.Common;
using Bristlecone.DataLayer.Entities;

namespace Bristlecone.BusinessLayer.Interfaces
{

    public interface IApplicationBusinessEntity : IBusinessEntity<Application>
    {
        Task<Application> GetApplicationAsync(long id);

        Task<Application> CreateApplicationAsync(Application Application);

        Task<Application> UpdateApplicationAsync(Application Application);
    }

}