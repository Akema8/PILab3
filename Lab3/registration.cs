using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab3
{
    public partial class registration : Form
    {
        public string Key, path1, path2;
        //     JobWithFile Fl;
        shifr ST;
        private string Line = "";
        List<Button> btn = new List<Button>();
        List<Color> col = new List<Color>();

        public registration()
        {
            InitializeComponent();
            Key = "rita"; path1 = "User";
            ST = new shifr();
            
    
            col.Add(Color.Blue);
            col.Add(Color.Red);
            col.Add(Color.Green);
            col.Add(Color.Yellow);
            col.Add(Color.White);

            btn.Add(button1);
            btn.Add(button2);
            btn.Add(button3);
            btn.Add(button4);
            btn.Add(button5);
            btn.Add(button6);
            btn.Add(button7);
            btn.Add(button8);
            btn.Add(button9);
            btn.Add(button10);
            btn.Add(button11);
            btn.Add(button12);

            //Создание объекта для генерации чисел
            Random rnd = new Random();
            
            for (int i=0; i<btn.Count;i++)
            {
                int value = rnd.Next(1, 5);
                btn[i].BackColor = col[value];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Line += Convert.ToString(button1);
      //      Line += "button1";
            Line += Convert.ToString(button1.BackColor);
            button1.BackColor = Color.Gray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Line += Convert.ToString(button2);
            //  Line += "button2";
            Line += Convert.ToString(button2.BackColor);
            button2.BackColor = Color.Gray;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Line += Convert.ToString(button3);
         //   Line += "button3";
            Line += Convert.ToString(button3.BackColor);
            button3.BackColor = Color.Gray;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Line += Convert.ToString(button4);
           // Line += "button4";
            Line += Convert.ToString(button4.BackColor);
            button4.BackColor = Color.Gray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Line += Convert.ToString(button5);
            //   Line += "button5";
            Line += Convert.ToString(button5.BackColor);
            button5.BackColor = Color.Gray;
        }
        private void button6_Click(object sender, EventArgs e)
        {
           // Line += Convert.ToString(button6);
        //    Line += "button6";
            Line += Convert.ToString(button6.BackColor);
            button6.BackColor = Color.Gray;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //Line += Convert.ToString(button7);
            //   Line += "button7";
            Line += Convert.ToString(button7.BackColor);
            button7.BackColor = Color.Gray;
        }
        private void button8_Click(object sender, EventArgs e)
        {
          //  Line += Convert.ToString(button8);
          //  Line += "button8";
            Line += Convert.ToString(button8.BackColor);
            button8.BackColor = Color.Gray;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            //Line += Convert.ToString(button9);
          //  Line += "button9";
            Line += Convert.ToString(button9.BackColor);
            button9.BackColor = Color.Gray;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            // Line += Convert.ToString(button10);
            //Line += "button10";
            Line += Convert.ToString(button10.BackColor);
            button10.BackColor = Color.Gray;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            //  Line += Convert.ToString(button11);
            // Line += "button11";
            Line += Convert.ToString(button11.BackColor);
            button11.BackColor = Color.Gray;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Line += Convert.ToString(button12);
            // Line += "button12";
            Line += Convert.ToString(button12.BackColor);
            button12.BackColor = Color.Gray;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Line += Convert.ToString(button6.BackColor);
            button6.BackColor = Color.Gray;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Line += Convert.ToString(button7.BackColor);
            button7.BackColor = Color.Gray;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Line += Convert.ToString(button9.BackColor);
            button9.BackColor = Color.Gray;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            Line += Convert.ToString(button11.BackColor);
            button11.BackColor = Color.Gray;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Line += Convert.ToString(button12.BackColor);
            button12.BackColor = Color.Gray;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Line += Convert.ToString(button8.BackColor);
            button8.BackColor = Color.Gray;
        }

        

        private void button13_Click(object sender, EventArgs e)
        {
            string login = ST.GetShifr(textBox1.Text, Key);
            string line2 = ST.GetShifr(Line, Key);

            File.AppendAllText(path1, login);
            File.AppendAllText(path1, line2 + "\n");
            this.Close();
        }

       
    }
}
