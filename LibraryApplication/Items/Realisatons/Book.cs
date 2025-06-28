namespace LibraryApplication.Items;

public class Book : Item, ICheckable, IReservable
{
    public string? Author { get; private set; }
    public int ISBN { get; private set; }
    
    public bool IsCheckedOut { get; set; }
    
    public bool IsReserved { get; set; }

    public Book(int id, string title, int year, string author, int isbn) : base(id, title, year)
    {
        Author = author;
        ISBN = isbn;
        IsCheckedOut = false;
        IsReserved = false;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Название: {Title}\n" +
                          $"Автор: {Author}\n" +
                          $"Год выходы {Year}\n" +
                          $"Идентификатор {Id}\n" +
                          $"Номер ISBN {ISBN}\n");
    }
    
    public void CheckOut()
    {
        if (IsReserved)
        {
            Console.WriteLine("Данная книга уже зарезервирована\n");
        }

        if (IsCheckedOut)
        {
            Console.WriteLine("Данная книга у другого читателя\n");
        }
        else
        {
            IsCheckedOut = true;
            Console.WriteLine("Вам переданна книга\n");
            DisplayInfo();
        }
    }

    public void Return()
    {
        Console.WriteLine("Вы вернули книгу\n");
        DisplayInfo();
        IsCheckedOut = false;
    }

    public void Reserve()
    {
        if(IsCheckedOut)
        {
            Console.WriteLine("Данной книги нет в наличии\n");
        }
        else
        {
            Console.WriteLine("Вы зарезервировали данную книгу\n");
            IsReserved = true;
        }
    }

    public void CancleReservation()
    {
        Console.WriteLine("Вы отменили резервацию данной книги\n");
        IsReserved = false;
    }
}