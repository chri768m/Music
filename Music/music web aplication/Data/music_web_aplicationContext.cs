using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Music;

namespace music_web_aplication.Data
{
    public class music_web_aplicationContext : DbContext
    {
        public music_web_aplicationContext (DbContextOptions<music_web_aplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Music.Song> Song { get; set; }
    }
}
