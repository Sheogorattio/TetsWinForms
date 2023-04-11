using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetsWinForms
{
    public partial class Form1 : Form
    {
        public  DateTime time = new DateTime();
        public int answersCounter = 0;
        public Form1()
        {
            InitializeComponent();
            this.timer1.Interval = 1000;
            this.timer1.Start();
            this.progressBar1.Maximum = 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddMilliseconds(this.timer1.Interval);
            this.Text = time.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.progressBar1.Value = 0;
            answersCounter = 0;
            if (radioButton2.Checked) answersCounter++;
            if (radioButton6.Checked) answersCounter++;
            if (radioButton7.Checked) answersCounter++;
            if (radioButton11.Checked) answersCounter++;
            if (radioButton14.Checked) answersCounter++;
            if (radioButton16.Checked) answersCounter++;
            if (radioButton21.Checked) answersCounter++;
            if (radioButton22.Checked) answersCounter++;
            if(checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked) answersCounter++;
            if(checkBox5.Checked && !checkBox4.Checked && !checkBox6.Checked) answersCounter++;
            for(int i=0; i < answersCounter; i++)
            {
                this.progressBar1.Value++;
            }
        }
    }
}
