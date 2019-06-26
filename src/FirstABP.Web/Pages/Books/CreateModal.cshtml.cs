using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstABP.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstABP.Pages.Books
{
    public class CreateModalModel : FirstABPPageModelBase
    {
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }
        private readonly IBookAppService _bookAppService;
        public CreateModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}