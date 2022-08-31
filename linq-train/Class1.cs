namespace linq_train;
using System.Linq;
using System.Linq.Expressions; 
// using System.Data.Linq; 
public class Class1
{
  public static void Main(string[] args)
  {
    GamesControl();
    string[] actors = { "Al Pacino", "Samuel L. Jackson", "Robert De Niro", "Leonardo DiCaprio", "Morgan Freeman" };

    var actorsList = (from actor
                        in actors
                    select actor).Count();
    // São a mesma coisa...
    // var actorsList = actors.Count();
  }

  public static void GamesControl() 
  {
    string[] games = {"Fortnite", "Valorant", "Destiny", "Call of Duty", "World of Warcraft"};

    // 1° maneira... - declarativeLinq
    // IEnumerable<string> filteredGames = from game in games
    //                                          where game.Contains('a')
    //                                          select game;

    // 2° maneira... - labdaLinq
    // IEnumerable<string> filteredGames = System.Linq.Enumerable.Where(games, game => game.Contains('a')); 

    // 3° maneira... - labdaLinqRefactored
    var filteredGames = games.Where(game => game.Contains('a')); 

    foreach (var game in filteredGames)
    {
      Console.WriteLine(game);
    }
  }

}
