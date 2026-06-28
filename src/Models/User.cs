public class User : BaseEntity
{
    public required string Name { get; set; }
    public required string HashedPassword { get; set; }
    public required string Email { get; set; }


    //  REALTIONS
    // Navigation Property
    public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    public ICollection<Income> Income { get; set; } = new List<Income>();
    public ICollection<Category> Categories { get; set; } = new List<Category>();
    public ICollection<Source> Sources { get; set; } = new List<Source>();

}