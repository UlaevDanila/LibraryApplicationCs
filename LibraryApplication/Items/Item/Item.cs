namespace LibraryApplication.Items;

public abstract class Item
{
    public int Id { get; private set; }
    public string? Title { get; private set; }
    public int Year { get; private set; }

    public Item(int id, string title, int year)
    {
        Id = id;
        Year = year;
        Title = title;
    }
    public abstract void DisplayInfo();
}