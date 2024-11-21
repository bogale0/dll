using ClassLibrary1;
Console.WriteLine("Введите координаты вектора:");
double read() { return Convert.ToDouble(Console.ReadLine()); }
Point a = new Point(read(), read());
Console.WriteLine($"Вектор: ({a.x}; {a.y})");
Console.WriteLine($"Модуль: {a.Length()}");
Console.WriteLine($"Угол, °: {a.Angle() * 180 / Math.PI}");
a.Resize(1.5);
Console.WriteLine($"Увеличение в 1.5 раза: ({a.x}; {a.y})");
a = a + new Point(2, 3);
Console.WriteLine($"Прибавление вектора (2; 3): ({a.x}; {a.y})");
a.Rotate(Math.PI / 4);
Console.WriteLine($"Поворот на 45°: ({a.x}; {a.y})");
