using Demo5_AccesBDD.DBManager;
using Demo5_AccesBDD.Interfaces;
using Demo5_AccesBDD.Models;

namespace Demo5_AccesBDD.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly AppDbContext _context; 
        public GameRepository(AppDbContext context) 
        { 
            _context = context;
        }

        public Game AddGame(Game game)
        {
            _context.Games.Add(game);
            _context.SaveChanges();
            return game;
        }

        public List<Game> GetAll()
        {
            return _context.Games.ToList();
        }
    }
}
