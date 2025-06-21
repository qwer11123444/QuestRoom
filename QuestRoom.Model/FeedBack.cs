using System.ComponentModel.DataAnnotations;

namespace QuestRoom.Model;

public class FeedBack
{
    [Key] public int Id { get; set; }
    public string Feed { get; set; }
    public int Rate { get; set; }
}