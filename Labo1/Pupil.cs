using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    class Pupil : Person
    {
        public int Grade { get; set; }
        private char[] tabEval;
        private List<Activity> listActivities;
        public List<Activity> ListActivities
        {
            get
            {
                return listActivities;
            }

            set
            {
                listActivities = value;
            }
        }

        public char[] TabEval
        {
            get
            {
                return tabEval;
            }

            set
            {
                tabEval = value;
            }
        }
        private Dictionary<String, char> pupilActivities = new Dictionary<String, char>();

        public Dictionary<String, char> PupilActivities { get; set; }

        public Pupil(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;

            ListActivities = new List<Activity>();
            TabEval = new char[10];
            PupilActivities = new Dictionary<string, char>();
        }

        public Pupil(string name, int age) : this(name, age, 1) { }

        public void AddActivity(Activity activity)
        {
            /*TabEval[ListActivities.Count] = 'N';
            ListActivities.Add(activity);*/

        }

        public void AddActivity(String title)
        {
            PupilActivities.Add(title, ' ');
        }

        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            /*int i = 0;
            while (i < ListActivities.Count && ListActivities.ElementAt(i).Title != title) { i++; };
            if(i == ListActivities.Count || i > 10)
            {
                return;
            }
            else
            {
                TabEval[i] = evaluation;
            }*/
            if (title != null) PupilActivities[title] = evaluation;
        }

        private string PrintActivitiesPupil(string ch)
        {
            for(int i = 0; i < PupilActivities.Count; i++)
            {
                ch += "\n" + PupilActivities.ElementAt(i).Key.ToString() + " : " + PupilActivities.ElementAt(i).Value;
            }
                
            return ch;
        }
        private String HeaderPupil()
        {
            string ch = base.ToString();
            return ch;
        }

        public override string ToString()
        {
            /*string ch = base.ToString();
            if(ListActivities.Count == 0)
            {
                ch += " n'as pas encore choisi d'activités";
            }
            else
            {
                ch += " a comme activités";
                foreach(Activity activity in ListActivities)
                {
                    ch += " " + activity.ToString() + " avec " + TabEval[ListActivities.IndexOf(activity)] + " , ";
                }
                ch = ch.Remove(ch.Length - 3);
            }

            return ch;*/
            string ch = HeaderPupil();
            ch = PrintActivitiesPupil(ch);

            return ch;
        }


    }
}
