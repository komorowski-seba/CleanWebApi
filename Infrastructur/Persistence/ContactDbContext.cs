using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Api.Interfaces;
using WebApi.Api.Model;

namespace WebApi.Infrastructur.Persistence
{
    public class ContactDbContext : DbContext, IDbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }

        public async Task<int> DBSaveChangesAsync()
        {
            return await SaveChangesAsync();
        }
    }
}
