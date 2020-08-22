using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Api.Model;

namespace WebApi.Api.Interfaces
{
    public interface ICommandsContacts
    {
        Task<IEnumerable<Contact>> GetContacts();

        Task<Contact> GetContact(int id);

        Task<int> PostContact(Contact contact);

        Task<Contact> DeleteContact(int id);
    }
}
