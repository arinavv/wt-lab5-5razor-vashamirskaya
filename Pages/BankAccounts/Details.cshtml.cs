using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_vashamirskaya.Data;
using wt_lab5_5razor_vashamirskaya.Models;

namespace wt_lab5_5razor_vashamirskaya.Pages.BankAccounts
{
    public class DetailsModel : PageModel
    {
        public BankAccount? Account { get; set; }

        public IActionResult OnGet(int id)
        {
            Account = BankAccountStore.Accounts.FirstOrDefault(a => a.Id == id);

            if (Account == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}