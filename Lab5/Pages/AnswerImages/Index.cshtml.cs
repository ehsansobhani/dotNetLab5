using Lab5.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Pages.AnswerImages
{
    public class IndexModel : PageModel
    {
        private Lab5.Data.AnswerImageDataContext  _context;

        public IndexModel(Lab5.Data.AnswerImageDataContext  context)
        {
            _context = context;
        }

        public IList<AnswerImage> AnswerImage { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.AnswerImages != null)
            {
                AnswerImage = await _context.AnswerImages.ToListAsync();
            }
        }
    }
}
