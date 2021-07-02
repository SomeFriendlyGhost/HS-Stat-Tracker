using Microsoft.EntityFrameworkCore;
using HS_Stat_Tracker_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS_Stat_Tracker_DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {

        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Minion> Minions { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<Deck> Decks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deck>()
                .HasKey(c => c.ID);

            modelBuilder.Entity<Card>()
                .HasKey(c => c.dbfId);

            modelBuilder.Entity<Card>()
                .HasDiscriminator(c => c.type)
                .HasValue<Minion>("minion")
                .HasValue<Spell>("spell");
        }
    }
}
