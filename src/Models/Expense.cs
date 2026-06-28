public class Expense : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal Amount { get; set; }

    public DateTime ExpenseDate { get; set; }

    public string Category { get; set; } = string.Empty;

    public PaymentMethod PaymentMethod { get; set; }


    public int UserId { get; set; }

    // Navigation Property
    public User User { get; set; } = null!;
}