using Avernus_Games_Store.src.Data;
using Microsoft.AspNetCore.Mvc;
using Avernus_Games_Store.src.Models;
using Microsoft.EntityFrameworkCore;
using Avernus_Games_Store.src;
using System.Runtime.InteropServices;

[ApiController]
[Route("funcionario")]

public class FuncionarioController : ControllerBase
{
  private AvernusGamesDbContext _context;

  public FuncionarioController(AvernusGamesDbContext context)
  {
    _context = context;
  }

  [HttpGet]
  [Route("listar_funcionario")]
  public async Task<ActionResult<IEnumerable<Funcionario>>> ListarFuncionario()
  {
    if(_context.Funcionario is null)
      return NotFound();
    return await _context.Funcionario.ToListAsync();
  } 

  
  [HttpPost]
  [Route("cadastrar_funcionario")]
  public IActionResult CadastroFuncionario(Funcionario funcionario)
  {
     // Verifica o CPF
    /*if (GeneralHelper.ValidarCPF(funcionario.Cpf))
    {
      _context.Add(funcionario);  
      _context.SaveChanges(); 
      return Created("", funcionario); 
    }*/
    
      _context.Add(funcionario);  
      _context.SaveChanges(); 
      return Created("", funcionario); 
      //return BadRequest("CPF inválido.");

    
    
    
  }

  [HttpGet]
  [Route("buscar_funcionario_por_id")]
  public async Task<ActionResult<Funcionario>> BuscarFuncionarioPorId(int Id)
    {
    if (_context.Funcionario is null)
        return NotFound();
    var funcionario = await _context.Funcionario.FirstOrDefaultAsync(c => c.Id == Id);
    if (funcionario is null)
        return NotFound();
    return funcionario;
  }

  [HttpPut]
  [Route("alterar_funcionario")]
  public async Task<IActionResult> AlterarFuncionario(Funcionario funcionario)
  {
      _context.Funcionario.Update(funcionario);
      await _context.SaveChangesAsync();
      return Ok(); 
  }

    [HttpPatch()]
    [Route("alterar_senha_funcionario")]
    public async Task<ActionResult> AlterarSenha(int id, [FromForm] string senha)
    {
        if(_context is null) return NotFound();
        if(_context.Funcionario is null) return NotFound();
        var funcionarioTemp = await _context.Funcionario.FindAsync(id);
        if(funcionarioTemp is null) return NotFound();
        funcionarioTemp.Senha = senha;
        await _context.SaveChangesAsync();
        return Ok();  
    }

    [HttpDelete]
    [Route("excluir_funcionario_por_id")]
    public async Task<ActionResult> ExcluirFuncionario([FromRoute] int id)
    {
        var funcionario = await _context.Funcionario.FirstOrDefaultAsync(c => c.Id == id);
        if (funcionario == null)
        return NotFound();
        _context.Funcionario.Remove(funcionario);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}