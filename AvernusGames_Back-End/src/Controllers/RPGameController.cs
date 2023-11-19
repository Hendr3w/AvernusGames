using Avernus_Games_Store.src.Data;
using Microsoft.AspNetCore.Mvc;
using Avernus_Games_Store.src.Models;
using Microsoft.EntityFrameworkCore;


[ApiController]
[Route("rpgame")]

public class RPGameController : ControllerBase
{
  private AvernusGamesDbContext _dbContext;
  public RPGameController(AvernusGamesDbContext dbContext)
  {
    _dbContext = dbContext;
  }

  
  // Postar RPGame:
  [HttpPost]
  [Route("cadastrar_rpg")]
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
  [Route("listar_rpg")]
  public async Task<ActionResult<IEnumerable<RPGame>>> ListarRPGame()
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.RPGame is null) return NotFound();
    return await _dbContext.RPGame.ToListAsync();
  }


  // Buscar RPGame {id}:
  [HttpGet]
  [Route("buscar_rpg_id")]
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
  [Route("buscar_rpg_nome")]
  public async Task<ActionResult<List<RPGame>>> BuscarRPGameNome(string nome)
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.RPGame is null) return NotFound();
    var rpgamesTemp = await _dbContext.RPGame.Where(rpg => rpg.Nome.Contains(nome)).ToListAsync();
    if (rpgamesTemp.Count == 0) return NotFound();
    return rpgamesTemp;
  }


  //Alterar RPGame:
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
  } 

  // Alterar Valor RPG:
  [HttpPatch()]
  [Route("alterar_valor_rpg")]
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
  [Route("excluir_rpg_id")]
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

  
}