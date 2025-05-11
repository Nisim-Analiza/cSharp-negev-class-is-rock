using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                List<int> series;
                if (!TryGetSeriesFromArgs(args, out series))
                {
                    series = GetSeriesFromUser();
                }

                int choice;
                do
                {
                    ShowMenu();
                    choice = GetUserChoice();
                    HandleMenuChoice(choice, ref series);
                } while (choice != 10);
            }

            static bool TryGetSeriesFromArgs(string[] args, out List<int> series)
            {
                series = new List<int>();
                foreach (var arg in args)
                {
                    if (int.TryParse(arg, out int number) && number > 0)
                    {
                        series.Add(number);
                    }
                    else
                    {
                        series = new List<int>();
                        return false;
                    }
                }
                return series.Count >= 3;
            }

            static List<int> GetSeriesFromUser()
            {
                List<int> series;
                string input;
                bool valid;

                Console.WriteLine("Please enter at least 3 positive numbers, separated by spaces:");
                do
                {
                    input = Console.ReadLine() ?? "";
                    string[] parts = input.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
                    series = new List<int>();
                    valid = true;

                    foreach (var part in parts)
                    {
                        if (int.TryParse(part, out int num) && num > 0)
                        {
                            series.Add(num);
                        }
                        else
                        {
                            valid = false;
                            break;
                        }
                    }

                    if (!valid || series.Count < 3)
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }

                } while (!valid || series.Count < 3);

                return series;
            }

            static void ShowMenu()
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Input a new series");
                Console.WriteLine("2. Display the series");
                Console.WriteLine("3. Display reversed");
                Console.WriteLine("4. Display sorted");
                Console.WriteLine("5. Show Max");
                Console.WriteLine("6. Show Min");
                Console.WriteLine("7. Show Average");
                Console.WriteLine("8. Show Count");
                Console.WriteLine("9. Show Sum");
                Console.WriteLine("10. Exit");
            }

            static int GetUserChoice()
            {
                int choice;
                bool valid;
                do
                {
                    Console.Write("Enter choice (1-10): ");
                    valid = int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 10;
                    if (!valid)
                    {
                        Console.WriteLine("Invalid choice. Try again.");
                    }
                } while (!valid);

                return choice;
            }

            static void HandleMenuChoice(int choice, ref List<int> series)
            {
                switch (choice)
                {
                    case 1:
                        series = GetSeriesFromUser();
                        break;
                    case 2:
                        ShowSeries(series);
                        break;
                    case 3:
                        ShowReversed(series);
                        break;
                    case 4:
                        ShowSorted(series);
                        break;
                    case 5:
                        Console.WriteLine("Max: " + FindMax(series));
                        break;
                    case 6:
                        Console.WriteLine("Min: " + FindMin(series));
                        break;
                    case 7:
                        Console.WriteLine("Average: " + FindAverage(series));
                        break;
                    case 8:
                        Console.WriteLine("Count: " + FindCount(series));
                        break;
                    case 9:
                        Console.WriteLine("Sum: " + FindSum(series));
                        break;
                    case 10:
                        Console.WriteLine("Exiting...");
                        break;
                }
            }

            static void ShowSeries(List<int> series)
            {
                Console.WriteLine("Series: " + string.Join(", ", series));
            }

            static void ShowReversed(List<int> series)
            {
                List<int> reversed = new List<int>();
                for (int i = series.Count - 1; i >= 0; i--)
                {
                    reversed.Add(series[i]);
                }
                Console.WriteLine("Reversed: " + string.Join(", ", reversed));
            }

            static void ShowSorted(List<int> series)
            {
                List<int> sorted = new List<int>(series);
                sorted.Sort();
                Console.WriteLine("Sorted: " + string.Join(", ", sorted));
            }

            static int FindMax(List<int> series)
            {
                int max = series[0];
                for (int i = 1; i < series.Count; i++)
                {
                    if (series[i] > max)
                    {
                        max = series[i];
                    }
                }
                return max;
            }

            static int FindMin(List<int> series)
            {
                int min = series[0];
                for (int i = 1; i < series.Count; i++)
                {
                    if (series[i] < min)
                    {
                        min = series[i];
                    }
                }
                return min;
            }

            static double FindAverage(List<int> series)
            {
                int sum = FindSum(series);
                return (double)sum / series.Count;
            }

            static int FindCount(List<int> series)
            {
                return series.Count;
            }

            static int FindSum(List<int> series)
            {
                int sum = 0;
                foreach (int num in series)
                {
                    sum += num;
                }
                return sum;
            }
        }

    }

    
    

