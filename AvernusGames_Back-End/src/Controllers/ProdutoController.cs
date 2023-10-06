using Avernus_Games_Store.src.Data;
using Microsoft.AspNetCore.Mvc;
using Avernus_Games_Store.src.Models;
using Microsoft.EntityFrameworkCore;


[ApiController]
[Route("Controller")]

public class ProdutoController : ControllerBase
{
  private AvernusGamesDbContext _dbContext;
  public ProdutoController(AvernusGamesDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  // --------------------------   PRODUTOS --------------------------------------------------
  // Listar todos os produtos(Games, RPGs e Vestimentas)
  [HttpGet]
  [Route("ListarProdutos")]
  public async Task<ActionResult<IEnumerable<Produto>>> ListarProdutos()
  {
    if(_dbContext is null) return NotFound();
    if(_dbContext.Produto is null) return NotFound();
    return await _dbContext.Produto.ToListAsync();
  }


  // --------------------------   CRUD GAME --------------------------------------------------
  // Postar Games:
  [HttpPost]
  [Route("CadastrarGame")]
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
  [Route("ListarGame")]
  public async Task<ActionResult<IEnumerable<Game>>> ListarGame()
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Game is null) return NotFound();
    return await _dbContext.Game.ToListAsync();
  }


  // Buscar Game {id}:
  [HttpGet]
  [Route("BuscarGamePor{id}")]
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
  [Route("FindGame{nome}")]
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
  [Route("AlterarGame")]
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
  [Route("MudarValorGame{id}")]
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
  [Route("DeletarGame{id}")]
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


  // -------------------------- CRUD PRGame -----------------------------------------------------
  // Postar RPGame:
  [HttpPost]
  [Route("CadastrarRPG")]
  public IActionResult CadastrarRPG(RPGame rpgame)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.RPGame is null) return NotFound();
     _dbContext.Add(rpgame);
     _dbContext.SaveChanges();
    return Created("", rpgame);
  }
  

  // Listar somente os RPGs:
  [HttpGet]
  [Route("ListarRPGame")]
  public async Task<ActionResult<IEnumerable<RPGame>>> ListarRPGame()
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.RPGame is null) return NotFound();
    return await _dbContext.RPGame.ToListAsync();
  }


  // Buscar RPGame {id}:
  [HttpGet]
  [Route("BuscarRPGame{id}")]
  public async Task<ActionResult<RPGame>> BuscarRPGameId(int id)
  {
    if(_dbContext is null) return NotFound();
    if(_dbContext.RPGame is null) return NotFound();
    var rpgameTemp = await _dbContext.RPGame.FindAsync(id);
    if(rpgameTemp is null) return NotFound();
    return rpgameTemp;
  }


  // Buscar RPGame {nome}:
  [HttpGet]
  [Route("FindRPGame{nome}")]
  public async Task<ActionResult<List<RPGame>>> BuscarRPGameNome(string nome)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.RPGame is null) return NotFound();
    var rpgamesTemp = await _dbContext.RPGame.Where(rpg => rpg.Nome.Contains(nome)).ToListAsync();
    if (rpgamesTemp.Count == 0) return NotFound();
    return rpgamesTemp;
  }

