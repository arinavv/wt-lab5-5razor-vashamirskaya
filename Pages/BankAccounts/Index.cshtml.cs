using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_vashamirskaya.Data;
using wt_lab5_5razor_vashamirskaya.Models;

namespace wt_lab5_5razor_vashamirskaya.Pages.BankAccounts
{
    public class IndexModel : PageModel
    {
        public List<BankAccount> Accounts { get; set; } = new();

        public void OnGet()
        {
            Accounts = BankAccountStore.Accounts;
        }
    }
}