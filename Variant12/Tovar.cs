namespace Variant12
{
    /// <summary>
    /// Класс, описывающий товар
    /// </summary>
    class Tovar
    {
        // ===== АТРИБУТЫ (поля класса) =====

        /// <summary>Наименование товара</summary>
        private string naimenovanie;

        /// <summary>Количество товара</summary>
        private int kolichestvo;

        /// <summary>Стоимость товара</summary>
        private float stoimost;


        // ===== КОНСТРУКТОРЫ =====

        /// <summary>
        /// Конструктор по умолчанию — задаёт начальные значения
        /// </summary>
        public Tovar()
        {
            naimenovanie = "Не указано";
            kolichestvo = 0;
            stoimost = 0.0f;
        }

        /// <summary>
        /// Конструктор с параметрами — создаёт объект с заданными значениями
        /// </summary>
        /// <param name="naimenovanie">Наименование товара</param>
        /// <param name="kolichestvo">Количество товара</param>
        /// <param name="stoimost">Стоимость товара</param>
        public Tovar(string naimenovanie, int kolichestvo, float stoimost)
        {
            this.naimenovanie = naimenovanie;
            this.kolichestvo = kolichestvo;
            this.stoimost = stoimost;
        }


        // ===== СВОЙСТВА (геттеры и сеттеры) =====

        /// <summary>Свойство для наименования</summary>
        public string Naimenovanie
        {
            get { return naimenovanie; }
            set { naimenovanie = value; }
        }

        /// <summary>Свойство для количества</summary>
        public int Kolichestvo
        {
            get { return kolichestvo; }
            set
            {
                // Количество не может быть отрицательным
                if (value >= 0)
                    kolichestvo = value;
                else
                    Console.WriteLine("Ошибка: количество не может быть отрицательным!");
            }
        }

        /// <summary>Свойство для стоимости</summary>
        public float Stoimost
        {
            get { return stoimost; }
            set
            {
                // Стоимость не может быть отрицательной
                if (value >= 0)
                    stoimost = value;
                else
                    Console.WriteLine("Ошибка: стоимость не может быть отрицательной!");
            }
        }


        // ===== МЕТОДЫ =====

        /// <summary>
        /// Выводит информацию о товаре в консоль
        /// </summary>
        public void PrintInfo()
        {
            Console.WriteLine("==== Информация о товаре ====");
            Console.WriteLine($"Наименование : {naimenovanie}");
            Console.WriteLine($"Количество   : {kolichestvo} шт.");
            Console.WriteLine($"Стоимость    : {stoimost} руб.");
            Console.WriteLine("=============================");
        }

        /// <summary>
        /// Считает общую стоимость (количество × стоимость)
        /// </summary>
        /// <returns>Общая стоимость</returns>
        public float ObshayaStoimost()
        {
            return kolichestvo * stoimost;
        }
    }
}