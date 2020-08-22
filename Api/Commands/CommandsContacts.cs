using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Api.Interfaces;
using WebApi.Api.Model;

namespace WebApi.Api.Commands
{
    public class CommandsContacts : ICommandsContacts
    {
        private readonly IDbContext _context;

        public CommandsContacts(IDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Contact>> GetContacts()
        {
            return await _context.Contacts.ToListAsync();
        }

        public async Task<Contact> GetContact(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            return contact;
        }

        public async Task<int> PostContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            await _context.DBSaveChangesAsync();

            return contact.ContactId;
        }

        public async Task<Contact> DeleteContact(int id)
        {
            var contact = await _context.Contacts.FindAsync(id);
            if (contact == null)
            {
                return null;
            }

            _context.Contacts.Remove(contact);
            await _context.DBSaveChangesAsync();

            return contact;
        }
    }
}
