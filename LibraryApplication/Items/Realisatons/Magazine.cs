namespace LibraryApplication.Items;

public class Magazine : Item, ICheckable, IReservable
{
    public int IssueNumber { get; private set; }
    
    public bool IsCheckedOut { get; set; }
    
    public bool IsReserved { get; set; }

    public Magazine(int id, string title, int year, int issueNumber) : base(id, title, year)
    {
        IssueNumber = issueNumber;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Название: {Title}\n" +
                          $"Год выходы {Year}\n" +
                          $"Идентификатор {Id}\n" +
                          $"Номер выпуска {IssueNumber}\n");
    }
    
    public void CheckOut()
    {
        if (IsReserved)
        {
            Console.WriteLine("Данный журнал уже зарезервирована\n");
        }

        if (IsCheckedOut)
        {
            Console.WriteLine("Данный журнал у другого читателя\n");
        }
        else
        {
            IsCheckedOut = true;
            Console.WriteLine("Вам переданн данный журнал\n");
        }
    }

    public void Return()
    {
        Console.WriteLine("Вы вернули данный журнал\n");
        IsCheckedOut = false;
    }

    public void Reserve()
    {
        if(IsCheckedOut)
        {
            Console.WriteLine("Данного журнала нет в наличии\n");
        }
        else
        {
            Console.WriteLine("Вы зарезервировали данный журнал\n");
            IsReserved = true;
        }
    }

    public void CancleReservation()
    {
        Console.WriteLine("Вы отменили резервацию данного журнала\n");
        IsReserved = false;
    }
}