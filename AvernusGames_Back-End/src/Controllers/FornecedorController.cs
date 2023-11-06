using Avernus_Games_Store.src.Data;
using Microsoft.AspNetCore.Mvc;
using Avernus_Games_Store.src.Models;
using Microsoft.EntityFrameworkCore;
using Avernus_Games_Store.src;


[ApiController]
[Route("Controller")]
public class FornecedorController : ControllerBase
{
    private AvernusGamesDbContext? _context;

    public FornecedorController(AvernusGamesDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    [Route("ListarFornecedor")]
    public async Task<ActionResult<IEnumerable<Fornecedor>>> LisListarFornecedortar()
    {
        if(_context.Fornecedor is null)
            return NotFound();
        return await _context.Fornecedor.ToListAsync();
    } 

    [HttpPost]
    [Route("CadastrarFornecedor")]
    public IActionResult CadastrarFornecedor(Fornecedor fornecedor)
    {
        //Não vamos verificar CNPJ por enquanto
        /*if (!GeneralHelper.ValidarCNPJ(fornecedor.CNPJ)){
        return BadRequest("CNPJ INVALIDO. O Fornecedor não pode ser Cadastrado :");
        }*/
        _context.Add(fornecedor);
        _context.SaveChanges();
        return Created("", fornecedor);
    }
    

    [HttpGet]
    [Route("BuscarFornecedorPorCNPJ")]
    public async Task<ActionResult<Fornecedor>> BuscarFornecedorPorCNPJ(string cnpj)
    {
        if(_context.Fornecedor is null)
            return  NotFound();
        var fornecedor = await _context.Fornecedor.FirstOrDefaultAsync(f => f.CNPJ == cnpj);
        if (fornecedor is null)
            return NotFound();
        return fornecedor;
    }    

    [HttpGet]
    [Route("BuscarFornecedorPorNome")]
    public async Task<ActionResult<List<Fornecedor>>> BuscarFornecedorPorNome(string nome)
    {
    if (_context.Fornecedor is null)
        return NotFound();
    var fornecedor = await _context.Fornecedor.Where(f => f.Nome.Contains(nome)).ToListAsync();
    if (fornecedor.Count == 0)
        return NotFound();
    return fornecedor;
    }

    [HttpGet]
    [Route("BuscarFornecedorPorEmail")]
    public async Task<ActionResult<Fornecedor>> BuscarFornecedorPorEmail(string email)
    {
    if (_context.Fornecedor is null)
        return NotFound();
    var fornecedor = await _context.Fornecedor.FirstOrDefaultAsync(f => f.Email == email);
    if (fornecedor is null)
        return NotFound();
    return fornecedor;
    }

    [HttpPut]
    [Route("AlterarFornecedor")]
    public async Task<IActionResult> AlterarFornecedor(Fornecedor fornecedor)
    {
        _context.Fornecedor.Update(fornecedor);
        await _context.SaveChangesAsync();
        return Ok(); 
    }

    [HttpDelete]
    [Route("ExcluirFornecedorPorID - Fornecedor")]
    public async Task<ActionResult> ExcluirFornecedorPorID(int id)
    {
        var fornecedorExistente = await _context.Fornecedor.FirstOrDefaultAsync(f => f.Id == id);
        if (fornecedorExistente == null)
            return NotFound();
        _context.Fornecedor.Remove(fornecedorExistente);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}