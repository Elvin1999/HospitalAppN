using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp
{
    public class Hospital
    {
        public string Name { get; set; } = "State Hospital";
        public List<Section> Sections { get; set; }
        public void ShowAllSections()
        {
            int no = 1;
            foreach (var item in Sections)
            {
                Console.Write($" [{no++}] ");
                item.Show();
            }
        }
    }
}
