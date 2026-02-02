using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreAPI_UNO.Data;
using NetCoreAPI_UNO.Models;

namespace NetCoreAPI_UNO.Controllers
{
    [Route("/v1/api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductoController(AppDbContext context)
        {
            _context = context;
        }
        
        [HttpGet("getAll")]
        public async Task<ActionResult<IEnumerable<Producto>>> GetProductos()
        {
            return await _context.Productos.OrderByDescending(p=>p.Id).ToListAsync();
        }

        [HttpGet("getById/{idProducto}")]
        public async Task<ActionResult<Producto>> GetProducto(int idProducto)
        {
            var producto = await _context.Productos.FindAsync(idProducto);

            if (producto == null)
            {
                return NotFound();
            }
            return producto;
        }

        [HttpGet("buscar/{atributoProducto}")]
        public async Task<ActionResult<List<Producto>>> GetProductoTodo(string atributoProducto)
        {
            var _atributoProducto = WebUtility.UrlDecode(atributoProducto);            
            bool esDecimal = decimal.TryParse(_atributoProducto, NumberStyles.Any,CultureInfo.InvariantCulture, out decimal precio);
            bool esEntero = int.TryParse(_atributoProducto, out int stock);
            bool esFecha = DateTime.TryParse(_atributoProducto, out DateTime fecha);
            var query = _context.Productos.AsQueryable();            
            var productos = await query
            .Where(p =>
            p.Nombre.Contains(_atributoProducto) ||  
                    (esDecimal && p.Precio == precio) ||  
                    (esEntero && p.Stock == stock) ||  
                    (esFecha && p.Fecha.Date == fecha.Date)  
                ).ToListAsync();

            if (!productos.Any())
            {
                return NotFound("No se encontraron productos con el criterio de búsqueda");
            }
            return productos;
        }
        
        [HttpPut("actualizar/{idProducto}")]
        public async Task<IActionResult> PutProducto(int idProducto, Producto producto)
        {
            if (idProducto != producto.Id)
            {
                return BadRequest();
            }
            _context.Entry(producto).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductoExists(idProducto))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpPost("crear")]
        public async Task<ActionResult<Producto>> PostProducto(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducto", new { id = producto.Id }, producto);
        }
        
        [HttpDelete("eliminar/{idProducto}")]
        public async Task<IActionResult> DeleteProducto(int idProducto)
        {
            var producto = await _context.Productos.FindAsync(idProducto);
            if (producto == null)
            {
                return NotFound();
            }
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private bool ProductoExists(int idProducto)
        {
            return _context.Productos.Any(pro => pro.Id == idProducto);
        }
    }
}
