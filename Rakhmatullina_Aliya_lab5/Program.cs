using System;

namespace Rakhmatullina_Aliya_lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 6.3
            //Написать программу, вычисляющую среднюю температуру за год. Создать
            //двумерный рандомный массив temperature[12, 30], в котором будет храниться температура
            //для каждого дня месяца(предполагается, что в каждом месяце 30 дней).Сгенерировать
            //значения температур случайным образом. Для каждого месяца распечатать среднюю
            //температуру.Для этого написать метод, который по массиву temperature[12, 30] для каждого
            //месяца вычисляет среднюю температуру в нем, и в качестве результата возвращает массив
            //средних температур.Полученный массив средних температур отсортировать по
            //возрастанию.
            
            int months = 12;
            int days = 30;
            double[,] temperatures = new double[months, days];

            
            Random rand = new Random();
            for (int i = 0; i < months; i++)
            {
                for (int j = 0; j < days; j++)
                {
                    temperatures[i, j] = rand.Next(-40, 41); 
                }
            }

            
            double[] averageTemperatures = CalculateAverageTemperatures(temperatures);

            
            Console.WriteLine("Средние температуры за каждый месяц:");
            for (int i = 0; i < months; i++)
            {
                Console.WriteLine($"Месяц {i + 1}: {averageTemperatures[i]:F2} °C");
            }

            
            Array.Sort(averageTemperatures);

            
            Console.WriteLine("\nСредние температуры, отсортированные по возрастанию:");
            foreach (var avgTemp in averageTemperatures)
            {
                Console.WriteLine($"{avgTemp:F2} °C");
            }
        }

      
        static double[] CalculateAverageTemperatures(double[,] temperatures)
        {
            int months = temperatures.GetLength(0);
            double[] averageTemperatures = new double[months];

            for (int i = 0; i < months; i++)
            {
                double summa = 0;

                for (int j = 0; j < temperatures.GetLength(1); j++)
                {
                    summa += temperatures[i, j];
                }

                averageTemperatures[i] = summa / temperatures.GetLength(1); 
            }

            return averageTemperatures;
        }


    }
    
    
}
