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
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            string A = txt1.Text;
            string B = txt2.Text;
            string C = txt3.Text;
            string D = txt4.Text;
            string E = txt5.Text;
            string F = txt6.Text;
            string G = txt7.Text;
            string Frage = txtfrage.Text;













            FrageKlasse.Frageblock Frageblock1 = new FrageKlasse.Frageblock();
            Frageblock1.question.Text = Frage;


            if (chk1.Checked == true) { Frageblock1.answer.Add(true); } else { Frageblock1.answer.Add(true); }








            string JSON = JsonConvert.SerializeObject(Frageblock1, Formatting.Indented);

              txtausgabe.Text += JSON;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtausgabe.Text == "")
            { txtspeicher.Text = "Bitte klicke erst Create JSON um etwas zu speichern"; }

            else
            {
                using Form2 form2 = new Form2();
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK) { };


                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    File.AppendAllText(saveFileDialog.FileName, txtausgabe.Text);

                }
            }


        }



    }

    



}
