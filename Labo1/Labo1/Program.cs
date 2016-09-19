using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil allesandro = new Pupil("Alessandro", 5);
            Pupil thais = new Pupil("Thaïs", 7, 2);
            Pupil thais2 = new Pupil("Thaïs", 8, 2);
            Pupil machin2 = new Pupil("machin", 7, 2);

            Pupil Machin = new Pupil("Machin", 8);
            Pupil Truc = new Pupil("Truc", 10);
            Pupil Idiot = new Pupil("Idiot", 15);

            List<Pupil> pupils = new List<Pupil>();
            pupils.Add(allesandro);
            pupils.Add(thais);
            pupils.Add(Machin);
            pupils.Add(Truc);
            pupils.Add(Idiot);
            pupils.Add(thais2);
            pupils.Add(machin2);

            List<Person> persons = new List<Person>()
            {
                new Person("Matthieu", 23),
                new Person("Olivier", 22),
                new Person("Vassili", 10)
            };
            Activity calculus = new Activity("Calcul", true);
            Activity french = new Activity("Français", true);
            Activity english = new Activity("Anglais");
            Activity religion = new Activity("Religion");
            Activity sport = new Activity("Sport", true);

            allesandro.AddActivity(calculus);
            allesandro.AddActivity(french);
            allesandro.AddActivity(sport);
            allesandro.AddActivity(english);
            allesandro.AddEvaluation("Français", 'B');
            allesandro.AddEvaluation("Sport", 'B');
            
            thais.AddActivity(calculus);
            thais.AddActivity(french);
            thais.AddActivity(religion);
            thais.AddActivity(sport);
            thais.AddEvaluation("Religion", 'S');
            thais.AddEvaluation("Licornes", 'T');
            System.Console.WriteLine(allesandro.ToString());
            System.Console.WriteLine(thais.ToString());
            Console.Read();

            var pupilGrade1Plus6 = pupils.Where(pupil => pupil.Age > 6 && pupil.Grade == 1);
            foreach(Pupil pupil in pupilGrade1Plus6)
            {
                Console.WriteLine(pupil);
            }

            Console.Read();
            Console.Clear();

            var listFusion = persons.Union(pupils);
            foreach(Person person in listFusion)
            {
                Console.WriteLine(person);
            }

            Console.Read();
            Console.Clear();

            IEnumerable<Pupil> listPupilsNoDuplicated = pupils.Distinct<Pupil>(new PersonComparer());

            foreach(Pupil pupil in listPupilsNoDuplicated)
            {
                Console.WriteLine(pupil);
            }

            Console.Read();
        }
    }
}
