public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string? Icon { get; set; }


    // Foreign Key
    public int UserId { get; set; }

    public User User { get; set; } = null!;

    public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
}