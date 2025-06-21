using System.ComponentModel.DataAnnotations;

namespace QuestRoom.Model;

public class Client
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
}