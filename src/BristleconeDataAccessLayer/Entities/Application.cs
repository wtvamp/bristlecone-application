using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Bristlecone.DataLayer.Common;

namespace Bristlecone.DataLayer.Entities
{
    [Table("Application")]
    public class Application : BaseEntity
    {
        public int ApplicationID { get; set; }

        public string ApplicationName { get; set; }
         
        public string ApplicationType { get; set; }
        
    }
}
