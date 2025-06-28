using System;
using LibraryApplication.Items;
using LibraryApplication.Libarary;

namespace LibraryApplication
{
    public class Programm
    {
        public static void Main()
        {
            var library = new Library();
            Item book = new Book(1, "Удушье", 1998, "Чак Палланик", 1412914414);
            Item bookToGroup = new Book(2, "ksdk w w", 1998, "mwk kwkn w", 214812984);
            Item magazine = new Magazine(2, "Занимательная физика", 2025, 1233532523);
            
            book.DisplayInfo();
            magazine.DisplayInfo();

            ICheckable bookToCheck = (Book) book;
            bookToCheck.CheckOut();
            bookToCheck.CheckOut();
            bookToCheck.Return();
            bookToCheck.CheckOut();
            
            IReservable bookToReserve = (Book) book;
            bookToReserve.Reserve();
            bookToCheck.Return();
            bookToReserve.Reserve();
            bookToReserve.CancleReservation();
            
            ICheckable magazineToCheck = (Magazine) magazine;
            magazineToCheck.CheckOut();
            magazineToCheck.CheckOut();
            magazineToCheck.Return();
            magazineToCheck.CheckOut();

            IReservable magazineToReserve = (Magazine) magazine;
            magazineToReserve.Reserve();
            magazineToCheck.Return();
            magazineToReserve.Reserve();
            magazineToReserve.CancleReservation();

            library.AddItme(book);
            library.AddItme(bookToGroup);
            library.AddItme(magazine);

            foreach (var item in library.GetItemsByYear(1998))
            {
                item.DisplayInfo();
            }

            foreach (var item in library.SearchByTitle("Уду"))
            {
                item.DisplayInfo();
            }

            foreach (var items in library.GroupItemsByYear())
            {
                Console.WriteLine(items.Key);
                foreach (var item in items.Select(item => item))
                {
                    item.DisplayInfo();
                }
            }
        }
    }
}