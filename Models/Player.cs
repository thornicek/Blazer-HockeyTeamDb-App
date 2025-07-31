using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorTeamRegistrationApp.Models;

public class Player
{
    public int ID { get; set; }
    [Required]
    [StringLength(60, MinimumLength = 2)]
    public required string FirstName { get; set; }
    [Required]
    [StringLength(60, MinimumLength = 2)]
    public required string LastName { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    [Range(0, 82)]
    public int? GamesPlayed { get; set; }
    public int? Goals { get; set; }
    public int? Assists { get; set; }
    public int? Points { get; set; }
    public DateOnly DoB { get; set; }
    
}