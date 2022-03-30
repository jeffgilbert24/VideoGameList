using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameList.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options)
            : base(options) { }
        public DbSet<Game> Games { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId =1,
                    Name = "Grand Theft Auto",
                    year = 2013,
                    Rating = 5
                },
                new Game
                {
                    GameId = 2,
                    Name = "Shadow of the Tomb Raider ",
                    year = 2016,
                    Rating = 4
                },
                new Game
                {
                    GameId = 3,
                    Name = "Madden NFL 19",
                    year = 2019,
                    Rating = 4
                }
             );
        }
    }
}
