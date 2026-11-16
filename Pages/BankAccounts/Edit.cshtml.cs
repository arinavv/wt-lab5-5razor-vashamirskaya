using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_vashamirskaya.Data;
using wt_lab5_5razor_vashamirskaya.Models;

namespace wt_lab5_5razor_vashamirskaya.Pages.BankAccounts
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public BankAccount Account { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            var accountFromDb = BankAccountStore.Accounts.FirstOrDefault(a => a.Id == id);

            if (accountFromDb == null)
            {
                return NotFound();
            }

            Account = accountFromDb;
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var accountToUpdate = BankAccountStore.Accounts.FirstOrDefault(a => a.Id == Account.Id);

            if (accountToUpdate != null)
            {
                accountToUpdate.OwnerName = Account.OwnerName;
                accountToUpdate.Balance = Account.Balance;
                accountToUpdate.AccountType = Account.AccountType;
            }

            return RedirectToPage("./Index");
        }
    }
}