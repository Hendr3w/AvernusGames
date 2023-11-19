using Avernus_Games_Store.src.Data;
using Microsoft.AspNetCore.Mvc;
using Avernus_Games_Store.src.Models;
using Microsoft.EntityFrameworkCore;


[ApiController]
[Route("vestimenta")]

public class VestimentaController : ControllerBase
{
  private AvernusGamesDbContext _dbContext;
  public VestimentaController(AvernusGamesDbContext dbContext)
  {
    _dbContext = dbContext;
  }


  // -------------------------- CRUD VESTIMENTA -----------------------------------------------------------
  // Postar Vestimenta:
  [HttpPost]
  [Route("cadastrar_vestimenta")]
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
  [Route("listar_vestimenta")]
  public async Task<ActionResult<IEnumerable<Vestimenta>>> ListarVestimenta()
  {
    if (_dbContext is null) return NotFound();
    if (_dbContext.Vestimenta is null) return NotFound();
    return await _dbContext.Vestimenta.ToListAsync();
  }


  // Buscar Vestimenta {id}:
  [HttpGet]
  [Route("buscar_vestimenta_id")]
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
  [Route("buscar_vestimenta_nome")]
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
  [Route("alterar_valor_vestimenta")]
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
  [Route("excluir_vestimenta_id")]
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