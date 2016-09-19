using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo1
{
    class Activity
    {
        public String Title { get; set; }
        public Boolean Compulsory { get; set; }

        public Activity(String title, Boolean compulsory)
        {
            Title = title;
            Compulsory = compulsory;
        }
        public Activity(String title): this(title, false) { }
        public override string ToString()
        {
            return Title + ((Compulsory == true) ? " (obligatoire)" : "");
        }
    }
}
