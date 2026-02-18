using Demo5_AccesBDD.Interfaces;
using Demo5_AccesBDD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo5_AccesBDD.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService) 
        {
            _gameService = gameService;
        }

        public IActionResult AddGame()
        {
            Game g = new Game("Zelda", "C'est un zelda", 200, 1);
            return Json(_gameService.AddGame(g));
        }

        public IActionResult GetAllGames()
        {
            return Json(_gameService.Games());
        }
    }
}
