using System.ComponentModel.DataAnnotations;

namespace QuestRoom.Model;

public class Quest
{
    [Key] public int Id { get; set; }
    public string Tittle { get; set; }
    public string Desription { get; set; }
    public int PeopleCount { get; set; }
    public int Price { get; set; }
}