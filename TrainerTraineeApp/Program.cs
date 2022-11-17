namespace TrainerTraineeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Training training = new Training();
            Organization org = new Organization { Name = "Pratian" };
            Trainer trainer = new Trainer();
            trainer.TheOrganization = org;
            training.TheTrainer = trainer;

            Trainee t1 = new Trainee();
            Trainee t2 = new Trainee();
            Trainee t3 = new Trainee();
            training.Trainees.Add(t1);
            training.Trainees.Add(t2);
            training.Trainees.Add(t3);
            trainer.Trainees.Add(t1);
            trainer.Trainees.Add(t2);
            trainer.Trainees.Add(t3);


            Console.WriteLine($"Training Org Name : {training.GetTrainingOrganizationName()}");
            Console.WriteLine($"No. of trainees : {training.GetTotalTraineesCount()}");

            Course c = new Course();
            training.TheCourse = c;
            Module m1 = new Module();
            Module m2 = new Module();
            c.Modules.Add(m1);
            c.Modules.Add(m2);
            Unit u1 = new Unit { Duration = 120, Name = "Java" };
            Unit u2 = new Unit { Duration = 60, Name = "HTML" };
            Unit u3 = new Unit { Duration = 90, Name = "C#" };
            Unit u4 = new Unit { Duration = 60, Name = "JS" };

            m1.Units.Add(u1);
            m1.Units.Add(u2);
            m2.Units.Add(u3);
            m2.Units.Add(u4);

            Console.WriteLine($"Total Duration: {training.GetTotalDuration()}");
            Unit unit = training.GetLengthyUnitName();
            Console.WriteLine($"The Lengthy Unit name is {unit.Name} and the duration is {unit.Duration}");
        }
    }

    class Organization
    {
        public string Name { get; set; }
    }

    class Trainer
    {
        public Organization TheOrganization { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public List<Training> Trainings { get; set; } = new List<Training>();
    }

    class Trainee
    {
        public Trainer TheTrainer { get; set; }
        public List<Training> Trinings { get; set; } = new List<Training>();
    }
    class Training
    {
        public Trainer TheTrainer { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public Course TheCourse { get; set; }

        public string GetTrainingOrganizationName()
        {
            return TheTrainer.TheOrganization.Name;
        }

        public int GetTotalTraineesCount()
        {
            return Trainees.Count;
        }

        public int GetTotalDuration()
        {
            int duration = 0;
            // calculate the duration
            // for each moudles
            foreach (Module module in TheCourse.Modules)
            {
                // for each units
                foreach (Unit unit in module.Units)
                {
                    duration += unit.Duration;
                }
            }
            return duration;

            //for (int i = 0; i < TheCourse.Modules.Count; i++)
            //{
            //    for (int j = 0; j < TheCourse.Modules[j].Units.Count; j++)
            //    {
            //        duration += TheCourse.Modules[i].Units[j].Duration;
            //    }
            //}
        }

        public Unit GetLengthyUnitName()
        {
            int maxDuration = 0;
            string name = null;
            // calculate the maxduration
            // for each moudles
            foreach (Module module in TheCourse.Modules)
            {
                // for each units
                foreach (Unit unit in module.Units)
                {
                    if (unit.Duration >= maxDuration)
                    {
                        maxDuration = unit.Duration;
                        name = unit.Name;
                    }
                }
            }
            return new Unit { Duration = maxDuration, Name = name };
        }
    }

    class Course
    {
        public List<Module> Modules { get; set; } = new List<Module>();
    }

    class Module
    {
        public List<Unit> Units { get; set; } = new List<Unit>();
    }

    class Unit
    {
        public int Duration { get; set; }
        public string Name { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
    class Topic
    {
        public string Name { get; set; }
    }
}