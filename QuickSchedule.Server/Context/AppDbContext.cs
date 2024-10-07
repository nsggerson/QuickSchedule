using Microsoft.EntityFrameworkCore;
using QuickSchedule.Shared.Models;
using System.Collections.Generic;
using System.Net;

namespace QuickSchedule.Server.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Record> Records { get; set; }
        public DbSet<RecordAddress> RecordAddresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Password> Passwords { get; set; }
    }
}
