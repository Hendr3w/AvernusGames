using Avernus_Games_Store.src.Data;
using Microsoft.AspNetCore.Mvc;
using Avernus_Games_Store.src.Models;
using Microsoft.EntityFrameworkCore;


[ApiController]
[Route("game")]

public class GameController : ControllerBase
{
  private AvernusGamesDbContext _dbContext;
  public GameController(AvernusGamesDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  // --------------------------   GameS --------------------------------------------------
  // Listar todos os Games(Games, RPGs e Vestimentas)
  [HttpGet]
  [Route("listar_Games")]
  public async Task<ActionResult<IEnumerable<Game>>> ListarGames()
  {
    if(_dbContext is null) return NotFound();
    if(_dbContext.Game is null) return NotFound();
    return await _dbContext.Game.ToListAsync();
  }


  // --------------------------   CRUD GAME --------------------------------------------------
  // Cadastrar Games:
  [HttpPost]
  [Route("cadastrar_game")]
  public IActionResult CadastrarGame(Game game)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Game is null) return NotFound();
      _dbContext.Add(game);

      _dbContext.SaveChanges();
    return  Created("", game);
  }


  // Listar somente os Games:
  [HttpGet]
  [Route("listar_game")]
  public async Task<ActionResult<IEnumerable<Game>>> ListarGame()
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Game is null) return NotFound();
    return await _dbContext.Game.ToListAsync();
  }


  // Buscar Game {id}:
  [HttpGet]
  [Route("buscar_game_id")]
  public async Task<ActionResult<Game>> BuscarGameId(int id)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Game is null) return NotFound();
    var gameTemp = await _dbContext.Game.FindAsync(id);
    if (gameTemp is null) return NotFound();
    return gameTemp;
  }


  // Buscar Game {nome}:
  [HttpGet]
  [Route("buscar_game_nome")]
  public async Task<ActionResult<List<Game>>> BuscarGameNome(string nome)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Game is null) return NotFound();
    var gamesTemp = await _dbContext.Game.Where(g => g.Nome.Contains(nome)).ToListAsync();
    if (gamesTemp.Count == 0) return NotFound();
    return gamesTemp;
  }


  // Alterar Game:
  [HttpPut()]
  [Route("alterar_game")]
  public async Task<ActionResult> AlterarGame(Game game)
  {
    if(_dbContext is null) return NotFound();
    if(_dbContext.Game is null) return NotFound();
    var gameTemp = await _dbContext.Game.FindAsync(game.Id);
    if(gameTemp is null) return NotFound();
    _dbContext.Game.Update(game);
    await _dbContext.SaveChangesAsync();
    return Ok();
  }


  // Alterar Valor Game:
  [HttpPatch()]
  [Route("mudar_valor_game_id")]
  public async Task<ActionResult> MudarValorGame(int id, [FromForm] float valor)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Game is null) return NotFound();
    var gameTemp = await _dbContext.Game.FindAsync(id);
    if (gameTemp is null) return NotFound();
    gameTemp.ValorCompra = valor;
    await _dbContext.SaveChangesAsync();
    return Ok();
  }
  

  // Deletar Game {id}:
  [HttpDelete]
  [Route("deletar_game_id/{id}")]
  public async Task<ActionResult> DeletarGameId(int id)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Game is null) return NotFound();
    var gameTemp = await _dbContext.Game.FindAsync(id);
    if (gameTemp is null) return NotFound();
    _dbContext.Remove(gameTemp);
    await _dbContext.SaveChangesAsync();
    return Ok();
  }

  /*
  // Deletar Game {nome}:
  [HttpDelete]
  [Route("DeletarGame{nome}")]
  public async Task<ActionResult<List<Game>>> DeletarGameNome(string nome)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Game is null) return NotFound();
    var gamesTemp = await _dbContext.Game.Where(g => g.Nome.Contains(nome)).ToListAsync();
    if (gamesTemp.Count == 0) return NotFound();
    _dbContext.Remove(gamesTemp);
    await _dbContext.SaveChangesAsync();
    return Ok();
  }
  */



}