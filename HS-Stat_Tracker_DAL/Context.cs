using Microsoft.EntityFrameworkCore;
using HS_Stat_Tracker_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS_Stat_Tracker_DAL
{
    class Context : DbContext
    {
        public DbSet<Card> cards { get; set; }
        public DbSet<Minion> minions { get; set; }
        public DbSet<Spell> spells { get; set; }
        public DbSet<Deck> decks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Stat-Tracker;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deck>()
                .HasKey(c => c.ID);

            modelBuilder.Entity<Minion>()
                .HasKey(c => c.dbfId);

            modelBuilder.Entity<Spell>()
                .HasKey(c => c.dbfId);

            modelBuilder.Entity<Card>()
                .HasDiscriminator(c => c.type)
                .HasValue<Minion>("minion")
                .HasValue<Spell>("spell");
        }
    }
}
