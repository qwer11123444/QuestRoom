using System.ComponentModel.DataAnnotations;

namespace QuestRoom.Model;

public class Booking
{
    [Key] public int Id { get; set; }
    public string BookTittle { get; set; }
    public string BookDecription { get; set; }
    public int BookPeopleCount { get; set; }
    public int BookPrice { get; set; }
}