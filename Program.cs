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
using System.Runtime.Serialization.Formatters;
using System.Text.RegularExpressions;

// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     System.Console.WriteLine(letter);
// }
// System.Console.WriteLine(subject.Length);

int[] grades = { 4, 5, 3, 5, 4 };


foreach (int grade in grades)
{
    System.Console.WriteLine(grade);
}

System.Console.WriteLine();
int sum = 0;
for (int i = 0; i < grades.Length; i++)
{
    System.Console.WriteLine();
    sum = sum + grades[i];
    System.Console.WriteLine(sum);
} 
System.Console.WriteLine($"Сумма всех оценок: {sum}");
System.Console.WriteLine($"Средний балл: {sum / grades.Length}");

// string[] students = { "Аня", "Ярослав", "Вика" };

// int count = 0;

// foreach (string student in students)
// {
//     count++;
//     System.Console.WriteLine(student);
// }
// System.Console.WriteLine($"Количество студентов: {count}");
// System.Console.WriteLine();

// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] += 5;
// }

// System.Console.WriteLine("Вывод:");

// foreach (int point in points)
// {
//     System.Console.WriteLine(point);
// }


// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;

// foreach (string student in students)
// {
//     System.Console.WriteLine($"{number}. {student}");
//     number++;
// }

// // Задача A
// int[] numbers = { 30, 20, 40, 42, 5 };


// foreach (int number in numbers)
// {
//     System.Console.WriteLine(number);
// }

// System.Console.WriteLine();
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     sum = sum + numbers[i];
// } 
// System.Console.WriteLine(sum);
// System.Console.WriteLine();

// // Задача Г

// int[] numbers1 = { 3, 4, 2, 2, 4 };

// int max = 0;



// foreach (int number1 in numbers1)
// {
//     System.Console.WriteLine(number1);
//     for (int a = 0; a < numbers1.Length; a++)
// {
//     int current = numbers1[a];

//     if (current > max)
//     {
//         max = current;
//     }
// }
// }

