using Avernus_Games_Store.src.Data;
using Microsoft.AspNetCore.Mvc;
using Avernus_Games_Store.src.Models;
using Microsoft.EntityFrameworkCore;
using Avernus_Games_Store.src;


[ApiController]
[Route("general")]
public class GeneralController : ControllerBase
{
    private AvernusGamesDbContext? _context;

    public GeneralController (AvernusGamesDbContext context)
    {
        _context = context;
    }

    // --------------------------   Buscar Endereco por ID ----------------------------------------

    [HttpGet]
    [Route("buscar_endereco_por_id")]
    public async Task<ActionResult<Endereco>> BuscarEnderecoPorId(int id)
    {
        if (_context is null) return NotFound();
        if (_context.Endereco is null) return NotFound();
        var endereco = await _context.Endereco.FindAsync(id);
        if (endereco is null) return NotFound();
        return endereco;
    }

    // --------------------------   Buscar Game por ID ----------------------------------------

    [HttpGet]
    [Route("buscar_game_por_id")]
    public async Task<ActionResult<Game>> BuscarGamePorId(int id)
    {
        if (_context is null) return NotFound();
        if (_context.Game is null) return NotFound();
        var game = await _context.Game.FindAsync(id);
        if (game is null) return NotFound();
        return game;
    }

    // --------------------------   Buscar Desenvolvedor por ID ----------------------------------------

    [HttpGet]
    [Route("buscar_desenvolvedor_por_id")]
    public async Task<ActionResult<Desenvolvedor>> BuscarDesenvolvedorPorId(int id)
    {
        if (_context is null) return NotFound();
        if (_context.Desenvolvedor is null) return NotFound();
        var desenvolvedor = await _context.Desenvolvedor.FindAsync(id);
        if (desenvolvedor is null) return NotFound();
        return desenvolvedor;
    }

    // --------------------------   Buscar Genero por ID ----------------------------------------

    [HttpGet]
    [Route("buscar_genero_por_id")]
    public async Task<ActionResult<Genero>> BuscarGeneroPorId(int id)
    {
        if (_context is null) return NotFound();
        if (_context.Genero is null) return NotFound();
        var genero = await _context.Genero.FindAsync(id);
        if (genero is null) return NotFound();
        return genero;
    }

    // --------------------------   Buscar Plataforma por ID ----------------------------------------

    [HttpGet]
    [Route("buscar_plataforma_por_id")] 
    public async Task<ActionResult<Plataforma>> BuscarPlataformaPorId(int id)
    {
        if (_context is null) return NotFound();
        if (_context.Plataforma is null) return NotFound();
        var plataforma = await _context.Plataforma.FindAsync(id);
        if (plataforma is null) return NotFound();
        return plataforma;
    }
}