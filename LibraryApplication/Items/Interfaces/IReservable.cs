namespace LibraryApplication.Items;

public interface IReservable
{
    public bool IsReserved { get; set; }

    public void Reserve();
    public void CancleReservation();
}