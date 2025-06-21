using Microsoft.EntityFrameworkCore;
using QuestRoom.Model;

namespace QuestRoom.Database;

public class QuestRoomContext : DbContext
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Quest> Quests { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<FeedBack> FeedBacks { get; set; }
    public DbSet<Time> Times { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite("Data Source=QuestRoom.db");
    }
}