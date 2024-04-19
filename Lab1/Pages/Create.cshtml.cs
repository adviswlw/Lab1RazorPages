using Lab1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1.Pages;

public class CreateModel : PageModel
{
    [BindProperty]
    public ProgrammingLanguage Language { get; set; }

    private readonly ProgrammingLanguageRepository _repository;
    
    public CreateModel(ProgrammingLanguageRepository repository)
    {
        _repository = repository;
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _repository.Add(Language);

        return RedirectToPage("./Index");
    }
}
