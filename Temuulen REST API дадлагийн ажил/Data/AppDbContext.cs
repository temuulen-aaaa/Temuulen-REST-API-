using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Temuulen_REST_API_дадлагийн_ажил.Models;
namespace Temuulen_REST_API_дадлагийн_ажил.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<U021> U021s { get; set; }
        public DbSet<U41> U41 { get; set; }
        public DbSet<U021> U021 { get; set; }
        public DbSet<TEN_L> TEN_L { get; set; }
        public DbSet<MER_L> MER_L { get; set; }
        public DbSet<ATA_L> ATA_L { get; set; }
        public DbSet<AuthUser> AuthUser { get; set; }

    }
}
