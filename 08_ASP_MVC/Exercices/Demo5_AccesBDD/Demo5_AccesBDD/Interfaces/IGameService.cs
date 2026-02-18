using Demo5_AccesBDD.Models;

namespace Demo5_AccesBDD.Interfaces
{
    public interface IGameService
    {
        public List<Game> Games();
        public Game AddGame(Game game);
    }
}
