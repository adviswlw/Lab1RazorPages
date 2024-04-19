using Lab1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1.Pages
{
    public class DeleteModel : PageModel
    {
       public ProgrammingLanguage Language { get; set; }

        private readonly ProgrammingLanguageRepository _repository;

        public DeleteModel(ProgrammingLanguageRepository repository)
        {
            _repository = repository;
        }

        public void OnGet(Guid id)
        {
            Language = _repository.Get(id);
        }

        //                           
        public IActionResult OnPost(Guid id, string confirm)
        {
            Language = _repository.Get(id);

            if (confirm != "yes")
            {
                return Page();
            }
            _repository.Remove(id);

            return RedirectToPage("./Index");
        }
    }
}
