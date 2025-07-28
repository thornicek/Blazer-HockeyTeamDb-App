using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorTeamRegistrationApp.Models;

public class Player
{
    public int ID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int? GamesPlayed { get; set; }
    public int? Goals { get; set; }
    public int? Assists { get; set; }
    public int? Points { get; set; }
    public DateOnly DoB { get; set; }
    
}