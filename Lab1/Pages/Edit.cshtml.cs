using Lab1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1.Pages
{
    public class EditModel : PageModel
    {
        private readonly ProgrammingLanguageRepository _repository;

        [BindProperty]
        public ProgrammingLanguage Language { get; set; }


        public EditModel(ProgrammingLanguageRepository repository)
        {
            _repository = repository;
        }

        public void OnGet(Guid id)
        {
            Language = _repository.Get(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repository.Update(Language);

            return RedirectToPage("./Index");
        }
    }
}
