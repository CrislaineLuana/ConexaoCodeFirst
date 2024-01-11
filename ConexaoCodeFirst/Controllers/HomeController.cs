using ConexaoCodeFirst.Data;
using ConexaoCodeFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConexaoCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }



        [HttpGet("Produtos")]
        public async Task<List<ProdutoModel>> getProdutos()
        {
            var produtos = await _context.Produtos.ToListAsync();
            return produtos;
        }

    }
}
