// int[] numbers = { 10, 20, 30 };

// Console.WriteLine(numbers[0]);
// Console.WriteLine(numbers[2]);
// Console.WriteLine(numbers.Length);

// foreach (int n in numbers)
// {
//     Console.WriteLine(n);
// }



// string word = "код";

// foreach (char letter in word) 
// {
//     Console.WriteLine(letter);
// }

// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = numbers[i] * 2;
// }





using System.Globalization;

// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     System.Console.WriteLine(letter);
// }
// System.Console.WriteLine(subject.Length);

// int[] grades = { 4, 5, 3, 5, 4 };


// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
// }

// System.Console.WriteLine();
// int sum = 0;
// for (int i = 0; i < grades.Length; i++)
// {
//     System.Console.WriteLine();
//     sum = sum + grades[i];
//     System.Console.WriteLine(sum);
// } 
// System.Console.WriteLine(sum);

string[] students = { "Аня", "Ярослав", "Вика" };

int count = 0;

foreach (string student in students)
{
    count++;
    System.Console.WriteLine(student);
}
System.Console.WriteLine($"Количество студентов: {count}");
System.Console.WriteLine();

int[] points = { 10, 20, 15 };

for (int i = 0; i < points.Length; i++)
{
    points[i] += 5;
}

System.Console.WriteLine("Вывод:");

foreach (int point in points)
{
    System.Console.WriteLine(point);
}