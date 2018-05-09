using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.Test.Model
{
    public class MusicContext : DbContext
    {
        public MusicContext() : base()
        {
            //
        }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<CaSi> CaSis { get; set; }
        public DbSet<TheLoai> TheLoais { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}
