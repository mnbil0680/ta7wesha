public class Income : BaseEntity
{
 public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal Amount { get; set; }

    public DateTime IncomeDate { get; set; }

    public string Source { get; set; } = string.Empty;

    
    // REALTIONS
     // Foreign Key
    public int UserId { get; set; }

    // Navigation Property
    public User User { get; set; } = null!;
}