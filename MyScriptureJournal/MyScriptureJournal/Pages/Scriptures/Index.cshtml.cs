using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public PaginatedList<Scripture> Scripture { get; set; }
        //public IList<Scripture> Scripture { get;set; }

        public string SearchStringBook { get; set; }
        public SelectList Books { get; set; }
        public string ScriptureBook { get; set; }
        
        public string SearchStringNote { get; set; }
        public SelectList Notes { get; set; }
        public string ScriptureNote { get; set; }

        public string BookSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentSort { get; set; }

        public async Task OnGetAsync(string searchStringBook, string searchStringNote, string sortOrder, int? pageIndex)
        {
            CurrentSort = sortOrder;
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchStringBook != null || searchStringNote != null)
            {
                pageIndex = 1;
            }

            var scriptures = from m in _context.Scripture
                             select m;


            if (!String.IsNullOrEmpty(searchStringBook))
            {
                scriptures = scriptures.Where(s => s.Book.Contains(searchStringBook));
            }
            if (!String.IsNullOrEmpty(searchStringNote))
            {
                scriptures = scriptures.Where(s => s.Notes.Contains(searchStringNote));
            }

            switch (sortOrder)
            {
                case "book_desc":
                    scriptures = scriptures.OrderByDescending(s => s.Book);
                    break;
                case "Date":
                    scriptures = scriptures.OrderBy(s => s.AddedDate);
                    break;
                case "date_desc":
                    scriptures = scriptures.OrderByDescending(s => s.AddedDate);
                    break;
                default:
                    scriptures = scriptures.OrderBy(s => s.Book);
                    break;
            }

            int pageSize = 5;
            Scripture = await PaginatedList<Scripture>.CreateAsync(
                scriptures.AsNoTracking(), pageIndex ?? 1, pageSize);
            SearchStringBook = searchStringBook;
            SearchStringNote = searchStringNote;
        }
    }
}
