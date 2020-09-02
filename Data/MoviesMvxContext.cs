using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MoviesMvx.Models
{
    public class MoviesMvxContext : DbContext
    {
        public MoviesMvxContext (DbContextOptions<MoviesMvxContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesMvx.Models.Movie> Movie { get; set; }
    }
}
