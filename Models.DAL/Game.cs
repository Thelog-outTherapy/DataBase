using System.ComponentModel.DataAnnotations;

namespace Models.DAL;

public class Game
{
    [Key]public int GameID { get; set; }
    public string GameName { get; set; }
    public GameGenre Genre { get; set; }
}