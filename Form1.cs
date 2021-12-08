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

        //der Fragezähler hält fest, ob die vor und zurück button geklickt wurden, muss irgendwo anders stehen
        public int Fragezähler = 0;
        //ein String der das Quiz in ordentlicher Ausgabeform enthalten soll
        public string OA = "";


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
            if (Quiz.test.Count == 0)
            { txtspeicher.Text = "Es ist noch kein Speicherbares Quiz vorhanden"; }

            else
            {

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON Files|*.json";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string JSON = JsonConvert.SerializeObject(Quiz, Formatting.Indented);
                    File.AppendAllText(saveFileDialog.FileName, JSON);

                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // liest ein JSON Quiz ein, kopiert die Fragen in das derzeitige Quiz, zeigt die Vorschau
        private void button3_Click_1(object sender, EventArgs e)
        {


                using Form2 form2 = new Form2();
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK) { };

               
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "JSON Files|*.json";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                string J = File.ReadAllText(openFileDialog.FileName);

                    FrageKlasse Q = new FrageKlasse();
                    Q = JsonConvert.DeserializeObject<FrageKlasse>(J);

                Quiz.test.AddRange(Q.test);

                //zeigt eine ordentliche Vorschau
                button9.PerformClick();
                //aktiviert die Möglichkeit zu speichern
                button2.Enabled = true;
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
            //  kontrolle ob Häkchen gesetzt wurden
            if (chk1.Checked == false && chk2.Checked == false && chk3.Checked == false && chk4.Checked == false && chk5.Checked == false && chk6.Checked == false && chk7.Checked == false)
            {
                txtspeicher.Text = "Es wurde noch keine Antwort als richtig markiert";
            }
            else
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


                //die Question und die Labels müssen instanziiert werden
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
                //Kontrolliert ob wenigsten 4 choicemöglichkeiten gegeben sind
                if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "" || txt4.Text == "") { txtspeicher.Text = "Die ersten 4 Felder müssen ausgefüllt sein"; }

                else
                {
                    Quiz.test.Add(Frageblock1);
                    //zeigt die oderntliche Vorschau
                    button9.PerformClick();
                    //leert die Forlage
                    button4.PerformClick();
                    //aktiviert die Möglichkeit zu speichern
                    button2.Enabled = true;
                }
            }
        }


        //soll die Fragen, Choices und checkboxen zurück in die Vorlage laden um sie bearbeiten zu können und dann wieder zurück
        private void button6_Click(object sender, EventArgs e)
        {
            //eine Vorsichtsmaßnahme. Falls jemand mit den Buttons rumspielt bevor ein Quiz da ist
            if (Quiz.test.Count > 0)
            {
                //aktiviert die Buttons um ziwschen den Positionen zu switchen
                button7.Enabled = true; button8.Enabled = true;
                //die Stellle in der Testliste wird bestimmt, so dass sie nicht größer als die Liste und nicht kleiner 0 ist
                int stelle;
                stelle = Quiz.test.Count + Fragezähler - 1;
                //verhindert stellen größer als die Liste
                if (stelle >= Quiz.test.Count) { stelle = Quiz.test.Count - 1; Fragezähler = 0; }
                //verhindert stellen kleiner als die 0 in der Liste
                if (stelle <= 0) { stelle = 0; Fragezähler = -Quiz.test.Count + 1; }
                //ein neues Frageblock Objekt wird wird aus dem Quiz instanziiert, damit wir darauf zugreifen können
                FrageKlasse.Frageblock frageblock2 = Quiz.test.ElementAt(stelle);

                int i = frageblock2.choices.Count;
                //die choicelabel objekte müssen instanziiert werden
                Question question2 = frageblock2.question.ElementAt(0);
                Choicelabel choicelabelA2 = frageblock2.choices.ElementAt(0);
                Choicelabel choicelabelB2 = frageblock2.choices.ElementAt(1);
                Choicelabel choicelabelC2 = frageblock2.choices.ElementAt(2);
                Choicelabel choicelabelD2 = frageblock2.choices.ElementAt(3);
                if (i > 4) { Choicelabel choicelabelE2 = frageblock2.choices.ElementAt(4); txt5.Text = choicelabelE2.text; }
                if (i > 5) { Choicelabel choicelabelF2 = frageblock2.choices.ElementAt(5); txt6.Text = choicelabelF2.text; }
                if (i > 6) { Choicelabel choicelabelG2 = frageblock2.choices.ElementAt(6); txt7.Text = choicelabelG2.text; }
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
                if (i > 4 && frageblock2.answer.ElementAt(4) == true) { chk5.Checked = true; } else { chk5.Checked = false; }
                if (i > 5 && frageblock2.answer.ElementAt(5) == true) { chk6.Checked = true; } else { chk6.Checked = false; }
                if (i > 6 && frageblock2.answer.ElementAt(6) == true) { chk7.Checked = true; } else { chk7.Checked = false; }
            }

        }

        //der zurück button
        private void button7_Click(object sender, EventArgs e)
        {

            Fragezähler--;
            button6.PerformClick();
        }
        //der vorwärtsbutton
        private void button8_Click(object sender, EventArgs e)
        {
            Fragezähler++;
            button6.PerformClick();
        }
        //hier soll die ordentlich Vorschau entstehen, basiert auf der Technik vom Bearbeitungsknopf
        private void button9_Click(object sender, EventArgs e)
        {
            //die Textbox wird geleert damit keine Dopplungen entstehen oder ähnliche blöde Sachen
            txtausgabe.Text = "";
            //es wird über die Anzahl von Frageblöcken geloopt und der Text aus denen raus geschrieben
            for (int z = 0; z < Quiz.test.Count; z++)
            {
                FrageKlasse.Frageblock frageblock2 = Quiz.test.ElementAt(z);

                int i = frageblock2.choices.Count;
                //die choicelabel objekte müssen instanziiert werden
                Question question2 = frageblock2.question.ElementAt(0); txtausgabe.Text += "\n" + question2.text;
                Choicelabel choicelabelA2 = frageblock2.choices.ElementAt(0); txtausgabe.Text += "\n" + choicelabelA2.text;
                Choicelabel choicelabelB2 = frageblock2.choices.ElementAt(1); txtausgabe.Text += "\n" + choicelabelB2.text;
                Choicelabel choicelabelC2 = frageblock2.choices.ElementAt(2); txtausgabe.Text += "\n" + choicelabelC2.text;
                Choicelabel choicelabelD2 = frageblock2.choices.ElementAt(3); txtausgabe.Text += "\n" + choicelabelD2.text;
                if (i > 4) { Choicelabel choicelabelE2 = frageblock2.choices.ElementAt(4); txtausgabe.Text += "\n" + choicelabelE2.text; }
                if (i > 5) { Choicelabel choicelabelF2 = frageblock2.choices.ElementAt(5); txtausgabe.Text += "\n" + choicelabelF2.text; }
                if (i > 6) { Choicelabel choicelabelG2 = frageblock2.choices.ElementAt(6); txtausgabe.Text += "\n" + choicelabelG2.text; }
                //die Textboxen werden wiederhergestellt
                // if formulierungen, da nicht alle fragen 7 antworten haben

                // ob die Antworten richtig oder falsch waren wird als Textzeile geschrieben
                if (frageblock2.answer.ElementAt(0) == true) { txtausgabe.Text += "\n" + true + ", "; } else { txtausgabe.Text += "\n" + false + ", "; }
                if (frageblock2.answer.ElementAt(1) == true) { txtausgabe.Text += true + ", "; } else { txtausgabe.Text += false + ", "; }
                if (frageblock2.answer.ElementAt(2) == true) { txtausgabe.Text += true + ", "; } else { txtausgabe.Text += false + ", "; }
                if (frageblock2.answer.ElementAt(3) == true) { txtausgabe.Text += true + ", "; } else { txtausgabe.Text += false + ", "; }
                if (i > 4) { if (frageblock2.answer.ElementAt(4) == true) { txtausgabe.Text += true + ", "; } else { txtausgabe.Text += false + ", "; } }
                if (i > 5) { if (frageblock2.answer.ElementAt(5) == true) { txtausgabe.Text += true + ", "; } else { txtausgabe.Text += false + ", "; } }
                if (i > 6) { if (frageblock2.answer.ElementAt(6) == true) { txtausgabe.Text += true + ", "; } else { txtausgabe.Text += false + ", "; } }
                txtausgabe.Text += "\n" + "\n";
            }
        }
        //soll die Änderungen aus dem Bearbeitungsmodus übernehmen
        private void button10_Click(object sender, EventArgs e)
        {
            //disabled die Buttons zum rum switchen wieder
            button7.Enabled = false; button8.Enabled = false;
            //die Stellle in der Testliste wird bestimmt, so dass sie nicht größer als die Liste und nicht kleiner 0 ist
            int stelle;
            stelle = Quiz.test.Count + Fragezähler - 1;
            //verhindert stellen größer als die Liste
            if (stelle >= Quiz.test.Count) { stelle = Quiz.test.Count - 1; Fragezähler = 0; }
            //verhindert stellen kleiner als die 0 in der Liste
            if (stelle <= 0) { stelle = 0; Fragezähler = -Quiz.test.Count + 1; }

                //  kontrolle ob Häkchen gesetzt wurden
                if (chk1.Checked == false && chk2.Checked == false && chk3.Checked == false && chk4.Checked == false && chk5.Checked == false && chk6.Checked == false && chk7.Checked == false)
                {
                    txtspeicher.Text = "Es wurde noch keine Antwort als richtig markiert";
                }
                else
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


                    //die Question und die Labels müssen instanziiert werden
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
                    //Kontrolliert ob wenigsten 4 choicemöglichkeiten gegeben sind
                    if (txt1.Text == "" || txt2.Text == "" || txt3.Text == "" || txt4.Text == "") { txtspeicher.Text = "Die ersten 4 Felder müssen ausgefüllt sein"; }

                    else
                    {
                        //hier wird die änderung übernommen
                        Quiz.test.Remove(Quiz.test.ElementAt(stelle));
                        Quiz.test.Insert(stelle, Frageblock1); 
                        //zeigt die oderntliche Vorschau
                        button9.PerformClick();
                        //leert die Forlage
                        button4.PerformClick();
                    }
                }
            }
        }
    }