/*
  // Alterar RPGame:
  [HttpPut()]
  [Route("AlterarRPGame")]
  public async Task<ActionResult> AlterarRPGame(RPGame rpgame)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.RPGame is null) return NotFound();
    var rpgameTemp = await _dbContext.RPGame.FindAsync(rpgame.Id);
    if(rpgameTemp is null) return NotFound();
      _dbContext.RPGame.Update(rpgame);
    await _dbContext.SaveChangesAsync();
    return Ok();
  } */

  // Alterar Valor RPG:
  [HttpPatch()]
  [Route("MudarValorRPG{id}")]
  public async Task<ActionResult> MudarValorRPG(int id, [FromForm] float valor)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.RPGame is null) return NotFound();
    var rpgTemp = await _dbContext.RPGame.FindAsync(id);
    if (rpgTemp is null) return NotFound();
    rpgTemp.ValorCompra = valor;
    await _dbContext.SaveChangesAsync();
    return Ok();
  }


  // Deletar RPGame {id}:
  [HttpDelete]
  [Route("DelRPGame{id}")]
  public async Task<ActionResult> DeletarRPGameID(int id)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.RPGame is null) return NotFound();
    var rpgameTemp = await _dbContext.RPGame.FindAsync(id);
    if (rpgameTemp is null) return NotFound();
    _dbContext.Remove(rpgameTemp);
    await _dbContext.SaveChangesAsync();
    return Ok();
  }

  /*
  // Deletar RPGame {nome}:
  [HttpDelete]
  [Route("DeletarRPGame{nome}")]
  public async Task<ActionResult<List<RPGame>>> DeletarRPGameNome(string nome)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.RPGame is null) return NotFound();
    var rpgamesTemp = await _dbContext.RPGame.Where(rpg => rpg.Nome.Contains(nome)).ToListAsync();
    if (rpgamesTemp.Count == 0) return NotFound();
    _dbContext.Remove(rpgamesTemp);
    await _dbContext.SaveChangesAsync();
    return Ok();
  }
  */


  // -------------------------- CRUD VESTIMENTA -----------------------------------------------------------
  // Postar Vestimenta:
  [HttpPost]
  [Route("CadastrarVestimenta")]
  public IActionResult CadastrarVestimenta(Vestimenta vestimenta)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Vestimenta is null) return NotFound();

    _dbContext.Add(vestimenta);
    _dbContext.SaveChanges();
    return Created("", vestimenta);
  }


  // Listar somente as Vestimentas:
  [HttpGet]
  [Route("ListarVestimenta")]
  public async Task<ActionResult<IEnumerable<Vestimenta>>> ListarVestimenta()
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Vestimenta is null) return NotFound();
    return await _dbContext.Vestimenta.ToListAsync();
  }


  // Buscar Vestimenta {id}:
  [HttpGet]
  [Route("BuscarVestimenta{id}")]
  public async Task<ActionResult<Vestimenta>> BuscarVestimentaId(int id)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Vestimenta is null) return NotFound();
    var vestimentaTemp = await _dbContext.Vestimenta.FindAsync(id);
    if(vestimentaTemp is null) return NotFound();
    return vestimentaTemp;
  }


  // Buscar Vestimenta {nome}:
  [HttpGet]
  [Route("FindVestimenta{nome}")]
  public async Task<ActionResult<List<Vestimenta>>> BuscarVestimentaNome(string nome)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Vestimenta is null) return NotFound();
    var vestimentasTemp = await _dbContext.Vestimenta.Where(v => v.Nome.Contains(nome)).ToListAsync();
    if (vestimentasTemp.Count == 0) return NotFound();
    return vestimentasTemp;
  }

/*
  // Alterar Vestimenta:
  [HttpPut()]
  [Route("AlterarVestimenta")]
  public async Task<ActionResult> AlterarVestimenta(Vestimenta vestimenta)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Vestimenta is null) return NotFound();
    var vestimentaTemp = await _dbContext.Vestimenta.FindAsync(vestimenta.Id);
    if (vestimentaTemp is null) return NotFound();
    _dbContext.Vestimenta.Update(vestimenta);
    await _dbContext.SaveChangesAsync();
    return Ok();
  }
*/


  // Alterar Valor Vestimenta: 
  [HttpPatch()]
  [Route("MudarValorVestimenta{id}")]
  public async Task<ActionResult> MudarValorVestimenta(int id, [FromForm] float valor)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.RPGame is null) return NotFound();
    var VestTemp = await _dbContext.Vestimenta.FindAsync(id);
    if (VestTemp is null) return NotFound();
    VestTemp.ValorCompra = valor;
    await _dbContext.SaveChangesAsync();
    return Ok();
  }

  //Deletar Vestimenta {id}:
  [HttpDelete]
  [Route("DelVestimenta{id}")]
  public async Task<ActionResult> DeletarVestimentaId(int id)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Vestimenta is null) return NotFound();
    var vestimentaTemp = await _dbContext.Vestimenta.FindAsync(id);
    if (vestimentaTemp is null) return NotFound();


    _dbContext.Remove(vestimentaTemp);
    await _dbContext.SaveChangesAsync();
    return Ok();
  }

/*
  // Deletar Vestimenta {nome}:
  [HttpDelete]
  [Route("DeletarVestimenta{nome}")]
  public async Task<ActionResult<List<Vestimenta>>> DeletarVestimentaNome(string nome)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Vestimenta is null) return NotFound();
    var vestimentaTemp = await _dbContext.Vestimenta.Where(v => v.Nome.Contains(nome)).ToListAsync();
    if (vestimentaTemp.Count == 0) return NotFound();
    _dbContext.Remove(vestimentaTemp);
    await _dbContext.SaveChangesAsync();
    return Ok();
  }

  */


}