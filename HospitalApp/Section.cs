using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    public class Section
    {
        public string Name { get; set; }
        public List<Doctor> Doctors { get; set; }

        public void Show()
        {
            Console.WriteLine($"Section : {Name}");
        }
        public void ShowFull()
        {
            Console.WriteLine($"Section : {Name}");
            int no = 1;
            foreach (Doctor doctor in Doctors)
            {
                Console.Write($"[{no++}] ");
                doctor.ShowShort();
                Console.WriteLine();
            }
        }
    }
}
