using Microsoft.EntityFrameworkCore;
using Tube.Models;

namespace Tube.Data
{
    public class TubeContext : DbContext
    {
        public TubeContext(DbContextOptions<TubeContext> opt) : base(opt)
        {

        }

        public DbSet<Station> Stations { get; set; }
    }
}