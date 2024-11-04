// See https://aka.ms/new-console-template for more information
using NetCsharpMyDateClass;

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Введите первую дату:");
//Console.Write("День: ");
//int day1 = int.Parse(Console.ReadLine());
//Console.Write("Месяц: ");
//int month1 = int.Parse(Console.ReadLine());
//Console.Write("Год: ");
//int year1 = int.Parse(Console.ReadLine());

//MyDate date1 = new MyDate(day1, month1, year1);


//Console.WriteLine("Введите вторую дату:");
//Console.Write("День: ");
//int day2 = int.Parse(Console.ReadLine());
//Console.Write("Месяц: ");
//int month2 = int.Parse(Console.ReadLine());
//Console.Write("Год: ");
//int year2 = int.Parse(Console.ReadLine());

//MyDate date2 = new MyDate(day2, month2, year2);


//Console.WriteLine("\nПервая дата:");
//date1.Print();
//Console.WriteLine("Вторая дата:");
//date2.Print();


//int diffDays = date1.Diff(date2);
//if (diffDays != -1)
//{
//    Console.WriteLine($"Разница в днях: {diffDays}");
//}


//Console.Write("\nВведите количество дней для изменения первой даты: ");
//int changeDays = int.Parse(Console.ReadLine());
//date1.ChangeDate(changeDays);


//Console.WriteLine("\nПервая дата после изменения:");
//date1.Print();



Plane plane1 = new Plane("Boeing 737", "Boeing", 1997, "Passenger");
Plane plane2 = new Plane("Airbus A320", "Airbus", 2005, "Passenger");


Plane userPlane = new Plane();
userPlane.Input();


Console.WriteLine("\nInformation about planes:");
plane1.Print();
plane2.Print();
userPlane.Print();


Console.WriteLine("\nComparing planes by year:");
if (plane1 < plane2)
{
    Console.WriteLine($"{plane1} is older than {plane2}");
}
   
else if (plane1 > plane2)
{
     Console.WriteLine($"{plane1} is newer than {plane2}");
}

else
{
    Console.WriteLine($"{plane1} and {plane2} are the same age.");
}
    

Console.WriteLine("\nComparing planes by type:");
if (plane1 == plane2)
{
    Console.WriteLine("Both planes are of the same type.");
}

else
{
    Console.WriteLine("Planes are of different types.");

}

