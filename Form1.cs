using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace quizersteller2
{
    public partial class Form1 : Form
    {
        FrageKlasse Quiz = new FrageKlasse();
        




        public Form1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            FrageKlasse.Frageblock Frageblock1 = new FrageKlasse.Frageblock();

            string A = txt1.Text;
            string B = txt2.Text;
            string C = txt3.Text;
            string D = txt4.Text;
            string E = txt5.Text;
            string F = txt6.Text;
            string G = txt7.Text;
            string Frage = txtfrage.Text;




            if (chk1.Checked == true) { Frageblock1.answer.Add(true); } else { Frageblock1.answer.Add(false); }
            if (chk2.Checked == true) { Frageblock1.answer.Add(true); } else { Frageblock1.answer.Add(false); }
            if (chk3.Checked == true) { Frageblock1.answer.Add(true); } else { Frageblock1.answer.Add(false); }
            if (chk4.Checked == true) { Frageblock1.answer.Add(true); } else { Frageblock1.answer.Add(false); }
            if (chk5.Checked == true) { Frageblock1.answer.Add(true); } else { Frageblock1.answer.Add(false); }
            if (chk6.Checked == true) { Frageblock1.answer.Add(true); } else { Frageblock1.answer.Add(false); }
            if (chk7.Checked == true) { Frageblock1.answer.Add(true); } else { Frageblock1.answer.Add(false); }



            Question question = new Question(1, Frage);
            Frageblock1.question.Add(question);

            Choicelabel labelA = new Choicelabel("A", A);
            Choicelabel labelB = new Choicelabel("B", B);
            Choicelabel labelC = new Choicelabel("C", C);
            Choicelabel labelD = new Choicelabel("D", D);
            Choicelabel labelE = new Choicelabel("E", E);
            Choicelabel labelF = new Choicelabel("F", F);
            Choicelabel labelG = new Choicelabel("G", G);



            Frageblock1.choices.Add(labelA);
            Frageblock1.choices.Add(labelB);
            Frageblock1.choices.Add(labelC);
            Frageblock1.choices.Add(labelD);
            if (E != "") { Frageblock1.choices.Add(labelE); }
            if (F != "") { Frageblock1.choices.Add(labelF); }
            if (G != "") { Frageblock1.choices.Add(labelG); }

            if (G == "") { Frageblock1.answer.RemoveAt(6); }
            if (F == "") { Frageblock1.answer.RemoveAt(5); }
            if (E == "") { Frageblock1.answer.RemoveAt(4); }





            Quiz.test.Add(Frageblock1);
           


        


            string JSON = JsonConvert.SerializeObject(Quiz,Formatting.Indented);

            txtausgabe.Text = JSON;

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtausgabe.Text == "")
            { txtspeicher.Text = "Bitte klicke erst Create JSON um etwas zu speichern"; }

            else
            {
               // using Form2 form2 = new Form2();
               // if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK) { };


                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                   saveFileDialog.Filter = "JSON Files|*.json";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    File.AppendAllText(saveFileDialog.FileName, txtausgabe.Text);

                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           

            if (txtausgabe.Text == "")
            { txtspeicher.Text = "Bitte klicke erst Create JSON um etwas zu speichern"; }

            else
            {
                 using Form2 form2 = new Form2();
                 if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK) { };


                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON Files|*.json";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // string JSON = JsonConvert.SerializeObject(Quiz, Formatting.Indented);

                   
                    string J = File.ReadAllText(saveFileDialog.FileName);

                    FrageKlasse Q = new FrageKlasse();
                    Q = JsonConvert.DeserializeObject<FrageKlasse>(J);
                    
                    foreach (object frageblock in Q.test)
                    {
                        Quiz.test.Prepend((FrageKlasse.Frageblock)frageblock);
                    }
                    
                    
                    string JS = JsonConvert.SerializeObject(Quiz, Formatting.Indented);
                    txtausgabe.Text = JS;
                    File.WriteAllText(saveFileDialog.FileName, JS);
                    
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txtfrage.Text = "";



        }

        private void txtspeicher_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
