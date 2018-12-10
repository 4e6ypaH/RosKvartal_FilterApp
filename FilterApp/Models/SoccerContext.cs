using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilterApp.Models
{
    public class SoccerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }

    public class SoccerDbInitializer : DropCreateDatabaseAlways<SoccerContext>
    {
        protected override void Seed(SoccerContext db)
        {
            Team t1 = new Team { Name = "Барселона" };
            Team t2 = new Team { Name = "Реал Мадрид" };
            db.Teams.Add(t1);
            db.Teams.Add(t2);
            db.SaveChanges();
            Player pl1 = new Player { Name = "Роналду", Age = 31, Position = "Нападающий", Team = t2 };
            Player pl2 = new Player { Name = "Месси", Age = 28, Position = "Нападающий", Team = t1 };
            Player pl3 = new Player { Name = "Хави", Age = 34, Position = "Полузащитник", Team = t1 };
            Player pl4 = new Player { Name = "Гарет Бейл", Age = 25, Position = "Полузащитник", Team = t2 };
            Player pl5 = new Player { Name = "Неймар", Age = 22, Position = "Нападающий", Team = t1 };
            Player pl6 = new Player { Name = "Родригес", Age = 26, Position = "Полузащитник", Team = t2 };
            db.Players.AddRange(new List<Player> { pl1, pl2, pl3, pl4, pl5, pl6 });
            db.SaveChanges();
        }
    }
}