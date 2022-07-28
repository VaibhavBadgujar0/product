using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Product.Pages
{
    public class ProductModel : PageModel
    {
        public bool hasData=false;
        public string ProductId = "";
        public string Name = "";
        public string Description = "";
        public void OnGet()
        {
        }

        public void OnPost()
        {
            hasData=true;
            ProductId = Request.Form["ProductId"];
            Name = Request.Form["Name"];
            Description = Request.Form["Description"];
        }

    }
}
