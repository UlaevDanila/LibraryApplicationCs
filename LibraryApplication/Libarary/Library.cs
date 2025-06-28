using LibraryApplication.Items;

namespace LibraryApplication.Libarary;

public class Library
{
    private List<Item> _library;

    public Library()
    {
        _library = new List<Item>();
    }

    public void AddItme(Item item)
    {
        _library.Add(item);
        Console.WriteLine("Успешно добавлено");
    }

    public void RemoveItem(int id)
    {
        var itemToRemove = _library.FirstOrDefault(item => item.Id == id);
        if (itemToRemove == null)
        {
            Console.WriteLine("Нет такого id\n");
        }
        else
        {
            _library.Remove(itemToRemove);
            Console.WriteLine("Успешно удалено\n");
        }
    }

    public IEnumerable<Item> SearchByTitle(string keyword)
    {
        return _library.Where(item => item.Title != null && item.Title.Contains(keyword));
    }

    public IEnumerable<Item> GetItemsByYear(int year)
    {
        return _library.Where(item => item.Year == year);
    }

    public IEnumerable<IGrouping<int, Item>> GroupItemsByYear()
    {
        return _library.GroupBy(item => item.Year);
    }
}