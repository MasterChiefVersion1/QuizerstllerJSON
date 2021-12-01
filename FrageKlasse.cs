using System;
using System.Collections.Generic;
using System.Text;

namespace quizersteller2
{
    public class FrageKlasse
    {

        public author author;
        public string createdAt = "2019-03-05T08:06:29.168Z";
        public string title = "Übungsexam";
        public string description = "";
        public string code = "000-000";
        public int pass = 60;
        public int time = 60;
        public string image = "";
        public List<string> cover { get; }



        public List<Frageblock> test { get; set; }

        public FrageKlasse()
        {
            test = new List<Frageblock>();
            author = new author();
            cover = new List<string>();
        }


        public class Frageblock
        {

            public List<bool> answer { get; set; }
            public List<Question> question { get; set; }



            public List<Choicelabel> choices { get; set; }

            public List<Explanation> explanation;

            public Frageblock()
            {
                answer = new List<bool>();
                question = new List<Question>();
                choices = new List<Choicelabel>();
                explanation = new List<Explanation>();
                question = new List<Question>();
            }


           


            public int variant = 1;

        }
    }

   
}
