using Demo5_AccesBDD.Interfaces;
using Demo5_AccesBDD.Models;

namespace Demo5_AccesBDD.Service
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository repo) 
        {
            _gameRepository = repo;
        }

        public Game AddGame(Game game)
        {
            return _gameRepository.AddGame(game);
        }

        public List<Game> Games()
        {
            return _gameRepository.GetAll(); 
        }
    }
}
