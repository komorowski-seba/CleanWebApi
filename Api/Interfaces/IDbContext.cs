using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApi.Api.Model;

namespace WebApi.Api.Interfaces
{
    public interface IDbContext
    {
        DbSet<Contact> Contacts { get; set; }
        Task<int> DBSaveChangesAsync();
    }
}
