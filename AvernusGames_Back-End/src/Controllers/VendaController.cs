using Avernus_Games_Store.src.Data;
using Microsoft.AspNetCore.Mvc;
using Avernus_Games_Store.src.Models;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("venda")]
public class VendaController : ControllerBase
{
    private AvernusGamesDbContext _context;

    public VendaController(AvernusGamesDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    [Route("cadastrar_venda")]
    public IActionResult CadastrarVenda(Venda venda)
    {
        _context.Add(venda);
        _context.SaveChanges();
        return Created("", venda);
    }

    [HttpGet]
    [Route("listar_venda")]
    public async Task<ActionResult<IEnumerable<Venda>>> ListarVenda()
    {
        if(_context.Venda is null)
        return NotFound();
        return await _context.Venda.ToListAsync();
    }

    [HttpPost]
    [Route("cadastrar_item")]
    public ActionResult CadastrarItem(ItemVenda item)
    {
        _context.Add(item);
        _context.SaveChanges();
        return Created("", item);
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

    //BUSCAR POR Nf
    [HttpGet]
    [Route("buscar_venda_nf")]
    public async Task<ActionResult<Venda>> BuscarVendaNF (string nf)
    {
        if(_context.Venda is null)
            return  NotFound();
        var venda = await _context.Venda.FirstOrDefaultAsync(c => c.Nf == nf);
        if (venda is null)
            return NotFound();
        return venda;
    } 

    [HttpGet]
    [Route("buscar_venda_cliente")]
    public async Task<ActionResult<List<Venda>>> BuscarVendaCliente (Cliente cliente)
    {
        if(_context.Venda is null)
            return  NotFound();
        var vendas = await _context.Venda.Where(c => c.ClienteId == cliente.Id).ToListAsync();
        if (vendas is null)
            return NotFound();
        return vendas;
    } 




}