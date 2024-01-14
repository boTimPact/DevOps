using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevOps.Models;
using DevOps.Data;

namespace DevOps.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet, ActionName("Clicks")]
    public IActionResult GetClicks()
    {
        _logger.Log(LogLevel.Information, "Get Clicks");
        var timestamps = _context.Timestamps.Select(t => t.Time).ToList();
        return Json( new { clicks = timestamps });
    }

    [HttpPost, ActionName("Clicks")]
    public IActionResult PostClicks(string timestamp)
    {
        _logger.Log(LogLevel.Information, "Post Click");
        _context.Add(new Timestamp { Time = timestamp });
        _context.SaveChanges();
        return Ok();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

