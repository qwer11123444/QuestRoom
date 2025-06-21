using System.ComponentModel.DataAnnotations;

namespace QuestRoom.Model;

public class Time
{
    [Key] public int Id { get; set; }
    public DateTime RecordDate { get; set; } = DateTime.Today;

    public DateTime RecordTime { get; set; } =
        new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00);
}