using Demo5_AccesBDD.Models;

namespace Demo5_AccesBDD.Interfaces
{
    public interface IGameRepository
    {

        public List<Game> GetAll();
        public Game AddGame(Game game);

    }
}
