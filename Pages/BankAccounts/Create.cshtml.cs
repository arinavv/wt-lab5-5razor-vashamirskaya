using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_vashamirskaya.Data;
using wt_lab5_5razor_vashamirskaya.Models;

namespace wt_lab5_5razor_vashamirskaya.Pages.BankAccounts
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public BankAccount Account { get; set; } = new();

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Account.Id = BankAccountStore.Accounts.Any()
                ? BankAccountStore.Accounts.Max(x => x.Id) + 1
                : 1;

            BankAccountStore.Accounts.Add(Account);

            return RedirectToPage("./Index");
        }
    }
}