Console.WriteLine("Введите порядковый номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1: 
        Console.WriteLine("рабочий день");
        break;
    case 2: 
        Console.WriteLine("рабочий день");
        break;
    case 3: 
        Console.WriteLine("рабочий день");
        break;
    case 4: 
        Console.WriteLine("рабочий день");
        break;
    case 5: 
        Console.WriteLine("рабочий день");
        break;
    case 6: 
        Console.WriteLine("Выходной");
        break;
    case 7: 
        Console.WriteLine("Выходной");
        break;
    default:
        Console.WriteLine("Вне диапазона");
        break;
}
