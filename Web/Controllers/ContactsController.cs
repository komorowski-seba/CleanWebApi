using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Api.Interfaces;
using WebApi.Api.Model;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactsController : ControllerBase
    {
        private readonly ICommandsContacts _commandsContracts;

        public ContactsController(ICommandsContacts commandsContacts)
        {
            _commandsContracts = commandsContacts;
        }

        // GET: api/Contacts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        {
            var result = await _commandsContracts.GetContacts();
            return new ActionResult<IEnumerable<Contact>>(result);
        }

        // GET: api/Contacts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contact>> GetContact(int id)
        {
            var contact = await _commandsContracts.GetContact(id);
            if (contact == null)
            {
                return NotFound();
            }

            return contact;
        }

        // POST: api/Contacts
        [HttpPost]
        public async Task<ActionResult<Contact>> PostContact([FromBody] Contact contact)
        {
            var contactID = await _commandsContracts.PostContact(contact);
            return CreatedAtAction("GetContact", new { id = contactID }, contact);
        }

        // DELETE: api/Contacts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Contact>> DeleteContact(int id)
        {
            var contact = await _commandsContracts.DeleteContact(id);
            if (contact == null)
            {
                return NotFound();
            }

            return contact;
        }
    }
}
