
namespace quizersteller2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txtausgabe = new System.Windows.Forms.RichTextBox();
            this.txtfrage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.txt7 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtspeicher = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(225, 130);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(582, 60);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(225, 201);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(582, 60);
            this.txt2.TabIndex = 1;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(225, 270);
            this.txt3.Multiline = true;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(582, 60);
            this.txt3.TabIndex = 2;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(225, 342);
            this.txt4.Multiline = true;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(582, 60);
            this.txt4.TabIndex = 3;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(225, 409);
            this.txt5.Multiline = true;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(582, 60);
            this.txt5.TabIndex = 4;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(225, 475);
            this.txt6.Multiline = true;
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(582, 60);
            this.txt6.TabIndex = 5;
            // 
            // txtausgabe
            // 
            this.txtausgabe.Location = new System.Drawing.Point(857, 19);
            this.txtausgabe.Name = "txtausgabe";
            this.txtausgabe.ReadOnly = true;
            this.txtausgabe.Size = new System.Drawing.Size(735, 748);
            this.txtausgabe.TabIndex = 6;
            this.txtausgabe.Text = "";
            // 
            // txtfrage
            // 
            this.txtfrage.Location = new System.Drawing.Point(225, 12);
            this.txtfrage.Multiline = true;
            this.txtfrage.Name = "txtfrage";
            this.txtfrage.Size = new System.Drawing.Size(582, 60);
            this.txtfrage.TabIndex = 7;
            this.txtfrage.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 723);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "zu JSON formatieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(101, 130);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(123, 29);
            this.chk1.TabIndex = 9;
            this.chk1.Text = "Antwort A:";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(99, 203);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(121, 29);
            this.chk2.TabIndex = 10;
            this.chk2.Text = "Antwort B:";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(99, 268);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(122, 29);
            this.chk3.TabIndex = 11;
            this.chk3.Text = "Antwort C:";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(101, 342);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(124, 29);
            this.chk4.TabIndex = 12;
            this.chk4.Text = "Antwort D:";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(99, 409);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(120, 29);
            this.chk5.TabIndex = 13;
            this.chk5.Text = "Antwort E:";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(99, 475);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(120, 29);
            this.chk6.TabIndex = 14;
            this.chk6.Text = "Antwort F:";
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Frage: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(587, 696);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 60);
            this.button2.TabIndex = 16;
            this.button2.Text = "Speichern";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "korrekte Antworten ankreuzen";
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(101, 541);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(123, 29);
            this.chk7.TabIndex = 18;
            this.chk7.Text = "Antwort G:";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(225, 541);
            this.txt7.Multiline = true;
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(582, 60);
            this.txt7.TabIndex = 19;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Format|*.txt";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(587, 619);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 60);
            this.button3.TabIndex = 22;
            this.button3.Text = "In vorhandenes Quiz speichern";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 723);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 60);
            this.button4.TabIndex = 23;
            this.button4.Text = "Vorlage bereinigen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtspeicher
            // 
            this.txtspeicher.Location = new System.Drawing.Point(225, 804);
            this.txtspeicher.Multiline = true;
            this.txtspeicher.Name = "txtspeicher";
            this.txtspeicher.Size = new System.Drawing.Size(582, 60);
            this.txtspeicher.TabIndex = 24;
            this.txtspeicher.TextChanged += new System.EventHandler(this.txtspeicher_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 630);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 60);
            this.button5.TabIndex = 25;
            this.button5.Text = "Frage hinzufügen";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(857, 789);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(220, 60);
            this.button6.TabIndex = 0;
            this.button6.Text = "Bearbeiten Modus";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1107, 789);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(220, 60);
            this.button7.TabIndex = 26;
            this.button7.Text = "eins nach links";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1358, 793);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(220, 60);
            this.button8.TabIndex = 27;
            this.button8.Text = "eins nach rechts";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1691, 889);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtspeicher);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt7);
            this.Controls.Add(this.chk7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk6);
            this.Controls.Add(this.chk5);
            this.Controls.Add(this.chk4);
            this.Controls.Add(this.chk3);
            this.Controls.Add(this.chk2);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfrage);
            this.Controls.Add(this.txtausgabe);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.RichTextBox txtausgabe;
        private System.Windows.Forms.TextBox txtfrage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.TextBox txt7;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtspeicher;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

