using wt_lab5_5razor_vashamirskaya.Models;

namespace wt_lab5_5razor_vashamirskaya.Data
{
    public static class BankAccountStore
    {
        public static List<BankAccount> Accounts { get; } = new()
        {
            new BankAccount { Id = 1, OwnerName = "Арина Вашемирская", Balance = 1500.75m, AccountType = "Сберегательный" },
            new BankAccount { Id = 2, OwnerName = "Иван Петров", Balance = 320.50m, AccountType = "Кредитный" },
            new BankAccount { Id = 3, OwnerName = "Ольга Сидорова", Balance = 8000m, AccountType = "Сберегательный" },
            new BankAccount { Id = 4, OwnerName = "Дмитрий Кузнецов", Balance = 12000m, AccountType = "Кредитный" },
            new BankAccount { Id = 5, OwnerName = "Наталья Смирнова", Balance = 5000m, AccountType = "Обычный" }
        };
    }
}