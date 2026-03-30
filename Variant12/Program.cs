namespace Variant12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Вариант 12: Класс Товар ===\n");

            // --- Объект через конструктор по умолчанию ---
            Tovar tovar1 = new Tovar();
            Console.WriteLine("Объект создан конструктором по умолчанию:");
            tovar1.PrintInfo();

            // --- Изменяем поля через свойства ---
            tovar1.Naimenovanie = "Молоко";
            tovar1.Kolichestvo = 50;
            tovar1.Stoimost = 89.9f;
            Console.WriteLine("\nПосле изменения через свойства:");
            tovar1.PrintInfo();

            // --- Объект через конструктор с параметрами ---
            Tovar tovar2 = new Tovar("Хлеб", 100, 45.5f);
            Console.WriteLine("\nОбъект создан конструктором с параметрами:");
            tovar2.PrintInfo();

            // --- Проверка метода ObshayaStoimost ---
            Console.WriteLine($"Общая стоимость товара '{tovar2.Naimenovanie}': " +
                              $"{tovar2.ObshayaStoimost()} руб.\n");

            // --- Проверка защиты от некорректных данных ---
            Console.WriteLine("Попытка задать отрицательное количество:");
            tovar1.Kolichestvo = -5;

            // --- Третий объект через конструктор с параметрами ---
            Tovar tovar3 = new Tovar("Масло", 30, 120.0f);
            Console.WriteLine("\nТретий объект (конструктор с параметрами):");
            tovar3.PrintInfo();
            Console.WriteLine($"Общая стоимость: {tovar3.ObshayaStoimost()} руб.");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}