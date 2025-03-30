using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    class CourseComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }

        public CourseComponent(string name, string description, int hours)
        {
            Name = name;
            Description = description;
            Hours = hours;
        }

        public override string ToString() => $"{Name} ({Hours} hours): {Description}";
    }

    class Module
    {
        public string Name { get; set; }
        public List<CourseComponent> Components { get; } = new List<CourseComponent>();

        public Module(string name) => Name = name;

        public void AddComponent(CourseComponent component) => Components.Add(component);
    }

    class StudyProgram
    {
        public string Title { get; set; }
        public List<Module> Modules { get; } = new List<Module>();

        public StudyProgram(string title) => Title = title;

        public void AddModule(Module module) => Modules.Add(module);
    }

    class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            StudyProgram program = new StudyProgram("Computer Science");
            Module module1 = new Module("Programming Basics");
            module1.AddComponent(new CourseComponent("C# Introduction", "Basics of C# language", 10));
            module1.AddComponent(new CourseComponent("OOP in C#", "Object-oriented programming concepts", 15));
            program.AddModule(module1);

            Console.WriteLine($"Study Program: {program.Title}");
            foreach (var mod in program.Modules)
            {
                Console.WriteLine($"- Module: {mod.Name}");
                foreach (var comp in mod.Components)
                {
                    Console.WriteLine($"  - {comp}");
                }
            }
        }
    }
}
