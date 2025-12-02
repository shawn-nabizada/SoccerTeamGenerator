using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoccerApp.Data;
using SoccerApp.Models;
using SoccerApp.Services;

namespace SoccerApp.Controllers
{
    public class TeamController : Controller
    {
        private readonly SoccerContext _context;

        public TeamController(SoccerContext context)
        {
            _context = context;
        }
        
        
        public async Task<IActionResult> Index()
        {
            var players = await _context.Players.ToListAsync();
            
            return View(players);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Players
                .FirstOrDefaultAsync(m => m.Id == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }
        
        [HttpPost]
        public async Task<IActionResult> Generate(List<Player> players, int numberOfTeams)
        {
            var selectedIds = players.Where(p => p.IsSelected).Select(p => p.Id).ToList();

            var dbPlayers = await _context.Players
                                        .Where(p => selectedIds.Contains(p.Id))
                                        .ToListAsync();

            if (dbPlayers.Count < numberOfTeams)
            {
                ViewBag.Error = $"You selected {dbPlayers.Count} players, but requested {numberOfTeams} teams. Reduce teams or select more players.";
                return View("Index", await _context.Players.ToListAsync());
            }

            var teams = TeamBalancer.GenerateTeams(dbPlayers, numberOfTeams);

            return View("Results", teams);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Player player)
        {
            if (ModelState.IsValid)
            {
                _context.Add(player);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(player);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var player = await _context.Players.FirstOrDefaultAsync(m => m.Id == id);
            if (player == null) return NotFound();
            return View(player);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player != null)
            {
                _context.Players.Remove(player);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}