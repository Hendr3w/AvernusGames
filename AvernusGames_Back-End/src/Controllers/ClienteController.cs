using Avernus_Games_Store.src.Data;
using Microsoft.AspNetCore.Mvc;
using Avernus_Games_Store.src.Models;
using Microsoft.EntityFrameworkCore;
using Avernus_Games_Store.src;


[ApiController]
[Route("Controller")]
public class ClienteController : ControllerBase
{
    private AvernusGamesDbContext? _context;

    public ClienteController(AvernusGamesDbContext context)
    {
        _context = context;
    }

    //LISTAR
    [HttpGet]
    [Route("Listar - Cliente")]
    public async Task<ActionResult<IEnumerable<Cliente>>> Listar()
    {
        if(_context.Cliente is null)
            return NotFound();
        return await _context.Cliente.ToListAsync();
    } 

    //CADASTRAR
    [HttpPost]
    [Route("CadastrarCliente")]
    public IActionResult Cadastrar(Cliente cliente)
    {
        if (!GeneralHelper.ValidarCPF(cliente.CPF)){
            // O CPF é inválido, retorne uma resposta de erro
            return BadRequest("CPF inválido. O cliente não foi cadastrado.");
        }
        _context.Add(cliente);
        _context.SaveChanges();
        return Created("", cliente);
    }

    //BUSCAR POR CPF
    [HttpGet]
    [Route("BuscarPorCPFdoCliente")]
    public async Task<ActionResult<Cliente>> BuscarCpfCliente (string cpf)
    {
        if(_context.Cliente is null)
            return  NotFound();
        var cliente = await _context.Cliente.FirstOrDefaultAsync(c => c.CPF == cpf);
        if (cliente is null)
            return NotFound();
        return cliente;
    }    

    //Buscar por nome exato
    /*[HttpGet]
    [Route("BuscarPorNome")]
    public async Task<ActionResult<List<Cliente>>> BuscarPorNome(string nome)
    {
    if (_context.Cliente is null)
        return NotFound();

    var clientes = await _context.Cliente.Where(c => c.Nome.Contains(nome)).ToListAsync();

    if (clientes.Count == 0)
        return NotFound();

    return clientes;
    }*/

    //Buscar por nome teoricamente sem ser precisamente exato
    [HttpGet]
    [Route("BuscarPorNome - Cliente")]
    public async Task<ActionResult<List<Cliente>>> BuscarClientePorNome(string nome)
    {
    if (_context.Cliente is null)
        return NotFound();
    var clientes = await _context.Cliente.Where(c => c.Nome.Contains(nome)).ToListAsync();
    if (clientes.Count == 0)
        return NotFound();
    return clientes;
    }


    //Buscar Cliente por E-Mail
    [HttpGet]
    [Route("BuscarPorEmail - Cliente")]
    public async Task<ActionResult<Cliente>> BuscarClientePorEmail(string email)
    {
    if (_context.Cliente is null)
        return NotFound();
    var cliente = await _context.Cliente.FirstOrDefaultAsync(c => c.Email == email);
    if (cliente is null)
        return NotFound();
    return cliente;
    }


    //Excluir Cliente ID
    [HttpDelete]
    [Route("ExcluirClientePorID - Cliente")]
    public async Task<ActionResult> ExcluirClientePorID(int id)
    {
        var clienteExistente = await _context.Cliente.FirstOrDefaultAsync(c => c.ClienteId == id);
        if (clienteExistente == null)
            return NotFound();
        _context.Cliente.Remove(clienteExistente);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    //Excluir Cliente CPF
    [HttpDelete]
    [Route("ExcluirClientePorCPF - Cliente")]
    public async Task<ActionResult> ExcluirClientePorCPF(string cpf)
    {
        var clienteExistente = await _context.Cliente.FirstOrDefaultAsync(c => c.CPF == cpf);
        if (clienteExistente == null)
            return NotFound();
        _context.Cliente.Remove(clienteExistente);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    /*
    //Alterar Cliente
    [HttpPut]
    [Route("AlterarCliente")]
    public async Task<IActionResult> AlterarCliente(Cliente cliente)
    {
        _context.Cliente.Update(cliente);
        await _context.SaveChangesAsync();
        return Ok(); 
    } */

    [HttpPatch()]
    [Route("AlterarSenha/{id}")]
    public async Task<ActionResult> AlterarSenha(int id, [FromForm] string senha)
    {
        if(_context is null) return NotFound();
        if(_context.Cliente is null) return NotFound();
        var clienteTemp = await _context.Cliente.FindAsync(id);
        if(clienteTemp is null) return NotFound();
        clienteTemp.Senha = senha;
        await _context.SaveChangesAsync();
        return Ok();  
    }
}