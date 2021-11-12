using System;
using System.Collections.Generic;
using System.Text;

namespace quizersteller2
{
    class FrageKlasse
    {
        public class Frageblock
        {

            public List<bool> answer { get; set; }
            public Question question { get; set; }

            public Explanation explanation;

            public Frageblock()
            {
                this.question = new Question() { Text = "" };
                this.explanation = new Explanation();
            }


           


            public int variant = 1;

        }

        public class Question
        {
            public int variant = 1;
            public string Text { get; set; }

        }

        public class Explanation
        {
            public int variant = 1; public string text = "";
        }

        public class choices
        {

        }
    }
}
