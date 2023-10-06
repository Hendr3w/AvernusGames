using Avernus_Games_Store.src.Data;
using Microsoft.AspNetCore.Mvc;
using Avernus_Games_Store.src.Models;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("Controller")]
public class VendaController : ControllerBase
{
    private AvernusGamesDbContext _context;

    public VendaController(AvernusGamesDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    [Route("CadastrarVenda")]
    public IActionResult CadastrarVenda(Venda venda)
    {
        _context.Add(venda);
        _context.SaveChanges();
        return Created("", venda);
    }

    [HttpGet]
    [Route("ListarVenda")]
    public async Task<ActionResult<IEnumerable<Venda>>> ListarVenda()
    {
        if(_context.Venda is null)
        return NotFound();
        return await _context.Venda.ToListAsync();
    }

    /*[HttpDelete]
    [Route("ExcluirVenda")]
    public async Task<ActionResult> ExcluirVenda(int id)
    {
        var venda = await _context.Venda.FirstOrDefaultAsync(c => c.VendaId == id);
        if (venda == null)
        return NotFound();
        _context.Venda.Remove(venda);
        await _context.SaveChangesAsync();
        return NoContent();
    }*/

    //BUSCAR POR CPF
    [HttpGet]
    [Route("BuscarVendaNF")]
    public async Task<ActionResult<Venda>> BuscarVendaNF (string nf)
    {
        if(_context.Venda is null)
            return  NotFound();
        var venda = await _context.Venda.FirstOrDefaultAsync(c => c.Nf == nf);
        if (venda is null)
            return NotFound();
        return venda;
    } 
}