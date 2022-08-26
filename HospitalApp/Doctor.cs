using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Experience { get; set; }
        public List<WorkHour> WorkHours { get; set; }
        public void ShowShort()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Surname : {Surname}");
            Console.WriteLine($"Experience : {Experience}");
        }
        public void ShowFull()
        {
            ShowShort();
            Console.WriteLine("Working Hours");
            int no = 1;
            foreach (var item in WorkHours)
            {
                Console.Write($"[{no++}] {item.Interval}");
                if (item.Reserved)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" reserved");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" not reserved");
                    Console.ResetColor();
                }
            }
        }
    }
}
