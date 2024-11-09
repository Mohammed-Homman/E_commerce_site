using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MANZO_PROJECT.Context;
using MANZO_PROJECT.Models;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public ProductController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet("getallproducts")]
    public IActionResult GetAllProducts()
    {
        try
        {
            var products = _dbContext.products.ToList();

            var productDtos = products.Select(p => new
            {
                p.ProductId,
                p.UserId,
                p.Category,
                p.Cover,
                p.CreatedAt,
                p.DeliveryTime,
                p.Desc,
                p.Features,
                p.Images,
                p.Price,
                p.ProductId1,
                p.RevisionNumber,
                p.Sales,
                p.ShortDesc,
                p.ShortTitle,
                p.Title,
                p.UpdatedAt,
            });

            return Ok(productDtos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal Server Error");
        }
    }
}
    


