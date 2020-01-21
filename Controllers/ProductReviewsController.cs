using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using revirewsAPI.Models;

namespace revirewsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductReviewsController : ControllerBase
    {
        private readonly ProductReviewContext _context;

        public ProductReviewsController(ProductReviewContext context)
        {
            _context = context;
        }

        // GET: api/ProductReviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductReview>>> GetProductReviews()
        {
            return await _context.ProductReviews.ToListAsync();
        }

        // GET: api/ProductReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductReview>> GetProductReview(long id)
        {
            var productReview = await _context.ProductReviews.FindAsync(id);

            if (productReview == null)

            {
                return NotFound();
            }

            return productReview;
        }

        // PUT: api/ProductReviews/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductReview(long id, ProductReview productReview)
        {
            if (id != productReview.Id)
            {
                return BadRequest();
            }

            _context.Entry(productReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductReviewExists(id))
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

        // POST: api/ProductReviews
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<ProductReview>> PostProductReview(ProductReview productReview)
        {
            _context.ProductReviews.Add(productReview);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductReview", new { id = productReview.Id }, productReview);
        }

        // DELETE: api/ProductReviews/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProductReview>> DeleteProductReview(long id)
        {
            var productReview = await _context.ProductReviews.FindAsync(id);
            if (productReview == null)
            {
                return NotFound();
            }

            _context.ProductReviews.Remove(productReview);
            await _context.SaveChangesAsync();

            return productReview;
        }

        private bool ProductReviewExists(long id)
        {
            return _context.ProductReviews.Any(e => e.Id == id);
        }
    }
}
