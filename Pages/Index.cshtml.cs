using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoolApp.Services;
using CoolApp.Models;

namespace CoolApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public JsonFileProductsService ProductsService;
    public IEnumerable<Product> Products {get; private set;}

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
       
    }

    public void OnGet()
    {
        // Products=ProductsService.GetProducts();
    }
}
