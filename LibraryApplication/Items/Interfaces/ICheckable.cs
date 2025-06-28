namespace LibraryApplication.Items;

public interface ICheckable
{
    public bool IsCheckedOut { get; set; }

    public void CheckOut();

    public void Return();
}