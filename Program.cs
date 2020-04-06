using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class SuperVirus : Task5.Virus
    {
        public SuperVirus() :
            base(false)
        {
            DateTimeOfCreation = DateTime.Now;
        }
        public override float KillProbability {
            get { return killProbability; }
            set { killProbability = MathF.Min(value * 2, 1.0f); }
        }
        public override string Name { 
            get { return name; } 
            set { name = string.Format("{0}supervirus", value.Substring(0, value.LastIndexOf('v'))); } 
        }
        public override string VictimName { get; set; }
        public override DateTime DateTimeOfCreation { get; }

        private float killProbability;
        private string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task5, Task5.Virus> TaskSolver = task =>
            {
                Task5.Virus virus = new SuperVirus();
                return virus;
            };
            Task5.CheckSolver(TaskSolver);
        }
    }
}
