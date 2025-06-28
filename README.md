Базовые классы и ООП
Создайте абстрактный класс Item с общими свойствами (Id, Title, Year) и абстрактным методом DisplayInfo().

Реализуйте два производных класса:

Book (добавляет Author, ISBN)

Magazine (добавляет IssueNumber)

Переопределите DisplayInfo() для каждого класса.

2. Интерфейсы и полиморфизм
Создайте интерфейс ICheckable с методами CheckOut(), Return() и свойством IsCheckedOut.

Создайте интерфейс IReservable с методами Reserve(), CancelReservation() и свойством IsReserved.

Реализуйте эти интерфейсы в классах Book и Magazine.

3. Коллекции и LINQ
Создайте класс Library, который хранит список List<Item>.

Реализуйте методы:

AddItem(Item item), RemoveItem(int id)

SearchByTitle(string keyword) (поиск по части названия)

GetItemsByYear(int year) (фильтрация по году)

GroupItemsByYear() (группировка с помощью LINQ)