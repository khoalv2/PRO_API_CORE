using Microsoft.EntityFrameworkCore;
using PRO.Core;
using PRO.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace PRO.Data
{
    public class ProDbContext : DbContext
    {

        public DbSet<Music> Musics { get; set; }
        public DbSet<Artist> Artists { get; set; }

        public ProDbContext(DbContextOptions<ProDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new MusicConfiguration());
            builder.ApplyConfiguration(new ArtistConfiguration());
        }

    }
}
