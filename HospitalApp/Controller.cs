using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HospitalApp
{
    public class Controller
    {
        public static string Name = "";
        public static string Surname = "";
        public static string Email = "";
        public static string Phone = "";
        public static void Run()
        {
            Doctor d1 = new Doctor
            {
                Name = "Axmed",
                Surname = "Axmedli",
                Experience = 5,
                WorkHours = new List<WorkHour>
                    {
                        new WorkHour
                        {
                             Interval="09:00 - 10:00",
                        },
                        new WorkHour
                        {
                            Interval="11:00 - 12:00",
                        },
                        new WorkHour
                        {
                            Interval="12:00 - 14:00",
                        },
                    }
            };

            Doctor d2 = new Doctor
            {
                Name = "Leyla",
                Surname = "Mammadova",
                Experience = 5,
                WorkHours = new List<WorkHour>
                    {
                        new WorkHour
                        {
                             Interval="09:00 - 10:00",
                        },
                        new WorkHour
                        {
                            Interval="11:00 - 12:00",
                        },
                        new WorkHour
                        {
                            Interval="12:00 - 14:00",
                        },
                    }
            };

            Doctor d3 = new Doctor
            {
                Name = "Eli",
                Surname = "Eliyev",
                Experience = 5,
                WorkHours = new List<WorkHour>
                    {
                        new WorkHour
                        {
                             Interval="09:00 - 10:00",
                        },
                        new WorkHour
                        {
                            Interval="11:00 - 12:00",
                        },
                        new WorkHour
                        {
                            Interval="12:00 - 14:00",
                        },
                    }
            };

            Doctor d4 = new Doctor
            {
                Name = "Mammad",
                Surname = "Mammadov",
                Experience = 5,
                WorkHours = new List<WorkHour>
                    {
                        new WorkHour
                        {
                             Interval="09:00 - 10:00",
                        },
                        new WorkHour
                        {
                            Interval="11:00 - 12:00",
                        },
                        new WorkHour
                        {
                            Interval="12:00 - 14:00",
                        },
                    }
            };

            Doctor d5 = new Doctor
            {
                Name = "Nezrin",
                Surname = "Nezrinli",
                Experience = 5,
                WorkHours = new List<WorkHour>
                    {
                        new WorkHour
                        {
                             Interval="09:00 - 10:00",
                        },
                        new WorkHour
                        {
                            Interval="11:00 - 12:00",
                        },
                        new WorkHour
                        {
                            Interval="12:00 - 14:00",
                        },
                    }
            };

            Section section1 = new Section
            {
                Name = "Pediatriya",
                Doctors = new List<Doctor> { d1, d2 }
            };
            Section section2 = new Section
            {
                Name = "Travmatalogiya",
                Doctors = new List<Doctor> { d3, d4 }
            };
            Section section3 = new Section
            {
                Name = "Stamatologiya",
                Doctors = new List<Doctor> { d5 }
            };

            Hospital hospital = new Hospital
            {
                Sections = new List<Section> { section1, section2, section3 }
            };


            while (true)
            {
                Menu();
                Console.Clear();
                hospital.ShowAllSections();
                int no = int.Parse(Console.ReadLine());
                Section currentSection = null;
                Console.Clear();
                if (no == 1)
                {
                    currentSection = section1;
                }
                else if (no == 2)
                {
                    currentSection = section2;
                }
                else if (no == 3)
                {
                    currentSection = section3;
                }

                currentSection.ShowFull();
                Console.WriteLine("Select doctor by no : ");
                no = int.Parse(Console.ReadLine());
                var currentDoctor = currentSection.Doctors[no - 1];
                currentDoctor.ShowFull();
                do
                {
                    Console.WriteLine("Select time by no : ");
                    no = int.Parse(Console.ReadLine());
                    if (currentDoctor.WorkHours[no - 1].Reserved == true)
                    {
                        Console.WriteLine("This hour is already reserved");
                    }
                    else
                    {
                        currentDoctor.WorkHours[no - 1].Reserved = true;
                        Console.WriteLine($"{Name} {Surname}  you were registered to {currentDoctor.Name} successfully");
                        Thread.Sleep(3000);
                        Console.Clear();
                        break;
                    }
                } while (true);


            }

        }

        public static void Menu()
        {
            Console.WriteLine("Welcome to our Hospital");
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Surname");
            Surname = Console.ReadLine();
            Console.WriteLine("Enter Email");
            Email = Console.ReadLine();
            Console.WriteLine("Enter Phone");
            Phone = Console.ReadLine();

        }
    }
}
