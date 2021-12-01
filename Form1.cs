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

        //zeigt das komplette Quiz im JSON Format
        public void button1_Click(object sender, EventArgs e)
        {
            string JSON = JsonConvert.SerializeObject(Quiz, Formatting.Indented);

            txtausgabe.Text = JSON;

        }
        //speichert den Txtasugabe Text als ein neues File
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtausgabe.Text == "")
            { txtspeicher.Text = "Bitte klicke erst Create JSON um etwas zu speichern"; }
            //  kontrolle ob Häkchen gesetzt wurden
            if (chk1.Checked == false && chk2.Checked == false && chk3.Checked == false && chk4.Checked == false && chk5.Checked == false && chk6.Checked == false && chk7.Checked == false)
            {
                txtspeicher.Text = "Es wurde noch keine Antwort als richtig markiert";
            }
            else
            {

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
        // liest ein JSON Quiz ein, kopiert die Fragen in das derzeitige Quiz, speichert dieses in das File des alten Quiz
        private void button3_Click_1(object sender, EventArgs e)
        {

            // Kontrolle ob überhaupt etwas gespeichert wird
            if (txtausgabe.Text == "")
            { txtspeicher.Text = "Bitte klicke erst Create JSON um etwas zu speichern"; }
            //  kontrolle ob Häkchen gesetzt wurden
            if (chk1.Checked == false && chk2.Checked == false && chk3.Checked == false && chk4.Checked == false && chk5.Checked == false && chk6.Checked == false && chk7.Checked == false)
            {
                txtspeicher.Text = "Es wurde noch keine Antwort als richtig markiert";
            }

            else
            {
                using Form2 form2 = new Form2();
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK) { };


                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON Files|*.json";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {



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
        //leert die Textfelder und checkboxen
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

            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chk4.Checked = false;
            chk5.Checked = false;
            chk6.Checked = false;
            chk7.Checked = false;

        }

        private void txtspeicher_TextChanged(object sender, EventArgs e)
        {

        }
        //fügt dem Quiz eine neue Frage hinzu
        private void button5_Click(object sender, EventArgs e)
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



            //die Checkboxen werden kontrolliert
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
            //button 1 erstellt das JSON
            button1.PerformClick();

        }
        

        //soll die Fragen, Choices und checkboxen zurück in die Vorlage laden um sie bearbeiten zu können und dann wieder zurück
        private void button6_Click(object sender, EventArgs e)
        {
            //ein neues Frageblock Objekt wird wird aus dem Quiz instanziiert, damit wir darauf zugreifen können
            int Stelle = Quiz.test.Count + Fragezähler -1;

            FrageKlasse.Frageblock frageblock2 = Quiz.test.ElementAt(Stelle);
            
            int i = frageblock2.choices.Count;
            //die choicelabel objekte müssen instanziiert werden
            Question question2 = frageblock2.question.ElementAt(0);
            Choicelabel choicelabelA2 = frageblock2.choices.ElementAt(0);
            Choicelabel choicelabelB2 = frageblock2.choices.ElementAt(1);
            Choicelabel choicelabelC2 = frageblock2.choices.ElementAt(2);
            Choicelabel choicelabelD2 = frageblock2.choices.ElementAt(3);
            if (i > 4) { Choicelabel choicelabelE2 = frageblock2.choices.ElementAt(4); txt5.Text = choicelabelE2.text; }
            if (i > 5) {Choicelabel choicelabelF2 = frageblock2.choices.ElementAt(5); txt6.Text = choicelabelF2.text; }
            if (i > 6) {Choicelabel choicelabelG2 = frageblock2.choices.ElementAt(6); txt7.Text = choicelabelG2.text; }
            //die Textboxen werden wiederhergestellt
            // if formulierungen, da nicht alle fragen 7 antworten haben
            txtfrage.Text = question2.text;
            txt1.Text = choicelabelA2.text;
            txt2.Text = choicelabelB2.text;
            txt3.Text = choicelabelC2.text;
            txt4.Text = choicelabelD2.text;
            //der Status der Checkboxen wird wiederhergestellt
            if (frageblock2.answer.ElementAt(0) == true) { chk1.Checked = true; } else { chk1.Checked = false; }
            if (frageblock2.answer.ElementAt(1) == true) { chk2.Checked = true; } else { chk2.Checked = false; }
            if (frageblock2.answer.ElementAt(2) == true) { chk3.Checked = true; } else { chk3.Checked = false; }
            if (frageblock2.answer.ElementAt(3) == true) { chk4.Checked = true; } else { chk4.Checked = false; }
            if (i>4 && frageblock2.answer.ElementAt(4) == true) { chk5.Checked = true; } else { chk5.Checked = false; }
            if (i>5 && frageblock2.answer.ElementAt(5) == true) { chk6.Checked = true; } else { chk6.Checked = false; }
            if (i>6 && frageblock2.answer.ElementAt(6) == true) { chk7.Checked = true; } else { chk7.Checked = false; }




            //Das alte Frageblock element wird entfernt, alles ist jetzt in den Textfeldern
            //Button 5 übernimmt dieses Einfügen, deshalb Perform click
            Quiz.test.Remove(Quiz.test.ElementAt(0));
            //button 1 erstellt das JSON
            button1.PerformClick();
        }
        //der Fragezähler hält fest, ob die vor und zurück button geklickt wurden, muss irgendwo anders stehen
        public int Fragezähler = 0;
        //der zurück button
        private void button7_Click(object sender, EventArgs e)
        {
            
          //  txtspeicher.Text = "Fragezähler: ", int Fragezähler;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Fragezähler++;
        }
    }
}
