// 1 Створення об'єкта
using sharp_lessons4;

Warehouse warehouse = new Warehouse();

// 2 Підписка на подію
warehouse.OnItemChanged += (index, item) =>
{
    Console.WriteLine($"Лог: У комірку №{index} додано товар: {item}");
};

// 3 Фільтрація (Predicate):
Predicate<string> isNotEmpty = product => !string.IsNullOrWhiteSpace(product);

// 4 Обробка даних (Func)
Func<string, string> toUpper = product => product?.ToUpper() ?? string.Empty;

// Додавання товарів на склад
string[] products = { "Ноутбук", "", "Планшет", null, "ПК", "  ", "Монитор" };

for (int i = 0; i < products.Length && i < warehouse.Size; i++)
{
    if (isNotEmpty(products[i]))
    {
        warehouse[i] = toUpper(products[i]);
    }
}
    