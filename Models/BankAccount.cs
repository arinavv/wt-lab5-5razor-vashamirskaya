using System.ComponentModel.DataAnnotations;

namespace wt_lab5_5razor_vashamirskaya.Models
{
    public class BankAccount
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Введите имя владельца")]
        [StringLength(100, ErrorMessage = "Имя не должно превышать 100 символов")]
        public string OwnerName { get; set; } = string.Empty;

        [Range(0.01, 1000000, ErrorMessage = "Баланс должен быть от 0.01 до 1 000 000")]
        public decimal Balance { get; set; }

        [Required(ErrorMessage = "Укажите тип счёта")]
        public string AccountType { get; set; } = string.Empty;
    }
}