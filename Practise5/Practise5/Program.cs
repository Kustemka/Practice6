using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practise5
{
    class Program
    {
        static void Main(string[] args)
        {
            char entry = '1';
            Console.WriteLine("Вывести данные на экран или заполнить и добавить данные? 1/2"); entry = Console.ReadKey(true).KeyChar;


            if (char.ToLower(entry) == '2')
            {
                using (StreamWriter sw = new StreamWriter("data.txt", true, Encoding.UTF8))
                {
                    string s;
                    do
                    {
                        int count = 0;
                        string lineNumber;
                        TextReader reader = new StreamReader("data.txt");
                        while ((lineNumber = reader.ReadLine()) != null)
                        {
                            count++;
                        }
                        
                        string timing;
                        count++;
                        s = count.ToString();
                        Console.WriteLine();
                        timing = $"{s}#";

                        DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                        Console.Write($"Время заметки {DateTime.Now.ToString("dd.MM.yyyy HH:mm")}");
                        timing += $"{DateTime.Now.ToString("dd.MM.yyyy HH:mm")}#";

                        string name = string.Empty;
                        Console.Write("\nВведите ФИО: ");
                        timing += $"{Console.ReadLine()}#";

                        string age = string.Empty;
                        Console.Write("\nВведите возраст: ");
                        timing += $"{Console.ReadLine()}#";

                        string height = string.Empty;
                        Console.Write("\nВведите рост: ");
                        timing += $"{Console.ReadLine()}#";

                        string bornDate = string.Empty;
                        Console.Write("\nВведите дату рождения: ");
                        timing += $"{Console.ReadLine()}#";

                        string bornPlace = string.Empty;
                        Console.Write("\nВведите место рождения: ");
                        timing += $"город {Console.ReadLine()}";

                        sw.WriteLine(timing);
                        Console.WriteLine("Показать список или Добавить в список ? п/д"); entry = Console.ReadKey(true).KeyChar;

                    } while (char.ToLower(entry) == '2');
                }
            }


            if (File.Exists("data.txt") & char.ToLower(entry) == '1')
            {
                using (StreamReader sr = new StreamReader("data.txt", Encoding.UTF8))
                {
                    string line;
                    Console.WriteLine($"{"ID",1}{"Время",10}{"ФИО",34}{"Возраст",19}{"Рост",5}{"Дата Рождения",15}{"Место Рождения",23}");

                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split('#');
                        Console.WriteLine($"{data[0],1}{data[1],20}{data[2],36}{data[3],6}{data[4],7}{data[5],14}{data[6],24}");
                        
                    }
                    
                } 
            }
            else
            {
                File.Create("data.txt");
            }

        }
    }
}
