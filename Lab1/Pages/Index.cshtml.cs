using Lab1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lab1.Pages;

public class IndexModel : PageModel
{
    public IList<ProgrammingLanguage> Languages { get; set; } = new List<ProgrammingLanguage>();

    private readonly ProgrammingLanguageRepository _repository;

    //                      /*Inject repository here*/
    public IndexModel(ProgrammingLanguageRepository repository)
    {
        _repository = repository;
    }

    public void OnGet(Guid id)
    {
        Languages = _repository.List();
    }
}
